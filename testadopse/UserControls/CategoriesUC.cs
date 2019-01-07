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
            testadopse.Category categoryp = new Category();
            TreeNodeCollection nodes = treeView1.Nodes;
            string[] pinakas = categoryp.get_all_categories();

            for (int i=0; i<pinakas.Length; i++)
                nodes = nodes.Find(pinakas[i], false).Length > 0  ?
               nodes.Find(pinakas[i], false)[0].Nodes : nodes.Add(pinakas[i], pinakas[i]).Nodes;
        }
        
        private void treeView1_DoubleClick(object sender, EventArgs e)
        {
            viewUC1.panel2.Controls.Clear();
            string send = sender as string;
            testadopse.CategoryLemmaMedia lemmac = new CategoryLemmaMedia();
            string[] pinakas = lemmac.SearchByCategory(treeView1.SelectedNode.Text);
            sn = treeView1.SelectedNode.Text;
            viewUC1.gemismalabel(pinakas);
               

        }

        private void image_dclick(object sender, EventArgs e)
        {
            viewUC1.panel2.Controls.Clear();

        }




        /*
private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
{
   foreach (TreeNode node in this.treeView1.Nodes)
   {
       if (treeView1.SelectedNode.Nodes.Count == 0)
       {

           categorie2UC1.BringToFront();
       }
       else
       {
           categories3UC2.BringToFront();
       }
   }
}
*/
    }
}
