using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EXday04
{
    public partial class GotListBox : Form
    {
        public GotListBox()
        {
            InitializeComponent();
            InitGotListBox();
        }

        //初始化数据
        private List<string> CobItems = new List<string>
        {
         "11112222333","22222","1111144444","222222444","22222","11111444","444444","444444","333333"
        };

        private void InitGotListBox()
        {
            //清空列表
            listBox1.Items.Clear();
            //将初始化的列表转为数组添加进去
            listBox1.Items.AddRange(CobItems.ToArray());

            textBox1.TextChanged += TextBox1_TextChanged;
            listBox1.SelectedIndexChanged += ListBox1_SelectedIndexChanged;
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            string input = textBox1.Text;
            // 如果输入为空，显示所有项
            if (string.IsNullOrEmpty(input))
            {
                listBox1.Items.Clear();
                listBox1.Items.AddRange(CobItems.ToArray());
            }
            else
            {
                // 找到包含输入框内容的数据存入list中
                List<string> reslist = CobItems.FindAll(item => item.Contains(input));
                // 存入列表框中
                listBox1.Items.Clear();
                listBox1.Items.AddRange(reslist.ToArray());
            }

            // 清空label显示（因为此时没有选中项）
            label1.Text = input;
        }
        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 当在ListBox中选择项时，将选中项的文本显示在label1上
            if (listBox1.SelectedItem != null)
            {
                string str = listBox1.SelectedItem.ToString();
                label1.Text = str;
            }
            else
            {
                label1.Text = "";
            }
        }
    }
}
