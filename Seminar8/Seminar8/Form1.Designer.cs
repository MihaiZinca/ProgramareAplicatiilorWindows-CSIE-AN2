namespace Seminar8
{
    partial class Form1
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
            this.lbCarti = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbTitulatura = new System.Windows.Forms.ComboBox();
            this.tbNume = new System.Windows.Forms.TextBox();
            this.tbAdresa = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbDa = new System.Windows.Forms.RadioButton();
            this.rbNu = new System.Windows.Forms.RadioButton();
            this.tbPlata = new System.Windows.Forms.TextBox();
            this.btnCumpara = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbTitlu
            // 
            this.tbTitlu.Location = new System.Drawing.Point(12, 31);
            this.tbTitlu.Multiline = true;
            this.tbTitlu.Name = "tbTitlu";
            this.tbTitlu.ReadOnly = true;
            this.tbTitlu.Size = new System.Drawing.Size(261, 26);
            this.tbTitlu.TabIndex = 0;
            // 
            // lbCarti
            // 
            this.lbCarti.FormattingEnabled = true;
            this.lbCarti.ItemHeight = 20;
            this.lbCarti.Location = new System.Drawing.Point(12, 88);
            this.lbCarti.Name = "lbCarti";
            this.lbCarti.Size = new System.Drawing.Size(261, 244);
            this.lbCarti.TabIndex = 1;
            this.lbCarti.SelectedIndexChanged += new System.EventHandler(this.lbCarti_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(333, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Formular cumparare";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(333, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Titulatura";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(333, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nume si prenume";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(333, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Adresa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(333, 406);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Total de plata";
            // 
            // cbTitulatura
            // 
            this.cbTitulatura.FormattingEnabled = true;
            this.cbTitulatura.Items.AddRange(new object[] {
            "Dl.",
            "Dn."});
            this.cbTitulatura.Location = new System.Drawing.Point(504, 115);
            this.cbTitulatura.Name = "cbTitulatura";
            this.cbTitulatura.Size = new System.Drawing.Size(121, 28);
            this.cbTitulatura.TabIndex = 7;
            // 
            // tbNume
            // 
            this.tbNume.Location = new System.Drawing.Point(504, 174);
            this.tbNume.Name = "tbNume";
            this.tbNume.Size = new System.Drawing.Size(121, 26);
            this.tbNume.TabIndex = 8;
            // 
            // tbAdresa
            // 
            this.tbAdresa.Location = new System.Drawing.Point(504, 237);
            this.tbAdresa.Name = "tbAdresa";
            this.tbAdresa.Size = new System.Drawing.Size(121, 26);
            this.tbAdresa.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbNu);
            this.groupBox1.Controls.Add(this.rbDa);
            this.groupBox1.Location = new System.Drawing.Point(390, 281);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sunteti student?";
            // 
            // rbDa
            // 
            this.rbDa.AutoSize = true;
            this.rbDa.Location = new System.Drawing.Point(3, 22);
            this.rbDa.Name = "rbDa";
            this.rbDa.Size = new System.Drawing.Size(55, 24);
            this.rbDa.TabIndex = 0;
            this.rbDa.TabStop = true;
            this.rbDa.Text = "Da";
            this.rbDa.UseVisualStyleBackColor = true;
            this.rbDa.CheckedChanged += new System.EventHandler(this.rbDa_CheckedChanged);
            // 
            // rbNu
            // 
            this.rbNu.AutoSize = true;
            this.rbNu.Location = new System.Drawing.Point(0, 53);
            this.rbNu.Name = "rbNu";
            this.rbNu.Size = new System.Drawing.Size(54, 24);
            this.rbNu.TabIndex = 1;
            this.rbNu.TabStop = true;
            this.rbNu.Text = "Nu";
            this.rbNu.UseVisualStyleBackColor = true;
            this.rbNu.CheckedChanged += new System.EventHandler(this.rbNu_CheckedChanged);
            // 
            // tbPlata
            // 
            this.tbPlata.Location = new System.Drawing.Point(470, 400);
            this.tbPlata.Name = "tbPlata";
            this.tbPlata.ReadOnly = true;
            this.tbPlata.Size = new System.Drawing.Size(155, 26);
            this.tbPlata.TabIndex = 11;
            // 
            // btnCumpara
            // 
            this.btnCumpara.Location = new System.Drawing.Point(382, 466);
            this.btnCumpara.Name = "btnCumpara";
            this.btnCumpara.Size = new System.Drawing.Size(207, 29);
            this.btnCumpara.TabIndex = 12;
            this.btnCumpara.Text = "Cumpara";
            this.btnCumpara.UseVisualStyleBackColor = true;
            this.btnCumpara.Click += new System.EventHandler(this.btnCumpara_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 570);
            this.Controls.Add(this.btnCumpara);
            this.Controls.Add(this.tbPlata);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbAdresa);
            this.Controls.Add(this.tbNume);
            this.Controls.Add(this.cbTitulatura);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbCarti);
            this.Controls.Add(this.tbTitlu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbTitlu;
        private System.Windows.Forms.ListBox lbCarti;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbTitulatura;
        private System.Windows.Forms.TextBox tbNume;
        private System.Windows.Forms.TextBox tbAdresa;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbNu;
        private System.Windows.Forms.RadioButton rbDa;
        private System.Windows.Forms.TextBox tbPlata;
        private System.Windows.Forms.Button btnCumpara;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

