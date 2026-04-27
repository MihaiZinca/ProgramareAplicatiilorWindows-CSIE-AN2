namespace EX2
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
            this.tbAngajati = new System.Windows.Forms.TextBox();
            this.btnAfisareLV = new System.Windows.Forms.Button();
            this.lvAngajati = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAdaugaAngajat = new System.Windows.Forms.Button();
            this.tbSalariuO = new System.Windows.Forms.TextBox();
            this.tbOreL = new System.Windows.Forms.TextBox();
            this.tbNume = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbAngajati
            // 
            this.tbAngajati.Location = new System.Drawing.Point(92, 334);
            this.tbAngajati.Multiline = true;
            this.tbAngajati.Name = "tbAngajati";
            this.tbAngajati.Size = new System.Drawing.Size(379, 173);
            this.tbAngajati.TabIndex = 16;
            // 
            // btnAfisareLV
            // 
            this.btnAfisareLV.Location = new System.Drawing.Point(309, 257);
            this.btnAfisareLV.Name = "btnAfisareLV";
            this.btnAfisareLV.Size = new System.Drawing.Size(180, 42);
            this.btnAfisareLV.TabIndex = 14;
            this.btnAfisareLV.Text = "Arata toti angajatii";
            this.btnAfisareLV.UseVisualStyleBackColor = true;
            this.btnAfisareLV.Click += new System.EventHandler(this.btnAfisareLV_Click);
            // 
            // lvAngajati
            // 
            this.lvAngajati.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvAngajati.GridLines = true;
            this.lvAngajati.HideSelection = false;
            this.lvAngajati.Location = new System.Drawing.Point(230, 57);
            this.lvAngajati.Name = "lvAngajati";
            this.lvAngajati.Size = new System.Drawing.Size(382, 180);
            this.lvAngajati.TabIndex = 13;
            this.lvAngajati.UseCompatibleStateImageBehavior = false;
            this.lvAngajati.View = System.Windows.Forms.View.Details;
            this.lvAngajati.SelectedIndexChanged += new System.EventHandler(this.lvAngajati_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nume";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ore lucrate";
            this.columnHeader2.Width = 86;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Salariu orar";
            this.columnHeader3.Width = 85;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Salariu";
            this.columnHeader4.Width = 77;
            // 
            // btnAdaugaAngajat
            // 
            this.btnAdaugaAngajat.Location = new System.Drawing.Point(25, 217);
            this.btnAdaugaAngajat.Name = "btnAdaugaAngajat";
            this.btnAdaugaAngajat.Size = new System.Drawing.Size(131, 55);
            this.btnAdaugaAngajat.TabIndex = 12;
            this.btnAdaugaAngajat.Text = "Adaugare angajat";
            this.btnAdaugaAngajat.UseVisualStyleBackColor = true;
            this.btnAdaugaAngajat.Click += new System.EventHandler(this.btnAdaugaAngajat_Click);
            // 
            // tbSalariuO
            // 
            this.tbSalariuO.Location = new System.Drawing.Point(25, 156);
            this.tbSalariuO.Name = "tbSalariuO";
            this.tbSalariuO.Size = new System.Drawing.Size(131, 22);
            this.tbSalariuO.TabIndex = 11;
            // 
            // tbOreL
            // 
            this.tbOreL.Location = new System.Drawing.Point(25, 108);
            this.tbOreL.Name = "tbOreL";
            this.tbOreL.Size = new System.Drawing.Size(131, 22);
            this.tbOreL.TabIndex = 10;
            // 
            // tbNume
            // 
            this.tbNume.Location = new System.Drawing.Point(25, 57);
            this.tbNume.Name = "tbNume";
            this.tbNume.Size = new System.Drawing.Size(131, 22);
            this.tbNume.TabIndex = 9;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(741, 28);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.openToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 559);
            this.Controls.Add(this.tbAngajati);
            this.Controls.Add(this.btnAfisareLV);
            this.Controls.Add(this.lvAngajati);
            this.Controls.Add(this.btnAdaugaAngajat);
            this.Controls.Add(this.tbSalariuO);
            this.Controls.Add(this.tbOreL);
            this.Controls.Add(this.tbNume);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbAngajati;
        private System.Windows.Forms.Button btnAfisareLV;
        private System.Windows.Forms.ListView lvAngajati;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button btnAdaugaAngajat;
        private System.Windows.Forms.TextBox tbSalariuO;
        private System.Windows.Forms.TextBox tbOreL;
        private System.Windows.Forms.TextBox tbNume;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

