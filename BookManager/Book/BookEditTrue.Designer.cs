namespace BookManager.Book
{
    partial class BookEditTrue
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
            ucBook1 = new BookManager.Controls.UCBook();
            table1 = new AntdUI.Table();
            SuspendLayout();
            // 
            // ucBook1
            // 
            ucBook1.Location = new Point(-30, -4);
            ucBook1.Name = "ucBook1";
            ucBook1.Size = new Size(614, 730);
            ucBook1.TabIndex = 0;
            // 
            // table1
            // 
            table1.Gap = 12;
            table1.Location = new Point(553, 37);
            table1.Name = "table1";
            table1.Size = new Size(583, 477);
            table1.TabIndex = 1;
            table1.Text = "table1";
            // 
            // BookEditTrue
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1148, 630);
            Controls.Add(table1);
            Controls.Add(ucBook1);
            Name = "BookEditTrue";
            Text = "BookEditTrue";
            ResumeLayout(false);
        }

        #endregion

        private Controls.UCBook ucBook1;
        private AntdUI.Table table1;
    }
}