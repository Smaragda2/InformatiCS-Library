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

        public CategoriesUC()
        {
            InitializeComponent();
        }

        private void viewUC1_Load(object sender, EventArgs e)
        {

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
