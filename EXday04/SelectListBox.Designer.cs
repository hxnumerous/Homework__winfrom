namespace EXday04
{
    partial class SelectListBox
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
            listBox1 = new ListBox();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(164, 141);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(245, 164);
            listBox1.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(164, 97);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(245, 27);
            textBox1.TabIndex = 1;
            // 
            // SelectListBox
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(listBox1);
            Name = "SelectListBox";
            Text = "SelectListBox";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private TextBox textBox1;
    }
}