using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lucene.Net;
using Lucene.Net.Store;
using Lucene.Net.Index;
using Lucene.Net.Analysis.Standard;
using Lucene.Net.Util;
using LVersion = Lucene.Net.Util.Version;
using Lucene.Net.Documents;
using Lucene.Net.Search;
using Lucene.Net.QueryParsers;
using System.Windows.Forms;
using System.Data.OleDb;
using testadopse.InformatiCS_LibraryDataSet1TableAdapters;
using System.Data;

public class Searcher
{
    //OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\InformatiCS_Library.mdb");

    public Searcher()
    {
        //connection.Open();
    }

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
            foreach(char ch in c)
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

            TopDocs hits = searcher.Search(bq,50);

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
    /// Search in the Database to find Lemmas that belong to the choosen Category.
    /// <para><returns>Returns table of string (string[]) </returns> with the Lemma Names.</para>
    /// </summary>
    public string[] SearchByCategory(string categoryName)
    {
        string[] results = null;
        int i = 0;
        Category_LemmaTableAdapter categoryLemmaTableAdapter = new Category_LemmaTableAdapter();
        DataTable newTable = categoryLemmaTableAdapter.GetDataByCategoryName(categoryName);
        
        results = new string[newTable.Rows.Count];
        foreach (DataRow row in newTable.Rows)
        {
            results[i++] = row[2].ToString();
        }
        return results;
    }
}
