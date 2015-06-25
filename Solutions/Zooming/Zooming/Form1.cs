using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trauer.Graphics;

namespace Zooming
{
    public partial class MainForm : Form
    {
        // Used to rubberband
        private Point mouseDownPosition = Point.Empty;
        private Point CurrentMousePos;
        private Brush areaSelectionBrush = new SolidBrush(Color.FromArgb(50, 0xE8, 0xED, 0xF5));
        private Pen framePen = new Pen(Color.FromArgb(0x33, 0x5E, 0xA8));

        // Used to draw and display the fractal
        ParallelOptions parallelOptions;
        Bitmap img;
        FastBitmap32 fbm;
        double horizontalMinimum = -2.5;
        double horizontalMaximum = 2.5;
        double verticalMinimum = -2.5;
        double verticalMaximum = 2.5;
        Stack<ZoomStep> zoomSteps = new Stack<ZoomStep>();

        double escapeRadius = 2;
        double ER2 { get { return escapeRadius * escapeRadius; } }

        double PixelWidth { get { return (horizontalMaximum - horizontalMinimum) / maximumSize.Width; } }
        double PixelHeight { get { return (verticalMaximum - verticalMinimum) / maximumSize.Height; } }

        Rectangle maximumSize;
        int maximumIterations = 256;

        public MainForm()
        {
            InitializeComponent();

            img = new System.Drawing.Bitmap(pictureBox1.Width, pictureBox1.Height);

            fbm = new FastBitmap32(img);
            fbm.SaveBits();

            pictureBox1.Image = img;
            maximumSize = new System.Drawing.Rectangle(0, 0, pictureBox1.Width, pictureBox1.Height);
            parallelOptions = new ParallelOptions();
            parallelOptions.MaxDegreeOfParallelism = 4; // Environment.ProcessorCount;

            DrawFractal(maximumSize);
            UpdateComplexValuesTextBoxes();
        }

        private void UpdateComplexValuesTextBoxes()
        {
            textBoxHorizontalMinimum.Text = horizontalMinimum.ToString();
            textBoxHorizontalMaximum.Text = horizontalMaximum.ToString();
            textBoxVerticalMinimum.Text = verticalMinimum.ToString();
            textBoxVerticalMaximum.Text = verticalMaximum.ToString();
        }

        private void UpdateComplexValues(Rectangle rect)
        {
            double fractalWidth = horizontalMaximum - horizontalMinimum;
            double fractalHeight = verticalMaximum - verticalMinimum;

            double horizontalMinimumRatio = ((double)maximumSize.Width) / (double)rect.X;
            double horizontalMaximumRatio = ((double)maximumSize.Width) / (double)(maximumSize.Width - rect.Right);

            double verticalMinimumRatio = ((double)maximumSize.Height) / (double)rect.Y;
            double verticalMaximumRatio = ((double)maximumSize.Height) / (double)(maximumSize.Height - rect.Bottom);

            horizontalMinimum += fractalWidth / horizontalMinimumRatio;
            horizontalMaximum -= fractalWidth / horizontalMaximumRatio;

            verticalMinimum += fractalHeight / verticalMinimumRatio;
            verticalMaximum -= fractalHeight / verticalMaximumRatio;

            UpdateComplexValuesTextBoxes();
        }


        private void DrawFractalAsync(Rectangle rect)
        {
            UpdateComplexValues(rect);

            Task.Run(() =>
            {
                DrawFractal(rect);
            });
        }

        private void DrawFractal(Rectangle rect)
        {
            // UpdateComplexValues(rect);
            using(var oldImage = (Bitmap)img.Clone())
            {
                pictureBox1.Image = oldImage;
                fbm.LoadBits();
                Parallel.For(0, fbm.Height, (yCoordinate) =>
                {
                    double complexY = horizontalMinimum + yCoordinate * PixelHeight;
                    if (Math.Abs(complexY) < (PixelHeight / 2)) complexY = 0;

                    for (int xCoordinate = 0; xCoordinate < fbm.Width; xCoordinate++)
                    {
                        double complexX = horizontalMinimum + xCoordinate * PixelWidth;

                        double Zx = 0.0;
                        double Zy = 0.0;
                        double Zx2 = Zx * Zx;
                        double Zy2 = Zy * Zy;

                        int Iteration;
                        for (Iteration = 0; Iteration < maximumIterations && ((Zx2 + Zy2) < ER2); Iteration++)
                        {
                            Zy = 2 * Zx * Zy + complexY;
                            Zx = Zx2 - Zy2 + complexX;
                            Zx2 = Zx * Zx;
                            Zy2 = Zy * Zy;
                        };

                        if (Iteration == maximumIterations)
                        {
                            fbm.SetColor(xCoordinate, yCoordinate, Color.Black);
                        }
                        else
                        {
                            Iteration = Iteration % 255;

                            int red = Iteration;
                            int blue = maximumIterations - Iteration;
                            int green = (red + blue) / 2;

                            Color color = Color.FromArgb(red, 0, 0);

                            fbm.SetColor(xCoordinate, yCoordinate, color);
                        };
                    }

                });

                fbm.SaveBits();
                pictureBox1.Image = img;
                pictureBox1.Invalidate();
            }           
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            base.OnMouseDown(e);
            if (e.Button == MouseButtons.Left)
            {
                mouseDownPosition = e.Location;
                return;
            }
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                PopComplexValues();
                DrawFractalAsync(maximumSize);
                return;
            }
        }

