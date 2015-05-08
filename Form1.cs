using System;
using System.Drawing;
using System.Windows.Forms;

namespace Timer
{
    public partial class TimeAnalogClock : Form
    {

        #region Variables

        private int _wight = 300, _hight = 300, _secund = 100, _minute = 120, _hour = 140;
        private int _centerX ;
        private int _centerY ;

        private int _sec;
        private int _min;
        private int _hours = 0;

        private Timer time = new Timer();

        private readonly Bitmap _bitmap;
        private Graphics _graphics;


        private bool _start;
        #endregion

        #region CoordinatesLogicMake

        public int[] Coordinates_MinSec(int val, int hlen)
        {
            var coordin = new int[2];

            val *= 6;   //each minute and second make 6 degree

            if (val >= 0 && val <= 180)
            {
                coordin[0] = _centerX + (int)(hlen * Math.Sin(Math.PI * val / 180));
                coordin[1] = _centerY - (int)(hlen * Math.Cos(Math.PI * val / 180));
            }
            else
            {
                coordin[0] = _centerX - (int)(hlen * -Math.Sin(Math.PI * val / 180));
                coordin[1] = _centerY - (int)(hlen * Math.Cos(Math.PI * val / 180));
            }
            return coordin;
        }

        public int[] Coordinates_Hour(int hval, int mval, int hlen)
        {
            var coordin = new int[2];
            //mval = minute value
            //hval = hour value
            //each hour +30 degree
            //each minute +0,5 degree
            int val = (int)((hval * 30) + (mval * 0.5));

            if (val >= 0 && val <= 180)
            {
                coordin[0] = _centerX + (int)(hlen * Math.Sin(Math.PI * val / 180));
                coordin[1] = _centerY - (int)(hlen * Math.Cos(Math.PI * val / 180));
            }
            else
            {
                coordin[0] = _centerX - (int)(hlen * -Math.Sin(Math.PI * val / 180));
                coordin[1] = _centerY - (int)(hlen * Math.Cos(Math.PI * val / 180));
            }

            return coordin;
        }

        public int[] DrawLinesEnd(int val, int hlen)
        {
            var coordin = new int[2];

            val *= 6;   //each minute and second make 6 degree

            if (val >= 0 && val <= 180)
            {
                coordin[0] = _centerX + (int) (hlen*Math.Sin(Math.PI*val/180)) + 3;
                coordin[1] = _centerY - (int) (hlen*Math.Cos(Math.PI*val/180)) - 3;
            }
            else
            {
                coordin[0] = _centerX - (int) (hlen*-Math.Sin(Math.PI*val/180)) - 3;
                coordin[1] = _centerY - (int) (hlen*Math.Cos(Math.PI*val/180)) + 3;
            }
            return coordin;
        }

        public int[] DrawLinesCenter(int val, int hlen)
        {
            var coordin = new int[2];

            val *= 6;   //each minute and second make 6 degree

            if (val >= 0 && val <= 180)
            {
                coordin[0] = _centerX + (int)(hlen * Math.Sin(Math.PI * val / 180)) +1;
                coordin[1] = _centerY - (int)(hlen * Math.Cos(Math.PI * val / 180))+1;
            }
            else
            {
                coordin[0] = _centerX - (int)(hlen * -Math.Sin(Math.PI * val / 180))-1;
                coordin[1] = _centerY - (int)(hlen * Math.Cos(Math.PI * val / 180))-1;
            }
            return coordin;
        }

        #endregion

        #region DrawingCoordinates

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (_start)
            {
                _graphics = Graphics.FromImage(_bitmap);

                if (DateTime.Now.Second >= 0)
                {
                    _sec++;
                }
                if (_sec == 60)
                {
                    _min++;
                }
                if (_min == 60)
                {
                    _hour++;
                }


                _graphics.Clear(Color.White);
                
                _graphics.DrawEllipse(new Pen(Color.Black, 1f), 0, 0, _wight, _hight);

                //for (int i = 5; i < 61; i=i+5)
                //{
                //    int b = 0;
                //    var linesCoordinEnd = DrawLinesEnd(i, 130);
                //    var linesCoordinCenter = DrawLinesCenter(i, 160);
                    
                //    _graphics.DrawString(
                //        "" + (int)i/5, 
                //        new Font("Arial", 14), 
                //        Brushes.Black, 
                //        new PointF((float)linesCoordinCenter[0],(float)linesCoordinCenter[1]));
                //    b++;
                //}

                _graphics.DrawString("12", new Font("Arial", 14), Brushes.Black, new PointF(140, 0));
                _graphics.DrawString("3", new Font("Arial", 14), Brushes.Black, new PointF(280, 140));
                _graphics.DrawString("6", new Font("Arail", 14), Brushes.Black, new PointF(140, 280));
                _graphics.DrawString("9", new Font("Arial", 14), Brushes.Black, new PointF(0, 140));

                var coordin = Coordinates_MinSec(_sec, _secund);
                
                if (coordin == null) throw new ArgumentNullException("sender");
                _graphics.DrawLine(new Pen(Color.Black, 1f), new Point(_centerX, _centerY),
                    new Point(coordin[0], coordin[1]));

               

                coordin = Coordinates_MinSec(_min, _minute);
                _graphics.DrawLine(new Pen(Color.Black, 2f), new Point(_centerX, _centerY),
                    new Point(coordin[0], coordin[1]));

                coordin = Coordinates_Hour(_hours, _min, _hour);
                _graphics.DrawLine(new Pen(Color.Black, 3f), new Point(_centerX, _centerY),
                    new Point(coordin[0], coordin[1]));

                Clock_PictBox.Image = _bitmap;

                Text = string.Format(@"Analog Timer {0}:{1}:{2}", _hours, _min, _sec);
                time.TimeStart(Text);
                _graphics.Dispose();

                if (_sec == 60)
                {
                    _sec = 0;
                }
                if (_min == 60)
                {
                    _min = 0;
                }
                if (_hour == 24)
                {
                    _hour = 0;
                }
            }
        }

        #endregion

        public TimeAnalogClock()
        {
            InitializeComponent();

            _bitmap = new Bitmap(_wight + 1, _hight + 1);

            _centerX = _wight / 2;
            _centerY = _hight / 2;

            BackColor = Color.White;
        }

        public override sealed Color BackColor
        {
            get { return base.BackColor; }
            set { base.BackColor = value; }
        }

        private void Start_Buttn_Click(object sender, EventArgs e)
        {
            _start = true;
            timer1.Start();
        }

        private void Stop_Buttn_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            _start = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _sec = 0;
            _min = 0;
            _hour = 0;
            _start = false;
            
            _graphics.Dispose();

            Start_Buttn.PerformClick(); 
        }

        private void TimerButton_Click(object sender, EventArgs e)
        {
            time.Show();
        }
    }
}
