namespace SubTranzactie
{
    partial class FormDB
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
            this.tbDb = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbDb
            // 
            this.tbDb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbDb.Location = new System.Drawing.Point(0, 0);
            this.tbDb.Multiline = true;
            this.tbDb.Name = "tbDb";
            this.tbDb.Size = new System.Drawing.Size(800, 450);
            this.tbDb.TabIndex = 0;
            // 
            // FormDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbDb);
            this.Name = "FormDB";
            this.Text = "FormDB";
            this.Load += new System.EventHandler(this.FormDB_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbDb;
    }
}