namespace SubTranzactie
{
    partial class FormExtras
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
            this.tbNume = new System.Windows.Forms.TextBox();
            this.tbAdresa = new System.Windows.Forms.TextBox();
            this.cmbTranzactie = new System.Windows.Forms.ComboBox();
            this.btnAdaugare = new System.Windows.Forms.Button();
            this.btnSalveaza = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbNume
            // 
            this.tbNume.Location = new System.Drawing.Point(36, 48);
            this.tbNume.Name = "tbNume";
            this.tbNume.Size = new System.Drawing.Size(215, 22);
            this.tbNume.TabIndex = 0;
            // 
            // tbAdresa
            // 
            this.tbAdresa.Location = new System.Drawing.Point(36, 118);
            this.tbAdresa.Name = "tbAdresa";
            this.tbAdresa.Size = new System.Drawing.Size(215, 22);
            this.tbAdresa.TabIndex = 1;
            // 
            // cmbTranzactie
            // 
            this.cmbTranzactie.FormattingEnabled = true;
            this.cmbTranzactie.Location = new System.Drawing.Point(36, 195);
            this.cmbTranzactie.Name = "cmbTranzactie";
            this.cmbTranzactie.Size = new System.Drawing.Size(215, 24);
            this.cmbTranzactie.TabIndex = 2;
            // 
            // btnAdaugare
            // 
            this.btnAdaugare.Location = new System.Drawing.Point(36, 256);
            this.btnAdaugare.Name = "btnAdaugare";
            this.btnAdaugare.Size = new System.Drawing.Size(88, 33);
            this.btnAdaugare.TabIndex = 3;
            this.btnAdaugare.Text = "Adauga";
            this.btnAdaugare.UseVisualStyleBackColor = true;
            this.btnAdaugare.Click += new System.EventHandler(this.btnAdaugare_Click);
            // 
            // btnSalveaza
            // 
            this.btnSalveaza.Location = new System.Drawing.Point(155, 256);
            this.btnSalveaza.Name = "btnSalveaza";
            this.btnSalveaza.Size = new System.Drawing.Size(96, 33);
            this.btnSalveaza.TabIndex = 4;
            this.btnSalveaza.Text = "Salveaza";
            this.btnSalveaza.UseVisualStyleBackColor = true;
            this.btnSalveaza.Click += new System.EventHandler(this.btnSalveaza_Click);
            // 
            // FormExtras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 337);
            this.Controls.Add(this.btnSalveaza);
            this.Controls.Add(this.btnAdaugare);
            this.Controls.Add(this.cmbTranzactie);
            this.Controls.Add(this.tbAdresa);
            this.Controls.Add(this.tbNume);
            this.Name = "FormExtras";
            this.Text = "FormExtras";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox tbNume;
        public System.Windows.Forms.TextBox tbAdresa;
        public System.Windows.Forms.ComboBox cmbTranzactie;
        public System.Windows.Forms.Button btnAdaugare;
        public System.Windows.Forms.Button btnSalveaza;
    }
}