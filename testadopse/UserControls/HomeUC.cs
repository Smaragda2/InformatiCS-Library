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
    public partial class HomeUC : UserControl
    {

        bool hide,hide2;
        testadopse.ClassOfStaticMethods cosm = new ClassOfStaticMethods();

        public HomeUC()
        {
            
            InitializeComponent();
            panel1.Visible = false;
            BookMarkP.Visible = false;
            hide = true;
            hide2 = true;

        }

        private void AdvSearchB_Click(object sender, EventArgs e)
        {
            if (hide)
            {
                panel1.Visible = true;
                hide = false;
            }
            else
            {
                panel1.Visible = false;
                hide = true;
            }
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox1.ForeColor = Color.Black;
        }

        private void HomeUC_Load(object sender, EventArgs e)
        {

            string[] pinakas = cosm.GetAllBookmarks();
            gemismabookmark(pinakas);
        }

        public void gemismabookmark(string[] pinakas)
        {
            
            Bookmarks.Controls.Clear();
            for (int i=0; i<pinakas.Length; i++)
            {
                Button btn = new Button();
                btn.Text = pinakas[i];
                btn.Dock = DockStyle.Top;
                btn.AutoSize = true;
                Bookmarks.Controls.Add(btn);
            }

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BookMarkB_Click(object sender, EventArgs e)
        {
            if (hide2)
            {
                BookMarkP.Visible = true;
                hide2 = false;
            }
            else
            {
                BookMarkP.Visible = false;
                hide2 = true;
            }
        }
    }
}
