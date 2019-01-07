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
    public partial class HistoryUC : UserControl
    {

        public Label[] labels;

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
            panel2.Controls.Clear();
            testadopse.UserControls.ViewUC vc = new ViewUC();

            testadopse.ClassOfStaticMethods cosm = vc.getclassOfStaticMethods() as ClassOfStaticMethods;
            string[] pinakas = cosm.getAllHistory();
            gemismahistory(pinakas);
        }

        public void gemismahistory(string[] pinakas)
        {
            labels = new Label[pinakas.Length];
            for (int i=0; i<pinakas.Length; i++)
            {
                labels[i] = new Label();
                labels[i].Text = pinakas[i].ToString();
                labels[i].ForeColor = System.Drawing.Color.FromArgb(128, 128, 255);
                labels[i].Font = new Font("Century Gothic", 15, FontStyle.Bold);
                labels[i].Location = new Point(60, i * 80);
                panel2.Controls.Add(labels[i]);
                panel2.Refresh();
            }
        }
    }
}
