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
    public partial class ViewUC : UserControl
    {
        public ViewUC()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Call the PrintLemma method
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            // Call the PrintPage method
        }

        public string GetHistory()
        {
            string results = null;



            return results;
        }

        private void SearchB_Click(object sender, EventArgs e)
        {
        }
    }
}
