namespace Zooming
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.horizontalValues = new System.Windows.Forms.Label();
            this.verticalValues = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxHorizontalMinimum = new System.Windows.Forms.TextBox();
            this.textBoxHorizontalMaximum = new System.Windows.Forms.TextBox();
            this.textBoxVerticalMaximum = new System.Windows.Forms.TextBox();
            this.textBoxVerticalMinimum = new System.Windows.Forms.TextBox();
            this.buttonReset = new System.Windows.Forms.Button();
            this.textBoxMouseY = new System.Windows.Forms.TextBox();
            this.textBoxMouseX = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxRectangle = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 800);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // horizontalValues
            // 
            this.horizontalValues.AutoSize = true;
            this.horizontalValues.Location = new System.Drawing.Point(818, 12);
            this.horizontalValues.Name = "horizontalValues";
            this.horizontalValues.Size = new System.Drawing.Size(90, 13);
            this.horizontalValues.TabIndex = 1;
            this.horizontalValues.Text = "horizontalValues: ";
            // 
            // verticalValues
            // 
            this.verticalValues.AutoSize = true;
            this.verticalValues.Location = new System.Drawing.Point(818, 35);
            this.verticalValues.Name = "verticalValues";
            this.verticalValues.Size = new System.Drawing.Size(79, 13);
            this.verticalValues.TabIndex = 2;
            this.verticalValues.Text = "verticalValues: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(818, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Max Iterations";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(818, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Zooming Values";
            // 
            // textBoxHorizontalMinimum
            // 
            this.textBoxHorizontalMinimum.Enabled = false;
            this.textBoxHorizontalMinimum.Location = new System.Drawing.Point(914, 9);
            this.textBoxHorizontalMinimum.Name = "textBoxHorizontalMinimum";
            this.textBoxHorizontalMinimum.Size = new System.Drawing.Size(100, 20);
            this.textBoxHorizontalMinimum.TabIndex = 5;
            // 
            // textBoxHorizontalMaximum
            // 
            this.textBoxHorizontalMaximum.Enabled = false;
            this.textBoxHorizontalMaximum.Location = new System.Drawing.Point(1020, 9);
            this.textBoxHorizontalMaximum.Name = "textBoxHorizontalMaximum";
            this.textBoxHorizontalMaximum.Size = new System.Drawing.Size(100, 20);
            this.textBoxHorizontalMaximum.TabIndex = 6;
            // 
            // textBoxVerticalMaximum
            // 
            this.textBoxVerticalMaximum.Enabled = false;
            this.textBoxVerticalMaximum.Location = new System.Drawing.Point(1020, 35);
            this.textBoxVerticalMaximum.Name = "textBoxVerticalMaximum";
            this.textBoxVerticalMaximum.Size = new System.Drawing.Size(100, 20);
            this.textBoxVerticalMaximum.TabIndex = 8;
            // 
            // textBoxVerticalMinimum
            // 
            this.textBoxVerticalMinimum.Enabled = false;
            this.textBoxVerticalMinimum.Location = new System.Drawing.Point(914, 35);
            this.textBoxVerticalMinimum.Name = "textBoxVerticalMinimum";
            this.textBoxVerticalMinimum.Size = new System.Drawing.Size(100, 20);
            this.textBoxVerticalMinimum.TabIndex = 7;
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(1138, 9);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(75, 23);
            this.buttonReset.TabIndex = 9;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // textBoxMouseY
            // 
            this.textBoxMouseY.Enabled = false;
            this.textBoxMouseY.Location = new System.Drawing.Point(927, 793);
            this.textBoxMouseY.Name = "textBoxMouseY";
            this.textBoxMouseY.Size = new System.Drawing.Size(100, 20);
            this.textBoxMouseY.TabIndex = 10;
            // 
            // textBoxMouseX
            // 
            this.textBoxMouseX.Enabled = false;
            this.textBoxMouseX.Location = new System.Drawing.Point(927, 767);
            this.textBoxMouseX.Name = "textBoxMouseX";
            this.textBoxMouseX.Size = new System.Drawing.Size(100, 20);
            this.textBoxMouseX.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(818, 770);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Mouse X Coordinate";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(818, 796);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Mouse Y  Coordinate";
            // 
            // textBoxRectangle
            // 
            this.textBoxRectangle.Enabled = false;
            this.textBoxRectangle.Location = new System.Drawing.Point(914, 80);
            this.textBoxRectangle.Name = "textBoxRectangle";
            this.textBoxRectangle.Size = new System.Drawing.Size(206, 20);
            this.textBoxRectangle.TabIndex = 14;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(914, 125);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 15;
            this.numericUpDown1.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1225, 823);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.textBoxRectangle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxMouseX);
            this.Controls.Add(this.textBoxMouseY);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.textBoxVerticalMaximum);
            this.Controls.Add(this.textBoxVerticalMinimum);
            this.Controls.Add(this.textBoxHorizontalMaximum);
            this.Controls.Add(this.textBoxHorizontalMinimum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.verticalValues);
            this.Controls.Add(this.horizontalValues);
            this.Controls.Add(this.pictureBox1);
            this.Name = "MainForm";
            this.Text = "Zoomer do Thiago";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label horizontalValues;
        private System.Windows.Forms.Label verticalValues;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxHorizontalMinimum;
        private System.Windows.Forms.TextBox textBoxHorizontalMaximum;
        private System.Windows.Forms.TextBox textBoxVerticalMaximum;
        private System.Windows.Forms.TextBox textBoxVerticalMinimum;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.TextBox textBoxMouseY;
        private System.Windows.Forms.TextBox textBoxMouseX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxRectangle;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}

