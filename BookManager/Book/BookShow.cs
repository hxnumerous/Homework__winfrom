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
    public partial class BookShow : Form
    {
        public BookShow()
        {
            InitializeComponent();
            ShowBook();
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
                Render = (object val, object cel, int index) => "删除"
            });
            table1.Columns.Add(new AntdUI.Column("Handler2", "操作")
            {
                Render = (object val, object cel, int index) => "编辑"
            });

            //绑定事件
            table1.CellClick += Table1_CellClick;

        }
        //为点击添加函数
        private void Table1_CellClick(object sender, TableClickEventArgs e)
        {
            BookInfo book = (e.Record as BookInfo);
            //MessageBox.Show(e.ColumnIndex.ToString());
            if (e.ColumnIndex.ToString() == "6")
            {
                // 删除
                BookDel DelForm = new BookDel(book);

                if (DelForm.ShowDialog() == DialogResult.OK)
                {
                    ShowBook(); // 刷新数据
                }
                return;
            }
            if (e.ColumnIndex.ToString() == "7")
            {
                BookEdit editForm = new BookEdit(book.Id);
                
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    ShowBook(); // 刷新数据
                }
                return;
            }
        }
    }
}
