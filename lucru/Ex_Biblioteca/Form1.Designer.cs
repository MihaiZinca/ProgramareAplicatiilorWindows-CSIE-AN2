namespace Ex_Biblioteca
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbCodCarte = new System.Windows.Forms.TextBox();
            this.tbTitlu = new System.Windows.Forms.TextBox();
            this.tbAutor = new System.Windows.Forms.TextBox();
            this.tbPret = new System.Windows.Forms.TextBox();
            this.tbNumeCit = new System.Windows.Forms.TextBox();
            this.tbVarsta = new System.Windows.Forms.TextBox();
            this.tbZile = new System.Windows.Forms.TextBox();
            this.lbCartiDisponibile = new System.Windows.Forms.ListBox();
            this.lvImprumuturi = new System.Windows.Forms.ListView();
            this.btnAdaugareCarte = new System.Windows.Forms.Button();
            this.btnImprumut = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveTXTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openTXTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveBINToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openBINToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.stergeImprumutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detaliiImprumutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tvT = new System.Windows.Forms.TreeView();
            this.btnPopulareTV = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cod carte";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Titlu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Autor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Pret";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 283);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Nume Cititor";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 319);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Varsta";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 356);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Zile imprumut";
            // 
            // tbCodCarte
            // 
            this.tbCodCarte.Location = new System.Drawing.Point(104, 51);
            this.tbCodCarte.Name = "tbCodCarte";
            this.tbCodCarte.Size = new System.Drawing.Size(100, 22);
            this.tbCodCarte.TabIndex = 7;
            // 
            // tbTitlu
            // 
            this.tbTitlu.Location = new System.Drawing.Point(104, 87);
            this.tbTitlu.Name = "tbTitlu";
            this.tbTitlu.Size = new System.Drawing.Size(100, 22);
            this.tbTitlu.TabIndex = 8;
            // 
            // tbAutor
            // 
            this.tbAutor.Location = new System.Drawing.Point(104, 130);
            this.tbAutor.Name = "tbAutor";
            this.tbAutor.Size = new System.Drawing.Size(100, 22);
            this.tbAutor.TabIndex = 9;
            // 
            // tbPret
            // 
            this.tbPret.Location = new System.Drawing.Point(104, 171);
            this.tbPret.Name = "tbPret";
            this.tbPret.Size = new System.Drawing.Size(100, 22);
            this.tbPret.TabIndex = 10;
            // 
            // tbNumeCit
            // 
            this.tbNumeCit.Location = new System.Drawing.Point(112, 280);
            this.tbNumeCit.Name = "tbNumeCit";
            this.tbNumeCit.Size = new System.Drawing.Size(100, 22);
            this.tbNumeCit.TabIndex = 11;
            // 
            // tbVarsta
            // 
            this.tbVarsta.Location = new System.Drawing.Point(112, 316);
            this.tbVarsta.Name = "tbVarsta";
            this.tbVarsta.Size = new System.Drawing.Size(100, 22);
            this.tbVarsta.TabIndex = 12;
            // 
            // tbZile
            // 
            this.tbZile.Location = new System.Drawing.Point(112, 350);
            this.tbZile.Name = "tbZile";
            this.tbZile.Size = new System.Drawing.Size(100, 22);
            this.tbZile.TabIndex = 13;
            // 
            // lbCartiDisponibile
            // 
            this.lbCartiDisponibile.FormattingEnabled = true;
            this.lbCartiDisponibile.ItemHeight = 16;
            this.lbCartiDisponibile.Location = new System.Drawing.Point(233, 31);
            this.lbCartiDisponibile.Name = "lbCartiDisponibile";
            this.lbCartiDisponibile.Size = new System.Drawing.Size(258, 180);
            this.lbCartiDisponibile.TabIndex = 14;
            // 
            // lvImprumuturi
            // 
            this.lvImprumuturi.CheckBoxes = true;
            this.lvImprumuturi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvImprumuturi.GridLines = true;
            this.lvImprumuturi.HideSelection = false;
            this.lvImprumuturi.Location = new System.Drawing.Point(228, 267);
            this.lvImprumuturi.Name = "lvImprumuturi";
            this.lvImprumuturi.Size = new System.Drawing.Size(263, 161);
            this.lvImprumuturi.TabIndex = 15;
            this.lvImprumuturi.UseCompatibleStateImageBehavior = false;
            this.lvImprumuturi.View = System.Windows.Forms.View.Details;
            this.lvImprumuturi.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.lvImprumuturi_ItemChecked);
            // 
            // btnAdaugareCarte
            // 
            this.btnAdaugareCarte.Location = new System.Drawing.Point(15, 225);
            this.btnAdaugareCarte.Name = "btnAdaugareCarte";
            this.btnAdaugareCarte.Size = new System.Drawing.Size(138, 23);
            this.btnAdaugareCarte.TabIndex = 16;
            this.btnAdaugareCarte.Text = "Adauga Carte";
            this.btnAdaugareCarte.UseVisualStyleBackColor = true;
            this.btnAdaugareCarte.Click += new System.EventHandler(this.btnAdaugareCarte_Click);
            // 
            // btnImprumut
            // 
            this.btnImprumut.Location = new System.Drawing.Point(23, 405);
            this.btnImprumut.Name = "btnImprumut";
            this.btnImprumut.Size = new System.Drawing.Size(138, 23);
            this.btnImprumut.TabIndex = 17;
            this.btnImprumut.Text = "Creeaza imprumut";
            this.btnImprumut.UseVisualStyleBackColor = true;
            this.btnImprumut.Click += new System.EventHandler(this.btnImprumut_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(843, 28);
            this.menuStrip1.TabIndex = 19;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveTXTToolStripMenuItem,
            this.openTXTToolStripMenuItem,
            this.saveBINToolStripMenuItem,
            this.openBINToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveTXTToolStripMenuItem
            // 
            this.saveTXTToolStripMenuItem.Name = "saveTXTToolStripMenuItem";
            this.saveTXTToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.saveTXTToolStripMenuItem.Text = "Save TXT";
            this.saveTXTToolStripMenuItem.Click += new System.EventHandler(this.saveTXTToolStripMenuItem_Click);
            // 
            // openTXTToolStripMenuItem
            // 
            this.openTXTToolStripMenuItem.Name = "openTXTToolStripMenuItem";
            this.openTXTToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.openTXTToolStripMenuItem.Text = "Open TXT";
            this.openTXTToolStripMenuItem.Click += new System.EventHandler(this.openTXTToolStripMenuItem_Click);
            // 
            // saveBINToolStripMenuItem
            // 
            this.saveBINToolStripMenuItem.Name = "saveBINToolStripMenuItem";
            this.saveBINToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.saveBINToolStripMenuItem.Text = "Save BIN";
            this.saveBINToolStripMenuItem.Click += new System.EventHandler(this.saveBINToolStripMenuItem_Click);
            // 
            // openBINToolStripMenuItem
            // 
            this.openBINToolStripMenuItem.Name = "openBINToolStripMenuItem";
            this.openBINToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.openBINToolStripMenuItem.Text = "Open BIN";
            this.openBINToolStripMenuItem.Click += new System.EventHandler(this.openBINToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stergeImprumutToolStripMenuItem,
            this.detaliiImprumutToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(192, 52);
            // 
            // stergeImprumutToolStripMenuItem
            // 
            this.stergeImprumutToolStripMenuItem.Name = "stergeImprumutToolStripMenuItem";
            this.stergeImprumutToolStripMenuItem.Size = new System.Drawing.Size(191, 24);
            this.stergeImprumutToolStripMenuItem.Text = "Sterge imprumut";
            this.stergeImprumutToolStripMenuItem.Click += new System.EventHandler(this.stergeImprumutToolStripMenuItem_Click);
            // 
            // detaliiImprumutToolStripMenuItem
            // 
            this.detaliiImprumutToolStripMenuItem.Name = "detaliiImprumutToolStripMenuItem";
            this.detaliiImprumutToolStripMenuItem.Size = new System.Drawing.Size(191, 24);
            this.detaliiImprumutToolStripMenuItem.Text = "Detalii imprumut";
            this.detaliiImprumutToolStripMenuItem.Click += new System.EventHandler(this.detaliiImprumutToolStripMenuItem_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "NumeCititor";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Cost";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // tvT
            // 
            this.tvT.Location = new System.Drawing.Point(524, 111);
            this.tvT.Name = "tvT";
            this.tvT.Size = new System.Drawing.Size(291, 211);
            this.tvT.TabIndex = 21;
            // 
            // btnPopulareTV
            // 
            this.btnPopulareTV.Location = new System.Drawing.Point(571, 345);
            this.btnPopulareTV.Name = "btnPopulareTV";
            this.btnPopulareTV.Size = new System.Drawing.Size(207, 27);
            this.btnPopulareTV.TabIndex = 22;
            this.btnPopulareTV.Text = "Populare TV";
            this.btnPopulareTV.UseVisualStyleBackColor = true;
            this.btnPopulareTV.Click += new System.EventHandler(this.btnPopulareTV_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 468);
            this.Controls.Add(this.btnPopulareTV);
            this.Controls.Add(this.tvT);
            this.Controls.Add(this.btnImprumut);
            this.Controls.Add(this.btnAdaugareCarte);
            this.Controls.Add(this.lvImprumuturi);
            this.Controls.Add(this.lbCartiDisponibile);
            this.Controls.Add(this.tbZile);
            this.Controls.Add(this.tbVarsta);
            this.Controls.Add(this.tbNumeCit);
            this.Controls.Add(this.tbPret);
            this.Controls.Add(this.tbAutor);
            this.Controls.Add(this.tbTitlu);
            this.Controls.Add(this.tbCodCarte);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbCodCarte;
        private System.Windows.Forms.TextBox tbTitlu;
        private System.Windows.Forms.TextBox tbAutor;
        private System.Windows.Forms.TextBox tbPret;
        private System.Windows.Forms.TextBox tbNumeCit;
        private System.Windows.Forms.TextBox tbVarsta;
        private System.Windows.Forms.TextBox tbZile;
        private System.Windows.Forms.ListBox lbCartiDisponibile;
        private System.Windows.Forms.ListView lvImprumuturi;
        private System.Windows.Forms.Button btnAdaugareCarte;
        private System.Windows.Forms.Button btnImprumut;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveTXTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openTXTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveBINToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openBINToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem stergeImprumutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detaliiImprumutToolStripMenuItem;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnPopulareTV;
        private System.Windows.Forms.TreeView tvT;
    }
}

