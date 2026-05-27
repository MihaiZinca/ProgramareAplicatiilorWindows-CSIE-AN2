namespace SubTranzactie
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
            this.lvAfisareExtrase = new System.Windows.Forms.ListView();
            this.Nume = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Adresa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAfisareEx = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.extraseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificareExtrasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stergereDateExtrasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvareExtrasDbToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.graficToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelGrafic = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvAfisareExtrase
            // 
            this.lvAfisareExtrase.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Nume,
            this.Adresa,
            this.columnHeader1});
            this.lvAfisareExtrase.FullRowSelect = true;
            this.lvAfisareExtrase.GridLines = true;
            this.lvAfisareExtrase.HideSelection = false;
            this.lvAfisareExtrase.Location = new System.Drawing.Point(42, 66);
            this.lvAfisareExtrase.Name = "lvAfisareExtrase";
            this.lvAfisareExtrase.Size = new System.Drawing.Size(490, 150);
            this.lvAfisareExtrase.TabIndex = 0;
            this.lvAfisareExtrase.UseCompatibleStateImageBehavior = false;
            this.lvAfisareExtrase.View = System.Windows.Forms.View.Details;
            this.lvAfisareExtrase.SelectedIndexChanged += new System.EventHandler(this.lvAfisareExtrase_SelectedIndexChanged);
            this.lvAfisareExtrase.DoubleClick += new System.EventHandler(this.lvAfisareExtrase_DoubleClick);
            // 
            // Nume
            // 
            this.Nume.Text = "Nume";
            this.Nume.Width = 86;
            // 
            // Adresa
            // 
            this.Adresa.Text = "Adresa";
            this.Adresa.Width = 79;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Detalii Tranzactie";
            this.columnHeader1.Width = 207;
            // 
            // btnAfisareEx
            // 
            this.btnAfisareEx.Location = new System.Drawing.Point(191, 238);
            this.btnAfisareEx.Name = "btnAfisareEx";
            this.btnAfisareEx.Size = new System.Drawing.Size(192, 33);
            this.btnAfisareEx.TabIndex = 1;
            this.btnAfisareEx.Text = "Afisare Extrase";
            this.btnAfisareEx.UseVisualStyleBackColor = true;
            this.btnAfisareEx.Click += new System.EventHandler(this.btnAfisareEx_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.extraseToolStripMenuItem,
            this.graficToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(644, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // extraseToolStripMenuItem
            // 
            this.extraseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modificareExtrasToolStripMenuItem,
            this.stergereDateExtrasToolStripMenuItem,
            this.salvareExtrasDbToolStripMenuItem});
            this.extraseToolStripMenuItem.Name = "extraseToolStripMenuItem";
            this.extraseToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.extraseToolStripMenuItem.Text = "Extrase";
            // 
            // modificareExtrasToolStripMenuItem
            // 
            this.modificareExtrasToolStripMenuItem.Name = "modificareExtrasToolStripMenuItem";
            this.modificareExtrasToolStripMenuItem.Size = new System.Drawing.Size(241, 26);
            this.modificareExtrasToolStripMenuItem.Text = "Modificare date extras";
            this.modificareExtrasToolStripMenuItem.Click += new System.EventHandler(this.modificareExtrasToolStripMenuItem_Click);
            // 
            // stergereDateExtrasToolStripMenuItem
            // 
            this.stergereDateExtrasToolStripMenuItem.Name = "stergereDateExtrasToolStripMenuItem";
            this.stergereDateExtrasToolStripMenuItem.Size = new System.Drawing.Size(241, 26);
            this.stergereDateExtrasToolStripMenuItem.Text = "Stergere date extras";
            this.stergereDateExtrasToolStripMenuItem.Click += new System.EventHandler(this.stergereDateExtrasToolStripMenuItem_Click);
            // 
            // salvareExtrasDbToolStripMenuItem
            // 
            this.salvareExtrasDbToolStripMenuItem.Name = "salvareExtrasDbToolStripMenuItem";
            this.salvareExtrasDbToolStripMenuItem.Size = new System.Drawing.Size(241, 26);
            this.salvareExtrasDbToolStripMenuItem.Text = "Salvare extras db";
            this.salvareExtrasDbToolStripMenuItem.Click += new System.EventHandler(this.salvareExtrasDbToolStripMenuItem_Click);
            // 
            // graficToolStripMenuItem
            // 
            this.graficToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bareToolStripMenuItem});
            this.graficToolStripMenuItem.Name = "graficToolStripMenuItem";
            this.graficToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.graficToolStripMenuItem.Text = "Grafic";
            // 
            // bareToolStripMenuItem
            // 
            this.bareToolStripMenuItem.Name = "bareToolStripMenuItem";
            this.bareToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.bareToolStripMenuItem.Text = "Bare";
            this.bareToolStripMenuItem.Click += new System.EventHandler(this.bareToolStripMenuItem_Click);
            // 
            // panelGrafic
            // 
            this.panelGrafic.Location = new System.Drawing.Point(42, 303);
            this.panelGrafic.Name = "panelGrafic";
            this.panelGrafic.Size = new System.Drawing.Size(490, 244);
            this.panelGrafic.TabIndex = 3;
            this.panelGrafic.Paint += new System.Windows.Forms.PaintEventHandler(this.panelGrafic_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 601);
            this.Controls.Add(this.panelGrafic);
            this.Controls.Add(this.btnAfisareEx);
            this.Controls.Add(this.lvAfisareExtrase);
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

        private System.Windows.Forms.ListView lvAfisareExtrase;
        private System.Windows.Forms.ColumnHeader Nume;
        private System.Windows.Forms.ColumnHeader Adresa;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Button btnAfisareEx;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem extraseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificareExtrasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stergereDateExtrasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvareExtrasDbToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem graficToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bareToolStripMenuItem;
        private System.Windows.Forms.Panel panelGrafic;
    }
}

