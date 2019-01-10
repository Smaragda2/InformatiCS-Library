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
        static int x;
        string lemmatext;
        string lemmaname;

        public ViewUC()
        {
            InitializeComponent();
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

        public void search1()
        {
            panel2.Controls.Clear();
            string[] pinakas = lm.Search(textBox1.Text);
            gemismalabel(pinakas);
        }


        //
        // Methodos gia dhmiourgia label kai morfopoihsh tous, apo ton pinaka pou epestrepse to search()
        //

        public Label[] gemismalabel(string[] pinakas)
        {
            labels = new Label[pinakas.Length];

            if (pinakas.Length > 0)
            {
                int i = 0;
                foreach(string pinaka in pinakas)
                {
                    labels[i] = new Label();
                    labels[i].Text = pinaka;
                    labels[i].ForeColor = System.Drawing.Color.FromArgb(128, 128, 255);
                    labels[i].Font = new Font("Century Gothic", 15, FontStyle.Bold);
                    labels[i].Location = new Point(40, i * 80 + 10);
                    labels[i].Click += label_Click;
                    labels[i].MouseEnter += OnMouseEnter;
                    labels[i].MouseLeave += OnMouseLeave;
                    panel2.Controls.Add(labels[i]);
                    panel2.Refresh();
                    i++;
                }
            }
            else
            {
                Label nolemma = new Label();
                nolemma.Text = "Η αναζήτηση - " + textBox1.Text + " - δεν βρήκε κάποιο έγγραφο .";
                nolemma.ForeColor = System.Drawing.Color.Black;
                nolemma.Font = new Font("Century Gothic", 16);
                panel2.Controls.Add(nolemma);
                nolemma.Location = new Point(100, 20);
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
                    pictureBox.Image = Image.FromFile(pinakas[i]);
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
            ViewLemma vl = new ViewLemma();
            Lemma lmid = new Lemma();


            panel2.Controls.Clear();
            panel2.Controls.Add(vl);
            vl.Dock = DockStyle.Fill;
            vl.lemman.Text = lbl.Text;
            setlemmaname(lbl.Text);
            vl.lemmat.Text = lm.GetLemmaContent(lbl.Text);
            setlemmatext(vl.lemmat.Text);


            addhistory(lmid, lbl); // Epidh exei epilegei na anoiksei to label klisei tis methodou addhistory
                                   // des pio katw gia thn methodo . 


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
        // EVENT: Otan patietai to koumpi export kai exei epilexthei ena lemma, kanei EXPORT to lema 
        //

        private void exportB_Click(object sender, EventArgs e)
        {
            if (lemmatext != null) lm.navigate_where_to_export_pdf_text_only(lemmatext);
            else MessageBox.Show("Δεν έχετε επιλέξει λήμμα");
        }

        //
        // EVENT: Otan patietai to koumpi bookmark kai exei epilexthei ena lemma, apothikeuei to lemma sto BOOKMARK
        //

        private void bookmarkB_Click(object sender, EventArgs e)
        {
            Lemma lmid = sender as Lemma;
            if (lemmatext != null) lm.add_to_bookmark(lemmaname, lemmaname); 
            else MessageBox.Show("Δεν έχετε επιλέξει λήμμα");       
        }

        //
        // EVENT: Otan patietai to koumpi print kai exei epilexthei ena lemma, ektupwnei to lemma
        //

        private void PrintB_Click(object sender, EventArgs e)
        {
            LemmaMedia lm = new LemmaMedia();
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

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Label lname = new Label();
            Label ltext = new Label();
            lname.Text = lemmaname;
            ltext.Text = lemmatext;

            lm.PrintPage(sender, e, lname, ltext);
        }
    }
}
