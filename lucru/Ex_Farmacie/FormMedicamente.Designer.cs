namespace Ex_Farmacie
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
            this.btnSalveaza = new System.Windows.Forms.Button();
            this.lbMedicamente = new System.Windows.Forms.ListBox();
            this.btnAdaugareMed = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbPret = new System.Windows.Forms.TextBox();
            this.tbCant = new System.Windows.Forms.TextBox();
            this.tbDen = new System.Windows.Forms.TextBox();
            this.tbCod = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSalveaza
            // 
            this.btnSalveaza.Location = new System.Drawing.Point(270, 281);
            this.btnSalveaza.Name = "btnSalveaza";
            this.btnSalveaza.Size = new System.Drawing.Size(170, 42);
            this.btnSalveaza.TabIndex = 22;
            this.btnSalveaza.Text = "Salveaza";
            this.btnSalveaza.UseVisualStyleBackColor = true;
            this.btnSalveaza.Click += new System.EventHandler(this.btnSalveaza_Click);
            // 
            // lbMedicamente
            // 
            this.lbMedicamente.FormattingEnabled = true;
            this.lbMedicamente.ItemHeight = 16;
            this.lbMedicamente.Location = new System.Drawing.Point(233, 33);
            this.lbMedicamente.Name = "lbMedicamente";
            this.lbMedicamente.Size = new System.Drawing.Size(290, 228);
            this.lbMedicamente.TabIndex = 21;
            // 
            // btnAdaugareMed
            // 
            this.btnAdaugareMed.Location = new System.Drawing.Point(63, 268);
            this.btnAdaugareMed.Name = "btnAdaugareMed";
            this.btnAdaugareMed.Size = new System.Drawing.Size(151, 55);
            this.btnAdaugareMed.TabIndex = 20;
            this.btnAdaugareMed.Text = "Adaugare medicament";
            this.btnAdaugareMed.UseVisualStyleBackColor = true;
            this.btnAdaugareMed.Click += new System.EventHandler(this.btnAdaugareMed_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 16);
            this.label4.TabIndex = 19;
            this.label4.Text = "Cant";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 16);
            this.label3.TabIndex = 18;
            this.label3.Text = "Pret";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "Den";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "Cod";
            // 
            // tbPret
            // 
            this.tbPret.Location = new System.Drawing.Point(97, 151);
            this.tbPret.Name = "tbPret";
            this.tbPret.Size = new System.Drawing.Size(100, 22);
            this.tbPret.TabIndex = 15;
            // 
            // tbCant
            // 
            this.tbCant.Location = new System.Drawing.Point(97, 209);
            this.tbCant.Name = "tbCant";
            this.tbCant.Size = new System.Drawing.Size(100, 22);
            this.tbCant.TabIndex = 14;
            // 
            // tbDen
            // 
            this.tbDen.Location = new System.Drawing.Point(97, 96);
            this.tbDen.Name = "tbDen";
            this.tbDen.Size = new System.Drawing.Size(100, 22);
            this.tbDen.TabIndex = 13;
            // 
            // tbCod
            // 
            this.tbCod.Location = new System.Drawing.Point(97, 53);
            this.tbCod.Name = "tbCod";
            this.tbCod.Size = new System.Drawing.Size(100, 22);
            this.tbCod.TabIndex = 12;
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

        private System.Windows.Forms.Button btnSalveaza;
        private System.Windows.Forms.ListBox lbMedicamente;
        private System.Windows.Forms.Button btnAdaugareMed;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox tbPret;
        public System.Windows.Forms.TextBox tbCant;
        private System.Windows.Forms.TextBox tbDen;
        private System.Windows.Forms.TextBox tbCod;
    }
}