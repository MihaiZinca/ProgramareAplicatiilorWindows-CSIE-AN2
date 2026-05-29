namespace CosCumparaturi
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
            this.lvCos = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAdaugare = new System.Windows.Forms.Button();
            this.btnAfisare = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.lVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stergereProdusCosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificareProdusCosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.previewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvCos
            // 
            this.lvCos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lvCos.FullRowSelect = true;
            this.lvCos.GridLines = true;
            this.lvCos.HideSelection = false;
            this.lvCos.Location = new System.Drawing.Point(28, 134);
            this.lvCos.Name = "lvCos";
            this.lvCos.Size = new System.Drawing.Size(405, 161);
            this.lvCos.TabIndex = 2;
            this.lvCos.UseCompatibleStateImageBehavior = false;
            this.lvCos.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Cod";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Denumire";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Pret";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Cantitate";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Valoare totala";
            // 
            // btnAdaugare
            // 
            this.btnAdaugare.Location = new System.Drawing.Point(114, 65);
            this.btnAdaugare.Name = "btnAdaugare";
            this.btnAdaugare.Size = new System.Drawing.Size(190, 46);
            this.btnAdaugare.TabIndex = 3;
            this.btnAdaugare.Text = "Adauga Produs";
            this.btnAdaugare.UseVisualStyleBackColor = true;
            this.btnAdaugare.Click += new System.EventHandler(this.btnAdaugare_Click);
            // 
            // btnAfisare
            // 
            this.btnAfisare.Location = new System.Drawing.Point(162, 316);
            this.btnAfisare.Name = "btnAfisare";
            this.btnAfisare.Size = new System.Drawing.Size(125, 42);
            this.btnAfisare.TabIndex = 4;
            this.btnAfisare.Text = "Afisare Cos";
            this.btnAfisare.UseVisualStyleBackColor = true;
            this.btnAfisare.Click += new System.EventHandler(this.btnAfisare_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 28);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(14, 20);
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lVToolStripMenuItem,
            this.previewToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(800, 28);
            this.menuStrip2.TabIndex = 6;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // lVToolStripMenuItem
            // 
            this.lVToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stergereProdusCosToolStripMenuItem,
            this.modificareProdusCosToolStripMenuItem});
            this.lVToolStripMenuItem.Name = "lVToolStripMenuItem";
            this.lVToolStripMenuItem.Size = new System.Drawing.Size(38, 24);
            this.lVToolStripMenuItem.Text = "LV";
            // 
            // stergereProdusCosToolStripMenuItem
            // 
            this.stergereProdusCosToolStripMenuItem.Name = "stergereProdusCosToolStripMenuItem";
            this.stergereProdusCosToolStripMenuItem.Size = new System.Drawing.Size(240, 26);
            this.stergereProdusCosToolStripMenuItem.Text = "Stergere produs cos";
            this.stergereProdusCosToolStripMenuItem.Click += new System.EventHandler(this.stergereProdusCosToolStripMenuItem_Click);
            // 
            // modificareProdusCosToolStripMenuItem
            // 
            this.modificareProdusCosToolStripMenuItem.Name = "modificareProdusCosToolStripMenuItem";
            this.modificareProdusCosToolStripMenuItem.Size = new System.Drawing.Size(240, 26);
            this.modificareProdusCosToolStripMenuItem.Text = "Modificare produs cos";
            this.modificareProdusCosToolStripMenuItem.Click += new System.EventHandler(this.modificareProdusCosToolStripMenuItem_Click);
            // 
            // previewToolStripMenuItem
            // 
            this.previewToolStripMenuItem.Name = "previewToolStripMenuItem";
            this.previewToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.previewToolStripMenuItem.Text = "Preview";
            this.previewToolStripMenuItem.Click += new System.EventHandler(this.previewToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.saveToolStripMenuItem.Text = "Save txt";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAfisare);
            this.Controls.Add(this.btnAdaugare);
            this.Controls.Add(this.lvCos);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvCos;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button btnAdaugare;
        private System.Windows.Forms.Button btnAfisare;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem lVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stergereProdusCosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificareProdusCosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem previewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