        private void UpdateMouseTextBoxes(Point location)
        {
            textBoxMouseX.Text = location.X.ToString();
            textBoxMouseY.Text = location.Y.ToString();
        }

        private void UpdateRectangleTextBoxes(Point location)
        {
            Rectangle selectedRect = new Rectangle(
                Math.Min(mouseDownPosition.X, CurrentMousePos.X),
                Math.Min(mouseDownPosition.Y, CurrentMousePos.Y),
                Math.Abs(CurrentMousePos.X - mouseDownPosition.X),
                Math.Abs(CurrentMousePos.Y - mouseDownPosition.Y));
            selectedRect.Intersect(maximumSize);

            textBoxRectangle.Text = selectedRect.ToString();
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            base.OnMouseMove(e);

            UpdateMouseTextBoxes(e.Location);
            UpdateRectangleTextBoxes(e.Location);

            if (e.Button == MouseButtons.Left && mouseDownPosition != Point.Empty)
            {
                pictureBox1.Invalidate();
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            base.OnMouseUp(e);

            if (e.Button != System.Windows.Forms.MouseButtons.Left)
            {
                return;
            }


            CurrentMousePos = e.Location; // this.PointToClient(MousePosition);
            Rectangle selectedRect = new Rectangle(
                Math.Min(mouseDownPosition.X, CurrentMousePos.X),
                Math.Min(mouseDownPosition.Y, CurrentMousePos.Y),
                Math.Abs(CurrentMousePos.X - mouseDownPosition.X),
                Math.Abs(CurrentMousePos.Y - mouseDownPosition.Y));
            selectedRect.Intersect(maximumSize);

            int maior = selectedRect.Height;
            if (selectedRect.Width > selectedRect.Height) maior = selectedRect.Width;
            selectedRect.Width = maior;
            selectedRect.Height = maior;

            PushComplexValues();

            DrawFractalAsync(selectedRect);
            textBoxRectangle.Text = selectedRect.ToString();
            mouseDownPosition = Point.Empty;
            pictureBox1.Invalidate();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {

            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            if (mouseDownPosition != Point.Empty)
            {
                CurrentMousePos = this.PointToClient(MousePosition);
                Rectangle selectedRect = new Rectangle(
                    Math.Min(mouseDownPosition.X, CurrentMousePos.X),
                    Math.Min(mouseDownPosition.Y, CurrentMousePos.Y),
                    Math.Abs(CurrentMousePos.X - mouseDownPosition.X),
                    Math.Abs(CurrentMousePos.Y - mouseDownPosition.Y));
                int maior = selectedRect.Height;
                if (selectedRect.Width > selectedRect.Height) maior = selectedRect.Width;
                selectedRect.Width = maior;
                selectedRect.Height = maior;
                e.Graphics.FillRectangle(areaSelectionBrush, selectedRect);
                e.Graphics.DrawRectangle(framePen, selectedRect);
            }

        }

        private void ResetFractal()
        {
            horizontalMinimum = -2.5;
            horizontalMaximum = 2.5;
            verticalMinimum = -2.5;
            verticalMaximum = 2.5;
            DrawFractalAsync(maximumSize);
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            ResetFractal();
        }


        private void PushComplexValues()
        {
            zoomSteps.Push(new ZoomStep(horizontalMinimum, horizontalMaximum, verticalMinimum, verticalMaximum));
        }

        private void PopComplexValues()
        {
            if (zoomSteps.Count == 0) return;

            ZoomStep zoomy = zoomSteps.Pop();

            this.horizontalMinimum = zoomy.horizontalMinimum;
            this.horizontalMaximum = zoomy.horizontalMaximum;
            this.verticalMinimum = zoomy.verticalMinimum;
            this.verticalMaximum = zoomy.verticalMaximum;
        }


        private class ZoomStep
        {
            public double horizontalMinimum = -2.5;
            public double horizontalMaximum = 2.5;
            public double verticalMinimum = -2.5;
            public double verticalMaximum = 2.5;

            public ZoomStep(double horizontalMinimum, double horizontalMaximum, double verticalMinimum, double verticalMaximum)
            {
                this.horizontalMinimum = horizontalMinimum;
                this.horizontalMaximum = horizontalMaximum;

                this.verticalMinimum = verticalMinimum;
                this.verticalMaximum = verticalMaximum;
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            this.maximumIterations = (int)numericUpDown1.Value;
        }
    }
}
