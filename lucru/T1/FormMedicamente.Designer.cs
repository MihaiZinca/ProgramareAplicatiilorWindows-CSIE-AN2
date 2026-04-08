namespace T1
{
    partial class FormMedicamente
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
            this.tbCod = new System.Windows.Forms.TextBox();
            this.tbDen = new System.Windows.Forms.TextBox();
            this.tbCant = new System.Windows.Forms.TextBox();
            this.tbPret = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAdaugareMed = new System.Windows.Forms.Button();
            this.lbMedicamente = new System.Windows.Forms.ListBox();
            this.btnSalveaza = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbCod
            // 
            this.tbCod.Location = new System.Drawing.Point(79, 32);
            this.tbCod.Name = "tbCod";
            this.tbCod.Size = new System.Drawing.Size(100, 22);
            this.tbCod.TabIndex = 0;
            // 
            // tbDen
            // 
            this.tbDen.Location = new System.Drawing.Point(79, 75);
            this.tbDen.Name = "tbDen";
            this.tbDen.Size = new System.Drawing.Size(100, 22);
            this.tbDen.TabIndex = 2;
            // 
            // tbCant
            // 
            this.tbCant.Location = new System.Drawing.Point(79, 188);
            this.tbCant.Name = "tbCant";
            this.tbCant.Size = new System.Drawing.Size(100, 22);
            this.tbCant.TabIndex = 3;
            // 
            // tbPret
            // 
            this.tbPret.Location = new System.Drawing.Point(79, 130);
            this.tbPret.Name = "tbPret";
            this.tbPret.Size = new System.Drawing.Size(100, 22);
            this.tbPret.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Cod";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Den";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Pret";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Cant";
            // 
            // btnAdaugareMed
            // 
            this.btnAdaugareMed.Location = new System.Drawing.Point(45, 247);
            this.btnAdaugareMed.Name = "btnAdaugareMed";
            this.btnAdaugareMed.Size = new System.Drawing.Size(151, 55);
            this.btnAdaugareMed.TabIndex = 9;
            this.btnAdaugareMed.Text = "Adaugare medicament";
            this.btnAdaugareMed.UseVisualStyleBackColor = true;
            this.btnAdaugareMed.Click += new System.EventHandler(this.btnAdaugareMed_Click);
            // 
            // lbMedicamente
            // 
            this.lbMedicamente.FormattingEnabled = true;
            this.lbMedicamente.ItemHeight = 16;
            this.lbMedicamente.Location = new System.Drawing.Point(215, 12);
            this.lbMedicamente.Name = "lbMedicamente";
            this.lbMedicamente.Size = new System.Drawing.Size(290, 228);
            this.lbMedicamente.TabIndex = 10;
            // 
            // btnSalveaza
            // 
            this.btnSalveaza.Location = new System.Drawing.Point(252, 260);
            this.btnSalveaza.Name = "btnSalveaza";
            this.btnSalveaza.Size = new System.Drawing.Size(170, 42);
            this.btnSalveaza.TabIndex = 11;
            this.btnSalveaza.Text = "Salveaza";
            this.btnSalveaza.UseVisualStyleBackColor = true;
            this.btnSalveaza.Click += new System.EventHandler(this.btnSalveaza_Click);
            // 
            // FormMedicamente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSalveaza);
            this.Controls.Add(this.lbMedicamente);
            this.Controls.Add(this.btnAdaugareMed);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbPret);
            this.Controls.Add(this.tbCant);
            this.Controls.Add(this.tbDen);
            this.Controls.Add(this.tbCod);
            this.Name = "FormMedicamente";
            this.Text = "FormMedicamente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbCod;
        private System.Windows.Forms.TextBox tbDen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox tbCant;
        public System.Windows.Forms.TextBox tbPret;
        private System.Windows.Forms.Button btnAdaugareMed;
        private System.Windows.Forms.ListBox lbMedicamente;
        private System.Windows.Forms.Button btnSalveaza;
    }
}