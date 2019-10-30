namespace itfantasy.gonode.toolkit
{
    partial class ConfForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.NameTb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ServiceTb = new System.Windows.Forms.TextBox();
            this.LogDirTb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.AutoCb = new System.Windows.Forms.CheckBox();
            this.OKBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.BatTb = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(24, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "程序集名称：";
            // 
            // NameTb
            // 
            this.NameTb.Location = new System.Drawing.Point(119, 33);
            this.NameTb.Name = "NameTb";
            this.NameTb.Size = new System.Drawing.Size(172, 21);
            this.NameTb.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(31, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "程序路径：";
            // 
            // ServiceTb
            // 
            this.ServiceTb.Location = new System.Drawing.Point(119, 67);
            this.ServiceTb.Multiline = true;
            this.ServiceTb.Name = "ServiceTb";
            this.ServiceTb.Size = new System.Drawing.Size(403, 123);
            this.ServiceTb.TabIndex = 3;
            // 
            // LogDirTb
            // 
            this.LogDirTb.Location = new System.Drawing.Point(119, 313);
            this.LogDirTb.Name = "LogDirTb";
            this.LogDirTb.Size = new System.Drawing.Size(403, 21);
            this.LogDirTb.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(31, 312);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "日志路径：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(31, 350);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "自动启动：";
            // 
            // AutoCb
            // 
            this.AutoCb.AutoSize = true;
            this.AutoCb.Location = new System.Drawing.Point(120, 354);
            this.AutoCb.Name = "AutoCb";
            this.AutoCb.Size = new System.Drawing.Size(156, 16);
            this.AutoCb.TabIndex = 7;
            this.AutoCb.Text = "                      ";
            this.AutoCb.UseVisualStyleBackColor = true;
            // 
            // OKBtn
            // 
            this.OKBtn.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.OKBtn.Location = new System.Drawing.Point(333, 385);
            this.OKBtn.Name = "OKBtn";
            this.OKBtn.Size = new System.Drawing.Size(99, 43);
            this.OKBtn.TabIndex = 8;
            this.OKBtn.Text = "确定";
            this.OKBtn.UseVisualStyleBackColor = true;
            this.OKBtn.Click += new System.EventHandler(this.OKBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelBtn.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CancelBtn.Location = new System.Drawing.Point(451, 385);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(99, 43);
            this.CancelBtn.TabIndex = 9;
            this.CancelBtn.Text = "取消";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // label5
            // 
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(18, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 34);
            this.label5.TabIndex = 10;
            this.label5.Text = "多个程序路径请自行换行";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(18, 223);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 50);
            this.label6.TabIndex = 13;
            this.label6.Text = "多段脚本请自行换行,服务重启时自动执行";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // BatTb
            // 
            this.BatTb.Location = new System.Drawing.Point(119, 199);
            this.BatTb.Multiline = true;
            this.BatTb.Name = "BatTb";
            this.BatTb.Size = new System.Drawing.Size(403, 104);
            this.BatTb.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(31, 198);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "前置脚本：";
            // 
            // ConfForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 453);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BatTb);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.OKBtn);
            this.Controls.Add(this.AutoCb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LogDirTb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ServiceTb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NameTb);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "ConfForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "配置信息";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.ConfForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NameTb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ServiceTb;
        private System.Windows.Forms.TextBox LogDirTb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox AutoCb;
        private System.Windows.Forms.Button OKBtn;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox BatTb;
        private System.Windows.Forms.Label label7;
    }
}