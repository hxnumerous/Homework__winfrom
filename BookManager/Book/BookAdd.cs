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
    public partial class BookAdd : Form
    {
        public BookAdd()
        {
            InitializeComponent();


            // 为接受数据方法进行绑定事件
            userBook11.SendData += AddBook;
        }

        private void AddBook(BookInfo book)
        {
            //创建一个List来存储信息
            List<BookInfo> books = new List<BookInfo>();
            //创建一个字符串来存储序列化或反序列化后的字符串
            string JsonStr = "";

            //读取文件，然后进行反序列化
            JsonStr = File.ReadAllText("./book.json");
            books = JsonSerializer.Deserialize<List<BookInfo>>(JsonStr);

            if (books.Exists(item => item.Name == book.Name))
            {
                MessageBox.Show("该书籍已存在，请勿重复添加");
                return;
            }
            //添加到列表中
            books.Add(book);

            //进行序列化
            JsonStr = JsonSerializer.Serialize(books, new JsonSerializerOptions()
            {
                WriteIndented = true,
                AllowTrailingCommas = true,
                Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping
            });
           
            //写入文件
            File.WriteAllText("./book.json", JsonStr);
            //为成功添加提示框
            MessageBox.Show("新增图书成功!!");
            //关闭窗口
            this.Close();
        }
    }
}
