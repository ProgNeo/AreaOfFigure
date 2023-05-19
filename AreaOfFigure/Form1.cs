using System.Drawing.Drawing2D;
using System.Globalization;

namespace AreaOfFigure
{
    public partial class MainForm : Form
    {
        private const float Angle = 1.25664f;
        private int _pentagonRadius = 2;
        private double _pentagonSide;
        private double _starRadius = 2.63 * 2;
        private double _circleRadius;
        private Point _centerPoint;

        public MainForm()
        {
            InitializeComponent();
            _centerPoint = new Point(pictureBox.Width / 2, pictureBox.Height / 2);
            scaleComboBox.Text = @"100%";
            Draw();
            CalculateArea();
        }

        private void TrackBarValueChanged(object sender, EventArgs e)
        {
            _pentagonRadius = trackBar.Value;
            _starRadius = 2.63 * _pentagonRadius;
            Draw();
            CalculateArea();
        }

        private void FormSizeChanged(object sender, EventArgs e)
        {
            _centerPoint = new Point(pictureBox.Width / 2, pictureBox.Height / 2);
            Draw();
            CalculateArea();
        }

        private void ScaleComboBoxChanged(object sender, EventArgs e)
        {
            Draw();
            CalculateArea();
        }

        private void CalculateArea()
        {
            var pentagonArea = CalculateAreaOfPentagon(_pentagonRadius, Angle);
            var circleArea = CalculateAreaOfCircle(_circleRadius);
            var area = pentagonArea - circleArea;

            areaOfFigure.Text = string.Format(CultureInfo.InvariantCulture, @"{0:0.00}", area);
        }

        private void Draw()
        {
            var bmp = new Bitmap(pictureBox.Width, pictureBox.Height);
            var graphics = Graphics.FromImage(bmp);

            graphics.SmoothingMode = SmoothingMode.AntiAlias;

            DrawPentagon(graphics);
            DrawCircle(graphics);
            DrawStar(graphics);

            pictureBox.Image = bmp;
        }

        private void DrawPentagon(Graphics graphics)
        {
            var redBrush = new SolidBrush(Color.FromArgb(100, Color.Red));

            var pentagonPoints = new DoublePoint[5];
            var drawablePoints = new Point[5];

            pentagonPoints[0] = new DoublePoint(0, _pentagonRadius);
            drawablePoints[0] = MoveToCenter(ScaleDoublePoint(ConvertCmToPx(pentagonPoints[0], graphics.DpiX)));

            for (var i = 1; i < 5; i++)
            {
                var x = pentagonPoints[i - 1].X * Math.Cos(Angle) - pentagonPoints[i - 1].Y * Math.Sin(Angle);
                var y = pentagonPoints[i - 1].X * Math.Sin(Angle) + pentagonPoints[i - 1].Y * Math.Cos(Angle);
                pentagonPoints[i] = new DoublePoint(x, y);
                drawablePoints[i] = MoveToCenter(ScaleDoublePoint(ConvertCmToPx(pentagonPoints[i], graphics.DpiX)));
            }

            _pentagonSide = CalculateSideOfPentagon(pentagonPoints);
            _circleRadius = CalculateCircleRadius(_pentagonSide);

            graphics.FillPolygon(redBrush, drawablePoints);
        }

        private void DrawCircle(Graphics graphics)
        {
            var whiteBrush = new SolidBrush(Color.FromArgb(255, Color.White));

            var drawableRadius = ScaleRadius(ConvertCmToPx(_circleRadius, graphics.DpiX));

            graphics.FillEllipse(whiteBrush, new Rectangle(
                Convert.ToInt32(_centerPoint.X - drawableRadius),
                Convert.ToInt32(_centerPoint.Y - drawableRadius),
                Convert.ToInt32(drawableRadius * 2),
                Convert.ToInt32(drawableRadius * 2)
            ));
        }

        private void DrawStar(Graphics graphics)
        {
            var blackPen = new Pen(Color.FromArgb(255, Color.Black), 5);

            var starPoints = new DoublePoint[5];
            var drawablePoints = new Point[5];

            starPoints[0] = new DoublePoint(0, -_starRadius);
            drawablePoints[0] = MoveToCenter(ScaleDoublePoint(ConvertCmToPx(starPoints[0], graphics.DpiX)));

            for (var i = 1; i < 5; i++)
            {
                var x = starPoints[i - 1].X * Math.Cos(Angle) - starPoints[i - 1].Y * Math.Sin(Angle);
                var y = starPoints[i - 1].X * Math.Sin(Angle) + starPoints[i - 1].Y * Math.Cos(Angle);
                starPoints[i] = new DoublePoint(x, y);
                drawablePoints[i] = MoveToCenter(ScaleDoublePoint(ConvertCmToPx(starPoints[i], graphics.DpiX)));
            }

            graphics.DrawLine(blackPen, drawablePoints[0], drawablePoints[2]);
            graphics.DrawLine(blackPen, drawablePoints[2], drawablePoints[4]);
            graphics.DrawLine(blackPen, drawablePoints[4], drawablePoints[1]);
            graphics.DrawLine(blackPen, drawablePoints[1], drawablePoints[3]);
            graphics.DrawLine(blackPen, drawablePoints[3], drawablePoints[0]);
        }

        private double CalculateSideOfPentagon(IReadOnlyList<DoublePoint> points)
        {
            return Math.Sqrt(Math.Pow(points[1].X - points[0].X, 2) + Math.Pow(points[1].Y - points[0].Y, 2));
        }

        private double CalculateCircleRadius(double pentagonSide)
        {
            return (pentagonSide * Math.Sqrt(25 + 10 * Math.Sqrt(5))) / 10;
        }

        private double CalculateAreaOfPentagon(double radius, double angle)
        {
            return 5f / 2f * radius * radius * Math.Sin(angle);
        }

        private double CalculateAreaOfCircle(double radius)
        {
            return Math.PI * (radius * radius);
        }

        private DoublePoint ConvertCmToPx(DoublePoint point, double dpi)
        {
            return new DoublePoint(point.X * (dpi / 2.54), point.Y * (dpi / 2.54));
        }

        private double ConvertCmToPx(double value, double dpi)
        {
            return value * (dpi / 2.54);
        }

        private DoublePoint ScaleDoublePoint(DoublePoint point)
        {
            var multiplier = scaleComboBox.SelectedIndex switch
            {
                0 => 0.5d,
                1 => 0.75d,
                2 => 1d,
                3 => 1.25d,
                4 => 1.5d,
                5 => 1.75d,
                6 => 2d,
                _ => 1d
            };

            return new DoublePoint(point.X * multiplier, point.Y * multiplier);
        }

        private double ScaleRadius(double radius)
        {
            var multiplier = scaleComboBox.SelectedIndex switch
            {
                0 => 0.5d,
                1 => 0.75d,
                2 => 1d,
                3 => 1.25d,
                4 => 1.5d,
                5 => 1.75d,
                6 => 2d,
                _ => 1d
            };

            return radius * multiplier;
        }

        private Point MoveToCenter(DoublePoint point)
        {
            return new Point(Convert.ToInt32(point.X + _centerPoint.X), Convert.ToInt32(point.Y + _centerPoint.Y));
        }
    }
}