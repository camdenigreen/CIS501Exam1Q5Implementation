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
    public partial class MainView : Form
    {
        private Model _model;
        private ViewBookDel viewBookDel;
        private SyncLibrary syncLibrary;

        public MainView(Model model)
        {
            _model = model;
            InitializeComponent();
        }

        public void AddDelegates(ViewBookDel viewBookDel, SyncLibrary syncLibrary)
        {
            this.viewBookDel = viewBookDel;
            this.syncLibrary = syncLibrary;
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            if (bookListBox.SelectedItem != null)
            {
                viewBookDel((Book)bookListBox.SelectedItem);
            }
        }

        private void syncButton_Click(object sender, EventArgs e)
        {
            syncLibrary();
        }

        public void UpdateBooks()
        {
            bookListBox.Items.Clear();
            foreach (Book book in _model.Books.Values)
            {
                bookListBox.Items.Add(book);
            }
            openButton.Enabled = _model.OpenButtonEnabled;
        }
    }
}
