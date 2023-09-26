using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpxShutdown
{
    internal class ProgramList
    {
        public static bool VCAutoDub { get; set; }
        public static bool MusicSync { get; set; }
        public static bool RunLogsUpload { get; set; }
        public static bool TransferConvert { get; set; }
        public static bool DeviceServer { get; set; }
        public static bool FtpServer { get; set; }
        public static bool FileServer { get; set; }
        public static int Repeater { get; set; }

        public static List<string> OpxPrograms = new()
    {
        "VCAutoDub",
        "MusicSync",
        "RunLogsUpload",
        "TransferConvert",
        "DeviceServer",
        "FTPServer",
        "FileServer",
        "Repeater"
    };
    }


}
