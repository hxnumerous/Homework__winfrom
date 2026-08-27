using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace EXday03
{
    public partial class TextBoxGotFocus : Form
    {
        public TextBoxGotFocus()
        {
            InitializeComponent();
            initOpt();
        }
        private void initOpt()
        {
            textBox1.Leave += TextBoxGotFocus_Leave;
        }

        private string reg = @"^1[356789]\d{9}$";
        private void TextBoxGotFocus_Leave(object sender, EventArgs e)
        {
            string txt = (sender as TextBox).Text;

             if (Regex.IsMatch(txt, reg))
            {
                label1.Visible = true;
                label2.Visible = false;
            }
            else
            {
                label2.Visible = true;
                label1.Visible = false;
            }
        }

       
        
    }
}
