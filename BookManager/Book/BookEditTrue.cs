using AntdUI;
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
    public partial class BookEditTrue : Form
    {
        // 保存原始书籍数据
        private BookInfo _originalBook;
        // 保存书籍ID
        private string _bookId;
        
        public BookEditTrue()
        {
            InitializeComponent();
            ShowBook();
            // 绑定保存事件
            ucBook1.SaveData += SaveBook;
            // 设置按钮文字
            ucBook1.SetButtonText("保存修改");
        }
        public void ShowBook()
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

            //给表传入数据
            table1.DataSource = books;

            // 重置表头
            table1.Columns.Clear();
            table1.Columns = new AntdUI.ColumnCollection {
                new AntdUI.Column("Id", "编号")
                {
                    Render = (object val,object cel,int index ) =>index.ToString()
                },
                new AntdUI.Column("Name", "书名"),
                new AntdUI.Column("Author", "作者"),
                new AntdUI.Column("Price", "价格"),
                new AntdUI.Column("BookLabel", "标签"),
                new AntdUI.Column("IsBorrow", "是否借阅"){
                    // val 单元的值, cel: 行数据, index 行号
                    Render = (object val,object cel,int index) =>
                    {
                        return (bool)val?"未借阅":"已借阅";
                    }
                },
            };
            table1.Columns.Add(new AntdUI.Column("Handler", "操作")
            {
                Render = (object val, object cel, int index) => "编辑"
            });

            table1.CellClick += Table1_CellClick;
        }

        private void Table1_CellClick(object sender, TableClickEventArgs e)
        {
            BookInfo book = (e.Record as BookInfo);
            if (book == null) return;

            // 保存书籍ID
            _bookId = book.Id;
            _originalBook = book;


            ucBook1.SetBookData(book);
            ucBook1.SetButtonText("保存修改");

        }
        
        private void SaveBook(BookInfo book)
        {
            string JsonStr = "";
            List<BookInfo> books = new List<BookInfo>();

            string path = "./book.json";
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

            //  写入文件
            File.WriteAllText("./book.json", JsonStr);
            MessageBox.Show("修改图书成功!!");

            //  刷新表格
            ShowBook();


        }

    }
}
