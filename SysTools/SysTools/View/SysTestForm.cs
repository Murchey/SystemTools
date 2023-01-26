using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace SysTools
{
    public partial class SysTestForm : Form
    {
        public SysTestForm()
        {
            InitializeComponent();
        }

        private void SysTestForm_Load(object sender, EventArgs e)
        {
            lbItems.Items.Add("电脑名称: " + SystemInformation.ComputerName);
            lbItems.Items.Add("用户名称: " + SystemInformation.UserName);
            lbItems.Items.Add("CPU核心个数: " + Environment.ProcessorCount);
            lbItems.Items.Add("显示器数量: " + SystemInformation.MonitorCount);
            lbItems.Items.Add("显示器分辨率: " + SystemInformation.PrimaryMonitorMaximizedWindowSize.Width + " * " + SystemInformation.PrimaryMonitorMaximizedWindowSize.Height);
            lbItems.Items.Add("主显示器当前分辨率: " + SystemInformation.PrimaryMonitorSize.Width + " * " + SystemInformation.PrimaryMonitorSize.Height);
            lbItems.Items.Add("系统内存页: " + Environment.SystemPageSize.ToString() + "MB");
            lbItems.Items.Add("鼠标速度: " + SystemInformation.MouseSpeed.ToString());
            if (Environment.Is64BitOperatingSystem)
            { lbItems.Items.Add("x64-64位操作系统"); }
            else { lbItems.Items.Add("x32-32位操作系统"); }
            if (SystemInformation.Network)
            { lbItems.Items.Add("网络已连接"); }
            else { lbItems.Items.Add("网络未连接"); }
            if (SystemInformation.BootMode.ToString() == "Normal")
            { lbItems.Items.Add("系统启动模式：正常启动"); }
            if (SystemInformation.BootMode.ToString() == "FailSafe")
            { lbItems.Items.Add("系统启动模式：安全启动"); }
            
        }
    }
}
