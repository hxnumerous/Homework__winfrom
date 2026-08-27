using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EXday03
{
    public partial class CursorLocation : Form
    {
        public CursorLocation()
        {
            InitializeComponent();
            initOpt();
        }
        private void initOpt()
        {
            //绑定事件
            this.MouseMove += CursorLocation_MouseMove;

        }

        private void CursorLocation_MouseMove(object sender, MouseEventArgs e)
        {
            lab1.Text = e.X.ToString();
            lab2.Text = e.Y.ToString();
        }
    }
}
