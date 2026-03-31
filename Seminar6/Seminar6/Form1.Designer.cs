namespace Seminar6
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
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tvStudenti = new System.Windows.Forms.TreeView();
            this.tbStudenti = new System.Windows.Forms.TextBox();
            this.btnPreluareLV = new System.Windows.Forms.Button();
            this.btnStergeElemLV = new System.Windows.Forms.Button();
            this.btnPopulareTV = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.stergeElemtLVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.stergeElementTVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.lvStudenti.Location = new System.Drawing.Point(11, 61);
            this.lvStudenti.Name = "lvStudenti";
            this.lvStudenti.Size = new System.Drawing.Size(305, 235);
            this.lvStudenti.TabIndex = 0;
            this.lvStudenti.UseCompatibleStateImageBehavior = false;
            this.lvStudenti.View = System.Windows.Forms.View.Details;
            this.lvStudenti.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.lvStudenti_ItemChecked);
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
            // tvStudenti
            // 
            this.tvStudenti.Location = new System.Drawing.Point(352, 61);
            this.tvStudenti.Name = "tvStudenti";
            this.tvStudenti.Size = new System.Drawing.Size(276, 235);
            this.tvStudenti.TabIndex = 1;
            this.tvStudenti.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvStudenti_AfterSelect);
            // 
            // tbStudenti
            // 
            this.tbStudenti.Location = new System.Drawing.Point(696, 70);
            this.tbStudenti.Multiline = true;
            this.tbStudenti.Name = "tbStudenti";
            this.tbStudenti.ReadOnly = true;
            this.tbStudenti.Size = new System.Drawing.Size(280, 226);
            this.tbStudenti.TabIndex = 2;
            // 
            // btnPreluareLV
            // 
            this.btnPreluareLV.Location = new System.Drawing.Point(25, 348);
            this.btnPreluareLV.Name = "btnPreluareLV";
            this.btnPreluareLV.Size = new System.Drawing.Size(108, 53);
            this.btnPreluareLV.TabIndex = 3;
            this.btnPreluareLV.Text = "PopulareLV";
            this.btnPreluareLV.UseVisualStyleBackColor = true;
            this.btnPreluareLV.Click += new System.EventHandler(this.btnPreluareLV_Click);
            // 
            // btnStergeElemLV
            // 
            this.btnStergeElemLV.Location = new System.Drawing.Point(199, 348);
            this.btnStergeElemLV.Name = "btnStergeElemLV";
            this.btnStergeElemLV.Size = new System.Drawing.Size(103, 53);
            this.btnStergeElemLV.TabIndex = 4;
            this.btnStergeElemLV.Text = "Stergere element LV";
            this.btnStergeElemLV.UseVisualStyleBackColor = true;
            this.btnStergeElemLV.Click += new System.EventHandler(this.btnStergeElemLV_Click);
            // 
            // btnPopulareTV
            // 
            this.btnPopulareTV.Location = new System.Drawing.Point(330, 348);
            this.btnPopulareTV.Name = "btnPopulareTV";
            this.btnPopulareTV.Size = new System.Drawing.Size(118, 53);
            this.btnPopulareTV.TabIndex = 5;
            this.btnPopulareTV.Text = "Populare TV";
            this.btnPopulareTV.UseVisualStyleBackColor = true;
            this.btnPopulareTV.Click += new System.EventHandler(this.btnPopulareTV_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stergeElemtLVToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(207, 36);
            // 
            // stergeElemtLVToolStripMenuItem
            // 
            this.stergeElemtLVToolStripMenuItem.Name = "stergeElemtLVToolStripMenuItem";
            this.stergeElemtLVToolStripMenuItem.Size = new System.Drawing.Size(206, 32);
            this.stergeElemtLVToolStripMenuItem.Text = "Sterge Elemt LV";
            this.stergeElemtLVToolStripMenuItem.Click += new System.EventHandler(this.stergeElemtLVToolStripMenuItem_Click);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stergeElementTVToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(241, 69);
            // 
            // stergeElementTVToolStripMenuItem
            // 
            this.stergeElementTVToolStripMenuItem.Name = "stergeElementTVToolStripMenuItem";
            this.stergeElementTVToolStripMenuItem.Size = new System.Drawing.Size(240, 32);
            this.stergeElementTVToolStripMenuItem.Text = "Sterge element TV";
            this.stergeElementTVToolStripMenuItem.Click += new System.EventHandler(this.stergeElementTVToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 599);
            this.Controls.Add(this.btnPopulareTV);
            this.Controls.Add(this.btnStergeElemLV);
            this.Controls.Add(this.btnPreluareLV);
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
        private System.Windows.Forms.Button btnPreluareLV;
        private System.Windows.Forms.Button btnStergeElemLV;
        private System.Windows.Forms.Button btnPopulareTV;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem stergeElemtLVToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem stergeElementTVToolStripMenuItem;
    }
}

