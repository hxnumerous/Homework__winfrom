namespace EXday04
{
    partial class GotListBox
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
            label1 = new Label();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(117, 177);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(310, 252);
            listBox1.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(117, 105);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(310, 38);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(118, 65);
            label1.Name = "label1";
            label1.Size = new Size(0, 31);
            label1.TabIndex = 2;
            // 
            // GotListBox
            // 
            AutoScaleDimensions = new SizeF(14F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(995, 599);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(listBox1);
            Name = "GotListBox";
            Text = "GotListBox";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private TextBox textBox1;
        private Label label1;
    }
}