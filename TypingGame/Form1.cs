using System.Diagnostics.Eventing.Reader;

namespace Typing_Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //加载游戏
            this.Shown += GameStart;
        }
        //准备随机数变量
        Random r = new Random();
        //初始分数设置
        int score = 0;
        //设置定时器
        private System.Windows.Forms.Timer timer = new();
        //创建list来存储新建的label和timer
        private List<LabelAndTimer> list = new();


        //创建LabelAndTimer类 封装Label控件和窗体Timer
        public class LabelAndTimer
        {

            public Label Lab { get; set; }
            public System.Windows.Forms.Timer LabTimer { get; set; }

            public LabelAndTimer(Label lab, System.Windows.Forms.Timer tm)
            {
                Lab = lab;
                LabTimer = tm;
            }

        }
        //设置开始游戏数据
        private void GameStart(object sender, EventArgs e)
        {
            timer.Interval = 1000;
            timer.Tick += Timer_Tick; ;
            this.KeyPreview = true;
            this.ActiveControl = null;
            KeyUp += Gaming;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            //新建label
            Label lab = new Label();
            lab.Text = ((char)r.Next(65, 91)).ToString();
            lab.Size = new Size(30, 30);
            lab.Location = new Point(r.Next(panel1.Width - 30), 0);
            lab.TextAlign = ContentAlignment.MiddleCenter;
            lab.Font = new Font("微软雅黑", 14F, FontStyle.Bold, GraphicsUnit.Point);

            //添加到panel
            panel1.Controls.Add(lab);

            //设置label的时间定时器
            System.Windows.Forms.Timer ti = new();
            ti.Interval = 20;
            ti.Tick += (object sender, EventArgs e) => Ti_Tick(lab);
            ti.Start();

            //记录存储存List中
            list.Add(new LabelAndTimer(lab, ti));
        }

        private void Gaming(object sender, KeyEventArgs e)
        {
            //遍历存储的list，查看按键是否在list里面
            for (int i = list.Count-1; i >= 0; i--)
            {
                //判断lab上的text转为string
                if (Enum.TryParse(list[i].Lab.Text,true, out Keys k))
                {
                    //判断是否是按下的按键
                    if (k != e.KeyCode) continue;

                    //如果是按下的键，则删除这个label和定时器
                    panel1.Controls.Remove(list[i].Lab);
                    list[i].LabTimer.Stop();

                    //然后删除list[i]
                    list.RemoveAt(i);

                    label2.Text = (++score).ToString();

                    return;
                }
            }


        }

        private void Ti_Tick(Label label)
        {
            //移动速度
            if (score < 10)
            {
                label.Top += 2;
            }
            else if(score >= 10 && score <= 20 ) 
            {
                label.Top += 6;
            }
            else if (score > 20)
            {
                label.Top += 10;
            }

            //设定终点
            if (label.Top >= panel1.Height - 30)
            {
                //游戏此时结束  关闭所有的定时器
                timer.Stop();
                foreach (var item in list)
                {
                    item.LabTimer.Stop();
                }
                MessageBox.Show($"游戏结束！！！\n最终得分：{score}");
                //清除所有控件
                panel1.Controls.Clear();
                //清空list所有存储的label和timer
                list.Clear();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //恢复初始值
            score = 0;
            label2.Text = "0";
            timer.Start();
        }
    }
}
