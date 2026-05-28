namespace RezervareHotel
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
            this.tvHotel = new System.Windows.Forms.TreeView();
            this.btnAfisareHot = new System.Windows.Forms.Button();
            this.btnAdaugareHotel = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stergereHotelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editareHotelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAdaugareRez = new System.Windows.Forms.Button();
            this.salvareInBDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelGrafic = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tvHotel
            // 
            this.tvHotel.Location = new System.Drawing.Point(12, 108);
            this.tvHotel.Name = "tvHotel";
            this.tvHotel.Size = new System.Drawing.Size(368, 237);
            this.tvHotel.TabIndex = 0;
            this.tvHotel.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvHotel_AfterSelect);
            // 
            // btnAfisareHot
            // 
            this.btnAfisareHot.Location = new System.Drawing.Point(93, 362);
            this.btnAfisareHot.Name = "btnAfisareHot";
            this.btnAfisareHot.Size = new System.Drawing.Size(173, 57);
            this.btnAfisareHot.TabIndex = 1;
            this.btnAfisareHot.Text = "Afisare Hoteluri";
            this.btnAfisareHot.UseVisualStyleBackColor = true;
            this.btnAfisareHot.Click += new System.EventHandler(this.btnAfisareHot_Click);
            // 
            // btnAdaugareHotel
            // 
            this.btnAdaugareHotel.Location = new System.Drawing.Point(83, 41);
            this.btnAdaugareHotel.Name = "btnAdaugareHotel";
            this.btnAdaugareHotel.Size = new System.Drawing.Size(173, 49);
            this.btnAdaugareHotel.TabIndex = 2;
            this.btnAdaugareHotel.Text = "Adagua Hotel";
            this.btnAdaugareHotel.UseVisualStyleBackColor = true;
            this.btnAdaugareHotel.Click += new System.EventHandler(this.btnAdaugareHotel_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tVToolStripMenuItem,
            this.salvareInBDToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(962, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tVToolStripMenuItem
            // 
            this.tVToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stergereHotelToolStripMenuItem,
            this.editareHotelToolStripMenuItem});
            this.tVToolStripMenuItem.Name = "tVToolStripMenuItem";
            this.tVToolStripMenuItem.Size = new System.Drawing.Size(40, 24);
            this.tVToolStripMenuItem.Text = "TV";
            // 
            // stergereHotelToolStripMenuItem
            // 
            this.stergereHotelToolStripMenuItem.Name = "stergereHotelToolStripMenuItem";
            this.stergereHotelToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.stergereHotelToolStripMenuItem.Text = "Stergere hotel";
            this.stergereHotelToolStripMenuItem.Click += new System.EventHandler(this.stergereHotelToolStripMenuItem_Click);
            // 
            // editareHotelToolStripMenuItem
            // 
            this.editareHotelToolStripMenuItem.Name = "editareHotelToolStripMenuItem";
            this.editareHotelToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.editareHotelToolStripMenuItem.Text = "Editare hotel";
            this.editareHotelToolStripMenuItem.Click += new System.EventHandler(this.editareHotelToolStripMenuItem_Click);
            // 
            // btnAdaugareRez
            // 
            this.btnAdaugareRez.Location = new System.Drawing.Point(93, 441);
            this.btnAdaugareRez.Name = "btnAdaugareRez";
            this.btnAdaugareRez.Size = new System.Drawing.Size(173, 62);
            this.btnAdaugareRez.TabIndex = 4;
            this.btnAdaugareRez.Text = "Adauga Rezervare";
            this.btnAdaugareRez.UseVisualStyleBackColor = true;
            this.btnAdaugareRez.Click += new System.EventHandler(this.btnAdaugareRez_Click);
            // 
            // salvareInBDToolStripMenuItem
            // 
            this.salvareInBDToolStripMenuItem.Name = "salvareInBDToolStripMenuItem";
            this.salvareInBDToolStripMenuItem.Size = new System.Drawing.Size(111, 24);
            this.salvareInBDToolStripMenuItem.Text = "Salvare in BD";
            this.salvareInBDToolStripMenuItem.Click += new System.EventHandler(this.salvareInBDToolStripMenuItem_Click);
            // 
            // panelGrafic
            // 
            this.panelGrafic.Location = new System.Drawing.Point(468, 108);
            this.panelGrafic.Name = "panelGrafic";
            this.panelGrafic.Size = new System.Drawing.Size(397, 322);
            this.panelGrafic.TabIndex = 5;
            this.panelGrafic.Paint += new System.Windows.Forms.PaintEventHandler(this.panelGrafic_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 641);
            this.Controls.Add(this.panelGrafic);
            this.Controls.Add(this.btnAdaugareRez);
            this.Controls.Add(this.btnAdaugareHotel);
            this.Controls.Add(this.btnAfisareHot);
            this.Controls.Add(this.tvHotel);
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

        private System.Windows.Forms.TreeView tvHotel;
        private System.Windows.Forms.Button btnAfisareHot;
        private System.Windows.Forms.Button btnAdaugareHotel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stergereHotelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editareHotelToolStripMenuItem;
        private System.Windows.Forms.Button btnAdaugareRez;
        private System.Windows.Forms.ToolStripMenuItem salvareInBDToolStripMenuItem;
        private System.Windows.Forms.Panel panelGrafic;
    }
}

