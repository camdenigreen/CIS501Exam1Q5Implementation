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
    public class Book
    {
        public string Title { get; }
        public string Author { get; }
        public List<uint> Bookmarks { get; set; } = new List<uint>();
        public List<string> Pages { get; }
        public uint CurrentPageIndex { get; set; } = 0u;
        public string CurrentPage => Pages[(int)CurrentPageIndex];

        public Book(List<string> contents, string title, string author)
        {
            Pages = contents;
            Title = title;
            Author = author;
        }

        public override string ToString()
        {
            return $"{Title} By {Author}";
        }
    }
}