namespace EXday03
{
    partial class KeyMove
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            lab1 = new Label();
            lab2 = new Label();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Location = new Point(296, 219);
            panel1.Margin = new Padding(5, 5, 5, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(50, 50);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 14);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(197, 31);
            label1.TabIndex = 1;
            label1.Text = "小方块X轴坐标：";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 59);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(196, 31);
            label2.TabIndex = 1;
            label2.Text = "小方块Y轴坐标：";
            // 
            // lab1
            // 
            lab1.AutoSize = true;
            lab1.Location = new Point(202, 11);
            lab1.Margin = new Padding(5, 0, 5, 0);
            lab1.Name = "lab1";
            lab1.Size = new Size(0, 31);
            lab1.TabIndex = 2;
            // 
            // lab2
            // 
            lab2.AutoSize = true;
            lab2.Location = new Point(202, 59);
            lab2.Margin = new Padding(5, 0, 5, 0);
            lab2.Name = "lab2";
            lab2.Size = new Size(0, 31);
            lab2.TabIndex = 2;
            // 
            // KeyMove
            // 
            AutoScaleDimensions = new SizeF(14F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(900, 900);
            Controls.Add(lab2);
            Controls.Add(lab1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5, 5, 5, 5);
            Name = "KeyMove";
            Text = "KeyMove";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label lab1;
        private Label lab2;
    }
}