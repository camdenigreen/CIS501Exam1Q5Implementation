using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIS501Exam1Q5Implementation
{
    internal static class Program
    {
        const int WordsPerPage = 100;

        public static List<string> ReadFileIntoList(string path)
        {
            string fileContent = File.ReadAllText(path);
            List<string> fileLine = new List<string>();
            List<string> words = fileContent.Split(' ').ToList();

            for (int i = 0; i < words.Count / WordsPerPage; i++)
            {
                StringBuilder page = new StringBuilder();

                for (int e = 0; e < WordsPerPage; e++)
                {
                    page.Append(words[i * WordsPerPage + e] + " ");
                }

                fileLine.Add(page.ToString());
            }

            return fileLine;
        }

        public static List<Book> ConstructBookDatabase()
        {
            List<Book> bookList = new List<Book>();

            bookList.Add(new Book(ReadFileIntoList("../Shrek.txt"), "Shreak Movie", "idk"));
            bookList.Add(new Book(ReadFileIntoList("../Bee.txt"), "Bee Movie", "idk"));

            return bookList;
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Model mainModel = new Model(ConstructBookDatabase());
            MainView mainView = new MainView(mainModel);
            Controller controller = new Controller(mainModel);
            controller.AddUpdateViewDel(mainView.UpdateBooks);
            mainView.AddDelegates(controller.OpenBook, controller.SyncBooks);

            Application.Run(mainView);
        }
    }
}
