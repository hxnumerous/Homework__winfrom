using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EXday03
{
    public partial class KeyEnter : Form
    {
        public KeyEnter()
        {
            InitializeComponent();
            initOpt();
        }
        private void initOpt()
        {
            textBox1.KeyDown += TextBox1_KeyDown;
        }

        private void TextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            string txt =(sender as TextBox).Text;
            
            if(!string.IsNullOrEmpty(txt))
            {
                if(e.KeyCode == Keys.Enter)
                {
                    MessageBox.Show("你要提交吗？");
                }
            }
            


        }
    }
}
