namespace Ex_Sub1
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
            this.tbNume = new System.Windows.Forms.TextBox();
            this.tbPrenume = new System.Windows.Forms.TextBox();
            this.tbVarsta = new System.Windows.Forms.TextBox();
            this.tbMatricol = new System.Windows.Forms.TextBox();
            this.tbMedie = new System.Windows.Forms.TextBox();
            this.tbMaterii = new System.Windows.Forms.TextBox();
            this.btnAdaugareStud = new System.Windows.Forms.Button();
            this.tvStudenti = new System.Windows.Forms.TreeView();
            this.btnAfisareStudTV = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.binToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.lvAfisareStud = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbNume
            // 
            this.tbNume.Location = new System.Drawing.Point(43, 58);
            this.tbNume.Name = "tbNume";
            this.tbNume.Size = new System.Drawing.Size(123, 22);
            this.tbNume.TabIndex = 0;
            // 
            // tbPrenume
            // 
            this.tbPrenume.Location = new System.Drawing.Point(43, 107);
            this.tbPrenume.Name = "tbPrenume";
            this.tbPrenume.Size = new System.Drawing.Size(123, 22);
            this.tbPrenume.TabIndex = 1;
            // 
            // tbVarsta
            // 
            this.tbVarsta.Location = new System.Drawing.Point(43, 154);
            this.tbVarsta.Name = "tbVarsta";
            this.tbVarsta.Size = new System.Drawing.Size(123, 22);
            this.tbVarsta.TabIndex = 2;
            // 
            // tbMatricol
            // 
            this.tbMatricol.Location = new System.Drawing.Point(43, 195);
            this.tbMatricol.Name = "tbMatricol";
            this.tbMatricol.Size = new System.Drawing.Size(123, 22);
            this.tbMatricol.TabIndex = 3;
            // 
            // tbMedie
            // 
            this.tbMedie.Location = new System.Drawing.Point(43, 243);
            this.tbMedie.Name = "tbMedie";
            this.tbMedie.Size = new System.Drawing.Size(123, 22);
            this.tbMedie.TabIndex = 4;
            // 
            // tbMaterii
            // 
            this.tbMaterii.Location = new System.Drawing.Point(43, 290);
            this.tbMaterii.Name = "tbMaterii";
            this.tbMaterii.Size = new System.Drawing.Size(123, 22);
            this.tbMaterii.TabIndex = 5;
            // 
            // btnAdaugareStud
            // 
            this.btnAdaugareStud.Location = new System.Drawing.Point(43, 337);
            this.btnAdaugareStud.Name = "btnAdaugareStud";
            this.btnAdaugareStud.Size = new System.Drawing.Size(123, 38);
            this.btnAdaugareStud.TabIndex = 6;
            this.btnAdaugareStud.Text = "Adauga Student";
            this.btnAdaugareStud.UseVisualStyleBackColor = true;
            this.btnAdaugareStud.Click += new System.EventHandler(this.btnAdaugareStud_Click);
            // 
            // tvStudenti
            // 
            this.tvStudenti.Location = new System.Drawing.Point(274, 58);
            this.tvStudenti.Name = "tvStudenti";
            this.tvStudenti.Size = new System.Drawing.Size(338, 254);
            this.tvStudenti.TabIndex = 7;
            // 
            // btnAfisareStudTV
            // 
            this.btnAfisareStudTV.Location = new System.Drawing.Point(274, 337);
            this.btnAfisareStudTV.Name = "btnAfisareStudTV";
            this.btnAfisareStudTV.Size = new System.Drawing.Size(338, 38);
            this.btnAfisareStudTV.TabIndex = 8;
            this.btnAfisareStudTV.Text = "Afiseaza Studentii";
            this.btnAfisareStudTV.UseVisualStyleBackColor = true;
            this.btnAfisareStudTV.Click += new System.EventHandler(this.btnAfisareStudTV_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.binToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(674, 28);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // binToolStripMenuItem
            // 
            this.binToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.openToolStripMenuItem});
            this.binToolStripMenuItem.Name = "binToolStripMenuItem";
            this.binToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
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
            // lvAfisareStud
            // 
            this.lvAfisareStud.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lvAfisareStud.GridLines = true;
            this.lvAfisareStud.HideSelection = false;
            this.lvAfisareStud.Location = new System.Drawing.Point(105, 409);
            this.lvAfisareStud.Name = "lvAfisareStud";
            this.lvAfisareStud.Size = new System.Drawing.Size(425, 169);
            this.lvAfisareStud.TabIndex = 10;
            this.lvAfisareStud.UseCompatibleStateImageBehavior = false;
            this.lvAfisareStud.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nume";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Prenume";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Varsta";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Matricol";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Medie";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Materii";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 612);
            this.Controls.Add(this.lvAfisareStud);
            this.Controls.Add(this.btnAfisareStudTV);
            this.Controls.Add(this.tvStudenti);
            this.Controls.Add(this.btnAdaugareStud);
            this.Controls.Add(this.tbMaterii);
            this.Controls.Add(this.tbMedie);
            this.Controls.Add(this.tbMatricol);
            this.Controls.Add(this.tbVarsta);
            this.Controls.Add(this.tbPrenume);
            this.Controls.Add(this.tbNume);
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

        private System.Windows.Forms.TextBox tbNume;
        private System.Windows.Forms.TextBox tbPrenume;
        private System.Windows.Forms.TextBox tbVarsta;
        private System.Windows.Forms.TextBox tbMatricol;
        private System.Windows.Forms.TextBox tbMedie;
        private System.Windows.Forms.TextBox tbMaterii;
        private System.Windows.Forms.Button btnAdaugareStud;
        private System.Windows.Forms.TreeView tvStudenti;
        private System.Windows.Forms.Button btnAfisareStudTV;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem binToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ListView lvAfisareStud;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
    }
}

