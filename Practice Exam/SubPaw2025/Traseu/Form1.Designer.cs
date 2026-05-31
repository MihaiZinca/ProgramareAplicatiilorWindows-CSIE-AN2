namespace Traseu
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
            this.lvTraseu = new System.Windows.Forms.ListView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adaugareLocatieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvareBinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restaurareBinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvTraseu
            // 
            this.lvTraseu.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvTraseu.GridLines = true;
            this.lvTraseu.HideSelection = false;
            this.lvTraseu.Location = new System.Drawing.Point(-1, 31);
            this.lvTraseu.Name = "lvTraseu";
            this.lvTraseu.Size = new System.Drawing.Size(415, 419);
            this.lvTraseu.TabIndex = 0;
            this.lvTraseu.UseCompatibleStateImageBehavior = false;
            this.lvTraseu.View = System.Windows.Forms.View.Details;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.splitter1);
            this.panel1.Location = new System.Drawing.Point(405, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(393, 419);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.Resize += new System.EventHandler(this.panel1_Resize);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 419);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "X";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Y";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adaugareLocatieToolStripMenuItem,
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // adaugareLocatieToolStripMenuItem
            // 
            this.adaugareLocatieToolStripMenuItem.Name = "adaugareLocatieToolStripMenuItem";
            this.adaugareLocatieToolStripMenuItem.Size = new System.Drawing.Size(137, 24);
            this.adaugareLocatieToolStripMenuItem.Text = "Adaugare locatie";
            this.adaugareLocatieToolStripMenuItem.Click += new System.EventHandler(this.adaugareLocatieToolStripMenuItem_Click);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salvareBinToolStripMenuItem,
            this.restaurareBinToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // salvareBinToolStripMenuItem
            // 
            this.salvareBinToolStripMenuItem.Name = "salvareBinToolStripMenuItem";
            this.salvareBinToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.salvareBinToolStripMenuItem.Text = "Salvare bin";
            this.salvareBinToolStripMenuItem.Click += new System.EventHandler(this.salvareBinToolStripMenuItem_Click);
            // 
            // restaurareBinToolStripMenuItem
            // 
            this.restaurareBinToolStripMenuItem.Name = "restaurareBinToolStripMenuItem";
            this.restaurareBinToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.restaurareBinToolStripMenuItem.Text = "Restaurare bin";
            this.restaurareBinToolStripMenuItem.Click += new System.EventHandler(this.restaurareBinToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 444);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 26);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(122, 20);
            this.toolStripStatusLabel1.Text = "Lungime curenta:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 470);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lvTraseu);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvTraseu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adaugareLocatieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvareBinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restaurareBinToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}

