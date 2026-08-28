using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EXday04
{
    public partial class SelectListBox : Form
    {
        public SelectListBox()
        {
            InitializeComponent();
            InitSelect();
        }

        //初始化数据
        private List<string> CobItems = new List<string>
        {
         "11112222333","22222","1111144444","222222444","22222","11111444","444444","444444","333333"
        };

        private void InitSelect()
        {
            textBox1.KeyPress += TextBox1_KeyPress;
            //清空列表
            listBox1.Items.Clear();
            //将初始化的列表转为数组添加进去
            listBox1.Items.AddRange(CobItems.ToArray());
        }

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
           //获取输入框内容
           string Input = textBox1.Text;
            ////判断列表内容是否包含输入框内容
            //if (!listBox1.Items.Contains(Input))
            //{
            //    MessageBox.Show("输入内容在列表中不存在");
            //}
            //else
            //{
            //    //找到初始化的列表内容，获取包含输入框内容的数据存入list中
            //    List<string> reslist = CobItems.FindAll(item => item.Contains(Input));
            //    //存入列表框中
            //    listBox1.Items.Clear();
            //    listBox1.Items.AddRange(reslist.ToArray());
            //}

            //找到初始化的列表内容，获取包含输入框内容的数据存入list中
            List<string> reslist = CobItems.FindAll(item => item.Contains(Input));
            //存入列表框中
            listBox1.Items.Clear();
            listBox1.Items.AddRange(reslist.ToArray());
        }


    }
}
