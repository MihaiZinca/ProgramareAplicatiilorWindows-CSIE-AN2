namespace Seminar14_UserControl
{
    partial class UserControl1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbTara = new System.Windows.Forms.Label();
            this.cbTara = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lbTara
            // 
            this.lbTara.AutoSize = true;
            this.lbTara.Location = new System.Drawing.Point(54, 61);
            this.lbTara.Name = "lbTara";
            this.lbTara.Size = new System.Drawing.Size(107, 16);
            this.lbTara.TabIndex = 0;
            this.lbTara.Text = "Selecteaza Tara";
            // 
            // cbTara
            // 
            this.cbTara.FormattingEnabled = true;
            this.cbTara.Location = new System.Drawing.Point(57, 102);
            this.cbTara.Name = "cbTara";
            this.cbTara.Size = new System.Drawing.Size(210, 24);
            this.cbTara.TabIndex = 1;
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cbTara);
            this.Controls.Add(this.lbTara);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(357, 274);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTara;
        private System.Windows.Forms.ComboBox cbTara;
    }
}
