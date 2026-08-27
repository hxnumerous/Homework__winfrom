using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EXday03
{
    public partial class InitFocusHieghtLigth : Form
    {
        public InitFocusHieghtLigth()
        {
            InitializeComponent();
            initOpt();
        }
        private void initOpt()
        {
            button1.GotFocus += Button1_GotFocus;
            button1.Leave += Button1_Leave;
            textBox1.GotFocus += TextBox1_GotFocus;
            textBox1.Leave += TextBox1_Leave;
        }

        private void TextBox1_GotFocus(object sender, EventArgs e)
        {
            (sender as TextBox).BackColor = Color.LightYellow;
            (sender as TextBox).ForeColor = Color.LightGreen;
            (sender as TextBox).BorderStyle = BorderStyle.Fixed3D;
        }

        private void TextBox1_Leave(object sender, EventArgs e)
        {
            (sender as TextBox).BackColor = Color.White;
            (sender as TextBox).ForeColor = Color.Black;
            (sender as TextBox).BorderStyle = BorderStyle.FixedSingle;

        }

        private void Button1_GotFocus(object sender, EventArgs e)
        {
            (sender as Button).BackColor = Color.LightYellow;
            (sender as Button).ForeColor = Color.LightGreen;
            
        }
        private void Button1_Leave(object sender, EventArgs e)
        {
            (sender as Button).BackColor = Color.White;
            (sender as Button).ForeColor = Color.Black;

        }

    }
}
