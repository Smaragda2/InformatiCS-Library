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
    public partial class ViewLemma : UserControl
    {
        public ViewLemma()
        {
            InitializeComponent();
            panel1.Width = this.Width - 6;
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }


    }
}
