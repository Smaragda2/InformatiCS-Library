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
            BookMarkP.Visible = false;
        }

        public void HomeUC_Load(object sender, EventArgs e)
        {
            string[] pinakas = cosm.GetAllBookmarks();
            gemismabookmark(pinakas);
        }
        
        public TextBox textbox()
        {
            return this.textBox1;
        }

        //
        // Gemizontai ta bookmark
        //
        public void gemismabookmark(string[] pinakas)
        {
            if (pinakas.Length == 0 || pinakas[0] == "ze)")
            {
                Bookmarks.Controls.Clear();
                Label lbl = new Label();
                lbl.Text = "  Δεν έχετε κανένα bookmark";
                lbl.AutoSize = true;
                lbl.Font = new Font("Microsoft Sans Serif", 8);
                lbl.ForeColor = System.Drawing.Color.Black;
                Bookmarks.Size = new System.Drawing.Size(180, 30);
                BookMarkP.Size = new System.Drawing.Size(180, 112);
                lbl.Location = new Point(6, 10);
                Bookmarks.Controls.Add(lbl);
            }
            else
            {
                Bookmarks.Controls.Clear();
                Bookmarks.Size = new System.Drawing.Size(180, pinakas.Length * 30);
                BookMarkP.Size = new System.Drawing.Size(180, 62 + pinakas.Length * 30);
                for (int i = 0; i < pinakas.Length; i++)
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

        }

        //
        // EVENT : Otan patithei to koympi bookmark, anoigei to panel me tis epilogew bookmark kai ta bookmark
        //
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

        //
        // EVENT : Otan patithe diagrafontai oloi oi apothikeumenoi selidodeiktes
        //
        private void DeleteBookmarks_Click(object sender, EventArgs e)
        {
            cosm.delete_all_bookmarks();
            string[] pinak = new string[1];
            pinak[0] = "ze)";
            gemismabookmark(pinak);
        }

        //
        // EVENT : 
        //
        private void Delete1Bookmark_Click(object sender, EventArgs e)
        {

        }


    }
}
