namespace ComenziPizza
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
            this.tvComanda = new System.Windows.Forms.TreeView();
            this.btnAdaugare = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.citireTxtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnTopping = new System.Windows.Forms.Button();
            this.panelGrafic = new System.Windows.Forms.Panel();
            this.btnGrafic = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tvComanda
            // 
            this.tvComanda.Location = new System.Drawing.Point(41, 59);
            this.tvComanda.Name = "tvComanda";
            this.tvComanda.Size = new System.Drawing.Size(297, 218);
            this.tvComanda.TabIndex = 0;
            this.tvComanda.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvComanda_AfterSelect);
            // 
            // btnAdaugare
            // 
            this.btnAdaugare.Location = new System.Drawing.Point(91, 299);
            this.btnAdaugare.Name = "btnAdaugare";
            this.btnAdaugare.Size = new System.Drawing.Size(178, 39);
            this.btnAdaugare.TabIndex = 2;
            this.btnAdaugare.Text = "Adaugare Comanda";
            this.btnAdaugare.UseVisualStyleBackColor = true;
            this.btnAdaugare.Click += new System.EventHandler(this.btnAdaugare_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.citireTxtToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(865, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // citireTxtToolStripMenuItem
            // 
            this.citireTxtToolStripMenuItem.Name = "citireTxtToolStripMenuItem";
            this.citireTxtToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.citireTxtToolStripMenuItem.Text = "Citire txt";
            this.citireTxtToolStripMenuItem.Click += new System.EventHandler(this.citireTxtToolStripMenuItem_Click);
            // 
            // btnTopping
            // 
            this.btnTopping.Location = new System.Drawing.Point(107, 359);
            this.btnTopping.Name = "btnTopping";
            this.btnTopping.Size = new System.Drawing.Size(152, 53);
            this.btnTopping.TabIndex = 4;
            this.btnTopping.Text = "Adauga Topping";
            this.btnTopping.UseVisualStyleBackColor = true;
            this.btnTopping.Click += new System.EventHandler(this.btnTopping_Click);
            // 
            // panelGrafic
            // 
            this.panelGrafic.Location = new System.Drawing.Point(423, 59);
            this.panelGrafic.Name = "panelGrafic";
            this.panelGrafic.Size = new System.Drawing.Size(420, 324);
            this.panelGrafic.TabIndex = 5;
            this.panelGrafic.Paint += new System.Windows.Forms.PaintEventHandler(this.panelGrafic_Paint);
            // 
            // btnGrafic
            // 
            this.btnGrafic.Location = new System.Drawing.Point(107, 437);
            this.btnGrafic.Name = "btnGrafic";
            this.btnGrafic.Size = new System.Drawing.Size(152, 58);
            this.btnGrafic.TabIndex = 6;
            this.btnGrafic.Text = "Afisare Grafic";
            this.btnGrafic.UseVisualStyleBackColor = true;
            this.btnGrafic.Click += new System.EventHandler(this.btnGrafic_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 544);
            this.Controls.Add(this.btnGrafic);
            this.Controls.Add(this.panelGrafic);
            this.Controls.Add(this.btnTopping);
            this.Controls.Add(this.btnAdaugare);
            this.Controls.Add(this.tvComanda);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView tvComanda;
        private System.Windows.Forms.Button btnAdaugare;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem citireTxtToolStripMenuItem;
        private System.Windows.Forms.Button btnTopping;
        private System.Windows.Forms.Panel panelGrafic;
        private System.Windows.Forms.Button btnGrafic;
    }
}

