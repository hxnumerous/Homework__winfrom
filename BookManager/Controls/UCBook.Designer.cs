namespace BookManager.Controls
{
    partial class UCBook
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new AntdUI.Label();
            label2 = new AntdUI.Label();
            label3 = new AntdUI.Label();
            label4 = new AntdUI.Label();
            label5 = new AntdUI.Label();
            button1 = new AntdUI.Button();
            UCName = new AntdUI.Input();
            UCAuthor = new AntdUI.Input();
            UCLable = new AntdUI.Input();
            UCPrice = new AntdUI.InputNumber();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft YaHei UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label1.Location = new Point(247, 14);
            label1.Name = "label1";
            label1.Size = new Size(236, 94);
            label1.TabIndex = 0;
            label1.Text = "";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label2.Location = new Point(80, 129);
            label2.Name = "label2";
            label2.Size = new Size(89, 44);
            label2.TabIndex = 1;
            label2.Text = "图书名称：";
            // 
            // label3
            // 
            label3.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label3.Location = new Point(80, 207);
            label3.Name = "label3";
            label3.Size = new Size(89, 44);
            label3.TabIndex = 1;
            label3.Text = "图书作者：";
            // 
            // label4
            // 
            label4.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label4.Location = new Point(80, 291);
            label4.Name = "label4";
            label4.Size = new Size(89, 44);
            label4.TabIndex = 1;
            label4.Text = "图书价格：";
            // 
            // label5
            // 
            label5.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label5.Location = new Point(80, 367);
            label5.Name = "label5";
            label5.Size = new Size(89, 44);
            label5.TabIndex = 1;
            label5.Text = "图书标签：";
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft YaHei UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 134);
            button1.Location = new Point(257, 511);
            button1.Name = "button1";
            button1.Size = new Size(226, 61);
            button1.TabIndex = 2;
            button1.Click += button1_Click;
            // 
            // UCName
            // 
            UCName.ForeColor = Color.Black;
            UCName.Location = new Point(205, 114);
            UCName.Name = "UCName";
            UCName.PlaceholderColor = SystemColors.ActiveBorder;
            UCName.PlaceholderText = "请输入图片名称";
            UCName.Size = new Size(340, 66);
            UCName.TabIndex = 3;
            // 
            // UCAuthor
            // 
            UCAuthor.ForeColor = Color.Black;
            UCAuthor.Location = new Point(205, 198);
            UCAuthor.Name = "UCAuthor";
            UCAuthor.PlaceholderColor = SystemColors.ActiveBorder;
            UCAuthor.PlaceholderText = "请输入图书作者";
            UCAuthor.Size = new Size(340, 66);
            UCAuthor.TabIndex = 3;
            // 
            // UCLable
            // 
            UCLable.ForeColor = Color.Black;
            UCLable.Location = new Point(205, 367);
            UCLable.Multiline = true;
            UCLable.Name = "UCLable";
            UCLable.PlaceholderColor = SystemColors.ActiveBorder;
            UCLable.PlaceholderText = "请输入图书标签（一行一个）";
            UCLable.Size = new Size(340, 138);
            UCLable.TabIndex = 3;
            // 
            // UCPrice
            // 
            UCPrice.Location = new Point(205, 282);
            UCPrice.Name = "UCPrice";
            UCPrice.Size = new Size(340, 66);
            UCPrice.TabIndex = 4;
            UCPrice.Text = "0";
            // 
            // UCBook
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(UCPrice);
            Controls.Add(UCLable);
            Controls.Add(UCAuthor);
            Controls.Add(UCName);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UCBook";
            Size = new Size(738, 584);
            ResumeLayout(false);
        }

        #endregion

        private AntdUI.Label label1;
        private AntdUI.Label label2;
        private AntdUI.Label label3;
        private AntdUI.Label label4;
        private AntdUI.Label label5;
        private AntdUI.Button button1;
        private AntdUI.Input UCName;
        private AntdUI.Input UCAuthor;
        private AntdUI.Input UCLable;
        private AntdUI.InputNumber UCPrice;
    }
}
