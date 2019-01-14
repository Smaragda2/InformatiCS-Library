using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace testadopse
{
    public partial class Form1 : Form
    {
        int panelwidth = 170; //Metabliti gia na me boithisei sto timer
        bool Hidden;           //Metabliti gia na me boithisei sto timer

        // ***************************************************************************
        // Methodos gia na ginei h efarmogh me kyklikes gwnies
        // ***************************************************************************


        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );



        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            Hidden = false;
            HomeB.BackColor = HeaderP.BackColor;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        // ***************************************************************************
        // Ta Koumpia tou Menou
        // ***************************************************************************


        private void OptionsB_Click(object sender, EventArgs e)
        {
            timer.Start();
        }


        private void HomeB_Click(object sender, EventArgs e)
        {
            testadopse.UserControls.Homepage hp = new testadopse.UserControls.Homepage();
            ContentP.Controls.Add(hp);
            hp.Dock = DockStyle.Fill;
            hp.BringToFront();
            ChangeColour(HomeB, e);
        }


        private void CategoriesB_Click(object sender, EventArgs e)
        {
            testadopse.UserControls.CategoriesUC cp = new testadopse.UserControls.CategoriesUC();
            ContentP.Controls.Add(cp);
            cp.Dock = DockStyle.Fill;
            cp.BringToFront();
            ChangeColour(CategoriesB, e);
        }


        private void HistoryB_Click(object sender, EventArgs e)
        {
            testadopse.UserControls.HistoryUC hep = new testadopse.UserControls.HistoryUC();
            ContentP.Controls.Add(hep);
            hep.Dock = DockStyle.Fill;
            hep.BringToFront();
            ChangeColour(HistoryB, e);
        }


        private void HelpB_Click(object sender, EventArgs e)
        {
            testadopse.UserControls.Help hip = new testadopse.UserControls.Help();
            ContentP.Controls.Add(hip);
            hip.Dock = DockStyle.Fill;
            hip.BringToFront();
            ChangeColour(HelpB, e);
        }


        private void ContactB_Click(object sender, EventArgs e)
        {
            testadopse.UserControls.ContactUC cp = new testadopse.UserControls.ContactUC();
            ContentP.Controls.Add(cp);
            cp.Dock = DockStyle.Fill;
            cp.BringToFront();
            ChangeColour(ContactB, e);
        }


        private void TermsB_Click(object sender, EventArgs e)
        {
            testadopse.UserControls.Terms tp = new testadopse.UserControls.Terms();
            ContentP.Controls.Add(tp);
            tp.Dock = DockStyle.Fill;
            tp.BringToFront();
            ChangeColour(TermsB, e);
        }


        private void AboutB_Click(object sender, EventArgs e)
        {
            testadopse.UserControls.AboutUC ap = new testadopse.UserControls.AboutUC();
            ContentP.Controls.Add(ap);
            ap.Dock = DockStyle.Fill;
            ap.BringToFront();
            ChangeColour(AboutB, e);          
        }




        // ***************************************************************************
        // Ta koympia elaxistopoihshs/megenthinsis/kleisimatos                      
        //****************************************************************************


        private void Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        private void Maximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                this.FormBorderStyle = FormBorderStyle.None;
                Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
                this.FormBorderStyle = FormBorderStyle.None;
                Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            }
        }
        

        private void Close_Click(object sender, EventArgs e)
        {
            //timer1.Start();
            Application.Exit();
        }


        // ***************************************************************************
        // Medothos gia na allazei xrwma toy koumpi pou patithike
        // ***************************************************************************


        private void ChangeColour(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            HomeB.BackColor = MenuP.BackColor;
            HelpB.BackColor = MenuP.BackColor;
            CategoriesB.BackColor = MenuP.BackColor;
            AboutB.BackColor = MenuP.BackColor;
            ContactB.BackColor = MenuP.BackColor;
            HistoryB.BackColor = MenuP.BackColor;
            TermsB.BackColor = MenuP.BackColor;

            if (b.BackColor == MenuP.BackColor)
            {
                b.BackColor = HeaderP.BackColor;
            }         
        }



        // ***************************************************************************
        //  Timer gia na anoigokleinei to Menu
        // ***************************************************************************


        private void timer_Tick(object sender, EventArgs e)
        {
            if (Hidden)
            {
                MenuP.Width = MenuP.Width + 16;
                if (MenuP.Width >= panelwidth)
                {
                    timer.Stop();
                    Hidden = false;
                    this.Refresh();
                }
            }
            else
            {
                MenuP.Width = MenuP.Width - 16;
                if (MenuP.Width <= 42)
                {
                    timer.Stop();
                    Hidden = true;
                    this.Refresh();
                }
            }
         
        }



        // ***************************************************************************
        // Timer1 gia na kleinei to app siga siga
        // ***************************************************************************


        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity > 0.0)
            {
                this.Opacity -= 0.050;
            }
            else
            {
                timer1.Stop();
                Application.Exit();
            }
        }

 
    }
}
