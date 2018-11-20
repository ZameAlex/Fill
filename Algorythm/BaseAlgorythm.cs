using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Algorythm
{
    public abstract class BaseAlgorythm
    {
        protected Bitmap image;
        protected int x;
        protected int y;
        protected string name;
        public Color FillColor { get; set; }

        public BaseAlgorythm(string imageFileName, int x, int y, string name)
        {
            image = new Bitmap(imageFileName);
            this.x = x;
            this.y = y;
            this.name = name;
        }

        public abstract void Fill();


        public void SaveNewImage(string name, Bitmap image)
        {
            image.Save(name);
        }

    }
}
