namespace GestiuneParcAuto
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
            this.lvAuto = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnIncarcareBD = new System.Windows.Forms.Button();
            this.btnStergere = new System.Windows.Forms.Button();
            this.btnAfisareGrafic = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvAuto
            // 
            this.lvAuto.CheckBoxes = true;
            this.lvAuto.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lvAuto.FullRowSelect = true;
            this.lvAuto.GridLines = true;
            this.lvAuto.HideSelection = false;
            this.lvAuto.Location = new System.Drawing.Point(12, 105);
            this.lvAuto.Name = "lvAuto";
            this.lvAuto.Size = new System.Drawing.Size(778, 206);
            this.lvAuto.TabIndex = 2;
            this.lvAuto.UseCompatibleStateImageBehavior = false;
            this.lvAuto.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nume proprietar";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Pret";
            this.columnHeader3.Width = 77;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Numar locuri";
            this.columnHeader4.Width = 121;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Greutati curse";
            this.columnHeader5.Width = 195;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Numar curse";
            this.columnHeader6.Width = 285;
            // 
            // btnIncarcareBD
            // 
            this.btnIncarcareBD.Location = new System.Drawing.Point(44, 41);
            this.btnIncarcareBD.Name = "btnIncarcareBD";
            this.btnIncarcareBD.Size = new System.Drawing.Size(162, 37);
            this.btnIncarcareBD.TabIndex = 3;
            this.btnIncarcareBD.Text = "Incarca date din BD";
            this.btnIncarcareBD.UseVisualStyleBackColor = true;
            this.btnIncarcareBD.Click += new System.EventHandler(this.btnIncarcareBD_Click);
            // 
            // btnStergere
            // 
            this.btnStergere.Location = new System.Drawing.Point(25, 342);
            this.btnStergere.Name = "btnStergere";
            this.btnStergere.Size = new System.Drawing.Size(181, 49);
            this.btnStergere.TabIndex = 4;
            this.btnStergere.Text = "Stergere din LV";
            this.btnStergere.UseVisualStyleBackColor = true;
            this.btnStergere.Click += new System.EventHandler(this.btnStergere_Click);
            // 
            // btnAfisareGrafic
            // 
            this.btnAfisareGrafic.Location = new System.Drawing.Point(249, 342);
            this.btnAfisareGrafic.Name = "btnAfisareGrafic";
            this.btnAfisareGrafic.Size = new System.Drawing.Size(228, 49);
            this.btnAfisareGrafic.TabIndex = 5;
            this.btnAfisareGrafic.Text = "Afisare Grafic";
            this.btnAfisareGrafic.UseVisualStyleBackColor = true;
            this.btnAfisareGrafic.Click += new System.EventHandler(this.btnAfisareGrafic_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAfisareGrafic);
            this.Controls.Add(this.btnStergere);
            this.Controls.Add(this.btnIncarcareBD);
            this.Controls.Add(this.lvAuto);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvAuto;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button btnIncarcareBD;
        private System.Windows.Forms.Button btnStergere;
        private System.Windows.Forms.Button btnAfisareGrafic;
    }
}

