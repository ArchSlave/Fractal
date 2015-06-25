using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    public sealed class NetPbm
    {
        public static int BytesPerPixel = 3;
        public static int ColorIntensity = 255;
        private char[] _header;
        private byte[] _bytes;

        public int Width { get; set; }
        public int Height { get; set; }

        public NetPbm(int width, int height)
        {
            this.Width = width;
            this.Height = height;
            this._bytes = new byte[width * height * BytesPerPixel];
            this._header = ("P6" + '\n' + Width  + '\n' + Height + '\n' + ColorIntensity + '\n').ToCharArray();
        }

        public void SetColor(int x, int y, byte r, byte g, byte b)
        {
            int offset = y * Width + x;
            offset *= BytesPerPixel;

            _bytes[offset] = r;
            _bytes[offset + 1] = g;
            _bytes[offset + 2] = b;
        }

        public void SaveToFile(string fileName)
        {            
            using(var writer = new System.IO.BinaryWriter(System.IO.File.OpenWrite(fileName)))
            {
                writer.Write(_header);
                writer.Write(_bytes);
                writer.Flush();
            }
        }
    }
}
