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
    public partial class Terms : UserControl
    {
        public Terms()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            string targetURL = @"http://creativecommons.org/licenses/by-nc/4.0/";
            System.Diagnostics.Process.Start(targetURL);
        }
    }
}
