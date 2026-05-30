namespace GestionareCredite
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
            this.dtpAc = new System.Windows.Forms.DateTimePicker();
            this.btnModifica = new System.Windows.Forms.Button();
            this.tbPerioada = new System.Windows.Forms.TextBox();
            this.tbDobanda = new System.Windows.Forms.TextBox();
            this.tbValoare = new System.Windows.Forms.TextBox();
            this.tbClient = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpAc
            // 
            this.dtpAc.Location = new System.Drawing.Point(286, 218);
            this.dtpAc.Name = "dtpAc";
            this.dtpAc.Size = new System.Drawing.Size(200, 22);
            this.dtpAc.TabIndex = 24;
            // 
            // btnModifica
            // 
            this.btnModifica.Location = new System.Drawing.Point(149, 349);
            this.btnModifica.Name = "btnModifica";
            this.btnModifica.Size = new System.Drawing.Size(317, 72);
            this.btnModifica.TabIndex = 22;
            this.btnModifica.Text = "Modifica";
            this.btnModifica.UseVisualStyleBackColor = true;
            this.btnModifica.Click += new System.EventHandler(this.btnModifica_Click);
            // 
            // tbPerioada
            // 
            this.tbPerioada.Location = new System.Drawing.Point(286, 288);
            this.tbPerioada.Name = "tbPerioada";
            this.tbPerioada.Size = new System.Drawing.Size(175, 22);
            this.tbPerioada.TabIndex = 21;
            // 
            // tbDobanda
            // 
            this.tbDobanda.Location = new System.Drawing.Point(286, 148);
            this.tbDobanda.Name = "tbDobanda";
            this.tbDobanda.Size = new System.Drawing.Size(175, 22);
            this.tbDobanda.TabIndex = 20;
            // 
            // tbValoare
            // 
            this.tbValoare.Location = new System.Drawing.Point(286, 79);
            this.tbValoare.Name = "tbValoare";
            this.tbValoare.Size = new System.Drawing.Size(175, 22);
            this.tbValoare.TabIndex = 19;
            // 
            // tbClient
            // 
            this.tbClient.Location = new System.Drawing.Point(286, 19);
            this.tbClient.Name = "tbClient";
            this.tbClient.Size = new System.Drawing.Size(175, 22);
            this.tbClient.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(169, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 16);
            this.label5.TabIndex = 17;
            this.label5.Text = "Data Acordarii";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(169, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "Dobanda";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(169, 288);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Perioada";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(169, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Valoare";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(169, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Client";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FormEditare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 432);
            this.Controls.Add(this.dtpAc);
            this.Controls.Add(this.btnModifica);
            this.Controls.Add(this.tbPerioada);
            this.Controls.Add(this.tbDobanda);
            this.Controls.Add(this.tbValoare);
            this.Controls.Add(this.tbClient);
            this.Controls.Add(this.label5);
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

        private System.Windows.Forms.DateTimePicker dtpAc;
        private System.Windows.Forms.Button btnModifica;
        private System.Windows.Forms.TextBox tbPerioada;
        private System.Windows.Forms.TextBox tbDobanda;
        private System.Windows.Forms.TextBox tbValoare;
        private System.Windows.Forms.TextBox tbClient;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}