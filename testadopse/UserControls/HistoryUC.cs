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
    public partial class HistoryUC : UserControl
    {

        public Label[] labels;
        static string hdate;
        static int help1 = 0;
        static int megethos;

        string[] deletehistoryname;
        string[] deletehistorytimestamp;
        bool[] deletebool;

        testadopse.ClassOfStaticMethods cosm = new ClassOfStaticMethods();

        string[] deletehistory;

        public HistoryUC()
        {
            InitializeComponent();
           

        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox1.ForeColor = Color.Black;
        }

        private void HistoryUC_Load(object sender, EventArgs e)
        {
            // testadopse.UserControls.ViewUC vc = new ViewUC();
            // testadopse.ClassOfStaticMethods cosm = vc.getclassOfStaticMethods() as ClassOfStaticMethods;
            
            string[] pinakas = cosm.getAllHistory();
            gemismahistory(pinakas);
            megethos = 0;
        }

    
    //
    //          Methodos morfopoihshs toy History 
    //

    public void gemismahistory(string[] pinakas)
        {
            labels = new Label[pinakas.Length];
            pinakas = revertpinaka(pinakas);
            Button x = new Button();

            help1 = 0;
            for (int i = 0; i < pinakas.Length; i++)
            {
                labels[i] = new Label();
                Label historydate = new Label();
                Label historyday = new Label();
                Label historymonth = new Label();
                Label historyyear = new Label();
                Label historytime = new Label();
                Label historyhelp = new Label();
                Label historylemma = new Label();
                CheckBox cb = new CheckBox();
                labels[i].Text = pinakas[i].ToString();

                
                string[] data2 = labels[i].Text.Split(',');

                Lemma lemma = new Lemma();
                int id;
                Int32.TryParse(data2[0], out id);
                labels[i].Text = lemma.getLemmaNamebyLemmaID(id);


                string[] split = data2[1].Split(' ');
                string[] split2 = split[0].Split('-');
                string[] splitTime = split[1].Split(':');

                historyday.Text = split2[0];
                historymonth.Text = split2[1];
                historymonth.Text = setmhnas(historymonth.Text);
                historyyear.Text = split2[2];
                
                historydate.Text = historyday.Text + " & " + historymonth.Text + " & " + historyyear.Text;         
                //string[] data = labels[i].Text.Split(' ');
                historytime.Text = splitTime[0]+":"+splitTime[1];

                //var result = labels[i].Text.Substring(labels[i].Text.LastIndexOf(',') + 1);
                historylemma.Text = labels[i].Text.ToString();


                if (historyday.Text != hdate)
                {
                    historydate.ForeColor = System.Drawing.Color.FromArgb(128, 128, 255);
                    historydate.Font = new Font("Century Gothic", 20, FontStyle.Underline );
                    historydate.AutoSize = true;
                    if (help1 == 0) { historydate.Location = new Point(320, help1 + 10); help1 += 20; }
                    else { historydate.Location = new Point(320, help1 + 50); help1 += 70; }
                    panel2.Controls.Add(historydate);
                    
                }

                historytime.ForeColor = System.Drawing.Color.Black;
                historytime.Font = new Font("Century Gothic", 12);
                historytime.AutoSize = true;
                historytime.Location = new Point(220, help1 + 50);
                historytime.Name = "historytime_" + i + 1;
                panel2.Controls.Add(historytime);

                historylemma.ForeColor = System.Drawing.Color.Green;
                historylemma.Font = new Font("Century Gothic", 12);
                historylemma.AutoSize = true;
                historylemma.Location = new Point(350, help1 + 50);
                historylemma.Name = "historylemma_" + i + 1;
                panel2.Controls.Add(historylemma);

                cb.Location = new Point(150, help1 + 50);
                cb.CheckStateChanged += ChkBox_CheckedChanged;
                cb.Name = "cb_" + i + 1;
                panel2.Controls.Add(cb);

                string directory = System.IO.Directory.GetCurrentDirectory();
                string[] splitDir = directory.Split('\\');
                if (splitDir[splitDir.Length - 1] == "Debug")
                {
                    System.IO.Directory.SetCurrentDirectory("..\\..");
                }

                x.Location = new Point(800, help1 + 50);
                x.Text = null;
                x.Name = "x_" + (i + 1);
                x.Size = new Size(30, 25);
                x.FlatStyle = FlatStyle.Flat;
                x.FlatAppearance.BorderSize = 0;
                x.Image = Image.FromFile(System.IO.Directory.GetCurrentDirectory()+ "\\Resources\\warning_Icon.png");
                x.ImageAlign = ContentAlignment.MiddleRight;
                x.Click += x_click;
                panel2.Controls.Add(x);

                hdate = historyday.Text;
                help1 += 40;
                panel2.Refresh();
            }
        }


        //
        //    Antistrofh toy pinaka gia na emfanizetai to istoriko apo neotero se palaiotero
        //
        
        public string[] revertpinaka(string[] pinaka)
        {
            string[] pinakas2 = new string[pinaka.Length];
            int x = pinaka.Length;
            deletehistoryname = new string[pinaka.Length];
            deletehistorytimestamp = new string[pinaka.Length];
            deletebool = new bool[pinaka.Length];


            for (int i = 0; i < pinakas2.Length; i++)
            {
                pinakas2[i] = pinaka[x - i - 1];
                var result = pinakas2[i].Substring(pinakas2[i].LastIndexOf(',') + 1);
                deletehistoryname[i] = result.ToString();
                deletebool[i] = false;
                string[] data = pinakas2[i].Split(',');
                deletehistorytimestamp[i] = data[0];
            }

            return pinakas2;
        }


        //
        //     Methodos gia na pairnw to mhna apo noumero se tex! Paradeigma (to 1 ginetai Ianouariou)
        //

        public string setmhnas(string str)
        {
            string mhnas = str;
            switch (str)
            {
                case "1":
                case "Jan":
                    mhnas = "Ιανουαρίου";
                    break;
                case "2":
                case "Feb":
                    mhnas = "Φεβρουαρίου";
                    break;
                case "3":
                case "Mar":
                    mhnas = "Μαρτίου";
                    break;
                case "4":
                case "Apr":
                    mhnas = "Απριλίου";
                    break;
                case "5":
                case "May":
                    mhnas = "Μαίου";
                    break;
                case "6":
                case "Jun":
                    mhnas = "Ιουνίου";
                    break;
                case "7":
                case "Jul":
                    mhnas = "Ιουλίου";
                    break;
                case "8":
                case "Aug":
                    mhnas = "Αυγούστου";
                    break;
                case "9":
                case "Sep":
                    mhnas = "Σεπτεμβρίου";
                    break;
                case "10":
                case "Oct":
                    mhnas = "Οκτωβρίου";
                    break;
                case "11":
                case "Nov":
                    mhnas = "Νοεβρίου";
                    break;
                case "12":
                case "Dec":
                    mhnas = "Δεκεμβρίου";
                    break;
            }
            return mhnas;
        }
            //
            //    Methodos gia na spaw to string kai na pairnw auta pou thelw 
            //
            public static string Between(string value, string a, string b)
        {
            int posA = value.IndexOf(a, +1);
            int posB = value.IndexOf(b);
            if (posA == -1)
            {
                return "";
            }
            if (posB == -1)
            {
                return "";
            }
            int adjustedPosA = posA + a.Length;
            if (adjustedPosA >= posB)
            {
                return "";
            }
            return value.Substring(adjustedPosA, posB - adjustedPosA);
        }

        //
        //    Methodos gia na spaw to string kai na pairnw auta pou thelw 
        //

        public static string Between2(string value, string a, string b)
        {
            int posA = value.LastIndexOf(a);
            int posB = value.IndexOf(b);
            if (posA == -1)
            {
                return "";
            }
            if (posB == -1)
            {
                return "";
            }
            int adjustedPosA = posA + a.Length;
            if (adjustedPosA >= posB)
            {
                return "";
            }
            return value.Substring(adjustedPosA, posB - adjustedPosA);
        }

        private void DeleteB_Click(object sender, EventArgs e)
        {
            if (DeleteAll.Checked) { cosm.DeleteAllHistory(); panel2.Controls.Clear(); }
            if (DeleteHour.Checked) { cosm.DeleteHistoryBeforeOneHour(); this.Refresh(); }
            if (DeleteDay.Checked) { cosm.DeleteHistoryBeforeOneDay(); this.Refresh(); }         
        }

        private void ChkBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox ChkBox = sender as CheckBox;
            var result3 = ChkBox.Name.Substring(ChkBox.Name.LastIndexOf('_') + 1);
            string arithmos = result3.ToString();


            if (ChkBox.Checked == true)
            {
                //deletehistory[megethos] = arithmos;
            }
        }

        private void x_click(Object sender,EventArgs e)
        {
            Button x2 = new Button();
            string results3 = x2.Name.Substring(x2.Name.LastIndexOf('_') + 1);
            int arithmos = Int32.Parse(results3);
            arithmos = arithmos - 1;
            Lemma lm = new Lemma();
            int deleteHistorylemmaid = lm.getLemmaIDbyLemmaName(deletehistoryname[arithmos]);
            cosm.delete_history_keep_lemma_record(deleteHistorylemmaid, deletehistorytimestamp[arithmos]);

            panel2.Controls.Clear();
            HistoryUC_Load(sender, e);
        }
    }
}
