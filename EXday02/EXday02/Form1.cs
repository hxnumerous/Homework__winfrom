namespace EXday02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            initopt();

        }

        public void initopt()
        {
            button1.Click += Button1_Click;

        }

        //添加参数
        private void Button1_Click(object sender,EventArgs e)
        {
            //将button值类型由Object转为button
            Button btn = (Button)sender;

            //添加事件
            if (btn.Text == "打开")
            {
                // 通过代码给 图片控件 设置 图片资源Image.FromFile(图片路径)
                pictureBox1.Image=Image.FromFile(@"./images/on.png");
                //将文本改为关闭
                btn.Text = "关闭";
            }
            else
            {
                // 通过代码给 图片控件 设置 图片资源Image.FromFile(图片路径)
                pictureBox1.Image = Image.FromFile(@"./images/off.png");
                //将文本改为打开
                btn.Text = "打开";
            }
            
        }
    }
}