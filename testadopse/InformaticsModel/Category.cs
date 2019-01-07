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
        private CategoryTableAdapter categoryTableAdapter = new CategoryTableAdapter();
        private int i;

        private int id;
        private String name;

        /// <summary>
        /// Returns a string array with the categories.
        /// <para>Each string in the array has the Category name.</para>
        /// </summary>
        public string[] get_all_categories()
        {
            string[] categories = null;
            DataTable dataTable = categoryTableAdapter.GetAllCategories();
            categories = new string[dataTable.Rows.Count];
            i = 0;
            foreach (DataRow row in dataTable.Rows)
            {
                categories[i++] = row[1].ToString();
            }
            return categories;
        }
    }
}
