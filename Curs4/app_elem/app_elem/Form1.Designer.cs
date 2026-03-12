
namespace app_elem
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.el = new System.Windows.Forms.TextBox();
            this.pel = new System.Windows.Forms.TextBox();
            this.lb = new System.Windows.Forms.ListBox();
            this.err = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.err)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(51, 122);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(273, 27);
            this.button1.TabIndex = 1;
            this.button1.Text = "Apasa pe EL!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // el
            // 
            this.el.Location = new System.Drawing.Point(63, 35);
            this.el.Name = "el";
            this.el.Size = new System.Drawing.Size(248, 23);
            this.el.TabIndex = 0;
            this.el.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.el.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.el_KeyPress);
            // 
            // pel
            // 
            this.pel.Location = new System.Drawing.Point(63, 207);
            this.pel.Name = "pel";
            this.pel.ReadOnly = true;
            this.pel.Size = new System.Drawing.Size(248, 23);
            this.pel.TabIndex = 2;
            this.pel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lb
            // 
            this.lb.FormattingEnabled = true;
            this.lb.ItemHeight = 15;
            this.lb.Location = new System.Drawing.Point(51, 287);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(272, 184);
            this.lb.TabIndex = 3;
            this.lb.SelectedIndexChanged += new System.EventHandler(this.lb_SelectedIndexChanged);
            // 
            // err
            // 
            this.err.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 519);
            this.Controls.Add(this.lb);
            this.Controls.Add(this.pel);
            this.Controls.Add(this.el);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "App_WinF";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.err)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox el;
        private System.Windows.Forms.TextBox pel;
        private System.Windows.Forms.ListBox lb;
        private System.Windows.Forms.ErrorProvider err;
    }
}

