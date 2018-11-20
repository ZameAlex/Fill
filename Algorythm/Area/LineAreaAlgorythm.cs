using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorythm.Area
{
    public class LineAreaAlgorythm:BaseAlgorythm
    {
        Bitmap newImage;
        public LineAreaAlgorythm(string fileName, int x, int y, string name) : base(fileName, x, y,name)
        {
            newImage = new Bitmap(image);
        }

        public override void Fill()
        {
            PutPixel(x, y, 1);
            PutPixel(x, y, -1);
            newImage.Save($@"ResultImages\{name}");
        }

        private void PutPixel(int x, int y, int delta)
        {
            Stack<(int x, int y)> points = new Stack<(int x, int y)>();
            var startPoint = FindRowCoord(x, y);
            points.Push(startPoint);
            while (points.Count > 0)
            {
                var point = points.Pop();
                if (point.x == -1 || point.y == -1)
                    return;
                for (int coord = point.x; image.GetPixel(coord, point.y).ToArgb() == Color.White.ToArgb(); coord++)
                {
                    newImage.SetPixel(coord, point.y, FillColor);
                }
                points.Push(FindRowCoord(x, point.y + delta));
            }

        }

        private (int x, int y) FindRowCoord(int x, int y)
        {
            (int x, int y) leftPoint = (x, y), rightPoint = (x, y);
            while (x > 0)
            {
                if (image.GetPixel(leftPoint.x, y).ToArgb() == Color.White.ToArgb())
                {
                    leftPoint.x--;
                }
                else
                {
                    leftPoint.x++;
                    break;
                }
            }
            while (rightPoint.x < image.Width)
            {
                if (image.GetPixel(rightPoint.x, y).ToArgb() == Color.White.ToArgb())

                {
                    rightPoint.x++;
                }
                else
                {
                    rightPoint.x--;
                    break;
                }
            }

            if (rightPoint.x == image.Width || leftPoint.x == 0)
                return (-1, -1);
            return leftPoint;
        }

    }
}
