using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using testadopse.InformatiCS_LibraryDataSetTableAdapters;

namespace testadopse
{
    class Database
    {
        private string article = null;
        private History_keep_LemmaTableAdapter history_Keep_LemmaTableAdapter = new History_keep_LemmaTableAdapter();
        private Lemma_MediaTableAdapter lemma_MediaTableAdapter = new Lemma_MediaTableAdapter();
        private BookmarkTableAdapter bookmarkTableAdapter = new BookmarkTableAdapter();
        private CategoryTableAdapter categoryTableAdapter = new CategoryTableAdapter();
        private Category_LemmaTableAdapter category_LemmaTableAdapter = new Category_LemmaTableAdapter();
        int i = 0;


        /// <summary>
        /// Parameters:
        /// <para>PrintDialog sent the existing printDialog.</para>
        /// <para>PrintDocument sent the existing printDocument.</para>
        /// <para>title sent the Label that have the Lemma tilte.</para>
        /// <para>content sent the Label tha have the Lemma content.</para>
        /// </summary>
        public void PrintLemma(PrintDialog printDialog1, PrintDocument printDocument1, Label title, Label content)
        {
            article = title.Text + "\n" + content.Text;
            printDialog1.Document = printDocument1;

            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        /// <summary>
        /// Call this method in printDocument1_PrintPage event.
        /// <para>Paramaters is the same with the event method.</para>
        /// </summary>
        public void PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawString(article, new Font("Arial", 14, FontStyle.Bold), Brushes.Black, 150, 125);
        }

        /// <summary>
        /// Returns an array of string.
        /// <para>Split each result by ',' delimiter, the first part is the Lemma name,</para>
        /// <para>and the second part is the timestamp of the history.</para>
        /// </summary>
        public string[] GetAllHistoryData()
        {

            string[] results = null;
            string rowData = null;
            i = 0;
            DataTable newTable = history_Keep_LemmaTableAdapter.GetAllHistoryData();
            results = new string[newTable.Rows.Count];

            foreach (DataRow row in newTable.Rows)
            {
                rowData = row[2].ToString() + "," + row[3].ToString();
                results[i++] = rowData;
                Console.WriteLine(i - 1 + " = " + rowData);
            }
            return results;
        }

        /// <summary>
        /// Get the text Content of a Lemma by lemma name.
        /// <para>Give the name of the Lemma that you want to read!</para>
        /// <para>Returns a string with the text Content of the Lemma.</para>
        /// </summary>
        public string GetLemmaContent(string lemmaName)
        {
            string content = null;
            content = lemma_MediaTableAdapter.GetLemmaContentByLemmaName(lemmaName).ToString();
            return content;
        }

        /// <summary>
        /// Get the paths of Lemmas Images.
        /// <para>Give the Lemma Name to get the images path for.</para>
        /// <para>Returns a string array with the path of each image.</para>
        /// </summary>
        public string[] GetLemmaImagesPath(string lemmaName)
        {
            string[] imagesPath = null;
            i = 0;
            DataTable dataTable = lemma_MediaTableAdapter.GetImagePathsByLemmaName(lemmaName);
            imagesPath = new string[dataTable.Rows.Count];
            foreach (DataRow row in dataTable.Rows)
            {
                imagesPath[i++] = row[0].ToString();
            }
            return imagesPath;
        }

        /// <summary>
        /// Returns a string array.
        /// <para>Each string format is: "BookmarkName,LemmaName"</para>
        /// <para>~Example: my java Text,Java</para>
        /// </summary>
        public string[] GetAllBookmarks()
        {
            string[] bookmarks = null;
            DataTable dataTable = bookmarkTableAdapter.GetAllBookmarks();
            bookmarks = new string[dataTable.Rows.Count];
            i = 0;
            foreach (DataRow row in dataTable.Rows)
            {
                bookmarks[i++] = row[1] + "," + row[3];
            }
            return bookmarks;
        }

        /// <summary>
        /// Returns a string array with the categories.
        /// <para>Each string in the array has the Category name.</para>
        /// </summary>
        public string[] GetAllCategories()
        {
            string[] categories = null;
            DataTable dataTable = categoryTableAdapter.GetAllCategories();
            categories = new string[dataTable.Rows.Count];
            i = 0;
            foreach (DataRow row in dataTable.Rows)
            {
                categories[i++] = row[1].ToString();
            }
            return categories;
        }

        /// <summary>
        /// Returns a string array with the Lemma Name that exist in the Category.
        /// <para>Give the category Name to get all lemma name that exists in.</para>
        /// </summary>
        public string[] GetAllLemmasTitlesFromCategory(string categoryName)
        {
            string[] lemmasTitles = null;
            i = 0;
            DataTable dataTable = category_LemmaTableAdapter.GetLemmasNameByCategoryName(categoryName);
            lemmasTitles = new string[dataTable.Rows.Count];
            foreach (DataRow row in dataTable.Rows)
            {
                lemmasTitles[i++] = row[2].ToString();
            }
            return lemmasTitles;
        }
    }
}
