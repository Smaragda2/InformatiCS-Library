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
            Bookmarks.Size = new System.Drawing.Size(200,pinakas.Length * 30);
            BookMarkP.Size = new System.Drawing.Size(200,62+pinakas.Length*30);
            for (int i=0; i<pinakas.Length; i++)
            {
                Button btn = new Button();
                string[] data = pinakas[i].Split(',');
                btn.Text = "  " + (pinakas.Length - i) + ".     ";
                btn.Text += data[0];

                btn.TextAlign = ContentAlignment.MiddleLeft;
                btn.Dock = DockStyle.Top;
                btn.FlatStyle = FlatStyle.Flat;
                btn.Size = new System.Drawing.Size(135, 30);
                btn.Font = new Font("Microsoft Sans Serif", 8);
                btn.ForeColor = System.Drawing.Color.Black;
                btn.FlatAppearance.BorderSize = 0;
                Bookmarks.Controls.Add(btn);
            }

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BookmarkOptions_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DeleteBookmarks_Click(object sender, EventArgs e)
        {
            cosm.delete_all_bookmarks();
            Bookmarks.Controls.Clear();
            Label lbl = new Label();
            lbl.Text = "  Δεν εχετε κανενα bookmark ";
            lbl.AutoSize = true;
            lbl.Font = new Font("Microsoft Sans Serif", 10);
            lbl.ForeColor = System.Drawing.Color.Black;

            Bookmarks.Size = new System.Drawing.Size(200, 50);
            BookMarkP.Size = new System.Drawing.Size(200, 112);

            lbl.Location = new Point(0, 10);
            Bookmarks.Controls.Add(lbl);


        }

        private void Delete1Bookmark_Click(object sender, EventArgs e)
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
