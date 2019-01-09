using Lucene.Net.Index;
using Lucene.Net.Search;
using Lucene.Net.Store;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using testadopse.InformatiCS_LibraryDataSet1TableAdapters;

namespace testadopse
{
    class Lemma
    {
        private int id;
        private String name;
        public int getId() { throw new NotImplementedException(); }
        public void setAll(int id, String name) { }
        public String getName() { throw new NotImplementedException(); }

        public int getLemmaIDbyLemmaName(string lemmaName)
        {
            string directory = System.IO.Directory.GetCurrentDirectory();
            string[] splitDir = directory.Split('\\');
            if (splitDir[splitDir.Length - 1] == "Debug")
            {
                System.IO.Directory.SetCurrentDirectory("..\\..\\");
            }

            string[] splitLemmaName = lemmaName.Split('(');

            string results = null;
            int id = -1;
            string indexDir = "Index";
            using (Lucene.Net.Store.Directory dir = FSDirectory.Open(indexDir))
            using (IndexSearcher searcher = new IndexSearcher(dir))
            {
                Term term;
                WildcardQuery q = null;
                BooleanQuery bq = new BooleanQuery();
                
                term = new Term("title", "*"+splitLemmaName[0].ToLower()+"*");
                q = new WildcardQuery(term);
                bq.Add(q, Occur.SHOULD);
                

                TopDocs hits = searcher.Search(bq, 2);
               

                foreach (ScoreDoc d in hits.ScoreDocs)
                {
                    Lucene.Net.Documents.Document doc = searcher.Doc(d.Doc);
                    results = doc.Get("LID").ToString();
                }
            }
            Int32.TryParse(results, out id);
            return id;
        }


    }
}
