using InformaticsModel;
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
    class CategoryLemmaMedia
    {
        private int i;

        private LemmaMedia txt_and_media;
        private Category cat;

        /// <summary>
        /// Search in the Database to find Lemmas that belong to the choosen Category.
        /// <para><returns>Returns table of string (string[]) </returns> with the Lemma Names.</para>
        /// </summary>
        public string[] SearchByCategory(string categoryName)
        {
            string[] results = null;
            string indexDir = "IndexCategory";
            using (Lucene.Net.Store.Directory dir = FSDirectory.Open(indexDir))
            using (IndexSearcher searcher = new IndexSearcher(dir))
            {
                Term term;
                WildcardQuery q = null;
                BooleanQuery bq = new BooleanQuery();
                string[] splitName = categoryName.Split(' ');

                if (splitName.Length > 1)
                {
                    for(int i = 0; i < splitName.Length; i++)
                    {
                        string[] splitName2 = splitName[i].Split('-');
                        if (splitName2.Length > 1)
                        {
                            for(int k = 0; k < splitName2.Length; k++)
                            {
                                term = new Term("Cname", "*" + splitName2[k].ToLower() + "*");
                                q = new WildcardQuery(term);
                                bq.Add(q, Occur.MUST);
                            }
                        }
                        else
                        {
                            term = new Term("Cname", "*" + splitName[i].ToLower() + "*");
                            q = new WildcardQuery(term);
                            bq.Add(q, Occur.MUST);
                        }
                    }
                }
                else
                {
                    term = new Term("Cname", "*" + categoryName.ToLower() + "*");
                    q = new WildcardQuery(term);
                    bq.Add(q, Occur.MUST);
                }


                TopDocs hits = searcher.Search(bq, 100);

                int j = 0;
                results = new string[hits.TotalHits];
                foreach (ScoreDoc d in hits.ScoreDocs)
                {
                    Lucene.Net.Documents.Document doc = searcher.Doc(d.Doc);
                    results[j++] = doc.Get("title").ToString();
                }
            }
            return results;
        }


    }
}