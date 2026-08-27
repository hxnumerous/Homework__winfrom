using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EXday03
{
    public partial class KeyMove : Form
    {
        public KeyMove()
        {
            InitializeComponent();
            InitOpt();
            GetLocation();
        }
        private void InitOpt()
        {
            this.KeyDown += KeyMove_KeyDown;

            // 获取控件的尺寸
            //MessageBox.Show(this.Width.ToString());
            //MessageBox.Show(this.Height.ToString());
            //MessageBox.Show(panel1.Width.ToString());
            //MessageBox.Show(panel1.Height.ToString());
        }
        int speed = 5;
        private void KeyMove_KeyDown(object sender, KeyEventArgs e)
        {
            Point b1 = panel1.Location;
            bool res = b1.Y >=0 && b1.Y <= this.Height - 50 && b1.X >=0 && b1.X <= this.Width - 50;
            if (res) { 
            switch (e.KeyCode)
            {
                case Keys.W:
                   //b1.Y -= speed;
                   //b1.Y= b1.Y < 0 ? 0 : b1.Y;
                    b1.Y = (b1.Y - speed) < 0 ? 0 : (b1.Y - speed);
                    break;
                case Keys.S:
                    b1.Y = (b1.Y + speed) > this.Height - 50 ? this.Height - 50 : (b1.Y + speed);
                    break;
                case Keys.A:
                    b1.X = (b1.X - speed) < 0 ? 0 :(b1.X - speed);
                    break;
                case Keys.D:
                    b1.X = (b1.X + speed) > this.Width - 50 ? this.Width - 50 : (b1.X + speed);
                    break;
                default:
                    break;
            }
            panel1.Location = b1;
            GetLocation();
            }

            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
       
        private void GetLocation()
        {
            Point b1 = panel1.Location;
            lab1.Text = b1.X.ToString();
            lab2.Text = b1.Y.ToString();


        }
    }
}
