namespace Times
{
    public partial class Form1 : Form
    {
        private System.Windows.Forms.Timer MyTimer { get; set; }
        public Form1()
        {
            InitializeComponent();
            ShowTime();
        }

        private void ShowTime()
        {
            // 实例化Timer
            MyTimer = new System.Windows.Forms.Timer();
            //间隔时间
            MyTimer.Interval = 1000;
            //绑定事件
            MyTimer.Tick += (object snender, EventArgs e) => show();
            //启动
            MyTimer.Start();
        }
        private void show()
        {
            // 获取当前时间对象
            DateTime dt = DateTime.Now;
            DateTime gqdt = new DateTime(2026, 10, 01, 00, 00, 00);
             
            TimeSpan  resdt= gqdt - dt;
            //获取天数
            var day = ((int)resdt.TotalDays).ToString();
            
            //获取小时数
            var hour = ((int)resdt.Hours).ToString();

            //获取分钟数
            var minute = ((int)resdt.Minutes).ToString();

            //获取秒数
            var second = ((int)resdt.Seconds).ToString();

            //设置冒号图片
            pictureBox4.Image = Image.FromFile(@"./images/maohao.png");
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.Image = Image.FromFile(@"./images/maohao.png");
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox10.Image = Image.FromFile(@"./images/maohao.png");
            pictureBox10.SizeMode = PictureBoxSizeMode.StretchImage;

            //组装字符串
            string timeStr = day.PadLeft(3, '0') + hour.PadLeft(2, '0') + minute.PadLeft(2, '0') + second.PadLeft(2, '0');

            //组织一下控件在数组中
            var picArr = new PictureBox[] {
                    pictureBox1,pictureBox2,pictureBox3,
                    pictureBox5,pictureBox6,
                    pictureBox8,pictureBox9,
                    pictureBox11,pictureBox12,

                };
            for (int i = 0; i < picArr.Length; i++)
            {
                picArr[i].SizeMode = PictureBoxSizeMode.StretchImage;
                picArr[i].Image = Image.FromFile(@"./images/" + timeStr[i] + ".png");
            }


        }

    }
}
