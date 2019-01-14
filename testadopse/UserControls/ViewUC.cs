using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InformaticsModel;

namespace testadopse.UserControls
{
    public partial class ViewUC : UserControl
    {
        static LemmaMedia lm = new LemmaMedia();
        static testadopse.ClassOfStaticMethods cm = new ClassOfStaticMethods();
        public Label[] labels;
        ViewLemma vl;
        static int x;
        bool hide2;
        static bool bookmarkb = false;
        string lemmatext;
        string lemmaname;

        public ViewUC()
        {
            InitializeComponent();
            ExportP.Hide();
            hide2 = true;
        }

        private void ViewUC_Load(object sender, EventArgs e)
        {

        }

        //
        //   Methodos gia na pairnei to text apo thn arxikh othoni kai na einai idio otan anoigei
        //

        public void textboxtext(string text)
        {
            if (text == "" || text == "Κάντε αναζήτηση λήμματος ") textBox1.Text = " Δεν εχετει εισάγει τίποτα ";
            else textBox1.Text = text;
        }

        //
        //  Methodos gia na kanei search analoga me to ti yparxei sto textbox
        //

        public string[] search()
        {
            panel2.Controls.Clear();
            string[] pinakas = lm.Search(textBox1.Text);
            return pinakas;
        }


        //
        // Methodos gia dhmiourgia label kai morfopoihsh tous, apo ton pinaka pou epestrepse to search()
        //

        public Label[] gemismalabel(string[] pinakas)
        {
            labels = new Label[pinakas.Length];
            Panel p = new Panel();
            if (pinakas.Length > 0)
            {
                for (int i = 0; i < pinakas.Length; i++)
                {
                    labels[i] = new Label();
                    labels[i].Text = pinakas[i].ToString();
                    labels[i].ForeColor = System.Drawing.Color.FromArgb(128, 128, 255);
                    labels[i].Font = new Font("Century Gothic", 15, FontStyle.Bold);
                    labels[i].Location = new Point(40, i * 80 + 10);
                    labels[i].Click += label_Click;
                    labels[i].MouseEnter += OnMouseEnter;
                    labels[i].MouseLeave += OnMouseLeave;
                    panel2.Controls.Add(labels[i]);
                    panel2.Refresh();
                }
                Label lbl2 = new Label();
                lbl2.Location = new Point(40, pinakas.Length * 80 );

                panel2.Controls.Add(lbl2);
                Panel selidopoihshpanel = new Panel();
                selidopoihshpanel.Size = new Size(36, 100);
                //selidopoihshpanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                selidopoihshpanel.BackColor = Color.White;
                selidopoihshpanel.Dock = DockStyle.Bottom;

                Button previouspage = new Button();
                Button nextpage = new Button();

                previouspage.Size = new Size(50, 50);
                previouspage.Location = new Point(350, 10);
                //previouspage.BackColor = Color.White;
                //previouspage.ForeColor = Color.White;
                previouspage.FlatStyle = FlatStyle.Flat;
                previouspage.FlatAppearance.BorderSize = 0;
                previouspage.Image = Image.FromFile(Application.StartupPath + "\\Resources\\back.png");
                

                nextpage.Size = new Size(50, 50);
                nextpage.Location = new Point(850, 10);
                //nextpage.ForeColor = Color.White;
                //nextpage.BackColor = Color.White;
                nextpage.FlatStyle = FlatStyle.Flat;
                nextpage.FlatAppearance.BorderSize = 0;
                nextpage.Image = Image.FromFile(Application.StartupPath + "\\Resources\\forward.png");

                Label name = new Label();
                name.Text = "Informatics Library ";
                name.AutoSize = true;
                name.ForeColor = System.Drawing.Color.FromArgb(50, 126, 241);
                name.Location = new Point(520, 0);
                name.Font = new Font("Century Gothic", 18, FontStyle.Regular);

                Label previous = new Label();
                previous.Text = "previous";
                previous.AutoSize = true;
                previous.ForeColor = System.Drawing.Color.FromArgb(50, 126, 241);
                previous.Location = new Point(350, 65);
                previous.Font = new Font("Century Gothic", 8, FontStyle.Underline);

                Label next = new Label();
                next.Text = "next";
                next.AutoSize = true;
                next.ForeColor = System.Drawing.Color.FromArgb(50, 126, 241);
                next.Location = new Point(860, 65);
                next.Font = new Font("Century Gothic", 8, FontStyle.Underline);

                Button[] pages = new Button[pinakas.Length];
                for (int i = 0; i < pinakas.Length; i++)
                {
                    pages[i] = new Button();
                    pages[i].Text = (i + 1).ToString();
                    pages[i].FlatStyle = FlatStyle.Flat;
                    pages[i].FlatAppearance.BorderSize = 0;
                    pages[i].ForeColor = Color.Black;
                    pages[i].Size = new Size(30, 30);
                    pages[i].Location = new Point(550 + i * 30, 30);
                    selidopoihshpanel.Controls.Add(pages[i]);

                }

                selidopoihshpanel.Controls.Add(previous);
                selidopoihshpanel.Controls.Add(next);
                selidopoihshpanel.Controls.Add(name);
                selidopoihshpanel.Controls.Add(previouspage);
                selidopoihshpanel.Controls.Add(nextpage);
                panel2.Controls.Add(selidopoihshpanel);


            }
            else
            {
                Label nolemma = new Label();
                nolemma.Text = "Η αναζήτηση - " + textBox1.Text + " - δεν βρήκε κάποιο έγγραφο .";
                nolemma.ForeColor = System.Drawing.Color.Black;
                nolemma.Font = new Font("Century Gothic", 16);
                panel2.Controls.Add(nolemma);
                nolemma.Location = new Point(160, 20);
                nolemma.AutoSize = true;
                nolemma.Refresh();
            }
            return labels;
        }


