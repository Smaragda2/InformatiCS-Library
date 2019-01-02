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
        int panelwidth = 170 ; //Metabliti gia na me boithisei sto timer
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
            homeUC1.BringToFront();
            Hidden = false; 




        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        // ***************************************************************************
        // Ta Koumpia tou Menou
        // ***************************************************************************


        private void ContactB_Click(object sender, EventArgs e)
        {
            contactUC1.BringToFront();
            ChangeColour(ContactB, e);

        }

        private void OptionsB_Click(object sender, EventArgs e)
        {

            timer.Start();


        }

        private void HomeB_Click(object sender, EventArgs e)
        {
            homeUC1.BringToFront();
            ChangeColour(HomeB, e);


        }

        private void AboutB_Click(object sender, EventArgs e)
        {
            aboutUC1.BringToFront();
            ChangeColour(AboutB, e);
            
        }

        private void CategoriesB_Click(object sender, EventArgs e)
        {
            categoriesUC1.BringToFront();
            ChangeColour(CategoriesB, e);

        }

        private void HelpB_Click(object sender, EventArgs e)
        {
            help1.BringToFront();
            ChangeColour(HelpB, e);
        }

        private void HistoryB_Click(object sender, EventArgs e)
        {
            historyUC1.BringToFront();
            ChangeColour(HistoryB, e);
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
            timer1.Start();
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
            button2.BackColor = MenuP.BackColor;

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
                MenuP.Width = MenuP.Width + 10;
                if (MenuP.Width >= panelwidth)
                {
                    timer.Stop();
                    Hidden = false;
                    this.Refresh();
                }
            }
            else
            {
                MenuP.Width = MenuP.Width - 10;
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
