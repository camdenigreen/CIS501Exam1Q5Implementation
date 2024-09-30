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
    public class Controller
    {
        private Model model;
        private List<UpdateViewDel> updateViewDelList = new List<UpdateViewDel>();

        public Controller (Model model)
        {
            this.model = model;
        }

        public void AddUpdateViewDel(UpdateViewDel del)
        {
            updateViewDelList.Add(del);
        }

        public void GoToPage(Book book, uint page)
        {
            if (page > book.Pages.Count) return;

            book.CurrentPageIndex = page;
            UpdateViews();
        }

        public void OpenBook(Book book)
        {
            model.OpenButtonEnabled = false;
            UpdateViews();
            BookView bookView = new BookView(book, ChangePage);
            UpdateViews();
            updateViewDelList.Add(bookView.UpdateView);
            bookView.ShowDialog();
            updateViewDelList.Remove(bookView.UpdateView);
            model.OpenButtonEnabled = true;
            UpdateViews();
        }

        public void AddRemoveBookmark(Book book, uint page)
        {
            if (page > book.Pages.Count || book.Bookmarks.Count >= 5) return;

            if (book.Bookmarks.Contains(page))
            {
                book.Bookmarks.Remove(page);
            }
            else
            {
                book.Bookmarks.Add(page);
            }
        }

        public void ChangePage(Book book, BookAction action, uint page)
        {
            switch(action)
            {
                case BookAction.IncrementPage:
                    if (book.CurrentPageIndex >= book.Pages.Count-1) break;
                    book.CurrentPageIndex++;
                    break;
                case BookAction.DecrementPage:
                    if (book.CurrentPageIndex <= 0) break;
                        book.CurrentPageIndex--;
                    break;
                case BookAction.GoToPage:
                    if (page >= book.Pages.Count-1) break;
                    book.CurrentPageIndex = page;
                    break;
                case BookAction.AddRemoveBookmark:
                    AddRemoveBookmark(book, book.CurrentPageIndex);
                    break;
            }
            UpdateViews();
        }

        public void UpdateViews()
        {
            foreach (UpdateViewDel u in updateViewDelList)
            {
                u();
            }
        }

        public void SyncBooks()
        {
            int bookCount = model.Books.Count;

            model.Books.Add(($"{bookCount}", "Gavin Kellam"),
                new Book(new List<string>()
            {
                $"Test Book {bookCount}",
                "Second Pages",
                "Next Page after that!!!"
            }, "Gavin's Favorite Book", "Gavin Kellam"));
            UpdateViews();
        }
    }
}