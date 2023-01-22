using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SysTools
{
   public class Clean
    {
        public const int SHERB_NOCONFIRMATION = 0x000001;   //不显示确认删除的对话框
        public const int SHERB_NOPROGRESSUI = 0x000002;     //不显示删除过程的进度条
        public const int SHERB_NOSOUND = 0x000004;          //当删除完成时,不播放声音

        [DllImport("shell32.dll")]
        public static extern int SHEmptyRecycleBin(IntPtr handle, string root, int falgs);
        //SHEmptyRecycleBin(this.Handle, "", SHERB_NOCONFIRMATION + SHERB_NOPROGRESSUI + SHERB_NOSOUND);
    }
}
