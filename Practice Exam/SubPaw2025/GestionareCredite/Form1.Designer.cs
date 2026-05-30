namespace GestionareCredite
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
            this.btnAdaugaCredite = new System.Windows.Forms.Button();
            this.dgvCredite = new System.Windows.Forms.DataGridView();
            this.btnModifica = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            this.btnPaste = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCredite)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdaugaCredite
            // 
            this.btnAdaugaCredite.Location = new System.Drawing.Point(95, 74);
            this.btnAdaugaCredite.Name = "btnAdaugaCredite";
            this.btnAdaugaCredite.Size = new System.Drawing.Size(192, 55);
            this.btnAdaugaCredite.TabIndex = 0;
            this.btnAdaugaCredite.Text = "Adauga";
            this.btnAdaugaCredite.UseVisualStyleBackColor = true;
            this.btnAdaugaCredite.Click += new System.EventHandler(this.btnAdaugaCredite_Click);
            // 
            // dgvCredite
            // 
            this.dgvCredite.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCredite.Location = new System.Drawing.Point(36, 151);
            this.dgvCredite.Name = "dgvCredite";
            this.dgvCredite.RowHeadersWidth = 51;
            this.dgvCredite.RowTemplate.Height = 24;
            this.dgvCredite.Size = new System.Drawing.Size(341, 150);
            this.dgvCredite.TabIndex = 1;
            // 
            // btnModifica
            // 
            this.btnModifica.Location = new System.Drawing.Point(95, 337);
            this.btnModifica.Name = "btnModifica";
            this.btnModifica.Size = new System.Drawing.Size(192, 49);
            this.btnModifica.TabIndex = 2;
            this.btnModifica.Text = "Modifica";
            this.btnModifica.UseVisualStyleBackColor = true;
            this.btnModifica.Click += new System.EventHandler(this.btnModifica_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(36, 423);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(139, 23);
            this.btnCopy.TabIndex = 3;
            this.btnCopy.Text = "Copy";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // btnPaste
            // 
            this.btnPaste.Location = new System.Drawing.Point(236, 423);
            this.btnPaste.Name = "btnPaste";
            this.btnPaste.Size = new System.Drawing.Size(141, 23);
            this.btnPaste.TabIndex = 4;
            this.btnPaste.Text = "Paste";
            this.btnPaste.UseVisualStyleBackColor = true;
            this.btnPaste.Click += new System.EventHandler(this.btnPaste_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 490);
            this.Controls.Add(this.btnPaste);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.btnModifica);
            this.Controls.Add(this.dgvCredite);
            this.Controls.Add(this.btnAdaugaCredite);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCredite)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAdaugaCredite;
        private System.Windows.Forms.DataGridView dgvCredite;
        private System.Windows.Forms.Button btnModifica;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Button btnPaste;
    }
}

