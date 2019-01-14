namespace testadopse.UserControls
{
    partial class CategoriesUC
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
            this.CategoriesP = new System.Windows.Forms.Panel();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.viewUC1 = new testadopse.UserControls.ViewUC();
            this.CategoriesP.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // CategoriesP
            // 
            this.CategoriesP.Controls.Add(this.treeView1);
            this.CategoriesP.Dock = System.Windows.Forms.DockStyle.Left;
            this.CategoriesP.ForeColor = System.Drawing.Color.Black;
            this.CategoriesP.Location = new System.Drawing.Point(0, 0);
            this.CategoriesP.Name = "CategoriesP";
            this.CategoriesP.Size = new System.Drawing.Size(180, 661);
            this.CategoriesP.TabIndex = 0;
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(180, 661);
            this.treeView1.TabIndex = 0;
            this.treeView1.DoubleClick += new System.EventHandler(this.treeView1_DoubleClick);
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.Controls.Add(this.viewUC1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(180, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(936, 661);
            this.panel2.TabIndex = 1;
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
            this.viewUC1.Size = new System.Drawing.Size(936, 661);
            this.viewUC1.TabIndex = 0;
            this.viewUC1.Load += new System.EventHandler(this.viewUC1_Load);
            // 
            // CategoriesUC
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.CategoriesP);
            this.Name = "CategoriesUC";
            this.Size = new System.Drawing.Size(1116, 661);
            this.CategoriesP.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Panel CategoriesP;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TreeView treeView1;
        private ViewUC viewUC1;
    }
}
