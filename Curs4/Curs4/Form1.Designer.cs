namespace Curs4
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
            this.el = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pel = new System.Windows.Forms.TextBox();
            this.lb = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // el
            // 
            this.el.Location = new System.Drawing.Point(71, 52);
            this.el.Name = "el";
            this.el.Size = new System.Drawing.Size(316, 26);
            this.el.TabIndex = 0;
            this.el.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.el.TextChanged += new System.EventHandler(this.el_TextChanged);
            this.el.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.el_KeyPress);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(71, 119);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(316, 31);
            this.button1.TabIndex = 1;
            this.button1.Text = "Apasa pe EL";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pel
            // 
            this.pel.Location = new System.Drawing.Point(71, 186);
            this.pel.Name = "pel";
            this.pel.ReadOnly = true;
            this.pel.Size = new System.Drawing.Size(316, 26);
            this.pel.TabIndex = 2;
            this.pel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lb
            // 
            this.lb.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb.FormattingEnabled = true;
            this.lb.ItemHeight = 23;
            this.lb.Location = new System.Drawing.Point(71, 245);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(316, 119);
            this.lb.TabIndex = 3;
            this.lb.SelectedIndexChanged += new System.EventHandler(this.lb_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 454);
            this.Controls.Add(this.lb);
            this.Controls.Add(this.pel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.el);
            this.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox el;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox pel;
        private System.Windows.Forms.ListBox lb;
    }
}

