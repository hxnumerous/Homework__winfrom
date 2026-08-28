using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Reflection.Metadata;
using System.Text;
using System.Windows.Forms;

namespace EXday04
{
    public partial class NumSpit : Form
    {
        public NumSpit()
        {
            InitializeComponent();
            InitNumSpit();
        }
        private void InitNumSpit()
        {
            textBox1.TextChanged += TextBox1_TextChanged;
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            //获取文本内容
            string Input = textBox1.Text;
            //如果为空
            if (string.IsNullOrWhiteSpace(Input)) return;
            //出现逗号无法转换，去除逗号
            Input=Input.Replace(",","");
            //转为数字,然后加逗号
            string res = long.Parse(Input).ToString("#,#");
            //赋值回文本
            textBox1.Text = res;
            //光标回归
            textBox1.SelectionStart = res.Length;

        }
    }
}
