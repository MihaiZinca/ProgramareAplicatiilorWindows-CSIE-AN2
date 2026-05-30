namespace Bibliografice
{
    partial class FormCarte
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
            this.tbISBN = new System.Windows.Forms.TextBox();
            this.tbTitlu = new System.Windows.Forms.TextBox();
            this.tbPret = new System.Windows.Forms.TextBox();
            this.cmbCategorie = new System.Windows.Forms.ComboBox();
            this.btnAdaugare = new System.Windows.Forms.Button();
            this.btnSalveaza = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbISBN
            // 
            this.tbISBN.Location = new System.Drawing.Point(69, 84);
            this.tbISBN.Name = "tbISBN";
            this.tbISBN.Size = new System.Drawing.Size(100, 22);
            this.tbISBN.TabIndex = 0;
            // 
            // tbTitlu
            // 
            this.tbTitlu.Location = new System.Drawing.Point(69, 150);
            this.tbTitlu.Name = "tbTitlu";
            this.tbTitlu.Size = new System.Drawing.Size(100, 22);
            this.tbTitlu.TabIndex = 2;
            // 
            // tbPret
            // 
            this.tbPret.Location = new System.Drawing.Point(69, 225);
            this.tbPret.Name = "tbPret";
            this.tbPret.Size = new System.Drawing.Size(100, 22);
            this.tbPret.TabIndex = 3;
            // 
            // cmbCategorie
            // 
            this.cmbCategorie.FormattingEnabled = true;
            this.cmbCategorie.Location = new System.Drawing.Point(69, 287);
            this.cmbCategorie.Name = "cmbCategorie";
            this.cmbCategorie.Size = new System.Drawing.Size(121, 24);
            this.cmbCategorie.TabIndex = 4;
            // 
            // btnAdaugare
            // 
            this.btnAdaugare.Location = new System.Drawing.Point(69, 351);
            this.btnAdaugare.Name = "btnAdaugare";
            this.btnAdaugare.Size = new System.Drawing.Size(121, 38);
            this.btnAdaugare.TabIndex = 5;
            this.btnAdaugare.Text = "Adaguare";
            this.btnAdaugare.UseVisualStyleBackColor = true;
            this.btnAdaugare.Click += new System.EventHandler(this.btnAdaugare_Click);
            // 
            // btnSalveaza
            // 
            this.btnSalveaza.Location = new System.Drawing.Point(69, 405);
            this.btnSalveaza.Name = "btnSalveaza";
            this.btnSalveaza.Size = new System.Drawing.Size(121, 27);
            this.btnSalveaza.TabIndex = 6;
            this.btnSalveaza.Text = "Salvare";
            this.btnSalveaza.UseVisualStyleBackColor = true;
            this.btnSalveaza.Click += new System.EventHandler(this.btnSalveaza_Click);
            // 
            // FormCarte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 453);
            this.Controls.Add(this.btnSalveaza);
            this.Controls.Add(this.btnAdaugare);
            this.Controls.Add(this.cmbCategorie);
            this.Controls.Add(this.tbPret);
            this.Controls.Add(this.tbTitlu);
            this.Controls.Add(this.tbISBN);
            this.Name = "FormCarte";
            this.Text = "FormCarte";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbISBN;
        private System.Windows.Forms.TextBox tbTitlu;
        private System.Windows.Forms.TextBox tbPret;
        private System.Windows.Forms.ComboBox cmbCategorie;
        private System.Windows.Forms.Button btnAdaugare;
        private System.Windows.Forms.Button btnSalveaza;
    }
}