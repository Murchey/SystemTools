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
using System.Xml;

namespace SysTools
{
    public partial class SysToolsForm : Form
    {
        public SysToolsForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (File.Exists("shutdown-p.bat"))
            {
                Process.Start(".\\shutdown-p.bat");
            }
            else {
            File.WriteAllText(".\\shutdown-p.bat", "shutdown -p",Encoding.Default);
            Process.Start(".\\shutdown-p.bat");
            }
        }

        private void buClose_Click(object sender, EventArgs e)
        {
            if (File.Exists("shutdown-f.bat"))
            {
                Process.Start(".\\shutdown-f.bat");
            }
            else
            {
                File.WriteAllText(".\\shutdown-f.bat", "shutdown -f", Encoding.Default);
                Process.Start(".\\shutdown-f.bat");
            }
        }

        private void buTimer_Click(object sender, EventArgs e)
        {
            try
            {
                int allSeconds = Convert.ToInt32(txtTime.Text) * 60;
                File.WriteAllText(".\\TimerShut.bat", "shutdown -s -f -t " + allSeconds.ToString());
                Process.Start(".\\TimerShut.bat");
            }
            catch { }
        }

        private void buCancel_Click(object sender, EventArgs e)
        {
            if (File.Exists(".\\CancelShut.bat"))
            {
                Process.Start(".\\CancelShut.bat");
            }
            else
            {
                File.WriteAllText(".\\CancelShut.bat", "shutdown -a");
                Process.Start(".\\CancelShut.bat");
            }
            
        }