        //
        //  Methodos gia na kanei searchimage() analoga me to lemmaname
        //***************************************************************
        // ****(DEN EXEI TESTARISTEI GIATI DEN YPARXAN EIKONES)****
        //***************************************************************

        public void SearchImages(string[] pinakas)
        {
            for (int i = 0; i < pinakas.Length; i++)
            {
                string[] pinakas2 = lm.GetLemmaImagesPath(pinakas[i].ToString());
                gemismaimages(pinakas2);
            }

        }


        //
        //  Methodos gia na dhmioyrgei 
        //***************************************************************
        // ****(DEN EXEI TESTARISTEI GIATI DEN YPARXAN EIKONES)****
        //***************************************************************

        public void gemismaimages(string[] pinakas)
        {
            PictureBox pictureBox = new PictureBox();
            if (pinakas.Length > 0)
            {
                for (int i = 0; i < pinakas.Length; i++)
                {
                    pictureBox = new PictureBox();
                    pictureBox.Image = Image.FromFile(System.IO.Directory.GetCurrentDirectory()+pinakas[i]);
                    pictureBox1.Location = new Point(250, x);
                    x += 80;
                    panel2.Controls.Add(pictureBox);
                    panel2.Refresh();
                }
            }


        }


        //
        //  EVENT : Otan patietai to buttonsearch na kanei anazhthsh me bash toy textbox
        //

        private void SearchB_Click(object sender, EventArgs e)
        {
            string[] pinakas = search();
            gemismalabel(pinakas);
            SearchImages(pinakas);
        }


        //
        // EVENT : Otan klikarei panw sto textbox na sbhnetai to keimeno
        //

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }


        //
        // EVENT: Otan ginetai klik se ena lemmaname na emfanizei to lemma kai to periexomeno tou
        //

        public void label_Click(object sender, EventArgs e)
        {
            Label lbl = sender as Label;
            vl = new ViewLemma();
            Lemma lmid = new Lemma();
            bool yparxei;


            panel2.Controls.Clear();
            panel2.Controls.Add(vl);
            vl.Dock = DockStyle.Fill;
            vl.lemman.Text = lbl.Text;
            setlemmaname(lbl.Text);
            vl.lemmat.Text = lm.GetLemmaContent(lbl.Text);
            setlemmatext(vl.lemmat.Text);
            
            
            addhistory(lmid, lbl); // Epeidh exei epilegei na anoiksei to label klisei tis methodou addhistory
                                   // des pio katw gia thn methodo . 


            yparxei = checkbookmark();
            if (yparxei == true) ΒookmarkB.Image = Image.FromFile(Application.StartupPath + "\\Resources\\bookmarked.png");
            // x.Image = Image.FromFile(Application.StartupPath + "\\Resources\\warning_Icon.png");
            //MessageBox.Show("Το λήμμα υπάρχει ήδη στο bookmark");


        }

        public void setlemmaname(string lname)
        {
            lemmaname = lname;
        }

        public string getlemmaname()
        {
            return lemmaname;
        }

        public void setlemmatext(string ltext)
        {
            lemmatext = ltext;
        }

        public string getlemmatext()
        {
            return lemmatext;
        }


        //
        //  Methodos pou eisagei to klikarismeno label sto istoriko .
        //

        public void addhistory(object lemma, object lemmaname2)
        {
            Lemma lmid = lemma as Lemma;
            Label lbl = lemmaname2 as Label;
            cm.addLemmaToHistory(lmid.getLemmaIDbyLemmaName(lbl.Text));
        }

