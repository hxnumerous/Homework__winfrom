using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EXday04
{
    public partial class ChangeSize : Form
    {
        public ChangeSize()
        {
            InitializeComponent();
            InitChangeSize();
        }

        private void InitChangeSize()
        {
            panel1.MouseEnter += Panel1_MouseEnter;
            panel1.MouseLeave += Panel1_MouseLeave;
        }

        private void Panel1_MouseLeave(object sender, EventArgs e)
        {
            (sender as Panel).Size = new Size(100, 100);
        }

        private void Panel1_MouseEnter(object sender, EventArgs e)
        {
            (sender as Panel).Size = new Size(200,200);
        }
    }
}
