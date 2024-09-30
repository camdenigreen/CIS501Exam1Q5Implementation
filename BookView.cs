using System;
using System.Windows.Forms;

namespace CIS501Exam1Q5Implementation
{
    public partial class BookView : Form
    {
        private Book _book;
        private ChangeBookDel _changeBook;

        public BookView(Book book, ChangeBookDel changeBook)
        {
            InitializeComponent();
            _book = book;
            _changeBook = changeBook;
            UpdateView();
        }

        private void TurnPageRight()
        {
            _changeBook(_book, BookAction.IncrementPage, 0u);
        }

        private void TurnPageLeft()
        {
            _changeBook(_book, BookAction.DecrementPage, 0u);
        }

        private void GoToPage(uint i)
        {
            _changeBook(_book, BookAction.GoToPage, i);
        }

        private void AddRemoveBookmark(uint i)
        {
            _changeBook(_book, BookAction.AddRemoveBookmark, i);
        }

        public void UpdateView()
        {
            bookmarkedCheckbox.Checked = _book.Bookmarks.Contains(_book.CurrentPageIndex);
            bookContentTextBox.Text = _book.CurrentPage;
            goToPageTextbox.Text = _book.CurrentPageIndex.ToString();
        }

        private void bookmarkedCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            AddRemoveBookmark(_book.CurrentPageIndex);
        }

        private void previousPageButton_Click(object sender, EventArgs e)
        {
            TurnPageLeft();
        }

        private void nextPageButton_Click(object sender, EventArgs e)
        {
            TurnPageRight();
        }

        private void goToPageButton_Click(object sender, EventArgs e)
        {
            try
            {
                GoToPage(UInt32.Parse(goToPageTextbox.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
