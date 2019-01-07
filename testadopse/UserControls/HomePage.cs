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
    public partial class Homepage : UserControl
    {
        HomeUC ho = new HomeUC();
        public Homepage()
        {
            InitializeComponent();
            homeUC1.BringToFront();
            homeUC1.SearchB.Click += new EventHandler(search_click);
            homeUC1.textBox1.KeyDown += new KeyEventHandler(enter_click);
            viewUC1.pictureBox1.Click += new EventHandler(image_click);
            viewUC1.pictureBox1.DoubleClick += new EventHandler(image_dclick);
        }


        //Event otan pataei to enter sto textbox na proxwraei me thn anazhthsh
        private void enter_click(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                search_click(this, new EventArgs());
            }
        }

        
        private void search_click(object sender,EventArgs e)
        {
            viewUC1.BringToFront();
            viewUC1.textboxtext(homeUC1.textBox1.Text);
            string[] pinakas = viewUC1.search();
            viewUC1.gemismalabel(pinakas);                         
        }

        private void image_click(object sender,EventArgs e)
        {
            viewUC1.BringToFront();
            string[] pinakas = viewUC1.search();
            viewUC1.gemismalabel(pinakas);
        }

        private void image_dclick(object sender, EventArgs e)
        {
            homeUC1.BringToFront();
            homeUC1.textBox1.Text = "Κάντε αναζήτηση λήμματος ";
            homeUC1.textBox1.ForeColor = System.Drawing.Color.Gray;
            homeUC1.textBox1.Font = new Font("Microsoft Sans Serif", 12);
            this.Refresh();
        }
    }
}
