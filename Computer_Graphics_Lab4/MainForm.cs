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
        const int SizeX = 1000;
        const int SizeY = 300;
        Bitmap _bmp = new Bitmap(SizeX, SizeY);
        readonly Pen _penBlack = new Pen(Color.Black);
        readonly Pen _penTransparent = new Pen(Color.Transparent);


        public MainForm()
        {
            InitializeComponent();
        }


        void Koch(int x1, int y1, int x2, int y2, int rankFinal, int rankCurrent = 1)
        {
            if (rankFinal < rankCurrent)
                return;

            var g = Graphics.FromImage(_bmp);
            if (rankCurrent == 1)
            {
                g.DrawLine(_penBlack, x1, y1, x2, y2);

                Koch(x1, y1, (int)((x2 - x1) / 3), y2, rankFinal, rankCurrent + 1);
                Koch((int)((x2 - x1) / 3), y1, (int)((x2 - x1) * 2 / 3), y2, rankFinal, rankCurrent + 1);
                Koch((int)((x2 - x1) * 2 / 3), y1, x2, y2, rankFinal, rankCurrent + 1);
                return;
            }

            var x3 = Math.Abs(x2 - x1) / 3 + Math.Min(x1, x2);
            var y3 = Math.Abs(y2 - y1) / 3 + Math.Min(y1, y2);
            var x23 = Math.Abs(x2 - x1) * 2 / 3 + Math.Min(x1, x2);
            var y23 = Math.Abs(y2 - y1) * 2 / 3 + Math.Min(y1, y2);
            g.DrawLine(new Pen(Color.Red), x3, y3, x23, y23);
            //g.DrawLine(_penTransparent, x3, y3, x23, y23);
            _bmp.MakeTransparent(Color.Red);
        }

        private void bBuild_Click(object sender, EventArgs e)
        {
            Koch(0, SizeY - 1, SizeX - 1, SizeY - 1, 2);

            pbox.Image = _bmp;

            _bmp.Save("1.bmp");
        }
    }
}
