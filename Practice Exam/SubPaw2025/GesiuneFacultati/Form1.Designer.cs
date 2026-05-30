namespace GesiuneFacultati
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
            this.dgvStud = new System.Windows.Forms.DataGridView();
            this.btnAdaugareStud = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.prviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvareInBDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStud)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvStud
            // 
            this.dgvStud.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStud.Location = new System.Drawing.Point(53, 131);
            this.dgvStud.Name = "dgvStud";
            this.dgvStud.ReadOnly = true;
            this.dgvStud.RowHeadersWidth = 51;
            this.dgvStud.RowTemplate.Height = 24;
            this.dgvStud.Size = new System.Drawing.Size(366, 150);
            this.dgvStud.TabIndex = 0;
            this.dgvStud.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStud_CellDoubleClick);
            // 
            // btnAdaugareStud
            // 
            this.btnAdaugareStud.Location = new System.Drawing.Point(53, 81);
            this.btnAdaugareStud.Name = "btnAdaugareStud";
            this.btnAdaugareStud.Size = new System.Drawing.Size(204, 35);
            this.btnAdaugareStud.TabIndex = 1;
            this.btnAdaugareStud.Text = "Adaugare Stud";
            this.btnAdaugareStud.UseVisualStyleBackColor = true;
            this.btnAdaugareStud.Click += new System.EventHandler(this.btnAdaugareStud_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prviewToolStripMenuItem,
            this.salvareInBDToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // prviewToolStripMenuItem
            // 
            this.prviewToolStripMenuItem.Name = "prviewToolStripMenuItem";
            this.prviewToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.prviewToolStripMenuItem.Text = "Preview";
            this.prviewToolStripMenuItem.Click += new System.EventHandler(this.prviewToolStripMenuItem_Click);
            // 
            // salvareInBDToolStripMenuItem
            // 
            this.salvareInBDToolStripMenuItem.Name = "salvareInBDToolStripMenuItem";
            this.salvareInBDToolStripMenuItem.Size = new System.Drawing.Size(111, 24);
            this.salvareInBDToolStripMenuItem.Text = "Salvare in BD";
            this.salvareInBDToolStripMenuItem.Click += new System.EventHandler(this.salvareInBDToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAdaugareStud);
            this.Controls.Add(this.dgvStud);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvStud)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStud;
        private System.Windows.Forms.Button btnAdaugareStud;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem prviewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvareInBDToolStripMenuItem;
    }
}

