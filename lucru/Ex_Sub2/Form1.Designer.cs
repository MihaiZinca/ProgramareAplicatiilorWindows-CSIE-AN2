namespace Ex_Sub2
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
            this.tbOreLucrate = new System.Windows.Forms.TextBox();
            this.tbSalariuOrar = new System.Windows.Forms.TextBox();
            this.btnAdaugareAng = new System.Windows.Forms.Button();
            this.lvAngajati = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnArata = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.saveTxtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openTxtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbNume
            // 
            this.tbNume.Location = new System.Drawing.Point(28, 47);
            this.tbNume.Name = "tbNume";
            this.tbNume.Size = new System.Drawing.Size(125, 22);
            this.tbNume.TabIndex = 0;
            // 
            // tbOreLucrate
            // 
            this.tbOreLucrate.Location = new System.Drawing.Point(28, 165);
            this.tbOreLucrate.Name = "tbOreLucrate";
            this.tbOreLucrate.Size = new System.Drawing.Size(125, 22);
            this.tbOreLucrate.TabIndex = 1;
            // 
            // tbSalariuOrar
            // 
            this.tbSalariuOrar.Location = new System.Drawing.Point(28, 101);
            this.tbSalariuOrar.Name = "tbSalariuOrar";
            this.tbSalariuOrar.Size = new System.Drawing.Size(125, 22);
            this.tbSalariuOrar.TabIndex = 2;
            // 
            // btnAdaugareAng
            // 
            this.btnAdaugareAng.Location = new System.Drawing.Point(28, 224);
            this.btnAdaugareAng.Name = "btnAdaugareAng";
            this.btnAdaugareAng.Size = new System.Drawing.Size(125, 48);
            this.btnAdaugareAng.TabIndex = 4;
            this.btnAdaugareAng.Text = "Adaugare angajat";
            this.btnAdaugareAng.UseVisualStyleBackColor = true;
            this.btnAdaugareAng.Click += new System.EventHandler(this.btnAdaugareAng_Click);
            // 
            // lvAngajati
            // 
            this.lvAngajati.CheckBoxes = true;
            this.lvAngajati.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvAngajati.GridLines = true;
            this.lvAngajati.HideSelection = false;
            this.lvAngajati.Location = new System.Drawing.Point(240, 36);
            this.lvAngajati.Name = "lvAngajati";
            this.lvAngajati.Size = new System.Drawing.Size(310, 171);
            this.lvAngajati.TabIndex = 5;
            this.lvAngajati.UseCompatibleStateImageBehavior = false;
            this.lvAngajati.View = System.Windows.Forms.View.Details;
            this.lvAngajati.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.lvAngajati_ItemChecked);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nume";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ore Lucrate";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Salariu orar";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Salariu";
            // 
            // btnArata
            // 
            this.btnArata.Location = new System.Drawing.Point(295, 224);
            this.btnArata.Name = "btnArata";
            this.btnArata.Size = new System.Drawing.Size(161, 48);
            this.btnArata.TabIndex = 6;
            this.btnArata.Text = "Arata toti angajatii";
            this.btnArata.UseVisualStyleBackColor = true;
            this.btnArata.Click += new System.EventHandler(this.btnArata_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveTxtToolStripMenuItem,
            this.openTxtToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(573, 28);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // saveTxtToolStripMenuItem
            // 
            this.saveTxtToolStripMenuItem.Name = "saveTxtToolStripMenuItem";
            this.saveTxtToolStripMenuItem.Size = new System.Drawing.Size(76, 24);
            this.saveTxtToolStripMenuItem.Text = "Save.Txt";
            this.saveTxtToolStripMenuItem.Click += new System.EventHandler(this.saveTxtToolStripMenuItem_Click);
            // 
            // openTxtToolStripMenuItem
            // 
            this.openTxtToolStripMenuItem.Name = "openTxtToolStripMenuItem";
            this.openTxtToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.openTxtToolStripMenuItem.Text = "Open.Txt";
            this.openTxtToolStripMenuItem.Click += new System.EventHandler(this.openTxtToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 291);
            this.Controls.Add(this.btnArata);
            this.Controls.Add(this.lvAngajati);
            this.Controls.Add(this.btnAdaugareAng);
            this.Controls.Add(this.tbSalariuOrar);
            this.Controls.Add(this.tbOreLucrate);
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
        private System.Windows.Forms.TextBox tbOreLucrate;
        private System.Windows.Forms.TextBox tbSalariuOrar;
        private System.Windows.Forms.Button btnAdaugareAng;
        private System.Windows.Forms.ListView lvAngajati;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button btnArata;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem saveTxtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openTxtToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

