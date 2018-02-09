namespace NETForm
{
    partial class UwebBrower
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
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.label1 = new System.Windows.Forms.Label();
            this.txtweb = new System.Windows.Forms.TextBox();
            this.btnOPen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(747, 411);
            this.webBrowser1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "地址";
            // 
            // txtweb
            // 
            this.txtweb.Location = new System.Drawing.Point(60, 10);
            this.txtweb.Name = "txtweb";
            this.txtweb.Size = new System.Drawing.Size(558, 21);
            this.txtweb.TabIndex = 2;
            this.txtweb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtweb_KeyPress);
            // 
            // btnOPen
            // 
            this.btnOPen.Location = new System.Drawing.Point(624, 8);
            this.btnOPen.Name = "btnOPen";
            this.btnOPen.Size = new System.Drawing.Size(75, 23);
            this.btnOPen.TabIndex = 3;
            this.btnOPen.Text = "打开";
            this.btnOPen.UseVisualStyleBackColor = true;
            this.btnOPen.Click += new System.EventHandler(this.btnOPen_Click);
            // 
            // UwebBrower
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 411);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOPen);
            this.Controls.Add(this.txtweb);
            this.Controls.Add(this.webBrowser1);
            this.Name = "UwebBrower";
            this.Text = "webBrower";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtweb;
        private System.Windows.Forms.Button btnOPen;
    }
}