using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace itfantasy.gonode.toolkit
{
    public partial class MainForm : Form
    {
        int HK_START = 0;
        int HK_STOP = 0;
        int HK_RESTART = 0;
        int HK_HIDESHOW = 0;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Form.CheckForIllegalCrossThreadCalls = false;
            this.Hide();
            this.ShowInTaskbar = false;
            this.notifyIcon.Visible = true;

            Conf.LoadConfig();
            this.notifyIcon.Text = Conf.Name;
            if (Conf.Auto)
            {
                foreach (string svc in Conf.Services)
                {
                    OS.ExeFile(svc);
                    ToolStripMenuItem subItem = new ToolStripMenuItem();
                    subItem.Tag = svc;
                    subItem.Name = OS.GetProcessNameByPath(svc).Split('.')[0];
                    subItem.Text = subItem.Name;
                    IngMi.DropDownItems.Add(subItem);
                }
            }
            Hotkey hotkey = new Hotkey(this.Handle);
            HK_START = hotkey.RegisterHotkey(System.Windows.Forms.Keys.S, Hotkey.KeyFlags.MOD_WIN);
            HK_STOP = hotkey.RegisterHotkey(System.Windows.Forms.Keys.Q, Hotkey.KeyFlags.MOD_WIN);
            HK_RESTART = hotkey.RegisterHotkey(System.Windows.Forms.Keys.W, Hotkey.KeyFlags.MOD_WIN);
            HK_HIDESHOW = hotkey.RegisterHotkey(System.Windows.Forms.Keys.X, Hotkey.KeyFlags.MOD_WIN);
            hotkey.OnHotkey += new HotkeyEventHandler(OnHotkey);
        }

        private void OnHotkey(int HotkeyID)
        {
            if (HotkeyID == HK_START)
            {
                this.OnStart();
            }
            else if(HotkeyID == HK_STOP)
            {
                this.OnStop();
            }
            else if(HotkeyID == HK_RESTART)
            {
                this.OnRestart();
            }
            else if (HotkeyID == HK_HIDESHOW)
            {
                this.OnHideOrShow();
            }
        }

        private void ConfMi_Click(object sender, EventArgs e)
        {
            var result = ConfForm.ins.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                var ret = MessageBox.Show("本地配置已变更，要重启全部服务使之生效吗？", Conf.Name, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (ret == System.Windows.Forms.DialogResult.OK)
                {
                    this.OnStop();
                    this.OnStart();
                    MessageBox.Show("本地服务已重启完毕!", Conf.Name, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void StartMi_Click(object sender, EventArgs e)
        {
            this.OnStart();
        }

        private void OnStart()
        {
            int count = 0;
            foreach (string svc in Conf.Services)
            {
                if (!OS.CheckProcessExistByPath(svc))
                {
                    OS.ExeFile(svc);
                    count++;
                    bool bSign = false;
                    foreach (ToolStripMenuItem item in IngMi.DropDownItems)
                    {
                        if (item.Tag.ToString() == svc)
                        {
                            bSign = true;
                        }
                    }
                    if (!bSign)
                    {
                        ToolStripMenuItem subItem = new ToolStripMenuItem();
                        subItem.Tag = svc;
                        subItem.Name = OS.GetProcessNameByPath(svc).Split('.')[0];
                        subItem.Text = subItem.Name;
                        IngMi.DropDownItems.Add(subItem);
                    }
                }
            }
            HideMi.Checked = false;
        }

        private void StopMi_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定要关停全部服务吗？", Conf.Name, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.OK)
            {
                this.OnStop();
            }
        }

        private void OnStop()
        {
            foreach (string svc in Conf.Services)
            {
                OS.KillProcessByPath(svc);
            }
            HideMi.Checked = false;
        }

        private void RestartMi_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定要重启全部服务吗？", Conf.Name, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.OK)
            {
                this.OnRestart();
            }
        }

        private void OnRestart()
        {
            foreach (string svc in Conf.Services)
            {
                OS.KillProcessByPath(svc);
            }
            foreach (string svc in Conf.Services)
            {
                OS.ExeFile(svc);
            }
            HideMi.Checked = false;
        }

        private void EndMi_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定要关停全部服务并退出吗？", Conf.Name, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.OK)
            {
                foreach (string svc in Conf.Services)
                {
                    OS.KillProcessByPath(svc);
                }
                Application.Exit();
            }
        }

        private void HideMi_Click(object sender, EventArgs e)
        {
            this.OnHideOrShow();
        }

        private void OnHideOrShow()
        {
            HideMi.Checked = !HideMi.Checked;
            if (HideMi.Checked)
            {
                foreach (string svc in Conf.Services)
                {
                    OS.HideCmd(svc);
                }
            }
            else
            {
                foreach (string svc in Conf.Services)
                {
                    OS.ShowCmd(svc);
                }
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (IngMi.DropDownItems.Count > 0)
            {
                foreach (ToolStripMenuItem item in IngMi.DropDownItems)
                {
                    item.Text = item.Name;
                    if (!OS.CheckProcessExistByPath(item.Tag.ToString()))
                    {
                        item.Text += "(不可用)";
                    }
                }
            }
        }

        private void LogMi_Click(object sender, EventArgs e)
        {
            List<FileInfo> logInfos = FileIOUtil.GetFileInfos(Conf.Logdir);
            string logs = "";
            foreach (FileInfo info in logInfos)
            {
                logs += " " + info.FullName;
            }

            if (logs != "")
            {
                new System.Threading.Thread(() =>
                {
                    OS.Execute(String.Format("start {0}bin_tools\\baretail\\baretail.exe{1}", OS.exePath, logs));
                }).Start();
            }
        }

        private void AboutMi_Click(object sender, EventArgs e)
        {
            AboutForm.ins.ShowDialog();
        }


    }
}
