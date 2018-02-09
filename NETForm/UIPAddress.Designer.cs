namespace NETForm
{
    partial class UIPAddress
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
            this.btnquery = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblmessage = new System.Windows.Forms.Label();
            this.txtweb = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnquery
            // 
            this.btnquery.Location = new System.Drawing.Point(60, 145);
            this.btnquery.Name = "btnquery";
            this.btnquery.Size = new System.Drawing.Size(75, 23);
            this.btnquery.TabIndex = 0;
            this.btnquery.Text = "查询";
            this.btnquery.UseVisualStyleBackColor = true;
            this.btnquery.Click += new System.EventHandler(this.btnquery_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "网站";
            // 
            // lblmessage
            // 
            this.lblmessage.AutoSize = true;
            this.lblmessage.Location = new System.Drawing.Point(58, 58);
            this.lblmessage.Name = "lblmessage";
            this.lblmessage.Size = new System.Drawing.Size(0, 12);
            this.lblmessage.TabIndex = 2;
            // 
            // txtweb
            // 
            this.txtweb.Location = new System.Drawing.Point(60, 28);
            this.txtweb.Name = "txtweb";
            this.txtweb.Size = new System.Drawing.Size(231, 21);
            this.txtweb.TabIndex = 3;
            // 
            // UIPAddress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 211);
            this.Controls.Add(this.txtweb);
            this.Controls.Add(this.lblmessage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnquery);
            this.Name = "UIPAddress";
            this.Text = "IPAddress";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnquery;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblmessage;
        private System.Windows.Forms.TextBox txtweb;
    }
}