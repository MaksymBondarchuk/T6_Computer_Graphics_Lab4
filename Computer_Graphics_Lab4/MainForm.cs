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
        const int SizeX = 1500;
        const int SizeY = 600;

        Bitmap bmp = new Bitmap(SizeX, SizeY);

        //readonly Color fillColor = Color.Black;
        readonly Pen _penBlack = new Pen(Color.Black);
        readonly Pen _penFutureTransparent = new Pen(Color.Red);
        readonly Color colorTransparent = Color.Red;
        //readonly Pen _penTransparent = new Pen(Color.Transparent);
        SolidBrush brushBlack = new SolidBrush(Color.Black);
        SolidBrush brushTransparent = new SolidBrush(Color.Red);

        int rankFinal = 5;

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


        void DrawLine(Pen pen, int x1, int y1, int x2, int y2)
        {
            int max = Math.Max(Math.Abs(y2 - y1), Math.Abs(x2 - x1));
            double dx = (x2 - x1) / (double)max;
            double dy = (y2 - y1) / (double)max;

            double x = x1;
            double y = y1;
            for (int i = 0; i < max; i++)
            {
                bmp.SetPixel((int)x, (int)y, pen.Color);
                x += dx;
                y += dy;
            }
        }

        async void Koch(int x1, int y1, int x2, int y2, int rankCurrent = 0, double rotate = 0)
        {
            //var g = Graphics.FromImage(_bmp);
            if (rankCurrent == 0)
            {
                DrawLine(_penBlack, x1, y1, x2, y2);
                Koch(x1, y1, x2, y2, rankCurrent + 1);
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

            int x = (int)(xBeforeRotate * Math.Cos(rotate) - yBeforeRotate * Math.Sin(rotate)) + mx;
            int y = (int)(xBeforeRotate * Math.Sin(rotate) + yBeforeRotate * Math.Cos(rotate)) + my;


            DrawLine(_penFutureTransparent, x1, y1, x2, y2);

            DrawLine(_penBlack, x1, y1, x13, y13);
            DrawLine(_penBlack, x13, y13, x, y);
            DrawLine(_penBlack, x, y, x23, y23);
            DrawLine(_penBlack, x23, y23, x2, y2);
            bmp.MakeTransparent(colorTransparent);

            pbox.Image = bmp;
            await Task.Delay(500);

            if (rankCurrent < rankFinal)
            {
                Koch(x1, y1, x13, y13, rankCurrent + 1, rotate);
                Koch(x13, y13, x, y, rankCurrent + 1, rotate - Math.PI / 3.0);
                Koch(x, y, x23, y23, rankCurrent + 1, rotate + Math.PI / 3.0);
                Koch(x23, y23, x2, y2, rankCurrent + 1, rotate);
            }

        }

        async void Serpinski(int x1, int y1, int x2, int y2, int x3, int y3, int rankCurrent = 0)
        {
            pbox.Image = bmp;
            await Task.Delay(500);

            var g = Graphics.FromImage(bmp);
            if (rankCurrent == 0)
            {
                Point[] points = { new Point(x1, y1), new Point(x2, y2), new Point(x3, y3) };
                g.FillPolygon(brushBlack, points);

                Serpinski(x1, y1, x2, y2, x3, y3, rankCurrent + 1);
                return;
            }

            int a = x2 - x1;
            int h = y1 - y3;

            int x13 = x1 + a / 4;
            int y13 = y1 - h / 2;
            int x12 = x1 + a / 2;
            int y12 = y1;
            int x23 = x3 + a / 4;
            int y23 = y13;

            Point[] _points = { new Point(x13, y13), new Point(x12, y12), new Point(x23, y23) };
            g.FillPolygon(brushTransparent, _points);
            bmp.MakeTransparent(colorTransparent);

            pbox.Image = bmp;
            await Task.Delay(500);

            if (rankCurrent < rankFinal)
            {
                Serpinski(x1, y1, x12, y12, x13, y13, rankCurrent + 1);
                Serpinski(x12, y12, x2, y2, x23, y23, rankCurrent + 1);
                Serpinski(x13, y13, x23, y23, x3, y3, rankCurrent + 1);
            }
        }

        private void bBuild_Click(object sender, EventArgs e)
        {
            //Thread T = new Thread(() => Koch(0, SizeY - 1, SizeX - 1, SizeY - 1, 5), 100000000);
            //T.Start();
            //T.Join();
            //T.Abort();
            //Koch(0, SizeY - 1, SizeX - 1, SizeY - 1);
            Serpinski((int)(SizeX / 2 - SizeY / Math.Sqrt(3)), SizeY - 1, (int)(SizeX / 2 + SizeY / Math.Sqrt(3)), SizeY - 1, SizeX / 2, 0);

            pbox.Image = bmp;

            bmp.Save("1.bmp");
        }
    }
}