namespace Bibliografice
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adaugaManualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importDBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lvPublicatii = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvAutori = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tbAutori = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dateToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(827, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dateToolStripMenuItem
            // 
            this.dateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adaugaManualToolStripMenuItem,
            this.importDBToolStripMenuItem});
            this.dateToolStripMenuItem.Name = "dateToolStripMenuItem";
            this.dateToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.dateToolStripMenuItem.Text = "Date";
            // 
            // adaugaManualToolStripMenuItem
            // 
            this.adaugaManualToolStripMenuItem.Name = "adaugaManualToolStripMenuItem";
            this.adaugaManualToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.adaugaManualToolStripMenuItem.Text = "Adauga Manual";
            this.adaugaManualToolStripMenuItem.Click += new System.EventHandler(this.adaugaManualToolStripMenuItem_Click);
            // 
            // importDBToolStripMenuItem
            // 
            this.importDBToolStripMenuItem.Name = "importDBToolStripMenuItem";
            this.importDBToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.importDBToolStripMenuItem.Text = "Import DB";
            this.importDBToolStripMenuItem.Click += new System.EventHandler(this.importDBToolStripMenuItem_Click);
            // 
            // lvPublicatii
            // 
            this.lvPublicatii.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.lvPublicatii.FullRowSelect = true;
            this.lvPublicatii.GridLines = true;
            this.lvPublicatii.HideSelection = false;
            this.lvPublicatii.Location = new System.Drawing.Point(30, 90);
            this.lvPublicatii.Name = "lvPublicatii";
            this.lvPublicatii.Size = new System.Drawing.Size(353, 248);
            this.lvPublicatii.TabIndex = 1;
            this.lvPublicatii.UseCompatibleStateImageBehavior = false;
            this.lvPublicatii.View = System.Windows.Forms.View.Details;
            this.lvPublicatii.SelectedIndexChanged += new System.EventHandler(this.lvPublicatii_SelectedIndexChanged);
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Titlu";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Pret";
            this.columnHeader5.Width = 85;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "ISBN";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "CATEGORIE";
            this.columnHeader7.Width = 132;
            // 
            // lvAutori
            // 
            this.lvAutori.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvAutori.FullRowSelect = true;
            this.lvAutori.GridLines = true;
            this.lvAutori.HideSelection = false;
            this.lvAutori.Location = new System.Drawing.Point(446, 90);
            this.lvAutori.Name = "lvAutori";
            this.lvAutori.Size = new System.Drawing.Size(306, 248);
            this.lvAutori.TabIndex = 2;
            this.lvAutori.UseCompatibleStateImageBehavior = false;
            this.lvAutori.View = System.Windows.Forms.View.Details;
            this.lvAutori.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lvAutori_MouseDown);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nume";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Grad";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Marca";
            // 
            // tbAutori
            // 
            this.tbAutori.AllowDrop = true;
            this.tbAutori.Location = new System.Drawing.Point(30, 376);
            this.tbAutori.Multiline = true;
            this.tbAutori.Name = "tbAutori";
            this.tbAutori.Size = new System.Drawing.Size(353, 113);
            this.tbAutori.TabIndex = 3;
            this.tbAutori.DragDrop += new System.Windows.Forms.DragEventHandler(this.tbAutori_DragDrop);
            this.tbAutori.DragEnter += new System.Windows.Forms.DragEventHandler(this.tbAutori_DragEnter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 533);
            this.Controls.Add(this.tbAutori);
            this.Controls.Add(this.lvAutori);
            this.Controls.Add(this.lvPublicatii);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adaugaManualToolStripMenuItem;
        private System.Windows.Forms.ListView lvPublicatii;
        private System.Windows.Forms.ListView lvAutori;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ToolStripMenuItem importDBToolStripMenuItem;
        private System.Windows.Forms.TextBox tbAutori;
    }
}

