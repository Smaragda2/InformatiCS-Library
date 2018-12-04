namespace testadopse
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.AboutB = new System.Windows.Forms.Button();
            this.ContactB = new System.Windows.Forms.Button();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.CategoriesB = new System.Windows.Forms.Button();
            this.HomeB = new System.Windows.Forms.Button();
            this.HelpB = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.contactUC1 = new testadopse.UserControls.ContactUC();
            this.homeUC1 = new testadopse.UserControls.HomeUC();
            this.aboutUC1 = new testadopse.UserControls.AboutUC();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.AboutB);
            this.panel1.Controls.Add(this.ContactB);
            this.panel1.Controls.Add(this.Logo);
            this.panel1.Controls.Add(this.CategoriesB);
            this.panel1.Controls.Add(this.HomeB);
            this.panel1.Controls.Add(this.HelpB);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(164, 720);
            this.panel1.TabIndex = 0;
            // 
            // AboutB
            // 
            this.AboutB.FlatAppearance.BorderSize = 0;
            this.AboutB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AboutB.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.AboutB.Image = ((System.Drawing.Image)(resources.GetObject("AboutB.Image")));
            this.AboutB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AboutB.Location = new System.Drawing.Point(4, 433);
            this.AboutB.Margin = new System.Windows.Forms.Padding(4);
            this.AboutB.Name = "AboutB";
            this.AboutB.Size = new System.Drawing.Size(157, 60);
            this.AboutB.TabIndex = 6;
            this.AboutB.Text = "About";
            this.AboutB.UseVisualStyleBackColor = true;
            this.AboutB.Click += new System.EventHandler(this.AboutB_Click);
            // 
            // ContactB
            // 
            this.ContactB.FlatAppearance.BorderSize = 0;
            this.ContactB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ContactB.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.ContactB.Image = ((System.Drawing.Image)(resources.GetObject("ContactB.Image")));
            this.ContactB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ContactB.Location = new System.Drawing.Point(4, 365);
            this.ContactB.Margin = new System.Windows.Forms.Padding(4);
            this.ContactB.Name = "ContactB";
            this.ContactB.Size = new System.Drawing.Size(157, 60);
            this.ContactB.TabIndex = 5;
            this.ContactB.Text = "Contact";
            this.ContactB.UseVisualStyleBackColor = true;
            this.ContactB.Click += new System.EventHandler(this.ContactB_Click);
            // 
            // Logo
            // 
            this.Logo.Image = ((System.Drawing.Image)(resources.GetObject("Logo.Image")));
            this.Logo.Location = new System.Drawing.Point(25, 13);
            this.Logo.Margin = new System.Windows.Forms.Padding(4);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(108, 99);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Logo.TabIndex = 3;
            this.Logo.TabStop = false;
            // 
            // CategoriesB
            // 
            this.CategoriesB.FlatAppearance.BorderSize = 0;
            this.CategoriesB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CategoriesB.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.CategoriesB.ForeColor = System.Drawing.Color.White;
            this.CategoriesB.Image = ((System.Drawing.Image)(resources.GetObject("CategoriesB.Image")));
            this.CategoriesB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CategoriesB.Location = new System.Drawing.Point(4, 229);
            this.CategoriesB.Margin = new System.Windows.Forms.Padding(4);
            this.CategoriesB.Name = "CategoriesB";
            this.CategoriesB.Size = new System.Drawing.Size(157, 60);
            this.CategoriesB.TabIndex = 3;
            this.CategoriesB.Text = "  Categories";
            this.CategoriesB.UseVisualStyleBackColor = true;
            this.CategoriesB.UseWaitCursor = true;
            // 
            // HomeB
            // 
            this.HomeB.FlatAppearance.BorderSize = 0;
            this.HomeB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeB.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.HomeB.ForeColor = System.Drawing.Color.White;
            this.HomeB.Image = ((System.Drawing.Image)(resources.GetObject("HomeB.Image")));
            this.HomeB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HomeB.Location = new System.Drawing.Point(4, 161);
            this.HomeB.Margin = new System.Windows.Forms.Padding(4);
            this.HomeB.Name = "HomeB";
            this.HomeB.Size = new System.Drawing.Size(157, 60);
            this.HomeB.TabIndex = 2;
            this.HomeB.Text = "Home";
            this.HomeB.UseVisualStyleBackColor = true;
            this.HomeB.Click += new System.EventHandler(this.HomeB_Click);
            // 
            // HelpB
            // 
            this.HelpB.FlatAppearance.BorderSize = 0;
            this.HelpB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HelpB.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.HelpB.ForeColor = System.Drawing.Color.White;
            this.HelpB.Image = ((System.Drawing.Image)(resources.GetObject("HelpB.Image")));
            this.HelpB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HelpB.Location = new System.Drawing.Point(4, 297);
            this.HelpB.Margin = new System.Windows.Forms.Padding(4);
            this.HelpB.Name = "HelpB";
            this.HelpB.Size = new System.Drawing.Size(157, 60);
            this.HelpB.TabIndex = 4;
            this.HelpB.Text = "Help";
            this.HelpB.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(164, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1116, 52);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.Location = new System.Drawing.Point(409, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "InformatiCS-Library";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.aboutUC1);
            this.panel3.Controls.Add(this.contactUC1);
            this.panel3.Controls.Add(this.homeUC1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(164, 59);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1116, 661);
            this.panel3.TabIndex = 6;
            // 
            // contactUC1
            // 
            this.contactUC1.BackColor = System.Drawing.Color.White;
            this.contactUC1.CausesValidation = false;
            this.contactUC1.Location = new System.Drawing.Point(0, 3);
            this.contactUC1.Name = "contactUC1";
            this.contactUC1.Size = new System.Drawing.Size(1116, 661);
            this.contactUC1.TabIndex = 1;
            // 
            // homeUC1
            // 
            this.homeUC1.BackColor = System.Drawing.Color.White;
            this.homeUC1.Location = new System.Drawing.Point(0, -3);
            this.homeUC1.Name = "homeUC1";
            this.homeUC1.Size = new System.Drawing.Size(1116, 661);
            this.homeUC1.TabIndex = 0;
            // 
            // aboutUC1
            // 
            this.aboutUC1.BackColor = System.Drawing.Color.White;
            this.aboutUC1.Location = new System.Drawing.Point(0, 3);
            this.aboutUC1.Name = "aboutUC1";
            this.aboutUC1.Size = new System.Drawing.Size(1116, 661);
            this.aboutUC1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Button CategoriesB;
        private System.Windows.Forms.Button HomeB;
        private System.Windows.Forms.Button HelpB;
        private System.Windows.Forms.Button AboutB;
        private System.Windows.Forms.Button ContactB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private UserControls.HomeUC homeUC1;
        private UserControls.ContactUC contactUC1;
        private UserControls.AboutUC aboutUC1;
    }
}

