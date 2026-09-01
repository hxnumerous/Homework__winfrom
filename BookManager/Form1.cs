namespace BookManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Book.BookAdd().Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Book.BookEditTrue().Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Book.BookShow().Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new Book.BookDel().Show();
        }
    }
}
