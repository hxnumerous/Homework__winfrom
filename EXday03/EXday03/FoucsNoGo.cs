using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EXday03
{
    public partial class FoucsNoGo : Form
    {
        public FoucsNoGo()
        {
            InitializeComponent();
            initOpt();
        }

        private void initOpt()
        {
            textBox1.Leave += TextBox_FoucsNoGo;
        }

        public void TextBox_FoucsNoGo(object sender, EventArgs e)
        {
            string tb = textBox1.Text;
            if (string.IsNullOrEmpty(tb))
            {
                textBox1.Focus();
                label1.Visible = true;
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string tb = textBox1.Text;
            if (!string.IsNullOrEmpty(tb))
            {
                label1.Visible = false;
            }
        }
    }
}
