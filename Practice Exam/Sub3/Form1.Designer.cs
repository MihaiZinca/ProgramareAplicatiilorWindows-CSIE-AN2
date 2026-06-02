namespace Sub3
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
            this.btnModifica = new System.Windows.Forms.Button();
            this.btnStergere = new System.Windows.Forms.Button();
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
            this.lv.Location = new System.Drawing.Point(276, 40);
            this.lv.MultiSelect = false;
            this.lv.Name = "lv";
            this.lv.Size = new System.Drawing.Size(392, 303);
            this.lv.TabIndex = 2;
            this.lv.UseCompatibleStateImageBehavior = false;
            this.lv.View = System.Windows.Forms.View.Details;
            this.lv.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lv_KeyDown);
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
            this.columnHeader3.Text = "Indice";
            this.columnHeader3.Width = 90;
            // 
            // Valoare
            // 
            this.Valoare.AutoSize = true;
            this.Valoare.Location = new System.Drawing.Point(32, 71);
            this.Valoare.Name = "Valoare";
            this.Valoare.Size = new System.Drawing.Size(55, 16);
            this.Valoare.TabIndex = 9;
            this.Valoare.Text = "Valoare";
            // 
            // tbObsv
            // 
            this.tbObsv.Location = new System.Drawing.Point(110, 70);
            this.tbObsv.Name = "tbObsv";
            this.tbObsv.Size = new System.Drawing.Size(100, 22);
            this.tbObsv.TabIndex = 8;
            this.tbObsv.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbObsv_KeyDown);
            // 
            // btnAdaugare
            // 
            this.btnAdaugare.Location = new System.Drawing.Point(79, 121);
            this.btnAdaugare.Name = "btnAdaugare";
            this.btnAdaugare.Size = new System.Drawing.Size(131, 42);
            this.btnAdaugare.TabIndex = 7;
            this.btnAdaugare.Text = "Adauga";
            this.btnAdaugare.UseVisualStyleBackColor = true;
            this.btnAdaugare.Click += new System.EventHandler(this.btnAdaugare_Click);
            // 
            // btnModifica
            // 
            this.btnModifica.Location = new System.Drawing.Point(79, 199);
            this.btnModifica.Name = "btnModifica";
            this.btnModifica.Size = new System.Drawing.Size(131, 42);
            this.btnModifica.TabIndex = 10;
            this.btnModifica.Text = "Modifica";
            this.btnModifica.UseVisualStyleBackColor = true;
            this.btnModifica.Click += new System.EventHandler(this.btnModifica_Click);
            // 
            // btnStergere
            // 
            this.btnStergere.Location = new System.Drawing.Point(79, 277);
            this.btnStergere.Name = "btnStergere";
            this.btnStergere.Size = new System.Drawing.Size(131, 42);
            this.btnStergere.TabIndex = 11;
            this.btnStergere.Text = "Stergere";
            this.btnStergere.UseVisualStyleBackColor = true;
            this.btnStergere.Click += new System.EventHandler(this.btnStergere_Click);
            // 
            // btnGrafic
            // 
            this.btnGrafic.Location = new System.Drawing.Point(79, 382);
            this.btnGrafic.Name = "btnGrafic";
            this.btnGrafic.Size = new System.Drawing.Size(131, 42);
            this.btnGrafic.TabIndex = 12;
            this.btnGrafic.Text = "Afisare Grafic";
            this.btnGrafic.UseVisualStyleBackColor = true;
            this.btnGrafic.Click += new System.EventHandler(this.btnGrafic_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(276, 382);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(403, 226);
            this.panel1.TabIndex = 13;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 637);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnGrafic);
            this.Controls.Add(this.btnStergere);
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
        private System.Windows.Forms.Button btnModifica;
        private System.Windows.Forms.Button btnStergere;
        private System.Windows.Forms.Button btnGrafic;
        private System.Windows.Forms.Panel panel1;
    }
}

