using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EXday03
{
    public partial class InitFocusOpen : Form
    {
        public InitFocusOpen()
        {
            InitializeComponent();
            initOpt();
        }
        private void initOpt()
        {
            comboBox1.GotFocus += ComboBox1_GotFocus;
            comboBox1.Leave += ComboBox1_Leave;
        }

        private void ComboBox1_Leave(object sender, EventArgs e)
        {
            (sender as ComboBox).DropDownStyle = ComboBoxStyle.DropDown;
        }

        private void ComboBox1_GotFocus(object sender, EventArgs e)
        {
            (sender as ComboBox).DropDownStyle = ComboBoxStyle.Simple;
        }
    }
}
