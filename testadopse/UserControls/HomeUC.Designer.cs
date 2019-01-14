namespace testadopse.UserControls
{
    partial class HomeUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeUC));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.BookMarkP = new System.Windows.Forms.Panel();
            this.Bookmarks = new System.Windows.Forms.Panel();
            this.BookmarkOptions = new System.Windows.Forms.Panel();
            this.Delete1Bookmark = new System.Windows.Forms.Button();
            this.LineP = new System.Windows.Forms.Panel();
            this.DeleteBookmarks = new System.Windows.Forms.Button();
            this.SearchB = new System.Windows.Forms.Button();
            this.AdvSearchB = new System.Windows.Forms.Button();
            this.BookMarkB = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BookMarkP.SuspendLayout();
            this.BookmarkOptions.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.textBox1.ForeColor = System.Drawing.Color.Gray;
            this.textBox1.Location = new System.Drawing.Point(270, 203);
            this.textBox1.MaximumSize = new System.Drawing.Size(553, 28);
            this.textBox1.MinimumSize = new System.Drawing.Size(553, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(553, 28);
            this.textBox1.TabIndex = 7;
            this.textBox1.Text = "Κάντε αναζήτηση λήμματος ";
            this.textBox1.Click += new System.EventHandler(this.textBox1_Click);
            // 
            // BookMarkP
            // 
            this.BookMarkP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BookMarkP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BookMarkP.Controls.Add(this.Bookmarks);
            this.BookMarkP.Controls.Add(this.BookmarkOptions);
            this.BookMarkP.Location = new System.Drawing.Point(1141, 4);
            this.BookMarkP.Name = "BookMarkP";
            this.BookMarkP.Size = new System.Drawing.Size(180, 200);
            this.BookMarkP.TabIndex = 15;
            // 
            // Bookmarks
            // 
            this.Bookmarks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Bookmarks.Location = new System.Drawing.Point(0, 62);
            this.Bookmarks.Name = "Bookmarks";
            this.Bookmarks.Size = new System.Drawing.Size(178, 136);
            this.Bookmarks.TabIndex = 16;
            // 
            // BookmarkOptions
            // 
            this.BookmarkOptions.Controls.Add(this.Delete1Bookmark);
            this.BookmarkOptions.Controls.Add(this.LineP);
            this.BookmarkOptions.Controls.Add(this.DeleteBookmarks);
            this.BookmarkOptions.Dock = System.Windows.Forms.DockStyle.Top;
            this.BookmarkOptions.Location = new System.Drawing.Point(0, 0);
            this.BookmarkOptions.Name = "BookmarkOptions";
            this.BookmarkOptions.Size = new System.Drawing.Size(178, 62);
            this.BookmarkOptions.TabIndex = 16;
            // 
            // Delete1Bookmark
            // 
            this.Delete1Bookmark.Dock = System.Windows.Forms.DockStyle.Top;
            this.Delete1Bookmark.FlatAppearance.BorderSize = 0;
            this.Delete1Bookmark.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete1Bookmark.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Delete1Bookmark.ForeColor = System.Drawing.Color.Black;
            this.Delete1Bookmark.Location = new System.Drawing.Point(0, 30);
            this.Delete1Bookmark.Name = "Delete1Bookmark";
            this.Delete1Bookmark.Size = new System.Drawing.Size(178, 30);
            this.Delete1Bookmark.TabIndex = 17;
            this.Delete1Bookmark.Text = "Delete a Bookmark";
            this.Delete1Bookmark.UseVisualStyleBackColor = true;
            this.Delete1Bookmark.Click += new System.EventHandler(this.Delete1Bookmark_Click);
            // 
            // LineP
            // 
            this.LineP.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LineP.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LineP.Location = new System.Drawing.Point(0, 61);
            this.LineP.Name = "LineP";
            this.LineP.Size = new System.Drawing.Size(178, 1);
            this.LineP.TabIndex = 16;
            // 
            // DeleteBookmarks
            // 
            this.DeleteBookmarks.Dock = System.Windows.Forms.DockStyle.Top;
            this.DeleteBookmarks.FlatAppearance.BorderSize = 0;
            this.DeleteBookmarks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteBookmarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.DeleteBookmarks.ForeColor = System.Drawing.Color.Black;
            this.DeleteBookmarks.Location = new System.Drawing.Point(0, 0);
            this.DeleteBookmarks.Name = "DeleteBookmarks";
            this.DeleteBookmarks.Size = new System.Drawing.Size(178, 30);
            this.DeleteBookmarks.TabIndex = 16;
            this.DeleteBookmarks.Text = "Delete Bookmarks";
            this.DeleteBookmarks.UseVisualStyleBackColor = true;
            this.DeleteBookmarks.Click += new System.EventHandler(this.DeleteBookmarks_Click);
            // 
            // SearchB
            // 
            this.SearchB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(126)))), ((int)(((byte)(241)))));
            this.SearchB.FlatAppearance.BorderSize = 0;
            this.SearchB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchB.Image = ((System.Drawing.Image)(resources.GetObject("SearchB.Image")));
            this.SearchB.Location = new System.Drawing.Point(384, 251);
            this.SearchB.Name = "SearchB";
            this.SearchB.Size = new System.Drawing.Size(117, 27);
            this.SearchB.TabIndex = 10;
            this.SearchB.UseVisualStyleBackColor = false;
            // 
            // AdvSearchB
            // 
            this.AdvSearchB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(126)))), ((int)(((byte)(241)))));
            this.AdvSearchB.FlatAppearance.BorderSize = 0;
            this.AdvSearchB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AdvSearchB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.AdvSearchB.ForeColor = System.Drawing.Color.White;
            this.AdvSearchB.Location = new System.Drawing.Point(660, 251);
            this.AdvSearchB.Name = "AdvSearchB";
            this.AdvSearchB.Size = new System.Drawing.Size(117, 27);
            this.AdvSearchB.TabIndex = 12;
            this.AdvSearchB.Text = "Adv Search";
            this.AdvSearchB.UseVisualStyleBackColor = false;
            this.AdvSearchB.Click += new System.EventHandler(this.AdvSearchB_Click);
            // 
            // BookMarkB
            // 
            this.BookMarkB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BookMarkB.FlatAppearance.BorderSize = 0;
            this.BookMarkB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BookMarkB.Image = ((System.Drawing.Image)(resources.GetObject("BookMarkB.Image")));
            this.BookMarkB.Location = new System.Drawing.Point(1328, 3);
            this.BookMarkB.Name = "BookMarkB";
            this.BookMarkB.Size = new System.Drawing.Size(56, 51);
            this.BookMarkB.TabIndex = 14;
            this.BookMarkB.UseVisualStyleBackColor = true;
            this.BookMarkB.Click += new System.EventHandler(this.BookMarkB_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.radioButton4);
            this.panel1.Controls.Add(this.radioButton3);
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(253, 296);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(604, 142);
            this.panel1.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(518, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Εως :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(437, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Απο :";
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownHeight = 90;
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.comboBox2.ForeColor = System.Drawing.Color.Black;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.IntegralHeight = false;
            this.comboBox2.Items.AddRange(new object[] {
            "1990",
            "1991",
            "1992",
            "1993",
            "1994",
            "1995",
            "1996",
            "1997",
            "1998",
            "1999",
            "2000",
            "2001",
            "2002",
            "2003",
            "2004",
            "2005",
            "2006",
            "2007",
            "2008",
            "2009",
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015",
            "2016",
            "2017",
            "2018",
            "2019"});
            this.comboBox2.Location = new System.Drawing.Point(515, 65);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(72, 21);
            this.comboBox2.TabIndex = 6;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownHeight = 90;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.comboBox1.ForeColor = System.Drawing.Color.Black;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.IntegralHeight = false;
            this.comboBox1.Items.AddRange(new object[] {
            "1990",
            "1991",
            "1992",
            "1993",
            "1994",
            "1995",
            "1996",
            "1997",
            "1998",
            "1999",
            "2000",
            "2001",
            "2002",
            "2003",
            "2004",
            "2005",
            "2006",
            "2007",
            "2008",
            "2009",
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015",
            "2016",
            "2017",
            "2018",
            "2019"});
            this.comboBox1.Location = new System.Drawing.Point(434, 65);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(72, 21);
            this.comboBox1.TabIndex = 6;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.radioButton4.ForeColor = System.Drawing.Color.Black;
            this.radioButton4.Location = new System.Drawing.Point(252, 74);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(41, 17);
            this.radioButton4.TabIndex = 5;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "OR";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.radioButton3.ForeColor = System.Drawing.Color.Black;
            this.radioButton3.Location = new System.Drawing.Point(252, 51);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(48, 17);
            this.radioButton3.TabIndex = 4;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "AND";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.radioButton2.ForeColor = System.Drawing.Color.Black;
            this.radioButton2.Location = new System.Drawing.Point(23, 75);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(95, 17);
            this.radioButton2.TabIndex = 3;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Content Based";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.radioButton1.ForeColor = System.Drawing.Color.Black;
            this.radioButton1.Location = new System.Drawing.Point(23, 51);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(78, 17);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Title Based";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(430, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 21);
            this.label4.TabIndex = 1;
            this.label4.Text = "Χρονικό Πλαίσιο";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(211, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "Συνδυασμός Keyword";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(7, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Τύπος Αναζήτησης";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(420, 612);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(491, 23);
            this.label1.TabIndex = 11;
            this.label1.Text = "Alexander Technological Insitude, Electronic Encyclopedia\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(474, 4);
            this.pictureBox1.MaximumSize = new System.Drawing.Size(200, 200);
            this.pictureBox1.MinimumSize = new System.Drawing.Size(180, 180);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 180);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.BookMarkB);
            this.panel2.Controls.Add(this.AdvSearchB);
            this.panel2.Controls.Add(this.SearchB);
            this.panel2.Controls.Add(this.BookMarkP);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1387, 658);
            this.panel2.TabIndex = 16;
            // 
            // HomeUC
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Name = "HomeUC";
            this.Size = new System.Drawing.Size(1387, 658);
            this.Load += new System.EventHandler(this.HomeUC_Load);
            this.BookMarkP.ResumeLayout(false);
            this.BookmarkOptions.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.Panel BookMarkP;
        private System.Windows.Forms.Panel Bookmarks;
        public System.Windows.Forms.Panel BookmarkOptions;
        private System.Windows.Forms.Panel LineP;
        public System.Windows.Forms.Button SearchB;
        private System.Windows.Forms.Button AdvSearchB;
        private System.Windows.Forms.Button BookMarkB;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Delete1Bookmark;
        private System.Windows.Forms.Button DeleteBookmarks;
    }
}
