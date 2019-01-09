using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using testadopse.InformatiCS_LibraryDataSet1TableAdapters;

using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Windows.Forms;
using System.IO;


namespace testadopse
{
    class ClassOfStaticMethods
    {
        private int i;
        private History_keep_LemmaTableAdapter history_Keep_LemmaTableAdapter = new History_keep_LemmaTableAdapter();
        private BookmarkTableAdapter bookmarkTableAdapter = new BookmarkTableAdapter();

        
        public void addLemmaToHistory(int lemmaid)
        {
            using (OleDbConnection myCon = new OleDbConnection(testadopse.Properties.Settings.Default.FinalConnectionString))
            {
                //String timestamp = "2009-04-21 16:25:53";
                String timestamp = System.DateTime.Now.ToString();
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into History_keep_Lemma(LemmaID,HistoryTimestamp) values (@param2,@param3)";
                
                cmd.Parameters.AddWithValue("@param2", lemmaid);
                cmd.Parameters.AddWithValue("@param3", timestamp);
                cmd.Connection = myCon;
                myCon.Open();
                cmd.ExecuteNonQuery();
                myCon.Close();
                //System.Windows.Forms.MessageBox.Show("An Item has been successfully added", "Caption", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }


        }
        /// <summary>
        /// Returns an array of string.
        /// <para>Split each result by ',' delimiter, the first part is the Lemma name,</para>
        /// <para>and the second part is the timestamp of the history.</para>
        /// </summary>
        /// 
        public string[] getAllHistory()
        {

            string[] results = null;
            string rowData = null;
            i = 0;
            DataTable newTable = history_Keep_LemmaTableAdapter.GetAllHistoryData();
            results = new string[newTable.Rows.Count];

            foreach (DataRow row in newTable.Rows)
            {
                rowData = row[1].ToString() + "," + row[2].ToString();
                results[i++] = rowData;
                Console.WriteLine(i - 1 + " = " + rowData);
            }
            return results;
        }

        /// <summary>
        ///  Delete ALL the history.
        /// </summary>
        public void DeleteAllHistory()
        {
           // history_Keep_LemmaTableAdapter.DeleteAllHistory();
        }

        /// <summary>
        /// Delete all the history that is greater OR equals ">=" of ONE (1) Hour.
        /// </summary>
        public void DeleteHistoryBeforeOneHour()
        {
           // history_Keep_LemmaTableAdapter.DeleteHistoryBeforeOneHour();
        }

        /// <summary>
        /// Delete all the history that is greater OR equals ">=" of ONE (1) DAY.
        /// </summary>
        public void DeleteHistoryBeforeOneDay()
        {
           // history_Keep_LemmaTableAdapter.DeleteHistoryBeforeOneDay();
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
        /*
        Deletes all  records of bookmarks table
        Created by Kardamanidis Christos
        This method gets the id of the lemma as a parameter and it deletes it   this history record 

            */
        public void delete_all_bookmarks()
        {
            using (OleDbConnection myCon = new OleDbConnection(Properties.Settings.Default.FinalConnectionString))
            {
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "DELETE FROM Bookmark";

                cmd.Connection = myCon;
                myCon.Open();
                cmd.ExecuteNonQuery();
                //System.Windows.Forms.MessageBox.Show("An Item has been successfully added", "Caption", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                myCon.Close();

            }




        }
        /*
         Deletes a single record of history_keep_lemma
         Created by Kardamanidis Christos
         This method gets the id of the lemma  and the timestamp of visiting it as a parameter and it deletes it   this history record 
             
             */
        public void delete_history_keep_lemma_record(int lemma_id, String history_timestamp)
        {
            using (OleDbConnection myCon = new OleDbConnection(Properties.Settings.Default.FinalConnectionString))
            {
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "DELETE FROM History_keep_Lemma WHERE LemmaID LIKE @param1 AND  HistoryTimestamp LIKE @param2";
                cmd.Parameters.AddWithValue("@param1", lemma_id);
                cmd.Parameters.AddWithValue("@param2", history_timestamp);

                cmd.Connection = myCon;
                myCon.Open();
                cmd.ExecuteNonQuery();
                myCon.Close();
            }


        }
        /*
         Deletes a single line of bookmark
         Created by Kardamanidis Christos
         This method gets bookmark name as a parameter and it deletes it    
             
             */
        public void delete_bookmark(String bname)
        {
            using (OleDbConnection myCon = new OleDbConnection(Properties.Settings.Default.FinalConnectionString))
            {
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "DELETE FROM Bookmark WHERE bname LIKE @param1";
                cmd.Parameters.AddWithValue("@param1", bname);

                cmd.Connection = myCon;
                myCon.Open();
                cmd.ExecuteNonQuery();
                myCon.Close();
            }


        }

    }
}
