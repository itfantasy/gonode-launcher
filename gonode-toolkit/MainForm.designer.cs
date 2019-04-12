namespace itfantasy.gonode.toolkit
{
    partial class MainForm
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.mainMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.AboutMi = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.ConfMi = new System.Windows.Forms.ToolStripMenuItem();
            this.IngMi = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.HideMi = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.StartMi = new System.Windows.Forms.ToolStripMenuItem();
            this.StopMi = new System.Windows.Forms.ToolStripMenuItem();
            this.RestartMi = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.LogMi = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.EndMi = new System.Windows.Forms.ToolStripMenuItem();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.mainMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.mainMenuStrip;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "runner";
            this.notifyIcon.Visible = true;
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutMi,
            this.toolStripSeparator5,
            this.ConfMi,
            this.IngMi,
            this.toolStripSeparator1,
            this.HideMi,
            this.toolStripSeparator4,
            this.StartMi,
            this.StopMi,
            this.RestartMi,
            this.toolStripSeparator2,
            this.LogMi,
            this.toolStripSeparator3,
            this.EndMi});
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(200, 232);
            // 
            // AboutMi
            // 
            this.AboutMi.Name = "AboutMi";
            this.AboutMi.Size = new System.Drawing.Size(199, 22);
            this.AboutMi.Text = "关 于";
            this.AboutMi.Click += new System.EventHandler(this.AboutMi_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(196, 6);
            // 
            // ConfMi
            // 
            this.ConfMi.Name = "ConfMi";
            this.ConfMi.Size = new System.Drawing.Size(199, 22);
            this.ConfMi.Text = "配 置";
            this.ConfMi.Click += new System.EventHandler(this.ConfMi_Click);
            // 
            // IngMi
            // 
            this.IngMi.Name = "IngMi";
            this.IngMi.Size = new System.Drawing.Size(199, 22);
            this.IngMi.Text = "运 行 中";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(196, 6);
            // 
            // HideMi
            // 
            this.HideMi.Name = "HideMi";
            this.HideMi.Size = new System.Drawing.Size(199, 22);
            this.HideMi.Text = "隐藏命令行 (WIN + X)";
            this.HideMi.Click += new System.EventHandler(this.HideMi_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(196, 6);
            // 
            // StartMi
            // 
            this.StartMi.Name = "StartMi";
            this.StartMi.Size = new System.Drawing.Size(199, 22);
            this.StartMi.Text = "启动服务 (WIN + S)";
            this.StartMi.Click += new System.EventHandler(this.StartMi_Click);
            // 
            // StopMi
            // 
            this.StopMi.Name = "StopMi";
            this.StopMi.Size = new System.Drawing.Size(199, 22);
            this.StopMi.Text = "关停服务 (WIN + Q)";
            this.StopMi.Click += new System.EventHandler(this.StopMi_Click);
            // 
            // RestartMi
            // 
            this.RestartMi.Name = "RestartMi";
            this.RestartMi.Size = new System.Drawing.Size(199, 22);
            this.RestartMi.Text = "重启服务 (WIN + W)";
            this.RestartMi.Click += new System.EventHandler(this.RestartMi_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(196, 6);
            // 
            // LogMi
            // 
            this.LogMi.Name = "LogMi";
            this.LogMi.Size = new System.Drawing.Size(199, 22);
            this.LogMi.Text = "查看日志";
            this.LogMi.Click += new System.EventHandler(this.LogMi_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(196, 6);
            // 
            // EndMi
            // 
            this.EndMi.Name = "EndMi";
            this.EndMi.Size = new System.Drawing.Size(199, 22);
            this.EndMi.Text = "停 止";
            this.EndMi.Click += new System.EventHandler(this.EndMi_Click);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Name = "MainForm";
            this.Text = "启动器";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.mainMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem AboutMi;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem StartMi;
        private System.Windows.Forms.ToolStripMenuItem StopMi;
        private System.Windows.Forms.ToolStripMenuItem RestartMi;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem LogMi;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem EndMi;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem HideMi;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem IngMi;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ToolStripMenuItem ConfMi;
    }
}

