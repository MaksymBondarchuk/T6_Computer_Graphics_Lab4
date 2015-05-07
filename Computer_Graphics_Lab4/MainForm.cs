using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Computer_Graphics_Lab4
{
    public partial class MainForm : Form
    {
        const int SizeX = 10000;
        const int SizeY = 3000;
        Bitmap _bmp = new Bitmap(SizeX, SizeY);
        Pen _pen = new Pen(Color.Black);


        public MainForm()
        {
            InitializeComponent();
        }


        void Koch(int rankCurrent)
        {
            if (rankCurrent == 1)
            {
                var g = Graphics.FromImage(_bmp);
                var start = new Point(100, SizeY - 100);
                var end = new Point(SizeX - 100, SizeY - 100);
                g.DrawLine(_pen, start, end);
            }
        }

        private void bBuild_Click(object sender, EventArgs e)
        {
            Koch(1);

            pbox.Image = _bmp;

            _bmp.Save("1.bmp");
        }
    }
}
