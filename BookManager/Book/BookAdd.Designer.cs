namespace BookManager.Book
{
    partial class BookAdd
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
            userBook11 = new BookManager.Controls.UCBook("新增");
            SuspendLayout();
            // 
            // userBook11
            // 
            userBook11.Location = new Point(36, 12);
            userBook11.Name = "userBook11";
            userBook11.Size = new Size(922, 730);
            userBook11.TabIndex = 0;
            // 
            // BookAdd
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(802, 654);
            Controls.Add(userBook11);
            Name = "BookAdd";
            Text = "BookAdd";
            ResumeLayout(false);
        }

        #endregion

        private Controls.UCBook userBook11;
    }
}