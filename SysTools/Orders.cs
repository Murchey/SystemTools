using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysTools
{
     public class Orders
    {
        public static void SendMsg(int n)
        {
            UpdateForm updateForm = new UpdateForm();
            switch (n)
            {
                case 0:
                    Environment.Exit(0);
                    break;
                case 1:
                    Process.Start("iexplore", "https://raw.githubusercontent.com/Murchey/SystemTools/main/TestUpdate.xml");
                    updateForm.Show();
                    break;
                default:
                    break;
            }
            
        }


    }
}
