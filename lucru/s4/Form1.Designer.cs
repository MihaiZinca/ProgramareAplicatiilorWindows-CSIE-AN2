namespace s4
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
            this.tbFacultate = new System.Windows.Forms.TextBox();
            this.tbNote = new System.Windows.Forms.TextBox();
            this.btnAdauga = new System.Windows.Forms.Button();
            this.tbStudenti = new System.Windows.Forms.TextBox();
            this.btnAfiseazaStud = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAfiseazaStudLV = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.binToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbNume
            // 
            this.tbNume.Location = new System.Drawing.Point(22, 39);
            this.tbNume.Name = "tbNume";
            this.tbNume.Size = new System.Drawing.Size(100, 22);
            this.tbNume.TabIndex = 0;
            // 
            // tbFacultate
            // 
            this.tbFacultate.Location = new System.Drawing.Point(22, 85);
            this.tbFacultate.Name = "tbFacultate";
            this.tbFacultate.Size = new System.Drawing.Size(100, 22);
            this.tbFacultate.TabIndex = 1;
            // 
            // tbNote
            // 
            this.tbNote.Location = new System.Drawing.Point(22, 124);
            this.tbNote.Name = "tbNote";
            this.tbNote.Size = new System.Drawing.Size(100, 22);
            this.tbNote.TabIndex = 2;
            // 
            // btnAdauga
            // 
            this.btnAdauga.Location = new System.Drawing.Point(22, 175);
            this.btnAdauga.Name = "btnAdauga";
            this.btnAdauga.Size = new System.Drawing.Size(75, 23);
            this.btnAdauga.TabIndex = 3;
            this.btnAdauga.Text = "Adauga";
            this.btnAdauga.UseVisualStyleBackColor = true;
            this.btnAdauga.Click += new System.EventHandler(this.btnAdauga_Click);
            // 
            // tbStudenti
            // 
            this.tbStudenti.Location = new System.Drawing.Point(217, 39);
            this.tbStudenti.Multiline = true;
            this.tbStudenti.Name = "tbStudenti";
            this.tbStudenti.Size = new System.Drawing.Size(279, 107);
            this.tbStudenti.TabIndex = 4;
            // 
            // btnAfiseazaStud
            // 
            this.btnAfiseazaStud.Location = new System.Drawing.Point(244, 175);
            this.btnAfiseazaStud.Name = "btnAfiseazaStud";
            this.btnAfiseazaStud.Size = new System.Drawing.Size(181, 23);
            this.btnAfiseazaStud.TabIndex = 5;
            this.btnAfiseazaStud.Text = "Afiseaza stud";
            this.btnAfiseazaStud.UseVisualStyleBackColor = true;
            this.btnAfiseazaStud.Click += new System.EventHandler(this.btnAfiseazaStud_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(22, 224);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(256, 117);
            this.listView1.TabIndex = 6;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nume";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Facultate";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Medie";
            // 
            // btnAfiseazaStudLV
            // 
            this.btnAfiseazaStudLV.Location = new System.Drawing.Point(22, 364);
            this.btnAfiseazaStudLV.Name = "btnAfiseazaStudLV";
            this.btnAfiseazaStudLV.Size = new System.Drawing.Size(161, 23);
            this.btnAfiseazaStudLV.TabIndex = 7;
            this.btnAfiseazaStudLV.Text = "Afiseaza stud LV";
            this.btnAfiseazaStudLV.UseVisualStyleBackColor = true;
            this.btnAfiseazaStudLV.Click += new System.EventHandler(this.btnAfiseazaStudLV_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.textToolStripMenuItem,
            this.binToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // textToolStripMenuItem
            // 
            this.textToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.openToolStripMenuItem});
            this.textToolStripMenuItem.Name = "textToolStripMenuItem";
            this.textToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.textToolStripMenuItem.Text = "Text";
            // 
            // binToolStripMenuItem
            // 
            this.binToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem1,
            this.openToolStripMenuItem1});
            this.binToolStripMenuItem.Name = "binToolStripMenuItem";
            this.binToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.binToolStripMenuItem.Text = "Bin";
            this.binToolStripMenuItem.Click += new System.EventHandler(this.binToolStripMenuItem_Click);
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
            // saveToolStripMenuItem1
            // 
            this.saveToolStripMenuItem1.Name = "saveToolStripMenuItem1";
            this.saveToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.saveToolStripMenuItem1.Text = "Save";
            this.saveToolStripMenuItem1.Click += new System.EventHandler(this.saveToolStripMenuItem1_Click);
            // 
            // openToolStripMenuItem1
            // 
            this.openToolStripMenuItem1.Name = "openToolStripMenuItem1";
            this.openToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.openToolStripMenuItem1.Text = "Open";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAfiseazaStudLV);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnAfiseazaStud);
            this.Controls.Add(this.tbStudenti);
            this.Controls.Add(this.btnAdauga);
            this.Controls.Add(this.tbNote);
            this.Controls.Add(this.tbFacultate);
            this.Controls.Add(this.tbNume);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNume;
        private System.Windows.Forms.TextBox tbFacultate;
        private System.Windows.Forms.TextBox tbNote;
        private System.Windows.Forms.Button btnAdauga;
        private System.Windows.Forms.TextBox tbStudenti;
        private System.Windows.Forms.Button btnAfiseazaStud;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button btnAfiseazaStudLV;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem textToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem binToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

