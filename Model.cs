using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIS501Exam1Q5Implementation
{
    public class Model
    {
        public Dictionary<(string, string), Book> Books {get; set;}
        public bool OpenButtonEnabled = true;
        public Model(List<Book> bookList)
        {
            Books = new Dictionary<(string, string), Book>();

            foreach (Book book in bookList)
            {
                Books.Add((book.Title, book.Author), book);
            }
        }

        public void AddBook((string, string) key, Book newBook)
        {
            Books.Add(key, newBook);
        }

        public Book GetBook((string, string) key)
        {
            return Books[key];
        }
    }
}