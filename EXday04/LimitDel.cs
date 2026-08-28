using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EXday04
{
    public partial class LimitDel : Form
    {
        public LimitDel()
        {
            InitializeComponent();
            InitLimitDel();
        }
        private void InitLimitDel()
        {
            textBox1.KeyDown += TextBox1_KeyDown;
            textBox1.KeyPress += TextBox1_KeyPress;
        }

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)8)
            {
                e.Handled = true;
            }
        }

        private void TextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete || e.KeyCode == Keys.Back || e.Control && e.KeyCode == Keys.X)
            {
                e.SuppressKeyPress = true;
            }
           
        }
        


    }
}
