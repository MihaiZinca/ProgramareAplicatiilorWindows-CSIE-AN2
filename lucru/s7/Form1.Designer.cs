namespace s7
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
            this.components = new System.ComponentModel.Container();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.tbDenumire = new System.Windows.Forms.TextBox();
            this.tbPret = new System.Windows.Forms.TextBox();
            this.tbCantitate = new System.Windows.Forms.TextBox();
            this.tbValoare = new System.Windows.Forms.TextBox();
            this.lvProduse = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAdaugaLinie = new System.Windows.Forms.Button();
            this.btnCalculeazaTotal = new System.Windows.Forms.Button();
            this.tbValoaretTotala = new System.Windows.Forms.TextBox();
            this.btnComanda = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // tbDenumire
            // 
            this.tbDenumire.Location = new System.Drawing.Point(12, 48);
            this.tbDenumire.Name = "tbDenumire";
            this.tbDenumire.Size = new System.Drawing.Size(100, 22);
            this.tbDenumire.TabIndex = 1;
            // 
            // tbPret
            // 
            this.tbPret.Location = new System.Drawing.Point(132, 48);
            this.tbPret.Name = "tbPret";
            this.tbPret.Size = new System.Drawing.Size(100, 22);
            this.tbPret.TabIndex = 2;
            this.tbPret.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCifre_KeyPress);
            // 
            // tbCantitate
            // 
            this.tbCantitate.Location = new System.Drawing.Point(260, 48);
            this.tbCantitate.Name = "tbCantitate";
            this.tbCantitate.Size = new System.Drawing.Size(100, 22);
            this.tbCantitate.TabIndex = 3;
            this.tbCantitate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCifre_KeyPress);
            // 
            // tbValoare
            // 
            this.tbValoare.Location = new System.Drawing.Point(380, 48);
            this.tbValoare.Name = "tbValoare";
            this.tbValoare.ReadOnly = true;
            this.tbValoare.Size = new System.Drawing.Size(100, 22);
            this.tbValoare.TabIndex = 4;
            // 
            // lvProduse
            // 
            this.lvProduse.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvProduse.GridLines = true;
            this.lvProduse.HideSelection = false;
            this.lvProduse.Location = new System.Drawing.Point(518, 48);
            this.lvProduse.Name = "lvProduse";
            this.lvProduse.Size = new System.Drawing.Size(319, 168);
            this.lvProduse.TabIndex = 5;
            this.lvProduse.UseCompatibleStateImageBehavior = false;
            this.lvProduse.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Denumire";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Pret";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Cantitate";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Valoare";
            // 
            // btnAdaugaLinie
            // 
            this.btnAdaugaLinie.Location = new System.Drawing.Point(529, 239);
            this.btnAdaugaLinie.Name = "btnAdaugaLinie";
            this.btnAdaugaLinie.Size = new System.Drawing.Size(117, 23);
            this.btnAdaugaLinie.TabIndex = 6;
            this.btnAdaugaLinie.Text = "Adauga Linie";
            this.btnAdaugaLinie.UseVisualStyleBackColor = true;
            this.btnAdaugaLinie.Click += new System.EventHandler(this.btnAdaugaLinie_Click);
            // 
            // btnCalculeazaTotal
            // 
            this.btnCalculeazaTotal.Location = new System.Drawing.Point(683, 239);
            this.btnCalculeazaTotal.Name = "btnCalculeazaTotal";
            this.btnCalculeazaTotal.Size = new System.Drawing.Size(144, 23);
            this.btnCalculeazaTotal.TabIndex = 7;
            this.btnCalculeazaTotal.Text = "Calculeaza total";
            this.btnCalculeazaTotal.UseVisualStyleBackColor = true;
            this.btnCalculeazaTotal.Click += new System.EventHandler(this.btnCalculeazaTotal_Click);
            // 
            // tbValoaretTotala
            // 
            this.tbValoaretTotala.Location = new System.Drawing.Point(529, 292);
            this.tbValoaretTotala.Name = "tbValoaretTotala";
            this.tbValoaretTotala.ReadOnly = true;
            this.tbValoaretTotala.Size = new System.Drawing.Size(117, 22);
            this.tbValoaretTotala.TabIndex = 8;
            // 
            // btnComanda
            // 
            this.btnComanda.Location = new System.Drawing.Point(683, 291);
            this.btnComanda.Name = "btnComanda";
            this.btnComanda.Size = new System.Drawing.Size(144, 23);
            this.btnComanda.TabIndex = 9;
            this.btnComanda.Text = "Comanda";
            this.btnComanda.UseVisualStyleBackColor = true;
            this.btnComanda.Click += new System.EventHandler(this.btnComanda_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 367);
            this.Controls.Add(this.btnComanda);
            this.Controls.Add(this.tbValoaretTotala);
            this.Controls.Add(this.btnCalculeazaTotal);
            this.Controls.Add(this.btnAdaugaLinie);
            this.Controls.Add(this.lvProduse);
            this.Controls.Add(this.tbValoare);
            this.Controls.Add(this.tbCantitate);
            this.Controls.Add(this.tbPret);
            this.Controls.Add(this.tbDenumire);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox tbDenumire;
        private System.Windows.Forms.TextBox tbPret;
        private System.Windows.Forms.TextBox tbCantitate;
        private System.Windows.Forms.TextBox tbValoare;
        private System.Windows.Forms.ListView lvProduse;
        private System.Windows.Forms.Button btnAdaugaLinie;
        private System.Windows.Forms.Button btnCalculeazaTotal;
        private System.Windows.Forms.TextBox tbValoaretTotala;
        private System.Windows.Forms.Button btnComanda;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

