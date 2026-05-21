namespace Curs13_Drag_Drop
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
            this.tb = new System.Windows.Forms.TextBox();
            this.lb = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // tb
            // 
            this.tb.Location = new System.Drawing.Point(79, 197);
            this.tb.Name = "tb";
            this.tb.Size = new System.Drawing.Size(174, 26);
            this.tb.TabIndex = 0;
            this.tb.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tb_MouseDown);
            // 
            // lb
            // 
            this.lb.AllowDrop = true;
            this.lb.FormattingEnabled = true;
            this.lb.ItemHeight = 20;
            this.lb.Location = new System.Drawing.Point(360, 84);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(336, 304);
            this.lb.TabIndex = 1;
            this.lb.DragDrop += new System.Windows.Forms.DragEventHandler(this.lb_DragDrop);
            this.lb.DragEnter += new System.Windows.Forms.DragEventHandler(this.lb_DragEnter);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lb);
            this.Controls.Add(this.tb);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb;
        private System.Windows.Forms.ListBox lb;
    }
}

