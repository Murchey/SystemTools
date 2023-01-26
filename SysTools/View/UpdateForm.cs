using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace SysTools
{
    public partial class UpdateForm : Form
    {
        public UpdateForm()
        {
            InitializeComponent();
        }

        private void buChoseFile_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog fd = new OpenFileDialog();
                fd.Filter = "XML配置文件|*.xml";
                fd.ShowDialog();
                string filePath = fd.FileName;
                txtFilePath.Text = filePath;
            }
            catch { }
        }

        private void buOK_Click(object sender, EventArgs e)
        {
            try
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(txtFilePath.Text);
                XmlNode st=doc.SelectSingleNode("SystemTools");
                XmlNode version = st.SelectSingleNode("version");
                if (!(version.InnerText=="V1.1.3"))
                {
                    Process.Start("iexplore", "https://github.com/Murchey/SystemTools");
                    this.Hide();
                }
                else
                {
                    MessageBox.Show( "当前已是最新版，无需更新", "SystemToolsUpdate", MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                    this.Hide();
                }
            }
            catch { }
        }
    }
}
