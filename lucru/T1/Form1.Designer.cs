namespace T1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbNume = new System.Windows.Forms.TextBox();
            this.tbDurataTr = new System.Windows.Forms.TextBox();
            this.cmbSimptome = new System.Windows.Forms.ComboBox();
            this.btnAdaugaMedicament = new System.Windows.Forms.Button();
            this.lbFisaPacient = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filtrareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.racealaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.febraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.greataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toateSimpomeleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serializareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deserializareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lvF = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nume";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Simptome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Durata tratament";
            // 
            // tbNume
            // 
            this.tbNume.Location = new System.Drawing.Point(110, 46);
            this.tbNume.Name = "tbNume";
            this.tbNume.Size = new System.Drawing.Size(100, 22);
            this.tbNume.TabIndex = 3;
            // 
            // tbDurataTr
            // 
            this.tbDurataTr.Location = new System.Drawing.Point(142, 144);
            this.tbDurataTr.Name = "tbDurataTr";
            this.tbDurataTr.Size = new System.Drawing.Size(100, 22);
            this.tbDurataTr.TabIndex = 4;
            // 
            // cmbSimptome
            // 
            this.cmbSimptome.FormattingEnabled = true;
            this.cmbSimptome.Items.AddRange(new object[] {
            "Raceala",
            "Febra",
            "Greata"});
            this.cmbSimptome.Location = new System.Drawing.Point(121, 95);
            this.cmbSimptome.Name = "cmbSimptome";
            this.cmbSimptome.Size = new System.Drawing.Size(121, 24);
            this.cmbSimptome.TabIndex = 5;
            // 
            // btnAdaugaMedicament
            // 
            this.btnAdaugaMedicament.Location = new System.Drawing.Point(25, 193);
            this.btnAdaugaMedicament.Name = "btnAdaugaMedicament";
            this.btnAdaugaMedicament.Size = new System.Drawing.Size(190, 45);
            this.btnAdaugaMedicament.TabIndex = 6;
            this.btnAdaugaMedicament.Text = "Adauga Medicament";
            this.btnAdaugaMedicament.UseVisualStyleBackColor = true;
            this.btnAdaugaMedicament.Click += new System.EventHandler(this.btnAdaugaMedicament_Click);
            // 
            // lbFisaPacient
            // 
            this.lbFisaPacient.FormattingEnabled = true;
            this.lbFisaPacient.ItemHeight = 16;
            this.lbFisaPacient.Location = new System.Drawing.Point(287, 46);
            this.lbFisaPacient.Name = "lbFisaPacient";
            this.lbFisaPacient.Size = new System.Drawing.Size(272, 116);
            this.lbFisaPacient.TabIndex = 7;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.filtrareToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serializareToolStripMenuItem,
            this.deserializareToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // filtrareToolStripMenuItem
            // 
            this.filtrareToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toateSimpomeleToolStripMenuItem,
            this.racealaToolStripMenuItem,
            this.febraToolStripMenuItem,
            this.greataToolStripMenuItem});
            this.filtrareToolStripMenuItem.Name = "filtrareToolStripMenuItem";
            this.filtrareToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
            this.filtrareToolStripMenuItem.Text = "Filtrare";
            // 
            // racealaToolStripMenuItem
            // 
            this.racealaToolStripMenuItem.Name = "racealaToolStripMenuItem";
            this.racealaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.racealaToolStripMenuItem.Text = "Raceala";
            this.racealaToolStripMenuItem.Click += new System.EventHandler(this.racealaToolStripMenuItem_Click);
            // 
            // febraToolStripMenuItem
            // 
            this.febraToolStripMenuItem.Name = "febraToolStripMenuItem";
            this.febraToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.febraToolStripMenuItem.Text = "Febra";
            this.febraToolStripMenuItem.Click += new System.EventHandler(this.febraToolStripMenuItem_Click);
            // 
            // greataToolStripMenuItem
            // 
            this.greataToolStripMenuItem.Name = "greataToolStripMenuItem";
            this.greataToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.greataToolStripMenuItem.Text = "Greata";
            this.greataToolStripMenuItem.Click += new System.EventHandler(this.greataToolStripMenuItem_Click);
            // 
            // toateSimpomeleToolStripMenuItem
            // 
            this.toateSimpomeleToolStripMenuItem.Name = "toateSimpomeleToolStripMenuItem";
            this.toateSimpomeleToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.toateSimpomeleToolStripMenuItem.Text = "Toate simpomele";
            this.toateSimpomeleToolStripMenuItem.Click += new System.EventHandler(this.toateSimpomeleToolStripMenuItem_Click);
            // 
            // serializareToolStripMenuItem
            // 
            this.serializareToolStripMenuItem.Name = "serializareToolStripMenuItem";
            this.serializareToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.serializareToolStripMenuItem.Text = "Serializare";
            this.serializareToolStripMenuItem.Click += new System.EventHandler(this.serializareToolStripMenuItem_Click);
            // 
            // deserializareToolStripMenuItem
            // 
            this.deserializareToolStripMenuItem.Name = "deserializareToolStripMenuItem";
            this.deserializareToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.deserializareToolStripMenuItem.Text = "Deserializare";
            this.deserializareToolStripMenuItem.Click += new System.EventHandler(this.deserializareToolStripMenuItem_Click);
            // 
            // lvF
            // 
            this.lvF.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvF.GridLines = true;
            this.lvF.HideSelection = false;
            this.lvF.Location = new System.Drawing.Point(287, 208);
            this.lvF.Name = "lvF";
            this.lvF.Size = new System.Drawing.Size(272, 166);
            this.lvF.TabIndex = 9;
            this.lvF.UseCompatibleStateImageBehavior = false;
            this.lvF.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nume";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Durata_Tratament";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Simptome";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Cost";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lvF);
            this.Controls.Add(this.lbFisaPacient);
            this.Controls.Add(this.btnAdaugaMedicament);
            this.Controls.Add(this.cmbSimptome);
            this.Controls.Add(this.tbDurataTr);
            this.Controls.Add(this.tbNume);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbNume;
        private System.Windows.Forms.TextBox tbDurataTr;
        private System.Windows.Forms.ComboBox cmbSimptome;
        private System.Windows.Forms.Button btnAdaugaMedicament;
        private System.Windows.Forms.ListBox lbFisaPacient;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filtrareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem racealaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem febraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem greataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toateSimpomeleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serializareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deserializareToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        public System.Windows.Forms.ListView lvF;
    }
}

