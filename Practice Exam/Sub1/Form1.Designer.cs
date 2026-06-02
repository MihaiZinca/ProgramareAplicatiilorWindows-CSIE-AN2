namespace Sub1
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
            this.btnAdaugare = new System.Windows.Forms.Button();
            this.tbObsv = new System.Windows.Forms.TextBox();
            this.Valoare = new System.Windows.Forms.Label();
            this.btnModifica = new System.Windows.Forms.Button();
            this.btnStergere = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
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
            this.lv.Location = new System.Drawing.Point(247, 45);
            this.lv.MultiSelect = false;
            this.lv.Name = "lv";
            this.lv.Size = new System.Drawing.Size(392, 303);
            this.lv.TabIndex = 0;
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
            // btnAdaugare
            // 
            this.btnAdaugare.Location = new System.Drawing.Point(56, 97);
            this.btnAdaugare.Name = "btnAdaugare";
            this.btnAdaugare.Size = new System.Drawing.Size(131, 42);
            this.btnAdaugare.TabIndex = 1;
            this.btnAdaugare.Text = "Adauga";
            this.btnAdaugare.UseVisualStyleBackColor = true;
            this.btnAdaugare.Click += new System.EventHandler(this.btnAdaugare_Click);
            // 
            // tbObsv
            // 
            this.tbObsv.Location = new System.Drawing.Point(87, 45);
            this.tbObsv.Name = "tbObsv";
            this.tbObsv.Size = new System.Drawing.Size(100, 22);
            this.tbObsv.TabIndex = 2;
            this.tbObsv.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbObsv_KeyDown);
            // 
            // Valoare
            // 
            this.Valoare.AutoSize = true;
            this.Valoare.Location = new System.Drawing.Point(13, 51);
            this.Valoare.Name = "Valoare";
            this.Valoare.Size = new System.Drawing.Size(55, 16);
            this.Valoare.TabIndex = 3;
            this.Valoare.Text = "Valoare";
            // 
            // btnModifica
            // 
            this.btnModifica.Location = new System.Drawing.Point(56, 165);
            this.btnModifica.Name = "btnModifica";
            this.btnModifica.Size = new System.Drawing.Size(131, 42);
            this.btnModifica.TabIndex = 4;
            this.btnModifica.Text = "Modifica";
            this.btnModifica.UseVisualStyleBackColor = true;
            this.btnModifica.Click += new System.EventHandler(this.btnModifica_Click);
            // 
            // btnStergere
            // 
            this.btnStergere.Location = new System.Drawing.Point(56, 235);
            this.btnStergere.Name = "btnStergere";
            this.btnStergere.Size = new System.Drawing.Size(131, 42);
            this.btnStergere.TabIndex = 5;
            this.btnStergere.Text = "Stergere";
            this.btnStergere.UseVisualStyleBackColor = true;
            this.btnStergere.Click += new System.EventHandler(this.btnStergere_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(56, 306);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(131, 42);
            this.btnPrint.TabIndex = 6;
            this.btnPrint.Text = "Printare";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 387);
            this.Controls.Add(this.btnPrint);
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
        private System.Windows.Forms.Button btnAdaugare;
        private System.Windows.Forms.TextBox tbObsv;
        private System.Windows.Forms.Label Valoare;
        private System.Windows.Forms.Button btnModifica;
        private System.Windows.Forms.Button btnStergere;
        private System.Windows.Forms.Button btnPrint;
    }
}

