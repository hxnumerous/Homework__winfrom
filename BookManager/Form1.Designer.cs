namespace BookManager
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new AntdUI.Button();
            button2 = new AntdUI.Button();
            button3 = new AntdUI.Button();
            label1 = new AntdUI.Label();
            button4 = new AntdUI.Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 134);
            button1.Location = new Point(67, 171);
            button1.Name = "button1";
            button1.Size = new Size(175, 85);
            button1.TabIndex = 0;
            button1.Text = "新增图书";
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 134);
            button2.Location = new Point(393, 171);
            button2.Name = "button2";
            button2.Size = new Size(175, 85);
            button2.TabIndex = 0;
            button2.Text = "编辑图书";
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 134);
            button3.Location = new Point(699, 171);
            button3.Name = "button3";
            button3.Size = new Size(175, 85);
            button3.TabIndex = 0;
            button3.Text = "查看图书";
            button3.Click += button3_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft YaHei UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label1.Location = new Point(329, 26);
            label1.Name = "label1";
            label1.Size = new Size(311, 111);
            label1.TabIndex = 1;
            label1.Text = "图书管理系统";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button4
            // 
            button4.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 134);
            button4.Location = new Point(393, 339);
            button4.Name = "button4";
            button4.Size = new Size(175, 85);
            button4.TabIndex = 2;
            button4.Text = "删除图书";
            button4.Click += button4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(996, 593);
            Controls.Add(button4);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private AntdUI.Button button1;
        private AntdUI.Button button2;
        private AntdUI.Button button3;
        private AntdUI.Label label1;
        private AntdUI.Button button4;
    }
}
