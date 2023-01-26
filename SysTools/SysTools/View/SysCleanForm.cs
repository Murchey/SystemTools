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
    public partial class SysClearForm : Form
    {
        public SysClearForm()
        {
            InitializeComponent();
            cbRubbishBin.CheckState = CheckState.Checked;
            cbTempFolder.CheckState = CheckState.Checked;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = 0;//用于显示提示框
            if(cbRubbishBin.CheckState==CheckState.Checked)
            {
                i++;
                Clean.SHEmptyRecycleBin(this.Handle, "", Clean.SHERB_NOCONFIRMATION + Clean.SHERB_NOPROGRESSUI + Clean.SHERB_NOSOUND);
            }//清空回收站
            if(cbTempFolder.CheckState==CheckState.Checked)
            {
                i++;
                string[] temp = {
                    "del /Q C:\\Temp",
                    "del /Q .\\deleteTempFolder.bat"
                };
                File.WriteAllLines(@".\deleteTempFolder.bat", temp);
                Process.Start(".\\deleteTempFolder.bat");
            }
            if (i>0)
            {
                MessageBox.Show("清理已完成！");
                i = 0;
            }
        }
    }
}
