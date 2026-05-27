namespace Biciclete
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
            this.lvBiciclete = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbUtilizatori = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.sumaTotalaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnGrafic = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.previewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serializareBicicleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serializareUtilizatoriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvBiciclete
            // 
            this.lvBiciclete.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvBiciclete.FullRowSelect = true;
            this.lvBiciclete.GridLines = true;
            this.lvBiciclete.HideSelection = false;
            this.lvBiciclete.Location = new System.Drawing.Point(42, 81);
            this.lvBiciclete.MultiSelect = false;
            this.lvBiciclete.Name = "lvBiciclete";
            this.lvBiciclete.Size = new System.Drawing.Size(298, 182);
            this.lvBiciclete.TabIndex = 0;
            this.lvBiciclete.UseCompatibleStateImageBehavior = false;
            this.lvBiciclete.View = System.Windows.Forms.View.Details;
            this.lvBiciclete.SelectedIndexChanged += new System.EventHandler(this.lvBiciclete_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "CodB";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "StatieParcare";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Km parcursi";
            // 
            // lbUtilizatori
            // 
            this.lbUtilizatori.FormattingEnabled = true;
            this.lbUtilizatori.ItemHeight = 16;
            this.lbUtilizatori.Location = new System.Drawing.Point(403, 81);
            this.lbUtilizatori.Name = "lbUtilizatori";
            this.lbUtilizatori.Size = new System.Drawing.Size(286, 180);
            this.lbUtilizatori.TabIndex = 1;
            this.lbUtilizatori.DoubleClick += new System.EventHandler(this.lbUtilizatori_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 305);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Suma totala incasata:";
            // 
            // tbTotal
            // 
            this.tbTotal.Location = new System.Drawing.Point(180, 302);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.ReadOnly = true;
            this.tbTotal.Size = new System.Drawing.Size(100, 22);
            this.tbTotal.TabIndex = 3;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sumaTotalaToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(159, 28);
            // 
            // sumaTotalaToolStripMenuItem
            // 
            this.sumaTotalaToolStripMenuItem.Name = "sumaTotalaToolStripMenuItem";
            this.sumaTotalaToolStripMenuItem.Size = new System.Drawing.Size(158, 24);
            this.sumaTotalaToolStripMenuItem.Text = "Suma totala";
            this.sumaTotalaToolStripMenuItem.Click += new System.EventHandler(this.sumaTotalaToolStripMenuItem_Click);
            // 
            // btnGrafic
            // 
            this.btnGrafic.Location = new System.Drawing.Point(42, 368);
            this.btnGrafic.Name = "btnGrafic";
            this.btnGrafic.Size = new System.Drawing.Size(136, 23);
            this.btnGrafic.TabIndex = 4;
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
            this.menuStrip1.TabIndex = 5;
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
            this.serializareBicicleteToolStripMenuItem,
            this.serializareUtilizatoriToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // serializareBicicleteToolStripMenuItem
            // 
            this.serializareBicicleteToolStripMenuItem.Name = "serializareBicicleteToolStripMenuItem";
            this.serializareBicicleteToolStripMenuItem.Size = new System.Drawing.Size(228, 26);
            this.serializareBicicleteToolStripMenuItem.Text = "Serializare biciclete";
            this.serializareBicicleteToolStripMenuItem.Click += new System.EventHandler(this.serializareBicicleteToolStripMenuItem_Click);
            // 
            // serializareUtilizatoriToolStripMenuItem
            // 
            this.serializareUtilizatoriToolStripMenuItem.Name = "serializareUtilizatoriToolStripMenuItem";
            this.serializareUtilizatoriToolStripMenuItem.Size = new System.Drawing.Size(228, 26);
            this.serializareUtilizatoriToolStripMenuItem.Text = "Serializare utilizatori";
            this.serializareUtilizatoriToolStripMenuItem.Click += new System.EventHandler(this.serializareUtilizatoriToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGrafic);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.tbTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbUtilizatori);
            this.Controls.Add(this.lvBiciclete);
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

        private System.Windows.Forms.ListView lvBiciclete;
        private System.Windows.Forms.ListBox lbUtilizatori;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbTotal;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sumaTotalaToolStripMenuItem;
        private System.Windows.Forms.Button btnGrafic;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem previewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serializareBicicleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serializareUtilizatoriToolStripMenuItem;
    }
}

