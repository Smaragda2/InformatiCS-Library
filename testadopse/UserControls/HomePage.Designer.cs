namespace testadopse.UserControls
{
    partial class Homepage
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.homeUC1 = new testadopse.UserControls.HomeUC();
            this.viewUC1 = new testadopse.UserControls.ViewUC();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.viewUC1);
            this.panel1.Controls.Add(this.homeUC1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1387, 658);
            this.panel1.TabIndex = 0;
            // 
            // homeUC1
            // 
            this.homeUC1.AutoSize = true;
            this.homeUC1.BackColor = System.Drawing.Color.White;
            this.homeUC1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.homeUC1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.homeUC1.Location = new System.Drawing.Point(0, 0);
            this.homeUC1.Name = "homeUC1";
            this.homeUC1.Size = new System.Drawing.Size(1387, 658);
            this.homeUC1.TabIndex = 0;
            // 
            // viewUC1
            // 
            this.viewUC1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.viewUC1.BackColor = System.Drawing.Color.White;
            this.viewUC1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewUC1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.viewUC1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.viewUC1.Location = new System.Drawing.Point(0, 0);
            this.viewUC1.Name = "viewUC1";
            this.viewUC1.Size = new System.Drawing.Size(1387, 658);
            this.viewUC1.TabIndex = 1;
            // 
            // Homepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "Homepage";
            this.Size = new System.Drawing.Size(1387, 658);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private HomeUC homeUC1;
        private ViewUC viewUC1;
    }
}
