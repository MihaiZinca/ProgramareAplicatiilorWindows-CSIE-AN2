namespace T2
{
    partial class FormAdaugaCarte
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
            this.tbTitlu = new System.Windows.Forms.TextBox();
            this.tbPret = new System.Windows.Forms.TextBox();
            this.tbISBN = new System.Windows.Forms.TextBox();
            this.cmbCategorie = new System.Windows.Forms.ComboBox();
            this.bt1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbCarte = new System.Windows.Forms.ListBox();
            this.btnSalveaza = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbTitlu
            // 
            this.tbTitlu.Location = new System.Drawing.Point(158, 56);
            this.tbTitlu.Name = "tbTitlu";
            this.tbTitlu.Size = new System.Drawing.Size(121, 22);
            this.tbTitlu.TabIndex = 0;
            // 
            // tbPret
            // 
            this.tbPret.Location = new System.Drawing.Point(158, 96);
            this.tbPret.Name = "tbPret";
            this.tbPret.Size = new System.Drawing.Size(121, 22);
            this.tbPret.TabIndex = 1;
            // 
            // tbISBN
            // 
            this.tbISBN.Location = new System.Drawing.Point(158, 133);
            this.tbISBN.Name = "tbISBN";
            this.tbISBN.Size = new System.Drawing.Size(121, 22);
            this.tbISBN.TabIndex = 2;
            // 
            // cmbCategorie
            // 
            this.cmbCategorie.FormattingEnabled = true;
            this.cmbCategorie.Items.AddRange(new object[] {
            "SF",
            "Drama",
            "Nutritie",
            "Sport"});
            this.cmbCategorie.Location = new System.Drawing.Point(158, 180);
            this.cmbCategorie.Name = "cmbCategorie";
            this.cmbCategorie.Size = new System.Drawing.Size(121, 24);
            this.cmbCategorie.TabIndex = 3;
            // 
            // bt1
            // 
            this.bt1.Location = new System.Drawing.Point(158, 236);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(121, 29);
            this.bt1.TabIndex = 4;
            this.bt1.Text = "Adauga Carte";
            this.bt1.UseVisualStyleBackColor = true;
            this.bt1.Click += new System.EventHandler(this.btnAdauga_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Titlu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Pret";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "ISBN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Categorie";
            // 
            // lbCarte
            // 
            this.lbCarte.FormattingEnabled = true;
            this.lbCarte.ItemHeight = 16;
            this.lbCarte.Location = new System.Drawing.Point(344, 56);
            this.lbCarte.Name = "lbCarte";
            this.lbCarte.Size = new System.Drawing.Size(287, 148);
            this.lbCarte.TabIndex = 9;
            // 
            // btnSalveaza
            // 
            this.btnSalveaza.Location = new System.Drawing.Point(398, 236);
            this.btnSalveaza.Name = "btnSalveaza";
            this.btnSalveaza.Size = new System.Drawing.Size(121, 29);
            this.btnSalveaza.TabIndex = 10;
            this.btnSalveaza.Text = "Salveaza";
            this.btnSalveaza.UseVisualStyleBackColor = true;
            this.btnSalveaza.Click += new System.EventHandler(this.btnSalveaza_Click);
            // 
            // FormAdaugaCarte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 446);
            this.Controls.Add(this.btnSalveaza);
            this.Controls.Add(this.lbCarte);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt1);
            this.Controls.Add(this.cmbCategorie);
            this.Controls.Add(this.tbISBN);
            this.Controls.Add(this.tbPret);
            this.Controls.Add(this.tbTitlu);
            this.Name = "FormAdaugaCarte";
            this.Text = "FormAdaugaCarte";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Button bt1;
        public System.Windows.Forms.TextBox tbTitlu;
        public System.Windows.Forms.TextBox tbPret;
        public System.Windows.Forms.TextBox tbISBN;
        public System.Windows.Forms.ComboBox cmbCategorie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lbCarte;
        public System.Windows.Forms.Button btnSalveaza;
    }
}