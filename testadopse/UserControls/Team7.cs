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
    public partial class Team7 : UserControl
    {
        public Team7()
        {
            InitializeComponent();
        }

        private void FacebookB_Click(object sender, EventArgs e)
        {
            string targetURL = @"https://www.facebook.com/groups/1444335492397620/?ref=bookmarks";
            System.Diagnostics.Process.Start(targetURL);
        }
    }
}
