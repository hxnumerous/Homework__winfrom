using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EXday03
{
    public partial class KeyEsc : Form
    {
        public KeyEsc()
        {
            InitializeComponent();
            initOpt();
        }
        private void initOpt()
        {
            textBox1.KeyUp += TextBox1_KeyUp;
        }

        private void TextBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                MessageBox.Show("你要关闭吗");
                this.Close();

            }
        }
    }
}
