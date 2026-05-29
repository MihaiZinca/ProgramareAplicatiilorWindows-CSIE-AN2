namespace GestiuneAngajati
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
            this.components = new System.ComponentModel.Container();
            this.dtN = new System.Windows.Forms.DateTimePicker();
            this.btnSalvare = new System.Windows.Forms.Button();
            this.tbIdCompanie = new System.Windows.Forms.TextBox();
            this.btnModifica = new System.Windows.Forms.Button();
            this.tbNume = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtN
            // 
            this.dtN.Location = new System.Drawing.Point(234, 110);
            this.dtN.Name = "dtN";
            this.dtN.Size = new System.Drawing.Size(200, 22);
            this.dtN.TabIndex = 25;
            // 
            // btnSalvare
            // 
            this.btnSalvare.Location = new System.Drawing.Point(301, 228);
            this.btnSalvare.Name = "btnSalvare";
            this.btnSalvare.Size = new System.Drawing.Size(112, 35);
            this.btnSalvare.TabIndex = 24;
            this.btnSalvare.Text = "Salveaza";
            this.btnSalvare.UseVisualStyleBackColor = true;
            this.btnSalvare.Click += new System.EventHandler(this.btnSalvare_Click);
            // 
            // tbIdCompanie
            // 
            this.tbIdCompanie.Location = new System.Drawing.Point(234, 164);
            this.tbIdCompanie.Name = "tbIdCompanie";
            this.tbIdCompanie.Size = new System.Drawing.Size(154, 22);
            this.tbIdCompanie.TabIndex = 23;
            // 
            // btnModifica
            // 
            this.btnModifica.Location = new System.Drawing.Point(113, 227);
            this.btnModifica.Name = "btnModifica";
            this.btnModifica.Size = new System.Drawing.Size(134, 37);
            this.btnModifica.TabIndex = 22;
            this.btnModifica.Text = "Modifica";
            this.btnModifica.UseVisualStyleBackColor = true;
            this.btnModifica.Click += new System.EventHandler(this.btnModifica_Click);
            // 
            // tbNume
            // 
            this.tbNume.Location = new System.Drawing.Point(234, 65);
            this.tbNume.Name = "tbNume";
            this.tbNume.Size = new System.Drawing.Size(154, 22);
            this.tbNume.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(130, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 16);
            this.label3.TabIndex = 20;
            this.label3.Text = "Id Companie";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(130, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = "Data nasterii";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(130, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "Nume";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FormModificare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 334);
            this.Controls.Add(this.dtN);
            this.Controls.Add(this.btnSalvare);
            this.Controls.Add(this.tbIdCompanie);
            this.Controls.Add(this.btnModifica);
            this.Controls.Add(this.tbNume);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormModificare";
            this.Text = "FormModificare";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtN;
        private System.Windows.Forms.Button btnSalvare;
        private System.Windows.Forms.TextBox tbIdCompanie;
        private System.Windows.Forms.Button btnModifica;
        private System.Windows.Forms.TextBox tbNume;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}