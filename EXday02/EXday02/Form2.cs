using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EXday02
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            initopt();
        }


        private void initopt()
        {
            button1.Click += Button1_Click;
            button2.Click += Button2_Click;
            button3.Click += Button3_Click;
        }
        public void Button1_Click(object sender, EventArgs e)
        {

            //将button值类型由Object转为button
            Button btn1 = (Button)sender;

            //添加事件
            if (btn1.Text == "小猫")
            {
                button2.BackColor = Color.DarkGray;
                button2.ForeColor = Color.Black;

                button3.BackColor = Color.DarkGray;
                button3.ForeColor = Color.Black;

                // 通过代码给 图片控件 设置 图片资源Image.FromFile(图片路径)
                pictureBox1.Image = Image.FromFile(@"./images/cat.jpg");

                // 将当前这个按钮的高亮添加
                Button btn = (Button)sender;
                btn.BackColor = Color.Cyan;
                btn.ForeColor = Color.White;
            }

        }

        public void Button2_Click(object sender, EventArgs e)
        {
            //将button值类型由Object转为button
            Button btn2 = (Button)sender;

            //添加事件
            if (btn2.Text == "小鸡")
            {

                button1.BackColor = Color.DarkGray;
                button1.ForeColor = Color.Black;

                button3.BackColor = Color.DarkGray;
                button3.ForeColor = Color.Black;

                // 通过代码给 图片控件 设置 图片资源Image.FromFile(图片路径)
                pictureBox1.Image = Image.FromFile(@"./images/bird.jpg");

                // 将当前这个按钮的高亮添加
                Button btn = (Button)sender;
                btn.BackColor = Color.Cyan;
                btn.ForeColor = Color.White;
            }


        }

        public void Button3_Click(object sender, EventArgs e)
        {
            //将button值类型由Object转为button
            Button btn3 = (Button)sender;

            //添加事件
            if (btn3.Text == "老鹰")
            {
                button1.BackColor = Color.DarkGray;
                button1.ForeColor = Color.Black;

                button2.BackColor = Color.DarkGray;
                button2.ForeColor = Color.Black;

                // 通过代码给 图片控件 设置 图片资源Image.FromFile(图片路径)
                pictureBox1.Image = Image.FromFile(@"./images/eagle.jpg");

                // 将当前这个按钮的高亮添加
                Button btn = (Button)sender;
                btn.BackColor = Color.Cyan;
                btn.ForeColor = Color.White;
            }



        }

    }
}
