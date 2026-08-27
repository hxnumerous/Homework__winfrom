using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EXday03
{
    public partial class KeyTime : Form
    {
        public KeyTime()
        {
            InitializeComponent();
            InitOpt();
        }
        private void InitOpt()
        {
            textBox1.KeyDown += TextBox1_KeyDown;
            textBox1.KeyUp += TextBox1_KeyUp;
        }
        private DateTime keyDownTime;
        private void TextBox1_KeyUp(object sender, KeyEventArgs e)
        {
            TimeSpan d = DateTime.Now - keyDownTime;
            MessageBox.Show(d.ToString());
        }

        private void TextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            keyDownTime = DateTime.Now;
        }
    }
}
