using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public class Book
        {
            public string Title { get; set; }

            public string Author { get; set; }

            public virtual string GetInfo()
            {
                return $"{Title} by {Author}";
            }
        }

        public class Magazine: Book
        {
            public int IssueNumber { get; set; }

            public override string GetInfo()
            {
                return $"{Title} - Issue {IssueNumber}";
            }
        }


        public class Ebook: Book
        {
            public double FileSizeMB { get; set; }

            public override string GetInfo()
            {
                return $"{Title} (Ebook) - {FileSizeMB}MB";
            }
        }


        private void DisplayBooks(Book[] books)
        {
            listBoxBooks2.Items.Clear();

            foreach (Book book in books)
            {
                listBoxBooks2.Items.Add(book.GetInfo());
            }
        }


        private void btnShowInfo_Click(object sender, EventArgs E)
        {
            Book[] books =
            {
                new Book {Title = "C# Basics", Author = "Alice"},
                new Magazine {Title = "Tech Weekly", IssueNumber = 45},
                new Ebook {Title = "OOP Guide", FileSizeMB = 3.8}

            };

            DisplayBooks(books);
        }
    }
}
