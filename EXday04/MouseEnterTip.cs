namespace EXday04
{
    public partial class MouseEnterTip : Form
    {
        public MouseEnterTip()
        {
            InitializeComponent();
            InitEnterTip();
        }
        private Label lab1 = new Label();
        private void InitEnterTip()
        {
            button1.MouseEnter += Button1_MouseEnter;
            button1.MouseLeave += Button1_MouseLeave;

        }
        
        private void Button1_MouseLeave(object sender, EventArgs e)
        {
            lab1.Visible = false;
        }

        private void Button1_MouseEnter(object sender, EventArgs e)
        {
            //添加提示文本
            lab1.Name = "lab1";
            lab1.Text = "鼠标进入";
            lab1.ForeColor = Color.Black;
            lab1.BackColor = Color.Pink;
            lab1.Visible = true;
            this.Controls.Add(lab1);

            lab1.Location = new Point(button1.Location.X + 150, button1.Location.Y +50);

        }
    }
}
