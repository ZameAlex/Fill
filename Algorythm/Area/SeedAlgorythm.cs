using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorythm.Area
{
    public class SeedAlgorythm : BaseAlgorythm
    {
        Bitmap newImage;
        public SeedAlgorythm(string fileName, int x, int y, string name) : base(fileName, x, y, name)
        {
            newImage = new Bitmap(image);
        }

        public override void Fill()
        {
            SetPixel(x, y);
            newImage.Save($@"ResultImages\{name}");
        }

        private void SetPixel(int x, int y)
        {
            Stack<(int x, int y)> points = new Stack<(int x, int y)>();
            points.Push((x, y));
            while (points.Count != 0)
            {
                var point = points.Pop();
                newImage.SetPixel(point.x, point.y, FillColor);
                if (newImage.GetPixel(point.x + 1, point.y).ToArgb() == Color.White.ToArgb())
                    points.Push((point.x + 1, point.y));
                if (newImage.GetPixel(point.x, point.y + 1).ToArgb() == Color.White.ToArgb())
                    points.Push((point.x, point.y + 1));
                if (newImage.GetPixel(point.x - 1, point.y).ToArgb() == Color.White.ToArgb())
                    points.Push((point.x - 1, point.y));
                if (newImage.GetPixel(point.x, point.y - 1).ToArgb() == Color.White.ToArgb())
                    points.Push((point.x, point.y - 1));
            }
        }
    }
}
