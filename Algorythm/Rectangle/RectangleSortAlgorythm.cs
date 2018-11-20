using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorythm.Rectangle
{
    public class RectangleSortAlgorythm : BaseAlgorythm
    {
        Bitmap newImage;
        List<Point> coord;

        private RectangleSortAlgorythm(string fileName, int x, int y, string name) : base(fileName, x, y, name)
        {
            newImage = new Bitmap(image);
        }

        public RectangleSortAlgorythm(string fileName, int x, int y, List<Point> points, string name) : this(fileName, x, y, name)
        {
            coord = points;
        }


        public override void Fill()
        {           
            for (int y = 0; y < image.Height- 1; y++)
            {
                for (int x = 0; x < image.Width- 1; x++)
                {
                    if (PointInsideRectangle(coord[0].X, coord[0].Y, coord[1].X, coord[1].Y, coord[2].X, coord[2].Y, coord[3].X, coord[3].Y, x, y))
                        newImage.SetPixel(x, y, FillColor);
                }
            }
            newImage.Save($@"ResultImages\{name}");
        }

        private int WherePoint(int ax, int ay, int bx, int by, int px, int py)
        {
            double s;

            s = (bx - ax) * (py - ay) - (by - ay) * (px - ax);
            if (s > 0)
                return 1;
            else if (s < 0)
                return -1;
            else
                return 0;
            
        }

        private bool PointInsideRectangle(int ax, int ay, int bx, int by, int cx, int cy, int dx,int dy, int px, int py)
        {
            int s1, s2, s3, s4;
            s1 = WherePoint(ax, ay, bx, by, px, py);
            s2 = WherePoint(bx, by, cx, cy, px, py);
            if (s2 * s1 <= 0)
                return false;
            s3 = WherePoint(cx, cy, dx, dy, px, py);
            if (s3 * s2 <= 0)
                return false;
            s4 = WherePoint(dx, dy, ax, ay, px, py);
            if (s4 * s3 <= 0)
                return false;
            return true;
        }


    }
}
