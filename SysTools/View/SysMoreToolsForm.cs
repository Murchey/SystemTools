using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysTools
{
    public partial class SysMoreToolsForm : Form
    {
        public SysMoreToolsForm()
        {
            InitializeComponent();
        }

        private void bu_Click(object sender, EventArgs e)
        {
            GongShiJiSuanQi gongShiJiSuanQi = new GongShiJiSuanQi();
            gongShiJiSuanQi.Show();
        }
    }
}