        public object getclassOfStaticMethods()
        {
            return cm;
        }

        //
        // EVENT : Otan o korsoras dhxnei to lemma na upogramizetai
        //

        private void OnMouseEnter(object sender, EventArgs e)
        {
            Label label1 = sender as Label;
            label1.Font = new Font(label1.Font.Name, label1.Font.SizeInPoints, FontStyle.Underline | FontStyle.Bold );         
        }

        //
        //  EVENT: Otan feugei o korsora to lemma na ginetai kanoniko
        //

        private void OnMouseLeave(object sender, EventArgs e)
        {
            Label label1 = sender as Label;
            label1.Font = new Font(label1.Font.Name, label1.Font.SizeInPoints, FontStyle.Bold);
        }

        //
        // EVENT: Otan patietai to koumpi export kai exei epilexthei ena lemma, anoigei tis epiloges gia to EXPORT
        //

        private void exportB_Click(object sender, EventArgs e)
        {
            if (lemmatext != null)
            {
                if (hide2)
                {
                    ExportP.Visible = true;
                    hide2 = false;
                }
                else
                {
                    ExportP.Visible = false;
                    hide2 = true;
                }
            }
           
            else MessageBox.Show("Δεν έχετε επιλέξει λήμμα");
        }

        //
        // EVENT: Otan patietai to koumpi bookmark kai exei epilexthei ena lemma, apothikeuei to lemma sto BOOKMARK
        //

        private void bookmarkB_Click(object sender, EventArgs e)
        {
            this.Refresh();
            Button btn = sender as Button;
            bool uparxei = false;
            if (lemmatext != null)
            {
                uparxei = checkbookmark();
                if (uparxei == true) MessageBox.Show("Το λήμμα υπάρχει ήδη στο bookmark");
                else { lm.add_to_bookmark(lemmaname, lemmaname); ΒookmarkB.Image = Image.FromFile(Application.StartupPath + "\\Resources\\bookmarked.png"); }
                }
            else MessageBox.Show("Δεν έχετε επιλέξει λήμμα");
            
        }

        private bool checkbookmark()
        {
            bookmarkb = false;
            string[] pinakas = cm.GetAllBookmarks();
            for (int i = 0; i < pinakas.Length; i++)
            {
                if (pinakas[i].Substring(pinakas[i].LastIndexOf(',') + 1) == lemmaname){ bookmarkb = true; i = pinakas.Length; }
                
            }
            return bookmarkb;           
        }

        //
        // EVENT: Otan patietai to koumpi print kai exei epilexthei ena lemma, ektupwnei to lemma
        //

        private void PrintB_Click(object sender, EventArgs e)
        {
            LemmaMedia lm = new LemmaMedia();
            Label lname = new Label();
            Label ltext = new Label();

            if (lemmatext != null) lm.Print(printDialog1, printDocument1);
            else MessageBox.Show("Δεν έχετε επιλέξει λήμμα");

        }

        //
        // EVENT: Otan patietai to koumpi ENTER mesa sto textbox, na ginetai anazhthsh me to bash to textbox
        //

        private void enter_click(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SearchB_Click(this, new EventArgs());
            }
        }

        //
        // EVENT : Otan patithei to koympi SAVE apo to EXPORT, na kanei save to epilegmeno lemma
        //
        private void Save_Click(object sender, EventArgs e)
        {
            ExportP.Hide();
            lm.navigate_where_to_export_pdf_text_only(lemmatext);
        }
        //
        // EVENT : Otan patithei to koympi SAVE apo to EXPORT, na kanei open + save to epilegmeno lemma
        //
        private void Open_Click(object sender, EventArgs e)
        {
            ExportP.Hide();
            lm.navigate_where_to_export_pdf_text_only(lemmatext);
            lm.open_pdf(lm.getlast_saved_pdf_path());
        }
        //
        //
        //
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //panel2.getComponents()).contains(ViewLemma);
            if (panel2.Contains(vl)) SearchB_Click(sender, e);
            ΒookmarkB.Image = Image.FromFile(Application.StartupPath + "\\Resources\\bookmark.png");
            lemmatext = null;
        }

        private void ExportP_MouseLeave(object sender, EventArgs e)
        {
            ExportP.Visible = false;
        }

        public void viewlemma_added(object sender,EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            LemmaMedia lm = new LemmaMedia();
            Label lname = new Label();
            Label ltext = new Label();
            lname.Text = lemmaname;
            ltext.Text = lemmatext;

            lm.PrintPage(sender, e, lname, ltext);
        }
    }
}
