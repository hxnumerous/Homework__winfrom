namespace EXday03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            initOpt();

        }

        public string[] picArr = [@"./images/cat.jpg", @"./images/bird.jpg", @"./images/eagle.jpg"];

        private int idx = 0;
        private void initOpt()
        {
            // 设置初始值
            pictureBox1.Image = Image.FromFile(picArr[0]);
            panel1.Controls[0].BackColor = Color.Cyan;
            panel1.Controls[0].ForeColor = Color.White;

            // 绑定事件
            label1.Click += btn_ClickLeft;
            label2.Click += btn_ClickRight;

            button1.Click += button1_Click;
            button2.Click += button2_Click;
            button3.Click += button3_Click;
        }
        public void btn_ClickLeft(object sender, EventArgs e)
        {
            // 先将所有的按钮的高亮效果移除
            for (int i = 0; i < panel1.Controls.Count; i++)
            {
                panel1.Controls[i].BackColor = Color.DarkGray;
                panel1.Controls[i].ForeColor = Color.Black;
            }

            // 切换上一张图片
            idx = (idx - 1 + picArr.Length) % picArr.Length;
            pictureBox1.Image = Image.FromFile(picArr[idx]);

            //将当前按钮改为高亮
            panel1.Controls[idx].BackColor = Color.Cyan;
            panel1.Controls[idx].ForeColor = Color.Blue;

        }

        public void btn_ClickRight(object sender, EventArgs e)
        {
            // 先将所有的按钮的高亮效果移除
            for (int i = 0; i < panel1.Controls.Count; i++)
            {
                panel1.Controls[i].BackColor = Color.DarkGray;
                panel1.Controls[i].ForeColor = Color.Black;
            }
            // 切换上一张图片
            idx = (idx + 1 + picArr.Length) % picArr.Length;
            pictureBox1.Image = Image.FromFile(picArr[idx]);

            //将当前按钮改为高亮
            panel1.Controls[idx].BackColor = Color.Cyan;
            panel1.Controls[idx].ForeColor = Color.Blue;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 先将所有的按钮的高亮效果移除
            for (int i = 0; i < panel1.Controls.Count; i++)
            {
                panel1.Controls[i].BackColor = Color.DarkGray;
                panel1.Controls[i].ForeColor = Color.Black;
            }

            pictureBox1.Image = Image.FromFile(picArr[0]);
            //将当前按钮改为高亮
            panel1.Controls[0].BackColor = Color.Cyan;
            panel1.Controls[0].ForeColor = Color.Blue;

        }
        private void button2_Click(object sender, EventArgs e)
        {
            // 先将所有的按钮的高亮效果移除
            for (int i = 0; i < panel1.Controls.Count; i++)
            {
                panel1.Controls[i].BackColor = Color.DarkGray;
                panel1.Controls[i].ForeColor = Color.Black;
            }

            pictureBox1.Image = Image.FromFile(picArr[1]);
            //将当前按钮改为高亮
            panel1.Controls[1].BackColor = Color.Cyan;
            panel1.Controls[1].ForeColor = Color.Blue;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            // 先将所有的按钮的高亮效果移除
            for (int i = 0; i < panel1.Controls.Count; i++)
            {
                panel1.Controls[i].BackColor = Color.DarkGray;
                panel1.Controls[i].ForeColor = Color.Black;
            }

            pictureBox1.Image = Image.FromFile(picArr[2]);
            //将当前按钮改为高亮
            panel1.Controls[2].BackColor = Color.Cyan;
            panel1.Controls[2].ForeColor = Color.Blue;
        }
    }
}
