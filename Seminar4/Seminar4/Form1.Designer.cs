namespace Seminar4
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
            this.tbNume = new System.Windows.Forms.TextBox();
            this.tbFacultate = new System.Windows.Forms.TextBox();
            this.tbNote = new System.Windows.Forms.TextBox();
            this.tbAdauga = new System.Windows.Forms.Button();
            this.tbStudenti = new System.Windows.Forms.TextBox();
            this.btnAfiseazaStud = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbNume
            // 
            this.tbNume.Location = new System.Drawing.Point(27, 46);
            this.tbNume.Name = "tbNume";
            this.tbNume.Size = new System.Drawing.Size(114, 26);
            this.tbNume.TabIndex = 0;
        
            // 
            // tbFacultate
            // 
            this.tbFacultate.Location = new System.Drawing.Point(27, 93);
            this.tbFacultate.Name = "tbFacultate";
            this.tbFacultate.Size = new System.Drawing.Size(114, 26);
            this.tbFacultate.TabIndex = 1;
            // 
            // tbNote
            // 
            this.tbNote.Location = new System.Drawing.Point(27, 134);
            this.tbNote.Name = "tbNote";
            this.tbNote.Size = new System.Drawing.Size(114, 26);
            this.tbNote.TabIndex = 2;
            // 
            // tbAdauga
            // 
            this.tbAdauga.Location = new System.Drawing.Point(27, 185);
            this.tbAdauga.Name = "tbAdauga";
            this.tbAdauga.Size = new System.Drawing.Size(100, 32);
            this.tbAdauga.TabIndex = 3;
            this.tbAdauga.Text = "Adauga";
            this.tbAdauga.UseVisualStyleBackColor = true;
            this.tbAdauga.Click += new System.EventHandler(this.tbAdauga_Click);
            // 
            // tbStudenti
            // 
            this.tbStudenti.Location = new System.Drawing.Point(202, 46);
            this.tbStudenti.Multiline = true;
            this.tbStudenti.Name = "tbStudenti";
            this.tbStudenti.Size = new System.Drawing.Size(245, 114);
            this.tbStudenti.TabIndex = 4;
            // 
            // btnAfiseazaStud
            // 
            this.btnAfiseazaStud.Location = new System.Drawing.Point(202, 185);
            this.btnAfiseazaStud.Name = "btnAfiseazaStud";
            this.btnAfiseazaStud.Size = new System.Drawing.Size(245, 32);
            this.btnAfiseazaStud.TabIndex = 5;
            this.btnAfiseazaStud.Text = "Afiseaza stud";
            this.btnAfiseazaStud.UseVisualStyleBackColor = true;
            this.btnAfiseazaStud.Click += new System.EventHandler(this.btnAfiseazaStud_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAfiseazaStud);
            this.Controls.Add(this.tbStudenti);
            this.Controls.Add(this.tbAdauga);
            this.Controls.Add(this.tbNote);
            this.Controls.Add(this.tbFacultate);
            this.Controls.Add(this.tbNume);
            this.Name = "Form1";
            this.Text = "PrimaFereastra";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNume;
        private System.Windows.Forms.TextBox tbFacultate;
        private System.Windows.Forms.TextBox tbNote;
        private System.Windows.Forms.Button tbAdauga;
        private System.Windows.Forms.TextBox tbStudenti;
        private System.Windows.Forms.Button btnAfiseazaStud;
    }
}

