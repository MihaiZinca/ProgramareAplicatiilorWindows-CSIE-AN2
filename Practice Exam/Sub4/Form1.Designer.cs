namespace Sub4
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
            this.lv = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Valoare = new System.Windows.Forms.Label();
            this.tbObsv = new System.Windows.Forms.TextBox();
            this.btnAdaugare = new System.Windows.Forms.Button();
            this.btnStergereSimpla = new System.Windows.Forms.Button();
            this.btnModifica = new System.Windows.Forms.Button();
            this.btnStergereCompleta = new System.Windows.Forms.Button();
            this.tbMedie = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGrafic = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lv
            // 
            this.lv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lv.FullRowSelect = true;
            this.lv.GridLines = true;
            this.lv.HideSelection = false;
            this.lv.Location = new System.Drawing.Point(280, 83);
            this.lv.MultiSelect = false;
            this.lv.Name = "lv";
            this.lv.Size = new System.Drawing.Size(392, 265);
            this.lv.TabIndex = 3;
            this.lv.UseCompatibleStateImageBehavior = false;
            this.lv.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Index";
            this.columnHeader1.Width = 89;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Observatii";
            this.columnHeader2.Width = 80;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Frecvente";
            this.columnHeader3.Width = 88;
            // 
            // Valoare
            // 
            this.Valoare.AutoSize = true;
            this.Valoare.Location = new System.Drawing.Point(40, 83);
            this.Valoare.Name = "Valoare";
            this.Valoare.Size = new System.Drawing.Size(55, 16);
            this.Valoare.TabIndex = 12;
            this.Valoare.Text = "Valoare";
            // 
            // tbObsv
            // 
            this.tbObsv.Location = new System.Drawing.Point(118, 82);
            this.tbObsv.Name = "tbObsv";
            this.tbObsv.Size = new System.Drawing.Size(100, 22);
            this.tbObsv.TabIndex = 11;
            // 
            // btnAdaugare
            // 
            this.btnAdaugare.Location = new System.Drawing.Point(70, 134);
            this.btnAdaugare.Name = "btnAdaugare";
            this.btnAdaugare.Size = new System.Drawing.Size(131, 42);
            this.btnAdaugare.TabIndex = 10;
            this.btnAdaugare.Text = "Adauga";
            this.btnAdaugare.UseVisualStyleBackColor = true;
            this.btnAdaugare.Click += new System.EventHandler(this.btnAdaugare_Click);
            // 
            // btnStergereSimpla
            // 
            this.btnStergereSimpla.Location = new System.Drawing.Point(70, 277);
            this.btnStergereSimpla.Name = "btnStergereSimpla";
            this.btnStergereSimpla.Size = new System.Drawing.Size(131, 42);
            this.btnStergereSimpla.TabIndex = 14;
            this.btnStergereSimpla.Text = "Stergere Simpla";
            this.btnStergereSimpla.UseVisualStyleBackColor = true;
            this.btnStergereSimpla.Click += new System.EventHandler(this.btnStergereSimpla_Click);
            // 
            // btnModifica
            // 
            this.btnModifica.Location = new System.Drawing.Point(70, 199);
            this.btnModifica.Name = "btnModifica";
            this.btnModifica.Size = new System.Drawing.Size(131, 42);
            this.btnModifica.TabIndex = 13;
            this.btnModifica.Text = "Modifica";
            this.btnModifica.UseVisualStyleBackColor = true;
            this.btnModifica.Click += new System.EventHandler(this.btnModifica_Click);
            // 
            // btnStergereCompleta
            // 
            this.btnStergereCompleta.Location = new System.Drawing.Point(70, 345);
            this.btnStergereCompleta.Name = "btnStergereCompleta";
            this.btnStergereCompleta.Size = new System.Drawing.Size(131, 42);
            this.btnStergereCompleta.TabIndex = 15;
            this.btnStergereCompleta.Text = "Stergere Completa";
            this.btnStergereCompleta.UseVisualStyleBackColor = true;
            this.btnStergereCompleta.Click += new System.EventHandler(this.btnStergereCompleta_Click);
            // 
            // tbMedie
            // 
            this.tbMedie.Location = new System.Drawing.Point(353, 377);
            this.tbMedie.Name = "tbMedie";
            this.tbMedie.ReadOnly = true;
            this.tbMedie.Size = new System.Drawing.Size(131, 22);
            this.tbMedie.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(290, 380);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 17;
            this.label1.Text = "Medie";
            // 
            // btnGrafic
            // 
            this.btnGrafic.Location = new System.Drawing.Point(70, 413);
            this.btnGrafic.Name = "btnGrafic";
            this.btnGrafic.Size = new System.Drawing.Size(131, 42);
            this.btnGrafic.TabIndex = 18;
            this.btnGrafic.Text = "Afisare Grafic";
            this.btnGrafic.UseVisualStyleBackColor = true;
            this.btnGrafic.Click += new System.EventHandler(this.btnGrafic_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(280, 413);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(403, 226);
            this.panel1.TabIndex = 19;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 675);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnGrafic);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbMedie);
            this.Controls.Add(this.btnStergereCompleta);
            this.Controls.Add(this.btnStergereSimpla);
            this.Controls.Add(this.btnModifica);
            this.Controls.Add(this.Valoare);
            this.Controls.Add(this.tbObsv);
            this.Controls.Add(this.btnAdaugare);
            this.Controls.Add(this.lv);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lv;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label Valoare;
        private System.Windows.Forms.TextBox tbObsv;
        private System.Windows.Forms.Button btnAdaugare;
        private System.Windows.Forms.Button btnStergereSimpla;
        private System.Windows.Forms.Button btnModifica;
        private System.Windows.Forms.Button btnStergereCompleta;
        private System.Windows.Forms.TextBox tbMedie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGrafic;
        private System.Windows.Forms.Panel panel1;
    }
}

