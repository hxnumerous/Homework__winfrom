using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EXday04
{
    public partial class ChangeUpOrDown : Form
    {
        public ChangeUpOrDown()
        {
            InitializeComponent();
            InitChangeUpOrDown();
        }
        private void InitChangeUpOrDown()
        {
            textBox1.TextChanged += TextBox1_TextChanged;
            textBox2.TextChanged += TextBox2_TextChanged;
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            //接受内容
            string Input = textBox1.Text;
            //转大写
            string res =Input.ToUpper().Trim();
            //赋值回文本
            textBox1.Text = res;
            //处理光标
            textBox1.SelectionStart = res.Length;

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
            //接受内容
            string Input = textBox2.Text;
            //转大写
            string res = Input.ToLower().Trim();
            //赋值回文本
            textBox2.Text = res;
            //处理光标
            textBox2.SelectionStart = res.Length;

        }
    }
}
