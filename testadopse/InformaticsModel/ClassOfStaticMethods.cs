using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using testadopse.InformatiCS_LibraryDataSetTableAdapters;

using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Windows.Forms;
using System.IO;


namespace InformaticsModel
{
    class ClassOfStaticMethods
    {
        private int i;
        private History_keep_LemmaTableAdapter history_Keep_LemmaTableAdapter = new History_keep_LemmaTableAdapter();
        private BookmarkTableAdapter bookmarkTableAdapter = new BookmarkTableAdapter();

        
        public static void addLemmaToHistory(int historyID, int lemmaid)
        {
            using (OleDbConnection myCon = new OleDbConnection(Properties.Settings.Default.AdopseFINALConnectionString))
            {
                //String timestamp = "2009-04-21 16:25:53";
                String timestamp = System.DateTime.Now.ToString();
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into History_keep_Lemma(HistoryID,LemmaID,HistoryTimestamp) values (@param1,@param2,@param3)";
                cmd.Parameters.AddWithValue("@param1", historyID);
                cmd.Parameters.AddWithValue("@param2", lemmaid);
                cmd.Parameters.AddWithValue("@param3", timestamp);
                cmd.Connection = myCon;
                myCon.Open();
                cmd.ExecuteNonQuery();
                //System.Windows.Forms.MessageBox.Show("An Item has been successfully added", "Caption", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }


        }
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
