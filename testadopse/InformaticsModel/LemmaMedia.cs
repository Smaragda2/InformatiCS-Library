using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using testadopse.InformatiCS_LibraryDataSet1TableAdapters;
using Lucene.Net.Documents;
using Lucene.Net.Search;
using Lucene.Net;
using Lucene.Net.Store;
using Lucene.Net.Index;
using Lucene.Net.Analysis.Standard;
using Lucene.Net.Util;
using LVersion = Lucene.Net.Util.Version;
using Lucene.Net.QueryParsers;

using iTextSharp.text;
using iTextSharp.text.pdf;

using System.IO;
using System.Data.OleDb;
using testadopse;

namespace InformaticsModel
{
    class LemmaMedia
    {
        private string article;
        private int i;

        private Media[] media_of_lemma;
        private Lemma limma;
        private Media get_media_of_lemma() {
            throw new NotImplementedException();
        }
        private Lemma get_lemma() {
            throw new NotImplementedException();
        }
        public void add_to_bookmark(String bname, string lemmaName)
        {
            int lemmaid = new Lemma().getLemmaIDbyLemmaName(lemmaName);
            using (OleDbConnection myCon = new OleDbConnection(testadopse.Properties.Settings.Default.FinalConnectionString))
            {
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into Bookmark (Bname,LemmaID) values (@param1,@param2)";
                cmd.Parameters.AddWithValue("@param1", bname);
                cmd.Parameters.AddWithValue("@param2", lemmaid);
                cmd.Connection = myCon;
                myCon.Open();
                cmd.ExecuteNonQuery();
                System.Windows.Forms.MessageBox.Show("An Item has been successfully added", "Caption", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                myCon.Close();
            }
        }
        public void showLemmaList() { }

        /// <summary>
        /// Using Lucene Search Engine.
        /// <para>Search both the Title and Content to find any match</para>
        /// <para><returns>Returns table of string (string[]) </returns> with the Lemma Names.</para>
        /// </summary>
        public string[] Search(string query)
        {
            string directory = System.IO.Directory.GetCurrentDirectory();
            string[] splitDir = directory.Split('\\');
            if (splitDir[splitDir.Length - 1] == "Debug")
            {
                System.IO.Directory.SetCurrentDirectory("..\\..\\");
            }

            string[] results = null;
            string indexDir = "Index";
            using (Lucene.Net.Store.Directory dir = FSDirectory.Open(indexDir))
            using (IndexSearcher searcher = new IndexSearcher(dir))
            {
                // QueryParser parser = new QueryParser(LVersion.LUCENE_30, "Content", new StandardAnalyzer(LVersion.LUCENE_30));
                char[] c = query.ToCharArray();
                string newQuery = "";
                foreach (char ch in c)
                {
                    switch (ch)
                    {
                        case '+':
                        case '-':
                        case '&':
                        case '|':
                        case '!':
                        case '(':
                        case ')':
                        case '{':
                        case '}':
                        case '[':
                        case ']':
                        case '^':
                        case '"':
                        case '~':
                        case '*':
                        case '?':
                        case ':':
                        case '\\':
                            newQuery += "\\" + ch;
                            break;
                        default:
                            newQuery += ch;
                            break;
                    }
                }
                //Query q = parser.Parse(newQuery);
                string[] splited;
                Term term;
                WildcardQuery q = null;
                BooleanQuery bq = new BooleanQuery();

                if (newQuery.Split(' ').Length > 1)
                {
                    splited = newQuery.Split(' ');
                    for (int i = 0; i < splited.Length; i++)
                    {
                        term = new Term("Content", "*" + splited[i].ToLower() + "*");
                        q = new WildcardQuery(term);
                        bq.Add(q, Occur.SHOULD);
                    }
                }
                else
                {
                    term = new Term("Content", "*" + newQuery + "*");
                    q = new WildcardQuery(term);
                    bq.Add(q, Occur.MUST);
                }

                TopDocs hits = searcher.Search(bq, 100);

                //lbl.Text +=  "Found " + hits.TotalHits + " documents matched query '" + bq + "':\n";
                int j = 0;
                results = new string[100];

                foreach (ScoreDoc d in hits.ScoreDocs)
                {
                    Lucene.Net.Documents.Document doc = searcher.Doc(d.Doc);
                    results[j++] = doc.Get("title").ToString();
                }
            }
            return results;
        }

        /// <summary>
        /// Parameters:
        /// <para>PrintDialog sent the existing printDialog.</para>
        /// <para>PrintDocument sent the existing printDocument.</para>
        /// <para>title sent the Label that have the Lemma tilte.</para>
        /// <para>content sent the Label tha have the Lemma content.</para>
        /// </summary>
        public void Print(PrintDialog printDialog1, PrintDocument printDocument1)
        {
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
        public void PrintPage(object sender, PrintPageEventArgs e, Label title, Label content)
        {
            article = title.Text + "\n" + content.Text;

            e.Graphics.DrawString(article, new System.Drawing.Font("Arial", 13, FontStyle.Regular), Brushes.Black,25, 50);
        }

        /// <summary>
        /// Get the text Content of a Lemma by lemma name.
        /// <para>Give the name of the Lemma that you want to read!</para>
        /// <para>Returns a string with the text Content of the Lemma.</para>
        /// </summary>
        public string GetLemmaContent(string lemmaName)
        {
            string directory = System.IO.Directory.GetCurrentDirectory();
            string[] splitDir = directory.Split('\\');
            if (splitDir[splitDir.Length - 1] == "Debug")
            {
                System.IO.Directory.SetCurrentDirectory("..\\..");
            }
            string[] splitLemmaName = lemmaName.Split('(');

            string results = null;
            string indexDir = "Index";
            using (Lucene.Net.Store.Directory dir = FSDirectory.Open(indexDir))
            using (IndexSearcher searcher = new IndexSearcher(dir))
            {
                Term term,term2;
                WildcardQuery q,q2 = null;
                BooleanQuery bq = new BooleanQuery();

                term = new Term("title", "*" + splitLemmaName[0].ToLower() + "*");

                q = new WildcardQuery(term);

                bq.Add(q, Occur.MUST);

                TopDocs hits = searcher.Search(bq, 1);


                foreach (ScoreDoc d in hits.ScoreDocs)
                {
                    Lucene.Net.Documents.Document doc = searcher.Doc(d.Doc);
                    results = doc.Get("Content").ToString();
                }
            }
            return results;
        }



        /// <summary>
        /// Get the paths of Lemmas Images.
        /// <para>Give the Lemma Name to get the images path for.</para>
        /// <para>Returns a string array with the path of each image.</para>
        /// </summary>
        public string[] GetLemmaImagesPath(string lemmaName)
        {
            string directory = System.IO.Directory.GetCurrentDirectory();
            string[] splitDir = directory.Split('\\');
            if (splitDir[splitDir.Length - 1] == "Debug")
            {
                System.IO.Directory.SetCurrentDirectory("..\\..");
            }

            string[] splitLemmaName = lemmaName.Split('(');
            string[] imageTypes = new string[]{ "jpg", "svg" , "png", "gif" };

            string[] results = null;
            string indexDir = "Index";
            using (Lucene.Net.Store.Directory dir = FSDirectory.Open(indexDir))
            using (IndexSearcher searcher = new IndexSearcher(dir))
            {
                Term term, term2;
                WildcardQuery q, q2 = null;
                BooleanQuery bq = new BooleanQuery();

                term = new Term("title", "*" + splitLemmaName[0].ToLower() + "*");
                q = new WildcardQuery(term);
                bq.Add(q, Occur.MUST);


                TopDocs hits = searcher.Search(bq,10);

                int j = 0;
                if(hits.TotalHits > 10)
                    results = new string[10];
                else
                    results = new string[hits.TotalHits+1];
                results[j++] = "hits:" + hits.TotalHits;
                foreach (ScoreDoc d in hits.ScoreDocs)
                {
                 
                    Lucene.Net.Documents.Document doc = searcher.Doc(d.Doc);
                    foreach(string type in imageTypes)
                    {
                        if (doc.Get("dataType").ToString() == type)
                        {
                            results[j++] = doc.Get("Content").ToString() + "." + doc.Get("dataType").ToString();
                        }
                    }
                }
            }
            return results;
        }



        public void navigate_where_to_export_pdf_text_only(String text)
        {
            //THIS METHOD NEEDS JUST THE TEXT AND IT WILL LEARN WHERE TO EXPORT IT
            FolderBrowserDialog obj = new FolderBrowserDialog();
            if (obj.ShowDialog() == DialogResult.OK)
            {
                String path = obj.SelectedPath;

                MessageBox.Show(path);
                //export(path ,text);
                export(path, text);
            }
        }
        public void navigate_where_to_export_pdf_text_and_image(String text, String url_to_photo)
        {   //THIS METHOD NEEDS JUST THE TEXT AND THE SOURCE OF THE IMAGE AND IT WILL LEARN WHERE TO EXPORT THEM
            FolderBrowserDialog obj = new FolderBrowserDialog();
            if (obj.ShowDialog() == DialogResult.OK)
            {
                String path = obj.SelectedPath;

                MessageBox.Show(path);

                export_with_icons(path, text, url_to_photo);
            }
        }
        private void export(String path, String text)
        {   //KARDAMANIDIS CHRISTOS
            //path is coming from filechooser,and text is what navigate_where gave us
            iTextSharp.text.Document doc = new iTextSharp.text.Document();
            String name_for_the_pdf = RandomString(8);
            PdfWriter.GetInstance(doc, new FileStream(path + "\\" + name_for_the_pdf + ".pdf", FileMode.Create));

            doc.Open();
            Paragraph p1 = new Paragraph(text);

            doc.Add(p1);
            doc.Close();
        }

        private void export_with_icons(String path, String text, String url_to_photo)
        {   //KARDAMANIDIS CHRISTOS
            iTextSharp.text.Image pic = iTextSharp.text.Image.GetInstance(url_to_photo);
            iTextSharp.text.Document doc = new iTextSharp.text.Document();
            String name_for_the_pdf = RandomString(8);
            PdfWriter.GetInstance(doc, new FileStream(path + "\\" + name_for_the_pdf + ".pdf", FileMode.Create));
            pic.ScaleAbsolute(120, 150);
            doc.Open();
            Paragraph p1 = new Paragraph(text);

            doc.Add(p1);
            doc.Add(pic);

            doc.Close();
        }
        private void open_pdf(String source)
        {   //KARDAMANIDIS CHRISTOS
            //this methods needs the path of a file to view it with the default editor of windows
            System.Diagnostics.Process.Start(source);
        }


        public static string RandomString(int length)
        {   //KARDAMANIDIS CHRISTOS
            Random random = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}
