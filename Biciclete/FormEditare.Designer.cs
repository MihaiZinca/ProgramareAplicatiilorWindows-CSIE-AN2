namespace Biciclete
{
    partial class FormEditare
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbCodU = new System.Windows.Forms.TextBox();
            this.tbNume = new System.Windows.Forms.TextBox();
            this.tbCodB = new System.Windows.Forms.TextBox();
            this.tbDurata = new System.Windows.Forms.TextBox();
            this.btnSalvare = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cod";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nume";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "CodB";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "DurataUtilizare";
            // 
            // tbCodU
            // 
            this.tbCodU.Location = new System.Drawing.Point(149, 53);
            this.tbCodU.Name = "tbCodU";
            this.tbCodU.Size = new System.Drawing.Size(145, 22);
            this.tbCodU.TabIndex = 4;
            // 
            // tbNume
            // 
            this.tbNume.Location = new System.Drawing.Point(149, 105);
            this.tbNume.Name = "tbNume";
            this.tbNume.Size = new System.Drawing.Size(145, 22);
            this.tbNume.TabIndex = 5;
            // 
            // tbCodB
            // 
            this.tbCodB.Location = new System.Drawing.Point(149, 150);
            this.tbCodB.Name = "tbCodB";
            this.tbCodB.Size = new System.Drawing.Size(145, 22);
            this.tbCodB.TabIndex = 6;
            // 
            // tbDurata
            // 
            this.tbDurata.Location = new System.Drawing.Point(149, 203);
            this.tbDurata.Name = "tbDurata";
            this.tbDurata.Size = new System.Drawing.Size(145, 22);
            this.tbDurata.TabIndex = 7;
            // 
            // btnSalvare
            // 
            this.btnSalvare.Location = new System.Drawing.Point(106, 261);
            this.btnSalvare.Name = "btnSalvare";
            this.btnSalvare.Size = new System.Drawing.Size(141, 46);
            this.btnSalvare.TabIndex = 8;
            this.btnSalvare.Text = "Salvare";
            this.btnSalvare.UseVisualStyleBackColor = true;
            this.btnSalvare.Click += new System.EventHandler(this.btnSalvare_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FormEditare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 340);
            this.Controls.Add(this.btnSalvare);
            this.Controls.Add(this.tbDurata);
            this.Controls.Add(this.tbCodB);
            this.Controls.Add(this.tbNume);
            this.Controls.Add(this.tbCodU);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormEditare";
            this.Text = "FormEditare";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox tbCodU;
        public System.Windows.Forms.TextBox tbNume;
        public System.Windows.Forms.TextBox tbCodB;
        public System.Windows.Forms.TextBox tbDurata;
        public System.Windows.Forms.Button btnSalvare;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}