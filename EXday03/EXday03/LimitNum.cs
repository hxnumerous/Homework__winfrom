using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EXday03
{
    public partial class LimitNum : Form
    {
        public LimitNum()
        {
            InitializeComponent();
            InitOpt();
        }
        private void InitOpt()
        {
            textBox1.KeyPress += TextBox1_KeyPress;

        }

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar < '0' || e.KeyChar > '9')
            {
                e.Handled = true;
            }
            

        }
    }
}
