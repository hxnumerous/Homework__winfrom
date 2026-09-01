using BookManager.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;

namespace BookManager.Book
{
    public partial class BookEdit : Form
    {
        // 保存原始书籍数据
        private BookInfo _originalBook;
        // 保存书籍ID
        private string _bookId;    
        
        public BookEdit()
        {
            InitializeComponent();
        }
        public BookEdit(string Id)
        {
            InitializeComponent();
            _bookId = Id;
            LoadBookData(Id);

            // 绑定保存事件
            ucBook1.SaveData += SaveBook;
        }
         private void LoadBookData(string Id)
        {
            string JsonStr = "";
            List<BookInfo> books = new List<BookInfo>();

            if (!File.Exists("./book.json"))
            {
                MessageBox.Show("文件不存在！！！");
                return;
            }

            JsonStr = File.ReadAllText("./book.json");
            books = JsonSerializer.Deserialize<List<BookInfo>>(JsonStr);

            _originalBook = books.Find(item => item.Id == Id);

            if (_originalBook == null)
            {
                MessageBox.Show("未找到书籍，请先添加");
                return;
            }

            // 显示在界面中
            ucBook1.SetBookData(_originalBook);
            // 设置按钮文字为"保存修改"
            ucBook1.SetButtonText("保存修改");
        }
        private void SaveBook(BookInfo book)
        {
            string JsonStr = "";
            List<BookInfo> books = new List<BookInfo>();

            if (!File.Exists("./book.json"))
            {
                MessageBox.Show("文件不存在！！！");
                return;
            }

            JsonStr = File.ReadAllText("./book.json");
            books = JsonSerializer.Deserialize<List<BookInfo>>(JsonStr);

            // 找到要修改的书籍并替换
            int index = books.FindIndex(item => item.Id == _bookId);
            if (index == -1)
            {
                MessageBox.Show("未找到要修改的书籍");
                return;
            }

            // 保留原ID，更新其他信息
            book.Id = _bookId;
            books[index] = book;

            // 序列化并写入文件
            JsonStr = JsonSerializer.Serialize(books, new JsonSerializerOptions()
            {
                WriteIndented = true,
                AllowTrailingCommas = true,
                Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping
            });

            File.WriteAllText("./book.json", JsonStr);
            MessageBox.Show("修改图书成功!!");
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

    }
}
