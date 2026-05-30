namespace GestionareCredite
{
    partial class FormCredite
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
            this.label5 = new System.Windows.Forms.Label();
            this.tbClient = new System.Windows.Forms.TextBox();
            this.tbValoare = new System.Windows.Forms.TextBox();
            this.tbDobanda = new System.Windows.Forms.TextBox();
            this.tbPerioada = new System.Windows.Forms.TextBox();
            this.btnAdaugare = new System.Windows.Forms.Button();
            this.btnSalveaza = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.dtpAc = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Client";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Valoare";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 328);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Perioada";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Dobanda";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(60, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Data Acordarii";
            // 
            // tbClient
            // 
            this.tbClient.Location = new System.Drawing.Point(177, 59);
            this.tbClient.Name = "tbClient";
            this.tbClient.Size = new System.Drawing.Size(175, 22);
            this.tbClient.TabIndex = 5;
            // 
            // tbValoare
            // 
            this.tbValoare.Location = new System.Drawing.Point(177, 119);
            this.tbValoare.Name = "tbValoare";
            this.tbValoare.Size = new System.Drawing.Size(175, 22);
            this.tbValoare.TabIndex = 6;
            // 
            // tbDobanda
            // 
            this.tbDobanda.Location = new System.Drawing.Point(177, 188);
            this.tbDobanda.Name = "tbDobanda";
            this.tbDobanda.Size = new System.Drawing.Size(175, 22);
            this.tbDobanda.TabIndex = 7;
            // 
            // tbPerioada
            // 
            this.tbPerioada.Location = new System.Drawing.Point(177, 328);
            this.tbPerioada.Name = "tbPerioada";
            this.tbPerioada.Size = new System.Drawing.Size(175, 22);
            this.tbPerioada.TabIndex = 9;
            // 
            // btnAdaugare
            // 
            this.btnAdaugare.Location = new System.Drawing.Point(40, 389);
            this.btnAdaugare.Name = "btnAdaugare";
            this.btnAdaugare.Size = new System.Drawing.Size(140, 72);
            this.btnAdaugare.TabIndex = 10;
            this.btnAdaugare.Text = "Adauga";
            this.btnAdaugare.UseVisualStyleBackColor = true;
            this.btnAdaugare.Click += new System.EventHandler(this.btnAdaugare_Click);
            // 
            // btnSalveaza
            // 
            this.btnSalveaza.Location = new System.Drawing.Point(217, 389);
            this.btnSalveaza.Name = "btnSalveaza";
            this.btnSalveaza.Size = new System.Drawing.Size(135, 72);
            this.btnSalveaza.TabIndex = 11;
            this.btnSalveaza.Text = "Salveaza";
            this.btnSalveaza.UseVisualStyleBackColor = true;
            this.btnSalveaza.Click += new System.EventHandler(this.btnSalveaza_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // dtpAc
            // 
            this.dtpAc.Location = new System.Drawing.Point(177, 258);
            this.dtpAc.Name = "dtpAc";
            this.dtpAc.Size = new System.Drawing.Size(200, 22);
            this.dtpAc.TabIndex = 12;
            // 
            // FormCredite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 493);
            this.Controls.Add(this.dtpAc);
            this.Controls.Add(this.btnSalveaza);
            this.Controls.Add(this.btnAdaugare);
            this.Controls.Add(this.tbPerioada);
            this.Controls.Add(this.tbDobanda);
            this.Controls.Add(this.tbValoare);
            this.Controls.Add(this.tbClient);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormCredite";
            this.Text = "FormCredite";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbClient;
        private System.Windows.Forms.TextBox tbValoare;
        private System.Windows.Forms.TextBox tbDobanda;
        private System.Windows.Forms.TextBox tbPerioada;
        private System.Windows.Forms.Button btnAdaugare;
        private System.Windows.Forms.Button btnSalveaza;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DateTimePicker dtpAc;
    }
}