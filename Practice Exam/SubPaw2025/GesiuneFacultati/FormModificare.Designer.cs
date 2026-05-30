namespace GesiuneFacultati
{
    partial class FormModificare
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
            this.btnSalvare = new System.Windows.Forms.Button();
            this.btnModificare = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbMedie = new System.Windows.Forms.TextBox();
            this.tbNume = new System.Windows.Forms.TextBox();
            this.tbNrMat = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSalvare
            // 
            this.btnSalvare.Location = new System.Drawing.Point(217, 267);
            this.btnSalvare.Name = "btnSalvare";
            this.btnSalvare.Size = new System.Drawing.Size(89, 23);
            this.btnSalvare.TabIndex = 15;
            this.btnSalvare.Text = "Salveaza";
            this.btnSalvare.UseVisualStyleBackColor = true;
            this.btnSalvare.Click += new System.EventHandler(this.btnSalvare_Click);
            // 
            // btnModificare
            // 
            this.btnModificare.Location = new System.Drawing.Point(86, 267);
            this.btnModificare.Name = "btnModificare";
            this.btnModificare.Size = new System.Drawing.Size(92, 23);
            this.btnModificare.TabIndex = 14;
            this.btnModificare.Text = "Modificare";
            this.btnModificare.UseVisualStyleBackColor = true;
            this.btnModificare.Click += new System.EventHandler(this.btnModificare_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(102, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Medie";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(103, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Nume";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Nr matricol";
            // 
            // tbMedie
            // 
            this.tbMedie.Location = new System.Drawing.Point(195, 210);
            this.tbMedie.Name = "tbMedie";
            this.tbMedie.Size = new System.Drawing.Size(100, 22);
            this.tbMedie.TabIndex = 10;
            // 
            // tbNume
            // 
            this.tbNume.Location = new System.Drawing.Point(195, 139);
            this.tbNume.Name = "tbNume";
            this.tbNume.ReadOnly = true;
            this.tbNume.Size = new System.Drawing.Size(100, 22);
            this.tbNume.TabIndex = 9;
            // 
            // tbNrMat
            // 
            this.tbNrMat.Location = new System.Drawing.Point(195, 71);
            this.tbNrMat.Name = "tbNrMat";
            this.tbNrMat.ReadOnly = true;
            this.tbNrMat.Size = new System.Drawing.Size(100, 22);
            this.tbNrMat.TabIndex = 8;
            // 
            // FormModificare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 332);
            this.Controls.Add(this.btnSalvare);
            this.Controls.Add(this.btnModificare);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbMedie);
            this.Controls.Add(this.tbNume);
            this.Controls.Add(this.tbNrMat);
            this.Name = "FormModificare";
            this.Text = "FormModificare";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalvare;
        private System.Windows.Forms.Button btnModificare;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbMedie;
        private System.Windows.Forms.TextBox tbNume;
        private System.Windows.Forms.TextBox tbNrMat;
    }
}