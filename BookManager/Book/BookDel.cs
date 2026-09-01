using AntdUI;
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
    public partial class BookDel : Form
    {

        private BookInfo _originalBook;
        // 保存书籍ID
        private string _bookId;

        public BookDel()
        {
            InitializeComponent();
            ShowBooksData();
        }
        public BookDel(BookInfo book)
        {
            InitializeComponent();
            _originalBook = book;
            _bookId = book.Id;
            ShowBookData(book);

        }
        private void ShowBookData(BookInfo book)
        {
            if (book == null)
            {
                MessageBox.Show("书籍数据为空");
                return;
            }

            // 创建包含单个书籍的列表
            List<BookInfo> books = new List<BookInfo> { book };

            // 给表传入数据
            table1.DataSource = books;

            // 重置表头
            table1.Columns.Clear();
            table1.Columns = new AntdUI.ColumnCollection {
                new AntdUI.Column("Id", "编号")
                {
                    Render = (object val, object cel, int index) => index.ToString()
                },
                new AntdUI.Column("Name", "书名"),
                new AntdUI.Column("Author", "作者"),
                new AntdUI.Column("Price", "价格"),
                new AntdUI.Column("BookLabel", "标签"),
                new AntdUI.Column("IsBorrow", "是否借阅"){
                    Render = (object val, object cel, int index) =>
                    {
                        return (bool)val ? "未借阅" : "已借阅";
                    }
                },
            };

            // 添加删除按钮列
            table1.Columns.Add(new AntdUI.Column("Handler", "操作")
            {
                Render = (object val, object cel, int index) => "确认删除"
            });


            // 绑定事件
            table1.CellClick += Table1_CellClick;
        }

        private void Table1_CellClick(object sender, TableClickEventArgs e)
        {
            if (string.IsNullOrEmpty(_bookId))
            {
                MessageBox.Show("未找到要删除的书籍");
                return;
            }

            string JsonStr = "";
            List<BookInfo> books = new List<BookInfo>();

            if (!File.Exists("./book.json"))
            {
                MessageBox.Show("文件不存在！！！");
                return;
            }

            JsonStr = File.ReadAllText("./book.json");
            books = JsonSerializer.Deserialize<List<BookInfo>>(JsonStr);

            // 找到要删除的书籍
            int index = books.FindIndex(item => item.Id == _bookId);
            if (index == -1)
            {
                MessageBox.Show("未找到要删除的书籍");
                return;
            }

            // 从列表中移除
            books.RemoveAt(index);

            // 序列化并写入文件
            JsonStr = JsonSerializer.Serialize(books, new JsonSerializerOptions()
            {
                WriteIndented = true,
                AllowTrailingCommas = true,
                Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping
            });

            File.WriteAllText("./book.json", JsonStr);
            MessageBox.Show("删除图书成功!!");

            // 关闭当前窗口
            this.Close();
        }

        private void ShowBooksData()
        {
            //创建一个字符串来存储序列化或反序列化后的字符串
            string JsonStr = "";
            //创建一个List来存储信息
            List<BookInfo> books = new List<BookInfo>();
            //依旧判断文件是否存在
            if (!File.Exists("./book.json"))
            {
                MessageBox.Show("文件不存在！！！");
                return;
            }
            //存在  读取文件
            JsonStr = File.ReadAllText("./book.json");
            //反序列化
            books = JsonSerializer.Deserialize<List<BookInfo>>(JsonStr);

            if (books == null)
            {
                MessageBox.Show("书籍数据为空");
                return;
            }

            // 给表传入数据
            table1.DataSource = books;

            // 重置表头
            table1.Columns.Clear();
            table1.Columns = new AntdUI.ColumnCollection {
                new AntdUI.Column("Id", "编号")
                {
                    Render = (object val, object cel, int index) => index.ToString()
                },
                new AntdUI.Column("Name", "书名"),
                new AntdUI.Column("Author", "作者"),
                new AntdUI.Column("Price", "价格"),
                new AntdUI.Column("BookLabel", "标签"),
                new AntdUI.Column("IsBorrow", "是否借阅"){
                    Render = (object val, object cel, int index) =>
                    {
                        return (bool)val ? "未借阅" : "已借阅";
                    }
                },
            };

            // 添加删除按钮列
            table1.Columns.Add(new AntdUI.Column("Handler", "操作")
            {
                Render = (object val, object cel, int index) => "删除"
            });

            // 绑定事件
            table1.CellClick += Table_CellClick;
        }
        private void Table_CellClick(object sender, TableClickEventArgs e)
        {
            // 获取选中的书籍
            BookInfo book = e.Record as BookInfo;

            string bookId = book.Id;
           
            if (string.IsNullOrEmpty(bookId))
            {
                MessageBox.Show("未找到要删除的书籍");
                return;
            }

            string JsonStr = "";
            List<BookInfo> books = new List<BookInfo>();

            if (!File.Exists("./book.json"))
            {
                MessageBox.Show("文件不存在！！！");
                return;
            }

            JsonStr = File.ReadAllText("./book.json");
            books = JsonSerializer.Deserialize<List<BookInfo>>(JsonStr);

            // 找到要删除的书籍
            int index = books.FindIndex(item => item.Id == bookId);
            if (index == -1)
            {
                MessageBox.Show("未找到要删除的书籍");
                return;
            }

            // 从列表中移除
            books.RemoveAt(index);

            // 序列化并写入文件
            JsonStr = JsonSerializer.Serialize(books, new JsonSerializerOptions()
            {
                WriteIndented = true,
                AllowTrailingCommas = true,
                Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping
            });

            File.WriteAllText("./book.json", JsonStr);
            MessageBox.Show("删除图书成功!!");

            // 关闭当前窗口
            this.Close();

        }
    }
}
