namespace ProgramMaster
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
            this.lvCandidati = new System.Windows.Forms.ListView();
            this.lbPrograme = new System.Windows.Forms.ListBox();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAdaugareCandidat = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.stergereToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnGrafic = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.previewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serializareCandidatiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serializareProgrameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvCandidati
            // 
            this.lvCandidati.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvCandidati.FullRowSelect = true;
            this.lvCandidati.GridLines = true;
            this.lvCandidati.HideSelection = false;
            this.lvCandidati.Location = new System.Drawing.Point(38, 110);
            this.lvCandidati.Name = "lvCandidati";
            this.lvCandidati.Size = new System.Drawing.Size(330, 196);
            this.lvCandidati.TabIndex = 0;
            this.lvCandidati.UseCompatibleStateImageBehavior = false;
            this.lvCandidati.View = System.Windows.Forms.View.Details;
            // 
            // lbPrograme
            // 
            this.lbPrograme.FormattingEnabled = true;
            this.lbPrograme.ItemHeight = 16;
            this.lbPrograme.Location = new System.Drawing.Point(411, 110);
            this.lbPrograme.Name = "lbPrograme";
            this.lbPrograme.Size = new System.Drawing.Size(289, 196);
            this.lbPrograme.TabIndex = 1;
            this.lbPrograme.SelectedIndexChanged += new System.EventHandler(this.lbPrograme_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Cod";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nume";
            this.columnHeader2.Width = 64;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Medie";
            this.columnHeader3.Width = 78;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Optiuni";
            this.columnHeader4.Width = 106;
            // 
            // btnAdaugareCandidat
            // 
            this.btnAdaugareCandidat.Location = new System.Drawing.Point(81, 333);
            this.btnAdaugareCandidat.Name = "btnAdaugareCandidat";
            this.btnAdaugareCandidat.Size = new System.Drawing.Size(154, 34);
            this.btnAdaugareCandidat.TabIndex = 2;
            this.btnAdaugareCandidat.Text = "Adaugare Candidat";
            this.btnAdaugareCandidat.UseVisualStyleBackColor = true;
            this.btnAdaugareCandidat.Click += new System.EventHandler(this.btnAdaugareCandidat_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stergereToolStripMenuItem,
            this.editareToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(135, 52);
            // 
            // stergereToolStripMenuItem
            // 
            this.stergereToolStripMenuItem.Name = "stergereToolStripMenuItem";
            this.stergereToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.stergereToolStripMenuItem.Text = "Stergere";
            this.stergereToolStripMenuItem.Click += new System.EventHandler(this.stergereToolStripMenuItem_Click);
            // 
            // editareToolStripMenuItem
            // 
            this.editareToolStripMenuItem.Name = "editareToolStripMenuItem";
            this.editareToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.editareToolStripMenuItem.Text = "Editare";
            this.editareToolStripMenuItem.Click += new System.EventHandler(this.editareToolStripMenuItem_Click);
            // 
            // btnGrafic
            // 
            this.btnGrafic.Location = new System.Drawing.Point(286, 333);
            this.btnGrafic.Name = "btnGrafic";
            this.btnGrafic.Size = new System.Drawing.Size(156, 34);
            this.btnGrafic.TabIndex = 5;
            this.btnGrafic.Text = "Afisare Grafic";
            this.btnGrafic.UseVisualStyleBackColor = true;
            this.btnGrafic.Click += new System.EventHandler(this.btnGrafic_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.previewToolStripMenuItem,
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // previewToolStripMenuItem
            // 
            this.previewToolStripMenuItem.Name = "previewToolStripMenuItem";
            this.previewToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.previewToolStripMenuItem.Text = "Preview";
            this.previewToolStripMenuItem.Click += new System.EventHandler(this.previewToolStripMenuItem_Click);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serializareCandidatiToolStripMenuItem,
            this.serializareProgrameToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // serializareCandidatiToolStripMenuItem
            // 
            this.serializareCandidatiToolStripMenuItem.Name = "serializareCandidatiToolStripMenuItem";
            this.serializareCandidatiToolStripMenuItem.Size = new System.Drawing.Size(231, 26);
            this.serializareCandidatiToolStripMenuItem.Text = "Serializare candidati";
            this.serializareCandidatiToolStripMenuItem.Click += new System.EventHandler(this.serializareCandidatiToolStripMenuItem_Click);
            // 
            // serializareProgrameToolStripMenuItem
            // 
            this.serializareProgrameToolStripMenuItem.Name = "serializareProgrameToolStripMenuItem";
            this.serializareProgrameToolStripMenuItem.Size = new System.Drawing.Size(231, 26);
            this.serializareProgrameToolStripMenuItem.Text = "Serializare programe";
            this.serializareProgrameToolStripMenuItem.Click += new System.EventHandler(this.serializareProgrameToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGrafic);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnAdaugareCandidat);
            this.Controls.Add(this.lbPrograme);
            this.Controls.Add(this.lvCandidati);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvCandidati;
        private System.Windows.Forms.ListBox lbPrograme;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button btnAdaugareCandidat;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem stergereToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editareToolStripMenuItem;
        private System.Windows.Forms.Button btnGrafic;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem previewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serializareCandidatiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serializareProgrameToolStripMenuItem;
    }
}

