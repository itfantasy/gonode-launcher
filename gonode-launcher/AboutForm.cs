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
    public partial class AboutForm : Form
    {
        private static AboutForm _ins;
        public static AboutForm ins
        {
            get
            {
                if (_ins == null)
                {
                    _ins = new AboutForm();
                }
                return _ins;
            }
        }

        public AboutForm()
        {
            InitializeComponent();
        }
    }
}
