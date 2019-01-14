using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testadopse.UserControls
{
    public partial class CategoriesUC : UserControl
    {
        string sn="";
        public CategoriesUC()
        {
            InitializeComponent();
            viewUC1.pictureBox1.DoubleClick += new EventHandler(image_dclick);
        }

        private void viewUC1_Load(object sender, EventArgs e)
        {
            treeView1.Nodes.Clear();
            testadopse.Category categoryp = new Category();
            TreeNodeCollection nodes = treeView1.Nodes;
            string[] pinakas = categoryp.get_all_categories();

            for (int i = 0; i < pinakas.Length; i++)
            {
                string[] split = pinakas[i].Split(':');
                treeView1.Nodes.Add(split[1]);
                split = null;
            }
                //nodes.Add(pinakas[i]);
                //treeView1.Nodes.AddRange(node);
        }
        
        private void treeView1_DoubleClick(object sender, EventArgs e)
        {
            viewUC1.panel2.Controls.Clear();
            string send = sender as string;
            testadopse.CategoryLemmaMedia lemmac = new CategoryLemmaMedia();
            string[] pinakas = lemmac.SearchByCategory(treeView1.SelectedNode.Text);
            sn = treeView1.SelectedNode.Text;
            viewUC1.gemismalabel(pinakas);
            CategoriesP.Width = 0;
            
        }

        private void image_dclick(object sender, EventArgs e)
        {
           if(CategoriesP.Width == 0 ) CategoriesP.Width = 180;
           else CategoriesP.Width = 0;
        }
        
    }
}
