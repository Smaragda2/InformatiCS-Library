namespace testadopse.UserControls
{
    partial class ViewUC
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewUC));
            this.panel1 = new System.Windows.Forms.Panel();
            this.ExportP = new System.Windows.Forms.Panel();
            this.Save = new System.Windows.Forms.Button();
            this.Open = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ExportB = new System.Windows.Forms.Button();
            this.PrintB = new System.Windows.Forms.Button();
            this.ΒookmarkB = new System.Windows.Forms.Button();
            this.SearchB = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.panel1.SuspendLayout();
            this.ExportP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.ExportP);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.ExportB);
            this.panel1.Controls.Add(this.PrintB);
            this.panel1.Controls.Add(this.ΒookmarkB);
            this.panel1.Controls.Add(this.SearchB);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1092, 70);
            this.panel1.TabIndex = 0;
            // 
            // ExportP
            // 
            this.ExportP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ExportP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ExportP.Controls.Add(this.Save);
            this.ExportP.Controls.Add(this.Open);
            this.ExportP.Location = new System.Drawing.Point(944, 4);
            this.ExportP.Name = "ExportP";
            this.ExportP.Size = new System.Drawing.Size(99, 60);
            this.ExportP.TabIndex = 0;
            this.ExportP.MouseLeave += new System.EventHandler(this.ExportP_MouseLeave);
            // 
            // Save
            // 
            this.Save.Dock = System.Windows.Forms.DockStyle.Top;
            this.Save.FlatAppearance.BorderSize = 0;
            this.Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Save.ForeColor = System.Drawing.Color.Black;
            this.Save.Location = new System.Drawing.Point(0, 30);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(97, 30);
            this.Save.TabIndex = 1;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Open
            // 
            this.Open.Dock = System.Windows.Forms.DockStyle.Top;
            this.Open.FlatAppearance.BorderSize = 0;
            this.Open.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Open.ForeColor = System.Drawing.Color.Black;
            this.Open.Location = new System.Drawing.Point(0, 0);
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(97, 30);
            this.Open.TabIndex = 0;
            this.Open.Text = "Open";
            this.Open.UseVisualStyleBackColor = true;
            this.Open.Click += new System.EventHandler(this.Open_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 69);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1092, 1);
            this.panel3.TabIndex = 13;
            // 
            // ExportB
            // 
            this.ExportB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ExportB.BackColor = System.Drawing.Color.White;
            this.ExportB.FlatAppearance.BorderSize = 0;
            this.ExportB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExportB.Image = ((System.Drawing.Image)(resources.GetObject("ExportB.Image")));
            this.ExportB.Location = new System.Drawing.Point(1038, 12);
            this.ExportB.Name = "ExportB";
            this.ExportB.Size = new System.Drawing.Size(42, 42);
            this.ExportB.TabIndex = 11;
            this.ExportB.UseVisualStyleBackColor = false;
            this.ExportB.Click += new System.EventHandler(this.exportB_Click);
            // 
            // PrintB
            // 
            this.PrintB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PrintB.BackColor = System.Drawing.Color.White;
            this.PrintB.FlatAppearance.BorderSize = 0;
            this.PrintB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PrintB.Image = ((System.Drawing.Image)(resources.GetObject("PrintB.Image")));
            this.PrintB.Location = new System.Drawing.Point(999, 12);
            this.PrintB.Name = "PrintB";
            this.PrintB.Size = new System.Drawing.Size(42, 42);
            this.PrintB.TabIndex = 11;
            this.PrintB.UseVisualStyleBackColor = false;
            this.PrintB.Click += new System.EventHandler(this.PrintB_Click);
            // 
            // ΒookmarkB
            // 
            this.ΒookmarkB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ΒookmarkB.BackColor = System.Drawing.Color.White;
            this.ΒookmarkB.FlatAppearance.BorderSize = 0;
            this.ΒookmarkB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ΒookmarkB.ForeColor = System.Drawing.Color.White;
            this.ΒookmarkB.Image = ((System.Drawing.Image)(resources.GetObject("ΒookmarkB.Image")));
            this.ΒookmarkB.Location = new System.Drawing.Point(961, 12);
            this.ΒookmarkB.Name = "ΒookmarkB";
            this.ΒookmarkB.Size = new System.Drawing.Size(42, 42);
            this.ΒookmarkB.TabIndex = 11;
            this.ΒookmarkB.UseVisualStyleBackColor = false;
            this.ΒookmarkB.Click += new System.EventHandler(this.bookmarkB_Click);
            // 
            // SearchB
            // 
            this.SearchB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SearchB.BackColor = System.Drawing.Color.Silver;
            this.SearchB.FlatAppearance.BorderSize = 0;
            this.SearchB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchB.Image = ((System.Drawing.Image)(resources.GetObject("SearchB.Image")));
            this.SearchB.Location = new System.Drawing.Point(797, 23);
            this.SearchB.Name = "SearchB";
            this.SearchB.Size = new System.Drawing.Size(55, 25);
            this.SearchB.TabIndex = 11;
            this.SearchB.UseVisualStyleBackColor = false;
            this.SearchB.Click += new System.EventHandler(this.SearchB_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(111, 61);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.textBox1.ForeColor = System.Drawing.Color.Black;
            this.textBox1.Location = new System.Drawing.Point(201, 23);
            this.textBox1.MaximumSize = new System.Drawing.Size(674, 25);
            this.textBox1.MinimumSize = new System.Drawing.Size(600, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(600, 35);
            this.textBox1.TabIndex = 0;
            this.textBox1.Click += new System.EventHandler(this.textBox1_Click);
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.enter_click);
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.AutoSize = true;
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 70);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1092, 433);
            this.panel2.TabIndex = 1;
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // ViewUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Name = "ViewUC";
            this.Size = new System.Drawing.Size(1092, 503);
            this.Load += new System.EventHandler(this.ViewUC_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ExportP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button ExportB;
        private System.Windows.Forms.Button PrintB;
        public System.Windows.Forms.Button ΒookmarkB;
        private System.Windows.Forms.Button SearchB;
        public System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Panel ExportP;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Open;
    }
}
