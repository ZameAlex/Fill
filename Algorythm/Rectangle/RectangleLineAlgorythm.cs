using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorythm.Rectangle
{
    public class RectangleLineAlgorythm : BaseAlgorythm
    {
        Bitmap newImage;
        List<Point> coord;

        private RectangleLineAlgorythm(string fileName, int x, int y, string name) : base(fileName, x, y, name)
        {
            newImage = new Bitmap(image);
        }

        public RectangleLineAlgorythm(string fileName, int x, int y,List<Point> points, string name):this(fileName,x,y,name)
        {
            coord = points;
        }

        public override void Fill()
        {
            for (int y = coord[0].Y + 1; y < coord[3].Y - 1; y++)
            {
                for (int x = coord[0].X + 1; x < coord[1].X - 1; x++)
                {
                    newImage.SetPixel(x, y, FillColor);
                }
            }
            newImage.Save($@"ResultImages\{name}");
        }
    }
}
