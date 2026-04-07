namespace s6
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
            this.lvStudenti = new System.Windows.Forms.ListView();
            this.tvStudenti = new System.Windows.Forms.TreeView();
            this.tbStudenti = new System.Windows.Forms.TextBox();
            this.tbnPopulareLV = new System.Windows.Forms.Button();
            this.btnStergeElementLV = new System.Windows.Forms.Button();
            this.btnPopulareTV = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.stergeElementLVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.stergeElementTVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvStudenti
            // 
            this.lvStudenti.CheckBoxes = true;
            this.lvStudenti.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvStudenti.GridLines = true;
            this.lvStudenti.HideSelection = false;
            this.lvStudenti.Location = new System.Drawing.Point(12, 38);
            this.lvStudenti.Name = "lvStudenti";
            this.lvStudenti.Size = new System.Drawing.Size(210, 194);
            this.lvStudenti.TabIndex = 0;
            this.lvStudenti.UseCompatibleStateImageBehavior = false;
            this.lvStudenti.View = System.Windows.Forms.View.Details;
            this.lvStudenti.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.lvStudenti_ItemChecked);
            // 
            // tvStudenti
            // 
            this.tvStudenti.Location = new System.Drawing.Point(240, 38);
            this.tvStudenti.Name = "tvStudenti";
            this.tvStudenti.Size = new System.Drawing.Size(218, 194);
            this.tvStudenti.TabIndex = 1;
            this.tvStudenti.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvStudenti_AfterSelect);
            // 
            // tbStudenti
            // 
            this.tbStudenti.Location = new System.Drawing.Point(484, 38);
            this.tbStudenti.Multiline = true;
            this.tbStudenti.Name = "tbStudenti";
            this.tbStudenti.ReadOnly = true;
            this.tbStudenti.Size = new System.Drawing.Size(233, 194);
            this.tbStudenti.TabIndex = 2;
            // 
            // tbnPopulareLV
            // 
            this.tbnPopulareLV.Location = new System.Drawing.Point(26, 261);
            this.tbnPopulareLV.Name = "tbnPopulareLV";
            this.tbnPopulareLV.Size = new System.Drawing.Size(127, 23);
            this.tbnPopulareLV.TabIndex = 3;
            this.tbnPopulareLV.Text = "PopulareLV";
            this.tbnPopulareLV.UseVisualStyleBackColor = true;
            this.tbnPopulareLV.Click += new System.EventHandler(this.tbnPopulareLV_Click);
            // 
            // btnStergeElementLV
            // 
            this.btnStergeElementLV.Location = new System.Drawing.Point(26, 290);
            this.btnStergeElementLV.Name = "btnStergeElementLV";
            this.btnStergeElementLV.Size = new System.Drawing.Size(127, 23);
            this.btnStergeElementLV.TabIndex = 4;
            this.btnStergeElementLV.Text = "Sterge element LV";
            this.btnStergeElementLV.UseVisualStyleBackColor = true;
            this.btnStergeElementLV.Click += new System.EventHandler(this.btnStergeElementLV_Click);
            // 
            // btnPopulareTV
            // 
            this.btnPopulareTV.Location = new System.Drawing.Point(269, 261);
            this.btnPopulareTV.Name = "btnPopulareTV";
            this.btnPopulareTV.Size = new System.Drawing.Size(165, 23);
            this.btnPopulareTV.TabIndex = 5;
            this.btnPopulareTV.Text = "Populare TV";
            this.btnPopulareTV.UseVisualStyleBackColor = true;
            this.btnPopulareTV.Click += new System.EventHandler(this.btnPopulareTV_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stergeElementLVToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(199, 28);
            // 
            // stergeElementLVToolStripMenuItem
            // 
            this.stergeElementLVToolStripMenuItem.Name = "stergeElementLVToolStripMenuItem";
            this.stergeElementLVToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.stergeElementLVToolStripMenuItem.Text = "Sterge element LV";
            this.stergeElementLVToolStripMenuItem.Click += new System.EventHandler(this.stergeElementLVToolStripMenuItem_Click);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stergeElementTVToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(201, 28);
            // 
            // stergeElementTVToolStripMenuItem
            // 
            this.stergeElementTVToolStripMenuItem.Name = "stergeElementTVToolStripMenuItem";
            this.stergeElementTVToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.stergeElementTVToolStripMenuItem.Text = "Sterge element TV";
            this.stergeElementTVToolStripMenuItem.Click += new System.EventHandler(this.stergeElementTVToolStripMenuItem_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Matricol";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nume";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Medie";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Observatie";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPopulareTV);
            this.Controls.Add(this.btnStergeElementLV);
            this.Controls.Add(this.tbnPopulareLV);
            this.Controls.Add(this.tbStudenti);
            this.Controls.Add(this.tvStudenti);
            this.Controls.Add(this.lvStudenti);
            this.Name = "Form1";
            this.Text = "Form1";
            this.contextMenuStrip1.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvStudenti;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.TreeView tvStudenti;
        private System.Windows.Forms.TextBox tbStudenti;
        private System.Windows.Forms.Button tbnPopulareLV;
        private System.Windows.Forms.Button btnStergeElementLV;
        private System.Windows.Forms.Button btnPopulareTV;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem stergeElementLVToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem stergeElementTVToolStripMenuItem;
    }
}

