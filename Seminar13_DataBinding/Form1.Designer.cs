namespace Seminar13_DataBinding
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
            this.btnPopuleaza = new System.Windows.Forms.Button();
            this.lbStudenti = new System.Windows.Forms.ListBox();
            this.dgvStudenti = new System.Windows.Forms.DataGridView();
            this.btnAfisareDGV = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tbStudent = new System.Windows.Forms.TextBox();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudenti)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPopuleaza
            // 
            this.btnPopuleaza.Location = new System.Drawing.Point(12, 54);
            this.btnPopuleaza.Name = "btnPopuleaza";
            this.btnPopuleaza.Size = new System.Drawing.Size(129, 23);
            this.btnPopuleaza.TabIndex = 0;
            this.btnPopuleaza.Text = "Populeaza LB";
            this.btnPopuleaza.UseVisualStyleBackColor = true;
            this.btnPopuleaza.Click += new System.EventHandler(this.btnPopuleaza_Click);
            // 
            // lbStudenti
            // 
            this.lbStudenti.FormattingEnabled = true;
            this.lbStudenti.ItemHeight = 16;
            this.lbStudenti.Location = new System.Drawing.Point(12, 111);
            this.lbStudenti.Name = "lbStudenti";
            this.lbStudenti.Size = new System.Drawing.Size(170, 164);
            this.lbStudenti.TabIndex = 1;
            // 
            // dgvStudenti
            // 
            this.dgvStudenti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudenti.Location = new System.Drawing.Point(244, 111);
            this.dgvStudenti.Name = "dgvStudenti";
            this.dgvStudenti.RowHeadersWidth = 51;
            this.dgvStudenti.RowTemplate.Height = 24;
            this.dgvStudenti.Size = new System.Drawing.Size(415, 164);
            this.dgvStudenti.TabIndex = 2;
            // 
            // btnAfisareDGV
            // 
            this.btnAfisareDGV.Location = new System.Drawing.Point(300, 293);
            this.btnAfisareDGV.Name = "btnAfisareDGV";
            this.btnAfisareDGV.Size = new System.Drawing.Size(141, 23);
            this.btnAfisareDGV.TabIndex = 3;
            this.btnAfisareDGV.Text = "Afisare date dgv";
            this.btnAfisareDGV.UseVisualStyleBackColor = true;
            this.btnAfisareDGV.Click += new System.EventHandler(this.btnAfisareDGV_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(538, 293);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tbStudent
            // 
            this.tbStudent.Location = new System.Drawing.Point(12, 306);
            this.tbStudent.Name = "tbStudent";
            this.tbStudent.Size = new System.Drawing.Size(170, 22);
            this.tbStudent.TabIndex = 5;
            // 
            // btnPrev
            // 
            this.btnPrev.Location = new System.Drawing.Point(12, 363);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(75, 23);
            this.btnPrev.TabIndex = 6;
            this.btnPrev.Tag = "Prev";
            this.btnPrev.Text = "<";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(107, 363);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 7;
            this.btnNext.Tag = "Next";
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.tbStudent);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnAfisareDGV);
            this.Controls.Add(this.dgvStudenti);
            this.Controls.Add(this.lbStudenti);
            this.Controls.Add(this.btnPopuleaza);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudenti)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPopuleaza;
        private System.Windows.Forms.ListBox lbStudenti;
        private System.Windows.Forms.DataGridView dgvStudenti;
        private System.Windows.Forms.Button btnAfisareDGV;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox tbStudent;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnNext;
    }
}

