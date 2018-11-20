using Algorythm;
using Algorythm.Area;
using Algorythm.Rectangle;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fill
{
    public partial class Lab2 : Form
    {

        public Lab2()
        {
            InitializeComponent();
        }

        private void Lab2_Load(object sender, EventArgs e)
        {
            Area1.Image = new Bitmap(@"Images\Area1.bmp");
            Area2.Image = new Bitmap(@"Images\Area2.bmp");
            //pictureBox1.Image = new Bitmap(@"Images\Rect1.bmp");
            //pictureBox2.Image = new Bitmap(@"Images\Rect2.bmp");
        }

        private void AreaFill1_Click(object sender, EventArgs e)
        {
            BaseAlgorythm seedAlgorythm = new SeedAlgorythm(@"Images\Area1.bmp", Area1.Image.Width / 2, Area1.Image.Height / 2, "Area1.bmp");
            seedAlgorythm.FillColor = Color.Green;
            seedAlgorythm.Fill();
            Area1.Image = new Bitmap(@"ResultImages\Area1.bmp");
        }

        private void AreaFill2_Click(object sender, EventArgs e)
        {
            BaseAlgorythm areaAlgorythm = new SeedAlgorythm(@"Images\Area2.bmp", Area2.Image.Width / 2, Area1.Image.Height / 2, "Area2.bmp");
            areaAlgorythm.FillColor = Color.Green;
            areaAlgorythm.Fill();
            Area2.Image = new Bitmap(@"ResultImages\Area2.bmp");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BaseAlgorythm rectLAlgorythm = new RectangleLineAlgorythm(@"Images\Rect1.bmp", 0,0,new List<Point> { new Point(50, 50), new Point(300, 50), new Point(300, 300), new Point(50, 300) }, "Rect1.bmp");
            rectLAlgorythm.FillColor = Color.Green;
            rectLAlgorythm.Fill();
            pictureBox1.Image = new Bitmap(@"ResultImages\Rect1.bmp");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            BaseAlgorythm rectSAlgorythm = new RectangleSortAlgorythm(@"Images\Rect2.bmp", 0,0, new List<Point> { new Point(150, 50), new Point(300, 300), new Point(150, 450), new Point(50, 50) },"Rect2.bmp");
            rectSAlgorythm.FillColor = Color.Green;
            rectSAlgorythm.Fill();
            pictureBox2.Image = new Bitmap(@"ResultImages\Rect2.bmp");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
