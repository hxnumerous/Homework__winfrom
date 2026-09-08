using System.Timers;
using static System.Net.Mime.MediaTypeNames;

namespace Clock
{
    public partial class Form1 : Form
    {
        private System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        private int Num = 0;
        private int Num2 = 0;
        private int Num3 = 0;
        public Form1()
        {
            InitializeComponent();
            //在pannel上创建画图事件
            panel1.Paint += Panel1_Paint;

            //设置定时器
            timer.Interval = 1000;
            timer.Tick += Timer_Tick; ;
            timer.Start();
        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            // 获取到秒数
            Num = DateTime.Now.Second;
            //获取到分钟数
            Num2 = DateTime.Now.Minute;
            //获取到小时数
            Num3 = DateTime.Now.Hour;

            //重新绘画
            panel1.Invalidate();

        }

        private int Radius = 150;
        private int RadiusX = 320;
        private int RadiusY = 200;
        // 每个刻度的长度
        private int LongScale = 10;
        private int Count = 60;

        
        private void Panel1_Paint(object? sender, PaintEventArgs e)
        {
            //获取画图的对象
            Graphics g = e.Graphics;
            //设置抗锯齿的模式
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            //画笔设置
            using (Pen penblack = new Pen(Color.Black,3))
            {
                //画圆
                g.DrawArc(penblack, RadiusX - Radius, RadiusY - Radius, 2 * Radius , 2 * Radius , 0 , 360 );

                //设置临时变量来存储不同的刻度长度
                var temLongScale = LongScale;

                //进行循环画刻度线
                for (int i = 0; i < Count; i++)
                {
                    if (i % 5 == 0) temLongScale = 2 * LongScale;
                    //确定线的起始和结束坐标
                    var startX = RadiusX + Math.Cos(i * ( 360 / Count) * Math.PI / 180 ) * Radius;
                    var startY = RadiusY + Math.Sin(i * (360 / Count) * Math.PI / 180) * Radius;
                    var endX = RadiusX + Math.Cos(i * (360 / Count) * Math.PI / 180) * (Radius - temLongScale);
                    var endY = RadiusY + Math.Sin(i * (360 / Count) * Math.PI / 180) * (Radius - temLongScale);
                    //画线
                    g.DrawLine(penblack,(int)startX, (int)startY, (int)endX, (int)endY);
                    //还原刻度线长度
                    temLongScale = LongScale;

                    if(i % 5 == 0)
                    {

                        int number = (i / 5 == 0) ? 12 : (i / 5);
                        double angle = (i * (360 / Count) - 90) * Math.PI / 180;
                        var textX = RadiusX + Math.Cos(angle) * (Radius - 3 * temLongScale);
                        var textY = RadiusY + Math.Sin(angle) * (Radius - 3 * temLongScale);
                        //画文字
                        using (Brush brushText = new SolidBrush(Color.Black))
                        {

                            System.Drawing.Font f = new System.Drawing.Font("微软雅黑", 12);
                            StringFormat Sf = new StringFormat();
                            Sf.Alignment = StringAlignment.Center;
                            Sf.LineAlignment = StringAlignment.Center;
                            g.DrawString(number.ToString(), f, brushText, (float)textX, (float)textY, Sf);
                        }
                       

                    }

                }

                //画秒针
                using (Pen penred = new Pen(Color.Red, 2))
                {
                    //确认起始点
                    //起点为圆心
                    var endX = Math.Cos(((360 / Count) * Num + 270) * Math.PI / 180) * (Radius - temLongScale) + RadiusX;
                    var endY = Math.Sin(((360 / Count) * Num + 270) * Math.PI / 180) * (Radius - temLongScale) + RadiusY;
                    //画线
                    g.DrawLine(penred, RadiusX, RadiusY, (int)endX, (int)endY);
                }

                //画分针
                using (penblack)
                {
                    //确认起始点
                    //起点为圆心
                    var endX = Math.Cos(((360 / Count) * Num2 + 270) * Math.PI / 180) * (Radius / 1.5) + RadiusX;
                    var endY = Math.Sin(((360 / Count) * Num2 + 270) * Math.PI / 180) * (Radius / 1.5) + RadiusY;
                    //画线
                    g.DrawLine(penblack, RadiusX, RadiusY, (int)endX, (int)endY);

                }

                //画时针
                using (Pen penblack2 = new Pen(Color.Black, 6))
                {
                    //确认起始点
                    //起点为圆心
                    float hourAngle = (Num3 % 12) * 30 + Num2 * 0.5f;
                    var endX = Math.Cos((hourAngle + 270) * Math.PI / 180) * (Radius / 3) + RadiusX;
                    var endY = Math.Sin((hourAngle + 270) * Math.PI / 180) * (Radius / 3) + RadiusY;
                    //画线
                    g.DrawLine(penblack2, RadiusX, RadiusY, (int)endX, (int)endY);

                }

                // 在圆心画一个小圆点装饰
                using (Brush brushCenter = new SolidBrush(Color.FromArgb(255, 0, 0, 0)))
                {
                    g.FillEllipse(brushCenter, RadiusX - 5, RadiusY - 5, 10, 10);
                }

            }


        }

        //设置缓存类
        public class DoubleBufferPanel : Panel
        {
            public DoubleBufferPanel()
            {
                //开启双缓冲，消除闪烁
                this.SetStyle(ControlStyles.UserPaint
                    | ControlStyles.AllPaintingInWmPaint
                    | ControlStyles.OptimizedDoubleBuffer, true);
                UpdateStyles();
            }
        }


    }
}
