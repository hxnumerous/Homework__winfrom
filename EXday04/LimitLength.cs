using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EXday04
{
    public partial class LimitLength : Form
    {
        public LimitLength()
        {
            InitializeComponent();
            InitLimitLength();
        }
        private void InitLimitLength()
        {
            textBox1.KeyPress += TextBox1_KeyPress;
        }
        int MaxLength = 10;
        private Label Lab1 =new Label();
        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //设置label
            Lab1.Text = "长度超出了";
            Lab1.ForeColor = Color.Red;
            Lab1.Location = new Point(textBox1.Location.X,textBox1.Location.Y - 20);
            Lab1.Visible = false;
            this.Controls.Add(Lab1);

            //判断长度
            string content = textBox1.Text;
            if (content.Length > MaxLength)
            {
                string res = content.Substring(0, MaxLength);
                textBox1.SelectionStart = MaxLength;
                textBox1.Text = res;
                textBox1.SelectionStart= MaxLength;
                Lab1.Visible= true;
                //MessageBox.Show("长度超出了");
            }


        }
    }
}
