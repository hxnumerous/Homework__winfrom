namespace EXday03
{
    partial class CursorLocation
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
            label1 = new Label();
            label2 = new Label();
            lab1 = new Label();
            lab2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 22);
            label1.Name = "label1";
            label1.Size = new Size(152, 20);
            label1.TabIndex = 0;
            label1.Text = "光标所在的x轴位置：";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 62);
            label2.Name = "label2";
            label2.Size = new Size(152, 20);
            label2.TabIndex = 0;
            label2.Text = "光标所在的y轴位置：";
            // 
            // lab1
            // 
            lab1.AutoSize = true;
            lab1.Location = new Point(179, 21);
            lab1.Name = "lab1";
            lab1.Size = new Size(0, 20);
            lab1.TabIndex = 1;
            // 
            // lab2
            // 
            lab2.AutoSize = true;
            lab2.Location = new Point(179, 62);
            lab2.Name = "lab2";
            lab2.Size = new Size(0, 20);
            lab2.TabIndex = 1;
            // 
            // CursorLocation
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lab2);
            Controls.Add(lab1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CursorLocation";
            Text = "CursorLocation";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label lab1;
        private Label lab2;
    }
}