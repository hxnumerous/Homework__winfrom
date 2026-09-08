namespace Gauge
{
    using static System.Net.Mime.MediaTypeNames;
    using static System.Windows.Forms.AxHost;

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //在pannel上创建画图事件
            panel1.Paint += Panel1_Paint; ;

        }

        private int Radius = 400;
        private int RadiusX = 100;
        private int RadiusY = 50;
        // 每个刻度的长度
        private int LongScale = 20;
        private int Count = 60;
        private void Panel1_Paint(object? sender, PaintEventArgs e)
        {
            //获取画图的对象
            Graphics g = e.Graphics;
            //设置抗锯齿的模式
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            //画笔设置
            using (Pen pengreen = new Pen(Color.Green, 3))
            {
                //画圆弧
                Rectangle Rect = new Rectangle(RadiusX, RadiusY, Radius, Radius);
                g.DrawArc(pengreen, Rect, 180, 180);

                //设置临时变量来存储不同的刻度长度
                var temLongScale = LongScale;

                using (Pen penorange = new Pen(Color.Orange, 3))
                using (SolidBrush brushred = new SolidBrush(Color.Red))
                {
                    //进行循环画刻度线
                    for (int i = 0; i <= Count; i++)
                    {
                        if (i % 10 == 0) temLongScale = 2 * LongScale;
                        //确定线的起始和结束坐标
                        var startX = RadiusX + Radius / 2 + Math.Cos((180 + (i * 180 / Count)) * Math.PI / 180) * (Radius / 2);
                        var startY = RadiusY + Radius / 2 + Math.Sin((180 + (i * 180 / Count)) * Math.PI / 180) * (Radius / 2);
                        var endX = RadiusX + Radius / 2 + (Math.Cos((180 + (i * 180 / Count)) * Math.PI / 180) * (Radius / 2 - temLongScale));
                        var endY = RadiusY + Radius / 2 + (Math.Sin((180 + (i * 180 / Count)) * Math.PI / 180) * (Radius / 2 - temLongScale));
                        //画线
                        g.DrawLine(penorange, (int)startX, (int)startY, (int)endX, (int)endY);
                        //还原刻度线长度
                        temLongScale = LongScale;


                        if (i % 20 == 0)
                        {
                            double angle = (180 + (i * 180 / Count)) * Math.PI / 180;

                            var textX = RadiusX + Radius / 2 + (Math.Cos(angle) * (Radius / 2 - 3 * temLongScale));
                            var textY = RadiusY + Radius / 2 + (Math.Sin(angle) * (Radius / 2 - 3 * temLongScale));
                            //画文字
                            using (Brush brushText = new SolidBrush(Color.Black))
                            {
                                System.Drawing.Font f = new System.Drawing.Font("微软雅黑", 12);
                                StringFormat Sf = new StringFormat();
                                Sf.Alignment = StringAlignment.Center;
                                Sf.LineAlignment = StringAlignment.Center;
                                g.DrawString(i.ToString(), f, brushText, (float)textX, (float)textY, Sf);
                            }
                        }

                    }

                    //确认起始位置
                    var lineX = RadiusX + Radius / 2;
                    var LineY = RadiusY + Radius / 2;
                    var endLineX = RadiusX + Radius / 2 + (Math.Cos((180 + (42 * 180 / Count)) * Math.PI / 180) * (Radius / 2 - temLongScale));
                    var endLineY = RadiusY + Radius / 2 + (Math.Sin((180 + (42 * 180 / Count)) * Math.PI / 180) * (Radius / 2 - temLongScale));
                    //画线
                    g.DrawLine(pengreen, (int)lineX, (int)LineY, (int)endLineX, (int)endLineY);

                    //画箭头三角形
                    Point[] points =
                    {
                        new Point((int)endLineX ,(int)endLineY ),
                        new Point(
                            (int)(endLineX - 10 * Math.Cos((180 + (42 * 180 / Count)) * Math.PI / 180) - 10 / 2 * Math.Cos((180 + (42 * 180 / Count)) * Math.PI / 180 + Math.PI/2)),
                            (int)(endLineY - 10 * Math.Sin((180 + (42 * 180 / Count)) * Math.PI / 180) - 10 / 2 * Math.Sin((180 + (42 * 180 / Count)) * Math.PI / 180 + Math.PI/2))),
                        new Point(
                            (int)(endLineX + 10 * Math.Cos((180 + (42 * 180 / Count)) * Math.PI / 180) - 10 / 2 * Math.Cos((180 + (42 * 180 / Count)) * Math.PI / 180 + Math.PI/2)),
                            (int)(endLineY + 10 * Math.Sin((180 + (42 * 180 / Count)) * Math.PI / 180) - 10 / 2 * Math.Sin((180 + (42 * 180 / Count)) * Math.PI / 180 + Math.PI/2))),

                    };

                    g.FillPolygon(brushred,points);


                }
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
