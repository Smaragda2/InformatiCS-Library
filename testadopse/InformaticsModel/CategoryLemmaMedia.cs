using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using testadopse.InformatiCS_LibraryDataSetTableAdapters;


namespace InformaticsModel
{
    class CategoryLemmaMedia
    {
        private int i;
        private Category_LemmaTableAdapter category_LemmaTableAdapter = new Category_LemmaTableAdapter();


        private LemmaMedia txt_and_media;
        private Category cat;

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
}
