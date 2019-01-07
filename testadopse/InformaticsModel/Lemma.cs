using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using testadopse.InformatiCS_LibraryDataSetTableAdapters;

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
            LemmaTableAdapter lemmaTableAdapter = new LemmaTableAdapter();
            int lemmaID = -1;
            lemmaID = (int)lemmaTableAdapter.GetLemmaIDbyLemmaName(lemmaName);
            return lemmaID;
        }

    }
}
