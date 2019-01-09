using Lucene.Net.Index;
using Lucene.Net.Search;
using Lucene.Net.Store;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using testadopse.InformatiCS_LibraryDataSet1TableAdapters;

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
            string[] categories  = GetAllCategories();
            return categories;
        }

        private string[] GetAllCategories()
        {
            string[] categories = null;

            string directory = System.IO.Directory.GetCurrentDirectory();
            string[] splitDir = directory.Split('\\');
            if (splitDir[splitDir.Length - 1] == "Debug")
            {
                System.IO.Directory.SetCurrentDirectory("..\\..");
            }

            string indexDir = "IndexCategory";
            using (Lucene.Net.Store.Directory dir = FSDirectory.Open(indexDir))
            using (IndexSearcher searcher = new IndexSearcher(dir))
            {
                Term term;
                WildcardQuery q = null;
                BooleanQuery bq = new BooleanQuery();

                term = new Term("Cname", "*");

                q = new WildcardQuery(term);

                bq.Add(q, Occur.MUST);

                TopDocs hits = searcher.Search(bq, 1);

                int j = 0;
                foreach (ScoreDoc d in hits.ScoreDocs)
                {
                    Lucene.Net.Documents.Document doc = searcher.Doc(d.Doc);
                    categories[j++] = doc.Get("Cname").ToString();
                }
            }
            return categories;
        }
    }
}