        private void txtTime_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtTime.Text== "输入时长（分钟）")
            {
                txtTime.Text = "";
            }
            
        }

        private void buBrowser_Click(object sender, EventArgs e)
        {
            Process.Start("IExplore", "https://bing.com");
        }

        private void buFileSys_Click(object sender, EventArgs e)
        {
            Process.Start("explorer");
        }

        private void buRegSys_Click(object sender, EventArgs e)
        {
            Process.Start("Regedit");
        }

        private void buNotepad_Click(object sender, EventArgs e)
        {
            Process.Start("notepad");
        }

        private void buWrite_Click(object sender, EventArgs e)
        {
            Process.Start("write");
        }

        private void buTskmgr_Click(object sender, EventArgs e)
        {
            Process.Start("Taskmgr");
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text== "搜索框（在此处输入内容进行搜索）")
            {
                txtSearch.Text = "";
            }
        }

        private void buCleanSearchTxt_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
        }
        #region buttonString
        string web1url;
        string web2url;
        string web3url;
        string web4url;
        string web5url;
        string web6url;
        string web7url;
        string web8url;
        string web9url;
        #endregion
        private void SysToolsForm_Load(object sender, EventArgs e)
        {
            if (File.Exists("Websites.xml"))
            {
                #region ReadXML
                XmlDocument doc = new XmlDocument();
                doc.Load("Websites.xml");
                XmlNode Websites = doc.SelectSingleNode("Websites");

                XmlNode Web1 = Websites.SelectSingleNode("Web1");
                buWeb1.Text = Web1.Attributes["Name"].Value;
                web1url = Web1.Attributes["URL"].Value;

                XmlNode Web2 = Websites.SelectSingleNode("Web2");
                buWeb2.Text = Web2.Attributes["Name"].Value;
                web2url = Web2.Attributes["URL"].Value;

                XmlNode Web3 = Websites.SelectSingleNode("Web3");
                buWeb3.Text = Web3.Attributes["Name"].Value;
                web3url = Web3.Attributes["URL"].Value;

                XmlNode Web4 = Websites.SelectSingleNode("Web4");
                buWeb4.Text = Web4.Attributes["Name"].Value;
                web4url = Web4.Attributes["URL"].Value;

                XmlNode Web5 = Websites.SelectSingleNode("Web5");
                buWeb5.Text = Web5.Attributes["Name"].Value;
                web5url = Web5.Attributes["URL"].Value;

                XmlNode Web6 = Websites.SelectSingleNode("Web6");
                buWeb6.Text = Web6.Attributes["Name"].Value;
                web6url = Web6.Attributes["URL"].Value;

                XmlNode Web7 = Websites.SelectSingleNode("Web7");
                buWeb7.Text = Web7.Attributes["Name"].Value;
                web7url = Web7.Attributes["URL"].Value;

                XmlNode Web8 = Websites.SelectSingleNode("Web8");
                buWeb8.Text = Web8.Attributes["Name"].Value;
                web8url = Web8.Attributes["URL"].Value;

                XmlNode Web9 = Websites.SelectSingleNode("Web9");
                buWeb9.Text = Web9.Attributes["Name"].Value;
                web9url = Web9.Attributes["URL"].Value;
                #endregion 
            }
            else
            {
                # region CreateXML
                XmlDocument doc = new XmlDocument();
                XmlDeclaration dec = doc.CreateXmlDeclaration("1.0", "UTF-8", null);
                doc.AppendChild(dec);

                XmlElement Websites = doc.CreateElement("Websites");
                doc.AppendChild(Websites);

                XmlElement Web1 = doc.CreateElement("Web1");
                Web1.SetAttribute("URL", "https://cn.bing.com");
                Web1.SetAttribute("Name", "Bing");
                Websites.AppendChild(Web1);

                XmlElement Web2 = doc.CreateElement("Web2");
                Web2.SetAttribute("URL", "https://cn.bing.com");
                Web2.SetAttribute("Name", "Bing");
                Websites.AppendChild(Web2);

                XmlElement Web3 = doc.CreateElement("Web3");
                Web3.SetAttribute("URL", "https://cn.bing.com");
                Web3.SetAttribute("Name", "Bing");
                Websites.AppendChild(Web3);

                XmlElement Web4 = doc.CreateElement("Web4");
                Web4.SetAttribute("URL", "https://cn.bing.com");
                Web4.SetAttribute("Name", "Bing");
                Websites.AppendChild(Web4);

                XmlElement Web5 = doc.CreateElement("Web5");
                Web5.SetAttribute("URL", "https://cn.bing.com");
                Web5.SetAttribute("Name", "Bing");
                Websites.AppendChild(Web5);

                XmlElement Web6 = doc.CreateElement("Web6");
                Web6.SetAttribute("URL", "https://cn.bing.com");
                Web6.SetAttribute("Name", "Bing");
                Websites.AppendChild(Web6);

                XmlElement Web7 = doc.CreateElement("Web7");
                Web7.SetAttribute("URL", "https://cn.bing.com");
                Web7.SetAttribute("Name", "Bing");
                Websites.AppendChild(Web7);

                XmlElement Web8 = doc.CreateElement("Web8");
                Web8.SetAttribute("URL", "https://cn.bing.com");
                Web8.SetAttribute("Name", "Bing");
                Websites.AppendChild(Web8);

                XmlElement Web9 = doc.CreateElement("Web9");
                Web9.SetAttribute("URL", "https://cn.bing.com");
                Web9.SetAttribute("Name", "Bing");
                Websites.AppendChild(Web9);

                doc.Save("Websites.xml");
                #endregion
            }
        }

        private void buSearch_Click(object sender, EventArgs e)
        {
            try {
                switch (cbSearchEngine.SelectedItem.ToString())
                {
                    case "Bing-必应":
                        Process.Start("iexplore", "https://cn.bing.com/search?q=" + txtSearch.Text);
                        break;
                    case "Baidu-百度":
                        Process.Start("iexplore", "https://www.baidu.com/s?ie=utf-8&f=8&rsv_bp=1&rsv_idx=1&tn=baidu&wd=" + txtSearch.Text);
                        break;
                    case "Bilibili-哔哩哔哩":
                        Process.Start("iexplore", "https://search.bilibili.com/all?keyword=" + txtSearch.Text);
                        break;
                    case "Github":
                        Process.Start("iexplore", "https://github.com/search?q=" + txtSearch.Text);
                        break;
                    case "Zhihu-知乎":
                        Process.Start("iexplore", "https://www.zhihu.com/search?type=content&q=" + txtSearch.Text);
                        break;
                    case "Google-谷歌":
                        Process.Start("iexplore", "https://www.google.com/search?q=" + txtSearch.Text);
                        break;
                    case "Twitter-推特":
                        Process.Start("iexplore", "https://twitter.com/search?q=" + txtSearch.Text);
                        break;
                    case "Youtube-油管":
                        Process.Start("iexplore", "https://www.youtube.com/results?search_query="+txtSearch.Text);
                        break;
                    default:
                        break;
                }
            }
            catch { }
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            try { 
            if (e.KeyCode==Keys.Enter)
                {
                buSearch_Click(null, null);
                }
            }
            catch { }
        }

        private void buWeb1_Click(object sender, EventArgs e)
        {
            Process.Start("Iexplore", web1url);
        }

        private void buWeb2_Click(object sender, EventArgs e)
        {
            Process.Start("Iexplore", web2url);
        }

        private void buWeb3_Click(object sender, EventArgs e)
        {
            Process.Start("Iexplore", web3url);
        }

        private void buWeb4_Click(object sender, EventArgs e)
        {
            Process.Start("Iexplore", web4url);
        }

        private void buWeb5_Click(object sender, EventArgs e)
        {
            Process.Start("Iexplore", web5url);
        }

        private void buWeb6_Click(object sender, EventArgs e)
        {
            Process.Start("Iexplore", web6url);
        }

        private void buWeb7_Click(object sender, EventArgs e)
        {
            Process.Start("Iexplore", web7url);
        }

        private void buWeb8_Click(object sender, EventArgs e)
        {
            Process.Start("Iexplore", web8url);
        }

        private void buWeb9_Click(object sender, EventArgs e)
        {
            Process.Start("Iexplore", web9url);
        }
    }
}
