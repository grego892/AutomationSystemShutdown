using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpxShutdown.Classes
{
    internal class ListPrograms
    {
        public static bool VCAutoDub { get; set; }
        public static bool MusicSync { get; set; }
        public static bool RunLogsUpload { get; set; }
        public static bool TransferConvert { get; set; }
        public static bool DeviceServer { get; set; }
        public static bool FuturiLDR { get; set; }
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
            "FuturiLDR",
            "FTPServer",
            "FileServer",
            "Repeater"
        };
    }
}
