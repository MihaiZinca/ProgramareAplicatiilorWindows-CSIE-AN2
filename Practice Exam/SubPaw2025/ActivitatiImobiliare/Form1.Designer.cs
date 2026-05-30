namespace ActivitatiImobiliare
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
            this.dgvCamere = new System.Windows.Forms.DataGridView();
            this.btnSalveaza = new System.Windows.Forms.Button();
            this.btnAfisareGrafic = new System.Windows.Forms.Button();
            this.btnFiltruSud = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCamere)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCamere
            // 
            this.dgvCamere.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCamere.Location = new System.Drawing.Point(38, 58);
            this.dgvCamere.Name = "dgvCamere";
            this.dgvCamere.RowHeadersWidth = 51;
            this.dgvCamere.RowTemplate.Height = 24;
            this.dgvCamere.Size = new System.Drawing.Size(394, 246);
            this.dgvCamere.TabIndex = 0;
            // 
            // btnSalveaza
            // 
            this.btnSalveaza.Location = new System.Drawing.Point(115, 338);
            this.btnSalveaza.Name = "btnSalveaza";
            this.btnSalveaza.Size = new System.Drawing.Size(205, 30);
            this.btnSalveaza.TabIndex = 1;
            this.btnSalveaza.Text = "Salveaza";
            this.btnSalveaza.UseVisualStyleBackColor = true;
            this.btnSalveaza.Click += new System.EventHandler(this.btnSalveaza_Click);
            // 
            // btnAfisareGrafic
            // 
            this.btnAfisareGrafic.Location = new System.Drawing.Point(143, 386);
            this.btnAfisareGrafic.Name = "btnAfisareGrafic";
            this.btnAfisareGrafic.Size = new System.Drawing.Size(141, 52);
            this.btnAfisareGrafic.TabIndex = 2;
            this.btnAfisareGrafic.Text = "Afisare Grafic";
            this.btnAfisareGrafic.UseVisualStyleBackColor = true;
            this.btnAfisareGrafic.Click += new System.EventHandler(this.btnAfisareGrafic_Click);
            // 
            // btnFiltruSud
            // 
            this.btnFiltruSud.Location = new System.Drawing.Point(115, 453);
            this.btnFiltruSud.Name = "btnFiltruSud";
            this.btnFiltruSud.Size = new System.Drawing.Size(205, 33);
            this.btnFiltruSud.TabIndex = 3;
            this.btnFiltruSud.Text = "Filtrare Sud";
            this.btnFiltruSud.UseVisualStyleBackColor = true;
            this.btnFiltruSud.Click += new System.EventHandler(this.btnFiltruSud_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 567);
            this.Controls.Add(this.btnFiltruSud);
            this.Controls.Add(this.btnAfisareGrafic);
            this.Controls.Add(this.btnSalveaza);
            this.Controls.Add(this.dgvCamere);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCamere)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCamere;
        private System.Windows.Forms.Button btnSalveaza;
        private System.Windows.Forms.Button btnAfisareGrafic;
        private System.Windows.Forms.Button btnFiltruSud;
    }
}

