using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EXday03
{
    public partial class MouseMoveAndLeave : Form
    {
        public MouseMoveAndLeave()
        {
            InitializeComponent();
            initOpt();
        }
        
        private void initOpt()
        {
            //绑定事件
            label1.MouseEnter += Label1_MouseEnter;
            label1.MouseLeave += Label1_MouseLeave;
        }

        private void Label1_MouseEnter(object sender, EventArgs e)
        {
            //改字体颜色
            label1.ForeColor = Color.Purple;
            //修改字体类型
            label1.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Underline, GraphicsUnit.Point);
        }

        private void Label1_MouseLeave(object sender, EventArgs e)
        {
            //改字体颜色
            label1.ForeColor = Color.Blue;
            //修改字体类型
            label1.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point);

        }
    }
}
