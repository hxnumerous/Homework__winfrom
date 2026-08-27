namespace EXday03
{
    partial class InitFocusOpen
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
            comboBox1 = new ComboBox();
            richTextBox1 = new RichTextBox();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "西瓜", "草莓", "香蕉", "苹果", "梨子" });
            comboBox1.Location = new Point(127, 109);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(208, 28);
            comboBox1.TabIndex = 0;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(389, 109);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(208, 131);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = "";
            // 
            // InitFocusOpen
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(richTextBox1);
            Controls.Add(comboBox1);
            Name = "InitFocusOpen";
            Text = "InitFocusOpen";
            ResumeLayout(false);
        }

        #endregion

        private ComboBox comboBox1;
        private RichTextBox richTextBox1;
    }
}