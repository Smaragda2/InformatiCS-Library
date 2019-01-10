using Lucene.Net.Index;
using Lucene.Net.Search;
using Lucene.Net.Store;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using testadopse.InformatiCS_LibraryDataSetTableAdapters;

namespace testadopse
{
    class Category
    {
        private int i;

        private int id;
        private String name;

        /// <summary>
        /// Returns a string array with the categories.
        /// <para>Each string in the array has the Category name.</para>
        /// </summary>
        public string[] get_all_categories()
        {
            string[] categories = GetAllCategories();
            return categories;
        }

        private string[] GetAllCategories()
        {
            string directory = System.IO.Directory.GetCurrentDirectory();
            string[] splitDir = directory.Split('\\');
            if (splitDir[splitDir.Length - 1] == "Debug")
            {
                System.IO.Directory.SetCurrentDirectory("..\\..\\");
            }

            string[] results = null;
            string indexDir = "IndexCategoryOnly";
            using (Lucene.Net.Store.Directory dir = FSDirectory.Open(indexDir))
            using (IndexSearcher searcher = new IndexSearcher(dir))
            {
                // QueryParser parser = new QueryParser(LVersion.LUCENE_30, "Content", new StandardAnalyzer(LVersion.LUCENE_30));
                //Query q = parser.Parse(newQuery);
                Term term;
                WildcardQuery q = null;
                BooleanQuery bq = new BooleanQuery();

                term = new Term("Cname", "***");
                q = new WildcardQuery(term);
                bq.Add(q, Occur.MUST);

                TopDocs hits = searcher.Search(bq, 20000);

                //lbl.Text +=  "Found " + hits.TotalHits + " documents matched query '" + bq + "':\n";
                int j = 0;
                results = new string[hits.TotalHits];

                foreach (ScoreDoc d in hits.ScoreDocs)
                {
                    Lucene.Net.Documents.Document doc = searcher.Doc(d.Doc);
                    results[j++] = doc.Get("Cname").ToString();
                }
            }
            return results;
        }
    }
}

