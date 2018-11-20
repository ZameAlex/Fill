using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace FillPixel
{
    public class Pixel
    {
        public int X { get; protected set; }
        public int Y { get; protected set; }
        public Color PixelColor { get; set; }
        private Rectangle rectangle;

        public Pixel(int x, int y, Color color)
        {
            X = x;
            Y = y;
            PixelColor = color;
            rectangle = new Rectangle(X, Y, 1, 1);
        }


        public void FillPixel( Graphics graphics)
        {
            graphics.DrawRectangle(new Pen(PixelColor), rectangle);
        }

    }
}
