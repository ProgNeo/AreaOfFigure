using System.Drawing.Drawing2D;
using System.Globalization;

namespace AreaOfFigure
{
    public partial class Form1 : Form
    {
        private int _distanceToApex = 100;

        public Form1()
        {
            InitializeComponent();
            Draw();
        }

        private void Draw()
        {
            var bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            var g = Graphics.FromImage(bmp);
            g.SmoothingMode = SmoothingMode.AntiAlias;

            var centerX = pictureBox1.Width / 2;
            var centerY = pictureBox1.Height / 2;

            var diameter = 0.62f * _distanceToApex;
            var pentagonRadius = 0.38f * _distanceToApex;

            const float angle = 1.25664f;

            var points = new Point[5];
            points[0] = new Point(centerX, centerY - _distanceToApex);

            for (var i = 1; i < 5; i++)
            {
                var x = Convert.ToInt32(centerX + (points[i - 1].X - centerX) * Math.Cos(angle) -
                                        (points[i - 1].Y - centerY) * Math.Sin(angle));
                var y = Convert.ToInt32(centerY + (points[i - 1].X - centerX) * Math.Sin(angle) +
                                        (points[i - 1].Y - centerY) * Math.Cos(angle));
                points[i] = new Point(x, y);
            }

            var pentagonPoints = new Point[5];
            pentagonPoints[0] = new Point(centerX, Convert.ToInt32(centerY + pentagonRadius));

            for (var i = 1; i < 5; i++)
            {
                var x = Convert.ToInt32(centerX + (pentagonPoints[i - 1].X - centerX) * Math.Cos(angle) -
                                        (pentagonPoints[i - 1].Y - centerY) * Math.Sin(angle));
                var y = Convert.ToInt32(centerY + (pentagonPoints[i - 1].X - centerX) * Math.Sin(angle) +
                                        (pentagonPoints[i - 1].Y - centerY) * Math.Cos(angle));
                pentagonPoints[i] = new Point(x, y);
            }

            var pentagonArea = CalculateAreaOfPentagon(pentagonRadius, angle);
            var circleArea = CalculateAreaOfCircle(diameter);
            var area = pentagonArea - circleArea;

            areaOfFigure.Text = string.Format(CultureInfo.InvariantCulture, @"{0:0.00}", area);

            g.FillPolygon(new SolidBrush(Color.FromArgb(100, Color.Red)), pentagonPoints);

            g.FillEllipse(new SolidBrush(Color.FromArgb(255, Color.White)),
                new Rectangle((int)(centerX - diameter / 2), (int)(centerY - diameter / 2), (int)diameter,
                    (int)diameter));

            var blackPen = new Pen(Color.FromArgb(255, 0, 0, 0), 3);

            g.DrawLine(blackPen, points[0], points[2]);
            g.DrawLine(blackPen, points[2], points[4]);
            g.DrawLine(blackPen, points[4], points[1]);
            g.DrawLine(blackPen, points[1], points[3]);
            g.DrawLine(blackPen, points[3], points[0]);

            pictureBox1.Image = bmp;
        }

        private double CalculateAreaOfPentagon(float radius, float angle)
        {
            return 5f / 2f * radius * radius * Math.Sin(angle);
        }

        private double CalculateAreaOfCircle(float diameter)
        {
            return Math.PI * ((diameter / 2) * (diameter / 2));
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            _distanceToApex = trackBar1.Value;
            Draw();
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            Draw();
        }
    }
}