using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using testadopse.InformatiCS_LibraryDataSetTableAdapters;
using Lucene.Net.Documents;
using Lucene.Net.Search;
using Lucene.Net;
using Lucene.Net.Store;
using Lucene.Net.Index;
using Lucene.Net.Analysis.Standard;
using Lucene.Net.Util;
using LVersion = Lucene.Net.Util.Version;
using Lucene.Net.QueryParsers;




namespace InformaticsModel
{
    class LemmaMedia
    {
        private string article = null;
        private Lemma_MediaTableAdapter lemma_MediaTableAdapter = new Lemma_MediaTableAdapter();
        private int i;

        private Media[] media_of_lemma;
        private Lemma limma;
        private Media get_media_of_lemma() {
            throw new NotImplementedException();
        }
        private Lemma get_lemma() {
            throw new NotImplementedException();
        }
        public void saveLemmaAsBookmark(String name) { }
        public void showLemmaList() { }

        /// <summary>
        /// Using Lucene Search Engine.
        /// <para>Search both the Title and Content to find any match</para>
        /// <para><returns>Returns table of string (string[]) </returns> with the Lemma Names.</para>
        /// </summary>
        public string[] Search(string query)
        {
            string[] results = null;
            string indexDir = ".\\Index";
            using (Directory dir = FSDirectory.Open(indexDir))
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
                        term = new Term("Content", "*" + splited[i] + "*");
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

                TopDocs hits = searcher.Search(bq, 50);

                //lbl.Text +=  "Found " + hits.TotalHits + " documents matched query '" + bq + "':\n";
                int j = 0;
                results = new string[hits.TotalHits];
                foreach (ScoreDoc d in hits.ScoreDocs)
                {
                    Document doc = searcher.Doc(d.Doc);
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
        public void Print(PrintDialog printDialog1, PrintDocument printDocument1, Label title, Label content)
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


        public void export() { }
    }
}
