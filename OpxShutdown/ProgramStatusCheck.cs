using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpxShutdown
{
    public partial class ProgramStatusCheck
    {
        public static void ProgramCheck()
        {
            ProgramList.VCAutoDub = Process.GetProcessesByName("VCAutoDub").Length > 0;
            ProgramList.MusicSync = (Process.GetProcessesByName("MusicSync").Length > 0);
            ProgramList.RunLogsUpload = (Process.GetProcessesByName("RunLogsUpload").Length > 0);
            ProgramList.TransferConvert = (Process.GetProcessesByName("TransferConvert").Length > 0);
            ProgramList.DeviceServer = (Process.GetProcessesByName("DeviceServer").Length > 0);
            ProgramList.FtpServer = (Process.GetProcessesByName("FtpServer").Length > 0);
            ProgramList.FileServer = (Process.GetProcessesByName("FileServer").Length > 0);
            ProgramList.Repeater = (Process.GetProcessesByName("Repeater").Length);
        }
    }
}
