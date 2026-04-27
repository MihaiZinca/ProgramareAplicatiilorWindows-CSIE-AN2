namespace EX1
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
            this.lvStud = new System.Windows.Forms.ListView();
            this.Nume = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAfisareTV = new System.Windows.Forms.Button();
            this.tvStudenti = new System.Windows.Forms.TreeView();
            this.btnAdaugareStud = new System.Windows.Forms.Button();
            this.tbNume = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.binToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.tbMaterii = new System.Windows.Forms.TextBox();
            this.tbMedie = new System.Windows.Forms.TextBox();
            this.tbMatricol = new System.Windows.Forms.TextBox();
            this.tbVarsta = new System.Windows.Forms.TextBox();
            this.tbPrenume = new System.Windows.Forms.TextBox();
            this.tbN = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvStud
            // 
            this.lvStud.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Nume,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lvStud.GridLines = true;
            this.lvStud.HideSelection = false;
            this.lvStud.Location = new System.Drawing.Point(44, 435);
            this.lvStud.Name = "lvStud";
            this.lvStud.Size = new System.Drawing.Size(475, 175);
            this.lvStud.TabIndex = 20;
            this.lvStud.UseCompatibleStateImageBehavior = false;
            this.lvStud.View = System.Windows.Forms.View.Details;
            // 
            // Nume
            // 
            this.Nume.Text = "Nume";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Prenume";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Varsta";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Matricol";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Medie";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Materii";
            // 
            // btnAfisareTV
            // 
            this.btnAfisareTV.Location = new System.Drawing.Point(253, 355);
            this.btnAfisareTV.Name = "btnAfisareTV";
            this.btnAfisareTV.Size = new System.Drawing.Size(266, 23);
            this.btnAfisareTV.TabIndex = 19;
            this.btnAfisareTV.Text = "Afiseaza studentii";
            this.btnAfisareTV.UseVisualStyleBackColor = true;
            this.btnAfisareTV.Click += new System.EventHandler(this.btnAfisareTV_Click);
            // 
            // tvStudenti
            // 
            this.tvStudenti.Location = new System.Drawing.Point(253, 39);
            this.tvStudenti.Name = "tvStudenti";
            this.tvStudenti.Size = new System.Drawing.Size(266, 278);
            this.tvStudenti.TabIndex = 18;
            // 
            // btnAdaugareStud
            // 
            this.btnAdaugareStud.Location = new System.Drawing.Point(33, 355);
            this.btnAdaugareStud.Name = "btnAdaugareStud";
            this.btnAdaugareStud.Size = new System.Drawing.Size(158, 23);
            this.btnAdaugareStud.TabIndex = 17;
            this.btnAdaugareStud.Text = "Adaugare Student";
            this.btnAdaugareStud.UseVisualStyleBackColor = true;
            this.btnAdaugareStud.Click += new System.EventHandler(this.btnAdaugareStud_Click);
            // 
            // tbNume
            // 
            this.tbNume.Location = new System.Drawing.Point(25, -37);
            this.tbNume.Name = "tbNume";
            this.tbNume.Size = new System.Drawing.Size(158, 22);
            this.tbNume.TabIndex = 11;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(658, 28);
            this.menuStrip1.TabIndex = 21;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.binToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // binToolStripMenuItem
            // 
            this.binToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.openToolStripMenuItem});
            this.binToolStripMenuItem.Name = "binToolStripMenuItem";
            this.binToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.binToolStripMenuItem.Text = "Bin";
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
            // tbMaterii
            // 
            this.tbMaterii.Location = new System.Drawing.Point(33, 307);
            this.tbMaterii.Name = "tbMaterii";
            this.tbMaterii.Size = new System.Drawing.Size(158, 22);
            this.tbMaterii.TabIndex = 27;
            // 
            // tbMedie
            // 
            this.tbMedie.Location = new System.Drawing.Point(33, 258);
            this.tbMedie.Name = "tbMedie";
            this.tbMedie.Size = new System.Drawing.Size(158, 22);
            this.tbMedie.TabIndex = 26;
            // 
            // tbMatricol
            // 
            this.tbMatricol.Location = new System.Drawing.Point(33, 201);
            this.tbMatricol.Name = "tbMatricol";
            this.tbMatricol.Size = new System.Drawing.Size(158, 22);
            this.tbMatricol.TabIndex = 25;
            // 
            // tbVarsta
            // 
            this.tbVarsta.Location = new System.Drawing.Point(33, 152);
            this.tbVarsta.Name = "tbVarsta";
            this.tbVarsta.Size = new System.Drawing.Size(158, 22);
            this.tbVarsta.TabIndex = 24;
            // 
            // tbPrenume
            // 
            this.tbPrenume.Location = new System.Drawing.Point(33, 101);
            this.tbPrenume.Name = "tbPrenume";
            this.tbPrenume.Size = new System.Drawing.Size(158, 22);
            this.tbPrenume.TabIndex = 23;
            // 
            // tbN
            // 
            this.tbN.Location = new System.Drawing.Point(33, 51);
            this.tbN.Name = "tbN";
            this.tbN.Size = new System.Drawing.Size(158, 22);
            this.tbN.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 741);
            this.Controls.Add(this.tbMaterii);
            this.Controls.Add(this.tbMedie);
            this.Controls.Add(this.tbMatricol);
            this.Controls.Add(this.tbVarsta);
            this.Controls.Add(this.tbPrenume);
            this.Controls.Add(this.tbN);
            this.Controls.Add(this.lvStud);
            this.Controls.Add(this.btnAfisareTV);
            this.Controls.Add(this.tvStudenti);
            this.Controls.Add(this.btnAdaugareStud);
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

        private System.Windows.Forms.ListView lvStud;
        private System.Windows.Forms.ColumnHeader Nume;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button btnAfisareTV;
        private System.Windows.Forms.TreeView tvStudenti;
        private System.Windows.Forms.Button btnAdaugareStud;
        private System.Windows.Forms.TextBox tbNume;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem binToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TextBox tbMaterii;
        private System.Windows.Forms.TextBox tbMedie;
        private System.Windows.Forms.TextBox tbMatricol;
        private System.Windows.Forms.TextBox tbVarsta;
        private System.Windows.Forms.TextBox tbPrenume;
        private System.Windows.Forms.TextBox tbN;
    }
}

