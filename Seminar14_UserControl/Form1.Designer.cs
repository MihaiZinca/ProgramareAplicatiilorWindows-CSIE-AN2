namespace Seminar14_UserControl
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
            this.userControl11 = new Seminar14_UserControl.UserControl1();
            this.btnAfiseazaTara = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userControl11
            // 
            this.userControl11.Location = new System.Drawing.Point(81, 12);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(357, 274);
            this.userControl11.TabIndex = 0;
            // 
            // btnAfiseazaTara
            // 
            this.btnAfiseazaTara.Location = new System.Drawing.Point(162, 178);
            this.btnAfiseazaTara.Name = "btnAfiseazaTara";
            this.btnAfiseazaTara.Size = new System.Drawing.Size(151, 23);
            this.btnAfiseazaTara.TabIndex = 1;
            this.btnAfiseazaTara.Text = "Afiseaza Tara Selectata";
            this.btnAfiseazaTara.UseVisualStyleBackColor = true;
            this.btnAfiseazaTara.Click += new System.EventHandler(this.btnAfiseazaTara_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAfiseazaTara);
            this.Controls.Add(this.userControl11);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private UserControl1 userControl11;
        private System.Windows.Forms.Button btnAfiseazaTara;
    }
}

