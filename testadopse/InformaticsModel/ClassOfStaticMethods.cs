using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using testadopse.InformatiCS_LibraryDataSetTableAdapters;


namespace InformaticsModel
{
    class ClassOfStaticMethods
    {
        private int i;
        private History_keep_LemmaTableAdapter history_Keep_LemmaTableAdapter = new History_keep_LemmaTableAdapter();
        private BookmarkTableAdapter bookmarkTableAdapter = new BookmarkTableAdapter();

        public static void addLemmaToHistory() { }

        /// <summary>
        /// Returns an array of string.
        /// <para>Split each result by ',' delimiter, the first part is the Lemma name,</para>
        /// <para>and the second part is the timestamp of the history.</para>
        /// </summary>
        public string[] getAllHistory()
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

        public static Collection<Object> ShowHistory() { throw new NotImplementedException(); }

        /// <summary>
        /// Each string format is: "BookmarkName,LemmaName".
        /// <para>Split each result by ',' delimiter, the first part is the Bookmark Name, </para>
        /// <para>and the second part is the Lemma Name.</para>
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
    }
}
