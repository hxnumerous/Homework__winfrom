using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BookManager.Controls
{
    public partial class UCBook : UserControl
    {
        private string _mode = "新增";  // 记录模式

        public UCBook()
        {
            InitializeComponent();
        }

        //重写方法，为标题填写信息
        public UCBook(string text)
        {
            InitializeComponent();
            _mode = text;
            button1.Text = text;
            label1.Text = text + "图书";
        }

        //添加传递信息的text  声明委托事件
        internal event Action<BookInfo> SendData;
        internal event Action<BookInfo> SaveData;

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(UCName.Text))
            {
                MessageBox.Show("请输入图书名称");
                return;
            }
            if (string.IsNullOrWhiteSpace(UCAuthor.Text))
            {
                MessageBox.Show("请输入图书作者");
                return;
            }
            if (!double.TryParse(UCPrice.Text, out double price) || price <= 0)
            {
                MessageBox.Show("请输入有效的图书价格");
                return;
            }

            if (_mode == "编辑" || button1.Text == "保存修改")
            {
                // 编辑模式 - 触发SaveData事件
                SaveData?.Invoke(new BookInfo()
                {
                    Id = "",  // ID由外部设置
                    Name = UCName.Text.Trim(),
                    Author = UCAuthor.Text.Trim(),
                    Price = price,
                    BookLabel = UCLable.Text.Trim(),
                    IsBorrow = true,
                });
            }
            else
            {
                // 新增模式 - 触发SendData事件
                SendData?.Invoke(new BookInfo()
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = UCName.Text.Trim(),
                    Author = UCAuthor.Text.Trim(),
                    Price = price,
                    BookLabel = UCLable.Text.Trim(),
                    IsBorrow = true,
                });
            }
        }

        internal void SetBookData(BookInfo book)
        {
            if (book == null) return;

            UCName.Text = book.Name;
            UCAuthor.Text = book.Author;
            UCPrice.Text = book.Price.ToString();
            UCLable.Text = book.BookLabel;
        }

        // 设置按钮文字
        internal void SetButtonText(string text)
        {
            button1.Text = text;
            if (text == "保存修改")
            {
                _mode = "编辑";
            }
        }

        // 获取用户输入
        public BookInfo GetBookData(BookInfo book)
        {
            double price = 0;
            double.TryParse(UCPrice.Text, out price);
            return new BookInfo()
            {
                Id = book?.Id ?? "",  // 保留原ID
                Name = UCName.Text.Trim(),
                Author = UCAuthor.Text.Trim(),
                Price = price,
                BookLabel = UCLable.Text.Trim(),
                IsBorrow = true,
            };
        }
    }
}
