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
        public ViewUC()
        {
            InitializeComponent();
        }

        private void ViewUC_Load(object sender, EventArgs e)
        {

        }

        public void textboxtext(string text)
        {
            if (text == "" || text == "Κάντε αναζήτηση λήμματος ") textBox1.Text = " Δεν εχετει εισάγει τίποτα ";
            else textBox1.Text = text;
        }

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

        public Label[] gemismalabel(string[] pinakas)
        {
            labels = new Label[pinakas.Length];
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


        public void SearchImages(string[] pinakas)
        {
            for (int i = 0; i < pinakas.Length; i++)
            {
                string[] pinakas2 = lm.GetLemmaImagesPath(pinakas[i].ToString());
                gemismaimages(pinakas2);
            }

        }
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

        private void SearchB_Click(object sender, EventArgs e)
        {
            string[] pinakas = search();
            gemismalabel(pinakas);
            SearchImages(pinakas);
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        public void label_Click(object sender, EventArgs e)
        {
            Label lbl = sender as Label;
            ViewLemma vl = new ViewLemma();
            Lemma lmid = new Lemma();


            panel2.Controls.Clear();
            panel2.Controls.Add(vl);
            vl.Dock = DockStyle.Fill;
            vl.lemman.Text = lbl.Text;
            vl.lemmat.Text = lm.GetLemmaContent(lbl.Text);
            setlemmatext(vl.lemmat.Text);


            addhistory(lmid, lbl);


        }

        public void setlemmatext(string ltext)
        {
            lemmatext = ltext;
        }

        public string getlemmatext()
        {
            return lemmatext;
        }

        public void addhistory(object lemma, object lemmaname)
        {
            Lemma lmid = lemma as Lemma;
            Label lbl = lemmaname as Label;
           // cm.addLemmaToHistory(lmid.getLemmaIDbyLemmaName(lbl.Text));

            cm.addLemmaToHistory(5);

        }

        public object getclassOfStaticMethods()
        {
            return cm;
        }

        private void OnMouseEnter(object sender, EventArgs e)
        {
            Label label1 = sender as Label;
            label1.Font = new Font(label1.Font.Name, label1.Font.SizeInPoints, FontStyle.Underline | FontStyle.Bold );         
        }

        private void OnMouseLeave(object sender, EventArgs e)
        {
            Label label1 = sender as Label;
            label1.Font = new Font(label1.Font.Name, label1.Font.SizeInPoints, FontStyle.Bold);
        }

        private void exportB_Click(object sender, EventArgs e)
        {
            if (lemmatext != null) lm.navigate_where_to_export_pdf_text_only(lemmatext);
            else MessageBox.Show("Δεν εχετε επιλεξει λημμα");
        }

        private void bookmarkB_Click(object sender, EventArgs e)
        {

        }

        private void PrintB_Click(object sender, EventArgs e)
        {

        }
    }
}
