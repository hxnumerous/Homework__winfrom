using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace EXday04
{
    public partial class CheckPwd : Form
    {
        public CheckPwd()
        {
            InitializeComponent();
            InitCheckPwd();
        }
        private void InitCheckPwd()
        {
            textBox1.TextChanged += TextBox1_TextChanged;

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
           string input = textBox1.Text;
            var reg1 = @"\d+";
            var reg2 = @"[a-z]+";
            var reg3 = @"[A-Z]+";
            int count = 0;

            if(Regex.IsMatch(input, reg1)) { count++; }
            if (Regex.IsMatch(input, reg2)) { count++; }
            if (Regex.IsMatch(input, reg3)) { count++; }

            string res = "";
            switch (count) {
                case 1:
                    res = "弱";
                    label2.Text = res;
                    label2.ForeColor = Color.Red;
                    break;
                case 2:
                    res = "中";
                    label2.Text = res;
                    label2.ForeColor = Color.Orange;
                    break;
                case 3:
                    res = "强";
                    label2.Text = res;
                    label2.ForeColor = Color.Green;
                    break;
                default:
                    res = "密码格式有误";
                    label2.Text = res;
                    label2.ForeColor = Color.Gray;
                    break;
            }

        }
    }
}
