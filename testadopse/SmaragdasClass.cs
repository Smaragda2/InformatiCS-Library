﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testadopse
{
    class SmaragdasClass
    {
        string article = null;
        /// <summary>
        /// Parameters:
        /// <para>PrintDialog sent the existing printDialog.</para>
        /// <para>PrintDocument sent the existing printDocument.</para>
        /// <para>title sent the Label that have the Lemma tilte.</para>
        /// <para>content sent the Label tha have the Lemma content.</para>
        /// </summary>
        public void PrintLemma(PrintDialog printDialog1, PrintDocument printDocument1, Label title,Label content)
        {
            article = title.Text + "\n" + content.Text;
            printDialog1.Document = printDocument1;

            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }
        /// <summary>
        /// Call this method in printDocument1_PrintPage event.
        /// <para>Paramaters is the same with the event method.</para>
        /// </summary>
        public void PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawString(article, new Font("Arial", 14, FontStyle.Bold), Brushes.Black, 150, 125);
        }

    }
}
