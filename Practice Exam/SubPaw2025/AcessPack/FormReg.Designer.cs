namespace AcessPack
{
    partial class Form
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
            this.tbNumeC = new System.Windows.Forms.TextBox();
            this.tbPasses = new System.Windows.Forms.TextBox();
            this.cmbAccesPack = new System.Windows.Forms.ComboBox();
            this.btnAdauga = new System.Windows.Forms.Button();
            this.dgvReg = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.stripCost = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sortareNumeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortarePackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReg)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbNumeC
            // 
            this.tbNumeC.Location = new System.Drawing.Point(56, 56);
            this.tbNumeC.Name = "tbNumeC";
            this.tbNumeC.Size = new System.Drawing.Size(192, 22);
            this.tbNumeC.TabIndex = 0;
            // 
            // tbPasses
            // 
            this.tbPasses.Location = new System.Drawing.Point(56, 119);
            this.tbPasses.Name = "tbPasses";
            this.tbPasses.Size = new System.Drawing.Size(192, 22);
            this.tbPasses.TabIndex = 1;
            // 
            // cmbAccesPack
            // 
            this.cmbAccesPack.FormattingEnabled = true;
            this.cmbAccesPack.Location = new System.Drawing.Point(56, 192);
            this.cmbAccesPack.Name = "cmbAccesPack";
            this.cmbAccesPack.Size = new System.Drawing.Size(213, 24);
            this.cmbAccesPack.TabIndex = 2;
            // 
            // btnAdauga
            // 
            this.btnAdauga.Location = new System.Drawing.Point(100, 261);
            this.btnAdauga.Name = "btnAdauga";
            this.btnAdauga.Size = new System.Drawing.Size(96, 32);
            this.btnAdauga.TabIndex = 3;
            this.btnAdauga.Text = "Adauga";
            this.btnAdauga.UseVisualStyleBackColor = true;
            this.btnAdauga.Click += new System.EventHandler(this.btnAdauga_Click);
            // 
            // dgvReg
            // 
            this.dgvReg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReg.Location = new System.Drawing.Point(315, 56);
            this.dgvReg.Name = "dgvReg";
            this.dgvReg.RowHeadersWidth = 51;
            this.dgvReg.RowTemplate.Height = 24;
            this.dgvReg.Size = new System.Drawing.Size(372, 237);
            this.dgvReg.TabIndex = 4;
            this.dgvReg.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReg_CellDoubleClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(429, 299);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 50);
            this.button1.TabIndex = 5;
            this.button1.Text = "Stergere inregistrare";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stripCost});
            this.statusStrip1.Location = new System.Drawing.Point(0, 396);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(720, 26);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // stripCost
            // 
            this.stripCost.Name = "stripCost";
            this.stripCost.Size = new System.Drawing.Size(76, 20);
            this.stripCost.Text = "Cost total:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sortareNumeToolStripMenuItem,
            this.sortarePackToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(720, 30);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sortareNumeToolStripMenuItem
            // 
            this.sortareNumeToolStripMenuItem.Name = "sortareNumeToolStripMenuItem";
            this.sortareNumeToolStripMenuItem.Size = new System.Drawing.Size(115, 26);
            this.sortareNumeToolStripMenuItem.Text = "Sortare Nume";
            this.sortareNumeToolStripMenuItem.Click += new System.EventHandler(this.sortareNumeToolStripMenuItem_Click);
            // 
            // sortarePackToolStripMenuItem
            // 
            this.sortarePackToolStripMenuItem.Name = "sortarePackToolStripMenuItem";
            this.sortarePackToolStripMenuItem.Size = new System.Drawing.Size(104, 26);
            this.sortarePackToolStripMenuItem.Text = "Sortare Pack";
            this.sortarePackToolStripMenuItem.Click += new System.EventHandler(this.sortarePackToolStripMenuItem_Click);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 422);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvReg);
            this.Controls.Add(this.btnAdauga);
            this.Controls.Add(this.cmbAccesPack);
            this.Controls.Add(this.tbPasses);
            this.Controls.Add(this.tbNumeC);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form";
            this.Text = "FormReg";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReg)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNumeC;
        private System.Windows.Forms.TextBox tbPasses;
        private System.Windows.Forms.ComboBox cmbAccesPack;
        private System.Windows.Forms.Button btnAdauga;
        private System.Windows.Forms.DataGridView dgvReg;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel stripCost;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sortareNumeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sortarePackToolStripMenuItem;
    }
}