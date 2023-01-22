using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysTools
{
    public partial class SysSpeed : Form
    {
        public SysSpeed()
        {
            InitializeComponent();
        }

        private void SysSpeed_Load(object sender, EventArgs e)
        {
            if (!File.Exists("speedUp.bat"))
            {
                File.WriteAllText("speedUp.bat","");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start(".\\speedUp.bat");
        }
    }
}
