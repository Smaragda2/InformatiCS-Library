using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using testadopse.InformatiCS_LibraryDataSet1TableAdapters;

namespace testadopse.UserControls
{
    public partial class HomeUC : UserControl
    {
        //static string connectionString = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source =| DataDirectory |\\InformatiCS_Library.mdb";
        Searcher searcher = new Searcher();
        public HomeUC()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
            if(textBox1.Text != "")
            {
                if (radioButton1.Checked || radioButton2.Checked)
                {
                    label3.Text = "";
                    string[] results = searcher.Search(textBox1.Text);
                    for(int i = 0; i < results.Length; i++)
                    {
                        label3.Text += results[i]+"\n";
                    }
                    //search.SearchInTitle(textBox1, label3);
                }
                else if (radioButton3.Checked)
                {
                    label3.Text = "";
                    string[] results = searcher.SearchByCategory(textBox1.Text);
                    for (int i = 0; i < results.Length; i++)
                    {
                        label3.Text += results[i] + "\n";
                    }
                }
            }
            else
            {
                //label3.Visible = false;
            }
        }

        private void listBox1_Click(object sender, EventArgs e)
        {
           //textBox1.Text = listBox1.SelectedItem.ToString();
        }
    }
}
