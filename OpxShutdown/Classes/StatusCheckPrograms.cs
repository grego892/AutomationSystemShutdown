using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpxShutdown.Classes
{
    public partial class StatusCheckPrograms
    {
        public static void ProgramCheck()
        {
            ListPrograms.VCAutoDub = Process.GetProcessesByName("VCAutoDub").Length > 0;
            ListPrograms.MusicSync = Process.GetProcessesByName("MusicSync").Length > 0;
            ListPrograms.RunLogsUpload = Process.GetProcessesByName("RunLogsUpload").Length > 0;
            ListPrograms.TransferConvert = Process.GetProcessesByName("TransferConvert").Length > 0;
            ListPrograms.DeviceServer = Process.GetProcessesByName("DeviceServer").Length > 0;
            ListPrograms.FuturiLDR = Process.GetProcessesByName("FuturiLDR").Length > 0;
            ListPrograms.FtpServer = Process.GetProcessesByName("FtpServer").Length > 0;
            ListPrograms.FileServer = Process.GetProcessesByName("FileServer").Length > 0;
            ListPrograms.Repeater = Process.GetProcessesByName("Repeater").Length;
        }
    }
}
