using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Reflection;
using System.Windows.Forms;
using OpxShutdown.Classes;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;


namespace OpxShutdown
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            StatusCheckPrograms.ProgramCheck();
            UpdateUI();
        }
        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            StatusCheckPrograms.ProgramCheck();
            UpdateUI();
        }

        public void UpdateUI()
        {
            VCAutoDubChk.Checked = ListPrograms.VCAutoDub;
            MusicSyncChk.Checked = ListPrograms.MusicSync;
            RunLogsUploadChk.Checked = ListPrograms.RunLogsUpload;
            TransferConvertChk.Checked = ListPrograms.TransferConvert;
            DeviceServerChk.Checked = ListPrograms.DeviceServer;
            FtpServerChk.Checked = ListPrograms.FtpServer;
            FileServerChk.Checked = ListPrograms.FileServer;
            RepeatersTxt.Text = ListPrograms.Repeater.ToString();
        }

        private async void VCAutoDubBtn_Click(object sender, EventArgs e)
        {
            StopPrograms.StopSingleProgram("VCAutoDub");

            await Task.Delay(5000);

            StatusCheckPrograms.ProgramCheck();
            UpdateUI();
        }

        private void MusicSyncBtn_Click(object sender, EventArgs e)
        {
            StopPrograms.StopSingleProgram("MusicSync");

            StatusCheckPrograms.ProgramCheck();
            UpdateUI();
        }

        private void RunLogsUploadBtn_Click(object sender, EventArgs e)
        {
            StopPrograms.StopSingleProgram("RunLogsUpload");

            StatusCheckPrograms.ProgramCheck();
            UpdateUI();
        }

        private void TransferConvertBtn_Click(object sender, EventArgs e)
        {
            StopPrograms.StopSingleProgram("TransferConvert");

            StatusCheckPrograms.ProgramCheck();
            UpdateUI();
        }
        private void DeviceServerBtn_Click(object sender, EventArgs e)
        {
            StopPrograms.StopSingleProgram("DeviceServer");

            StatusCheckPrograms.ProgramCheck();
            UpdateUI();
        }
        private void FuturiLDRBtn_Click(object sender, EventArgs e)
        {
            while (Process.GetProcessesByName("FuturiLDR").Length > 0)
            {
                StopPrograms.StopSingleProgram("FuturiLDR");
            }

            StatusCheckPrograms.ProgramCheck();
            UpdateUI();
        }
        private void FtpServerBtn_Click(object sender, EventArgs e)
        {
            StopPrograms.StopSingleProgram("FtpServer");

            StatusCheckPrograms.ProgramCheck();
            UpdateUI();
        }

        private void FileServerBtn_Click(object sender, EventArgs e)
        {
            StopPrograms.StopSingleProgram("FileServer");

            StatusCheckPrograms.ProgramCheck();
            UpdateUI();
        }

        private void RepeatersAllBtn_Click(object sender, EventArgs e)
        {
            while (Process.GetProcessesByName("Repeater").Length > 0)
            {
                StopPrograms.StopSingleProgram("Repeater");
            }

            StatusCheckPrograms.ProgramCheck();
            UpdateUI();
        }

        private void OpxStartupBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists("C:\\Program Files (x86)\\Broadcast Software International\\OpX\\StartUp.exe"))
                {
                    Process.Start($"C:\\Program Files (x86)\\Broadcast Software International\\OpX\\StartUp.exe");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        private async void ShutdownAllBtn_Click(object sender, EventArgs e)
        {
            StopPrograms.StopProgramsAll();

            Task.Delay(5000);

            StatusCheckPrograms.ProgramCheck();
            UpdateUI();
        }

        private void AboutBtn_Click(object sender, EventArgs e)
        {
            Version v = Assembly.GetExecutingAssembly().GetName().Version;
            string About = string.Format(CultureInfo.InvariantCulture, @"v{0}.{1}.{2}", v.Major, v.Minor, v.Build, v.Revision);

            MessageBox.Show(About, "About", MessageBoxButtons.OK);
        }

        private void RebootBtn_Click(object sender, EventArgs e)
        {
            DialogResult confirmResult = MessageBox.Show("Are you sure to REBOOT THIS SERVER ??", "Confirm Reboot!!", MessageBoxButtons.YesNo);

                if (confirmResult == DialogResult.Yes)
                {
                    Process.Start("shutdown.exe", "-r -t 0");
                }
                else
                {}
        }
    }
}
