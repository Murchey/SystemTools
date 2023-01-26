using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//添加命名空间
using System.Runtime.InteropServices;

namespace SysTools
{
    //该类用来解决无边框窗体的拖动
    public class Win32
    {
        public const int WM_SYSCOMMAND = 0x112;
        //该常量表示将向Windows发送的消息类型
        public const int SC_MOVE = 0xF010;
        //该常量表示发送消息的附加消息
        public const int HTCAPTION = 0x0002;
        //该常量表示发送消息的附加消息

        //用来释放当前线程中，某个被窗口捕获的光标
        [DllImport("User32.dll")]
        public static extern bool ReleaseCapture();
        //向指定的窗体发送Windows消息
        [DllImport("User32.dll")]
        public static extern bool SendMessage(IntPtr hwdn,int wMsg,int mParam,int lParam);
//                    Value           Meaning
//  SC_CLOSE            0xF060          关闭窗口。
//  SC_CONTEXTHELP      0xF180          将光标更改为带有指针的问号。如果用户随后单击对话框中的控件，则该控件将收到一条WM_HELP消息。
//  SC_DEFAULT          0xF160          选择默认项;用户双击窗口菜单。
//  SC_HOTKEY           0xF150          激活与应用程序指定的热键关联的窗口。lParam 参数标识要激活的窗口。
//  SC_HSCROLL          0xF080          水平滚动。
//  SCF_ISSECURE        0x00000001      指示屏幕保护程序是否安全。
//  SC_KEYMENU          0xF100          检索作为击键结果的窗口菜单。有关详细信息，请参阅“备注”部分。
//  SC_MAXIMIZE         0xF030          最大化窗口。
//  SC_MINIMIZE         0xF020          最小化窗口。
//  SC_MONITORPOWER     0xF170          设置显示的状态。此命令支持具有节能功能的设备，例如电池供电的个人计算机。
//  lParam 参数可以具有以下值：
//  -1（显示器通电）
//  1（显示器将要低功耗）
//  2（显示器正在关闭）
//  SC_MOUSEMENU        0xF090          检索作为鼠标单击结果的窗口菜单。
//  SC_MOVE             0xF010          移动窗口。
//  SC_NEXTWINDOW       0xF040          移动到下一个窗口。
//  SC_PREVWINDOW       0xF050          移动到上一个窗口。
//  SC_RESTORE          0xF120          将窗口恢复到其正常位置和大小。
//  SC_SCREENSAVE       0xF140          执行在 System.ini 文件的[boot] 部分中指定的屏幕保护程序应用程序。
//  SC_SIZE             0xF000          调整窗口大小。
//  SC_TASKLIST         0xF130          激活“开始”菜单。
//  SC_VSCROLL          0xF070          垂直滚动。
    }
}
