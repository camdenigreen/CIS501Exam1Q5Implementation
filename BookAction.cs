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
    public delegate void ChangeBookDel(Book book, BookAction action, uint page);
    public delegate void UpdateViewDel();
    public delegate void ViewBookDel(Book book);
    public delegate void SyncLibrary();

    public enum BookAction
    {
        IncrementPage,
        DecrementPage,
        AddRemoveBookmark,
        GoToPage,
        SyncBooks
    }
}