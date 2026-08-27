using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EXday03
{
    public partial class KeyCtrl : Form
    {
        public KeyCtrl()
        {
            InitializeComponent();
            InitOpt();
        }
        private void InitOpt()
        {
            textBox1.KeyUp += TextBox1_KeyUp;

        }

        private void TextBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.S)
            {
                MessageBox.Show("你要保存吗");
                string txt =(sender as TextBox).Text;
                File.WriteAllText("./Save.txt",txt);
            }
              
            if(e.Control && e.KeyCode == Keys.C)
            {
                MessageBox.Show("你要复制吗");
                string txt = (sender as TextBox).Text;
                File.WriteAllText("./Copy.txt", txt);
            }

            if (e.Control && e.KeyCode == Keys.X)
            {
                MessageBox.Show("你要粘贴吗");
                string txt = File.ReadAllText("./Copy.txt");
                (sender as TextBox).Text = txt;
            }

        }
    }
}
