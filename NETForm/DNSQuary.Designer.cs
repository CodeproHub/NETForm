namespace NETForm
{
    partial class DNSQuary
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnqurey = new System.Windows.Forms.Button();
            this.txtweb = new System.Windows.Forms.TextBox();
            this.txtnds = new System.Windows.Forms.TextBox();
            this.txtloca = new System.Windows.Forms.TextBox();
            this.txtip = new System.Windows.Forms.TextBox();
            this.lblmessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "网站";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "IP地址";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "本机主机名";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "DNS主机名";
            // 
            // btnqurey
            // 
            this.btnqurey.Location = new System.Drawing.Point(130, 166);
            this.btnqurey.Name = "btnqurey";
            this.btnqurey.Size = new System.Drawing.Size(75, 23);
            this.btnqurey.TabIndex = 4;
            this.btnqurey.Text = "查询";
            this.btnqurey.UseVisualStyleBackColor = true;
            this.btnqurey.Click += new System.EventHandler(this.btnqurey_Click);
            // 
            // txtweb
            // 
            this.txtweb.Location = new System.Drawing.Point(130, 10);
            this.txtweb.Name = "txtweb";
            this.txtweb.Size = new System.Drawing.Size(272, 21);
            this.txtweb.TabIndex = 5;
            // 
            // txtnds
            // 
            this.txtnds.Location = new System.Drawing.Point(130, 126);
            this.txtnds.Name = "txtnds";
            this.txtnds.Size = new System.Drawing.Size(272, 21);
            this.txtnds.TabIndex = 6;
            // 
            // txtloca
            // 
            this.txtloca.Location = new System.Drawing.Point(130, 90);
            this.txtloca.Name = "txtloca";
            this.txtloca.Size = new System.Drawing.Size(272, 21);
            this.txtloca.TabIndex = 7;
            // 
            // txtip
            // 
            this.txtip.Location = new System.Drawing.Point(130, 53);
            this.txtip.Name = "txtip";
            this.txtip.Size = new System.Drawing.Size(272, 21);
            this.txtip.TabIndex = 8;
            // 
            // lblmessage
            // 
            this.lblmessage.AutoSize = true;
            this.lblmessage.Location = new System.Drawing.Point(281, 166);
            this.lblmessage.Name = "lblmessage";
            this.lblmessage.Size = new System.Drawing.Size(0, 12);
            this.lblmessage.TabIndex = 9;
            // 
            // DNSQuary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 216);
            this.Controls.Add(this.lblmessage);
            this.Controls.Add(this.txtip);
            this.Controls.Add(this.txtloca);
            this.Controls.Add(this.txtnds);
            this.Controls.Add(this.txtweb);
            this.Controls.Add(this.btnqurey);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DNSQuary";
            this.Text = "DNSAddress";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnqurey;
        private System.Windows.Forms.TextBox txtweb;
        private System.Windows.Forms.TextBox txtnds;
        private System.Windows.Forms.TextBox txtloca;
        private System.Windows.Forms.TextBox txtip;
        private System.Windows.Forms.Label lblmessage;
    }
}

