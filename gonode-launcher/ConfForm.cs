using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace itfantasy.gonode.toolkit
{
    public partial class ConfForm : Form
    {
        private static ConfForm _ins;
        public static ConfForm ins
        {
            get
            {
                if (_ins == null)
                {
                    _ins = new ConfForm();
                }
                return _ins;
            }
        }

        public ConfForm()
        {
            InitializeComponent();
        }

        private void OKBtn_Click(object sender, EventArgs e)
        {
            var ret = MessageBox.Show("确定要修改本地配置吗？", "配置变更", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (ret == System.Windows.Forms.DialogResult.OK)
            {
                this.UpdateConf();
                this.DialogResult = ret;
                this.Close();
            }
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }

        private void ConfForm_Load(object sender, EventArgs e)
        {
            this.LoadConf();
        }

        private void LoadConf()
        {
            this.NameTb.Text = Conf.Name;
            this.ServiceTb.Text = "";
            foreach (string svc in Conf.Services)
            {
                if (this.ServiceTb.Text != "")
                {
                    this.ServiceTb.Text += "\r\n";
                }
                this.ServiceTb.Text += svc;
            }
            this.LogDirTb.Text = Conf.Logdir;
            this.AutoCb.Checked = Conf.Auto;
            this.BatTb.Text = Conf.Bat;
        }

        private void UpdateConf()
        {
            Conf.Name = this.NameTb.Text;
            string temp = this.ServiceTb.Text.Replace("\r\n", "#");
            Conf.Services = temp.Split('#');
            Conf.Logdir = this.LogDirTb.Text;
            Conf.Auto = this.AutoCb.Checked;
            Conf.Bat = this.BatTb.Text;
            Conf.SaveConfig();
        }
    }
}
