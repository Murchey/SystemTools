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

namespace SysTools
{
    public partial class MainView : Form
    {
        public MainView()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            SysToolsForm stf = new SysToolsForm();
            stf.Show();
        }

        private void buMin_Click(object sender, EventArgs e)
        {
           this.WindowState= FormWindowState.Minimized;//最小化窗体
        }

        private void buClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void 显示主界面ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            { this.Hide(); this.Show(); }
            else { this.Show(); }
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            Win32.ReleaseCapture();//用来释放被当前某个窗口捕获的光标
            //向Windows发送拖动窗体的消息
            Win32.SendMessage(this.Handle,Win32.WM_SYSCOMMAND,Win32.SC_MOVE+Win32.HTCAPTION,0);
        }
        
        private void buSysTest_Click(object sender, EventArgs e)
        {
            SysTestForm stf = new SysTestForm();
            stf.Show();
        }
        private void buSysClear_Click(object sender, EventArgs e)
        {
            SysClearForm scf = new SysClearForm();
            scf.Show();
        }

        private void txtOrders_MouseDown(object sender, MouseEventArgs e)
        {
            if (txtOrders.Text == "Type Orders Here") 
            {txtOrders.Text = ""; }
        }
        

        private void txtOrders_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string orders= txtOrders.Text;
                switch (orders)
                {
                    case "Exit"://退出命令
                        Orders.SendMsg(0);
                        break;
                    default:
                        break;
                }
                
            }
        }

        private void txtOrders_TextChanged(object sender, EventArgs e){}

        private void txtOrders_Leave(object sender, EventArgs e)
        {
            txtOrders.Text = "Type Orders Here";
        }

        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            { this.Hide(); this.Show(); }
            else { this.Show(); }
        }

        private void buSysSpeed_Click(object sender, EventArgs e)
        {
            SysSpeed ss = new SysSpeed();
            ss.Show();
        }

        private void MainView_Load(object sender, EventArgs e)
        {
            string p = Process.GetCurrentProcess().ProcessName;
            Process[] processes = Process.GetProcessesByName(p);
            if (processes.Length>1)
            {
                MessageBox.Show("程序正在运行，请去系统托盘调出主页面", "SysTools",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                Application.Exit();
            }
        }
    }
}
