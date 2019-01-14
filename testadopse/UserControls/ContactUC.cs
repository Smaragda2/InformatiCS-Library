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
    public partial class ContactUC : UserControl
    {
        public ContactUC()
        {
            InitializeComponent();
            team71.BringToFront();

        }



        private void FacebookB_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/groups/1444335492397620/");
        }

        private void memberUC1_Load(object sender, EventArgs e)
        {

        }

        private void Team7P_Paint(object sender, PaintEventArgs e)
        {

        }

        private void KyriakosPhoto_Click(object sender, EventArgs e)
        {
            memberKI1.BringToFront();
        }

        private void TeamPhoto_Click(object sender, EventArgs e)
        {
            team71.BringToFront();
        }

     
 
        private void XrhstosPhoto_Click(object sender, EventArgs e)
        {
            memberXK1.BringToFront();
        }

        private void SmaragdaPhoto_Click(object sender, EventArgs e)
        {
            memberSP1.BringToFront();
        }

        private void BasilhsPhoto_Click(object sender, EventArgs e)
        {
            memberBM1.BringToFront();
        }
    }
}
