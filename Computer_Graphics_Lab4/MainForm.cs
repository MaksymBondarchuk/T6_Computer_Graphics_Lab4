using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
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
        readonly Pen _penFutureTransparent = new Pen(Color.Red);
        readonly Color _colorFutureTransparent = Color.Red;
        //readonly Pen _penTransparent = new Pen(Color.Transparent);


        public class PointsForLine
        {
            public int x1;
            public int y1;
            public int x2;
            public int y2;

            public PointsForLine(int x1, int y1, int x2, int y2, bool _23 = false)
            {
                if (_23)
                {
                    this.x1 = Math.Abs(x2 - x1) / 3 + Math.Min(x1, x2);
                    this.y1 = Math.Max(y1, y2) - Math.Abs(y2 - y1) / 3;
                    this.x2 = Math.Abs(x2 - x1) * 2 / 3 + Math.Min(x1, x2);
                    this.y2 = Math.Max(y1, y2) - Math.Abs(y2 - y1) * 2 / 3;
                }
                else
                {
                    this.x1 = x1;
                    this.y1 = y1;
                    this.x2 = x2;
                    this.y2 = y2;
                }
            }
        }

        public MainForm()
        {
            InitializeComponent();
        }


        void drawLine(PointsForLine pointsNormal, PointsForLine points23)
        {
            var g = Graphics.FromImage(_bmp);
            g.DrawLine(_penBlack, pointsNormal.x1, pointsNormal.y1, points23.x1, points23.y1);
            g.DrawLine(_penBlack, pointsNormal.x2, pointsNormal.y2, points23.x2, points23.y2);
        }

        async void Koch(int x1, int y1, int x2, int y2, int rankFinal, int rankCurrent = 0, double rotate = 0)
        {
            var g = Graphics.FromImage(_bmp);
            if (rankCurrent == 0)
            {
                g.DrawLine(_penBlack, x1, y1, x2, y2);
                Koch(x1, y1, x2, y2, rankFinal, rankCurrent + 1);
                return;
            }

            int dx = x2 - x1;
            int dy = y2 - y1;

            int x13 = x1 + dx / 3;
            int y13 = y1 + dy / 3;
            int x23 = x1 + dx * 2 / 3;
            int y23 = y1 + dy * 2 / 3;

            int mx = x1 + dx / 2;
            int my = y1 + dy / 2;

            double a = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2)) / 3.0;
            double h = a * Math.Sqrt(3) / 2.0;
            double xBeforeRotate = mx - mx;
            double yBeforeRotate = my - h - my;

            int x = (int) (xBeforeRotate * Math.Cos(rotate) - yBeforeRotate * Math.Sin(rotate)) + mx;
            int y = (int) (xBeforeRotate * Math.Sin(rotate) + yBeforeRotate * Math.Cos(rotate)) + my;


            g.DrawLine(_penFutureTransparent, x1, y1, x2, y2);
            
            g.DrawLine(_penBlack, x1, y1, x13, y13);
            g.DrawLine(_penBlack, x13, y13, x, y);
            g.DrawLine(_penBlack, x, y, x23, y23);
            g.DrawLine(_penBlack, x23, y23, x2, y2);
            _bmp.MakeTransparent(_colorFutureTransparent);

            pbox.Image = _bmp;
            await Task.Delay(500);

            if (rankCurrent + 1 < rankFinal)
            {
                Koch(x1, y1, x13, y13, rankFinal, rankCurrent + 1, rotate);
                Koch(x13, y13, x, y, rankFinal, rankCurrent + 1, rotate - Math.PI / 3.0);
                Koch(x, y, x23, y23, rankFinal, rankCurrent + 1, rotate + Math.PI / 3.0);
                Koch(x23, y23, x2, y2, rankFinal, rankCurrent + 1, rotate);
            }
            
        }

        private void bBuild_Click(object sender, EventArgs e)
        {
            //Thread T = new Thread(() => Koch(0, SizeY - 1, SizeX - 1, SizeY - 1, 5), 100000000);
            //T.Start();
            //T.Join();
            //T.Abort();
            Koch(0, SizeY - 1, SizeX - 1, SizeY - 1, 7);

            pbox.Image = _bmp;

            _bmp.Save("1.bmp");
        }
    }
}
