namespace RezervareHotel
{
    partial class FormHotel
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
            this.tbLocatie = new System.Windows.Forms.TextBox();
            this.tbNrStele = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbRezevari = new System.Windows.Forms.ListBox();
            this.btnCreareHotel = new System.Windows.Forms.Button();
            this.btnSalvare = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbLocatie
            // 
            this.tbLocatie.Location = new System.Drawing.Point(150, 74);
            this.tbLocatie.Name = "tbLocatie";
            this.tbLocatie.Size = new System.Drawing.Size(100, 22);
            this.tbLocatie.TabIndex = 1;
            // 
            // tbNrStele
            // 
            this.tbNrStele.Location = new System.Drawing.Point(150, 143);
            this.tbNrStele.Name = "tbNrStele";
            this.tbNrStele.Size = new System.Drawing.Size(100, 22);
            this.tbNrStele.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Locatie";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Numar Stele";
            // 
            // lbRezevari
            // 
            this.lbRezevari.FormattingEnabled = true;
            this.lbRezevari.ItemHeight = 16;
            this.lbRezevari.Location = new System.Drawing.Point(56, 200);
            this.lbRezevari.Name = "lbRezevari";
            this.lbRezevari.Size = new System.Drawing.Size(274, 164);
            this.lbRezevari.TabIndex = 5;
            // 
            // btnCreareHotel
            // 
            this.btnCreareHotel.Location = new System.Drawing.Point(12, 395);
            this.btnCreareHotel.Name = "btnCreareHotel";
            this.btnCreareHotel.Size = new System.Drawing.Size(137, 23);
            this.btnCreareHotel.TabIndex = 6;
            this.btnCreareHotel.Text = "Creare hotel";
            this.btnCreareHotel.UseVisualStyleBackColor = true;
            this.btnCreareHotel.Click += new System.EventHandler(this.btnCreareHotel_Click);
            // 
            // btnSalvare
            // 
            this.btnSalvare.Location = new System.Drawing.Point(221, 395);
            this.btnSalvare.Name = "btnSalvare";
            this.btnSalvare.Size = new System.Drawing.Size(137, 23);
            this.btnSalvare.TabIndex = 7;
            this.btnSalvare.Text = "Salveaza";
            this.btnSalvare.UseVisualStyleBackColor = true;
            this.btnSalvare.Click += new System.EventHandler(this.btnSalvare_Click);
            // 
            // FormHotel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 467);
            this.Controls.Add(this.btnSalvare);
            this.Controls.Add(this.btnCreareHotel);
            this.Controls.Add(this.lbRezevari);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbNrStele);
            this.Controls.Add(this.tbLocatie);
            this.Name = "FormHotel";
            this.Text = "FormHotel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbLocatie;
        private System.Windows.Forms.TextBox tbNrStele;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbRezevari;
        private System.Windows.Forms.Button btnCreareHotel;
        private System.Windows.Forms.Button btnSalvare;
    }
}