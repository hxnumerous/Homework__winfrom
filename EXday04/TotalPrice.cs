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
    public partial class TotalPrice : Form
    {
        public TotalPrice()
        {
            InitializeComponent();
            InitTotalPrice();
        }
        //创建空的集合，集合内为字典元素。匹配价格和数量输入框，进行建立联系
        List<Dictionary<string, Control>> Lablist = new();
        private void InitTotalPrice()
        {
            //将组件添加进去
            Lablist.Add(new Dictionary<string, Control>()
            {
                ["price"] = lab1 ,
                ["count"] = textBox1,
            });
            Lablist.Add(new Dictionary<string, Control>()
            {
                ["price"] = lab2 ,
                ["count"] = textBox2,
            });

           
            //给输入框进行事件的绑定
            textBox1.TextChanged += TextBox_TotalPrice;
            textBox2.TextChanged += TextBox_TotalPrice;

            bt1.Click += Bt1_DClick;
            bt2.Click += Bt1_UClick;
            bt3.Click += Bt2_DClick;
            bt4.Click += Bt2_UClick;

            textBox1.Text = "0";
            textBox2.Text = "0";
        }
        private void ChangeTextBoxValue(TextBox textBox, int n)
        {
            int temp = int.Parse(textBox.Text) + n;
            if (temp < 0) temp = 0;
            textBox.Text = temp.ToString();
            TotalP();
        }

        private void Bt1_DClick(object sender, EventArgs e)
        {
            ChangeTextBoxValue(textBox1, -1);
        }

        private void Bt1_UClick(object sender, EventArgs e)
        {
            ChangeTextBoxValue(textBox1, 1);
        }

        private void Bt2_DClick(object sender, EventArgs e)
        {
            ChangeTextBoxValue(textBox2, -1);
        }

        private void Bt2_UClick(object sender, EventArgs e)
        {
            ChangeTextBoxValue(textBox2, 1);
        }


        private void TextBox_TotalPrice(object sender, EventArgs e)
        {
            TotalP();
        }

        private void TotalP()
        {
            //定义一个总和来收集总价
            int sum = 0;

            //然后进行遍历
            Lablist.ForEach(lab =>
            {
                //判断得到的数字
                if (string.IsNullOrEmpty(lab["count"].Text) || !Regex.IsMatch(lab["count"].Text, @"\d+")) {

                    lab["count"].Text = "0";
                    //MessageBox.Show("输入格式有误");
                    (lab["count"] as TextBox).SelectionStart = 1;
                }

                //得到单价
                int price = int.Parse(lab["price"].Text.ToString());
                //得到数量
                int count = int.Parse(lab["count"].Text.ToString());
                //进行计算
                sum += price * count;

            });
            //将结果赋值给lab3
            lab3.Text = sum.ToString();
        }
    }
}
