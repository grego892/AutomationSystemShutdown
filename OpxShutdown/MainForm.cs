using System.Collections.Generic;
using System.Diagnostics;

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
            ProgramStatusCheck.ProgramCheck();
            UpdateUI();
        }
        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            ProgramStatusCheck.ProgramCheck();
            UpdateUI();
        }

        public void UpdateUI()
        {
            VCAutoDubChk.Checked = ProgramList.VCAutoDub;
            MusicSyncChk.Checked = ProgramList.MusicSync;
            RunLogsUploadChk.Checked = ProgramList.RunLogsUpload;
            TransferConvertChk.Checked = ProgramList.TransferConvert;
            DeviceServerChk.Checked = ProgramList.DeviceServer;
            FtpServerChk.Checked = ProgramList.FtpServer;
            FileServerChk.Checked = ProgramList.FileServer;
            RepeatersTxt.Text = ProgramList.Repeater.ToString();
        }

        private async void ShutdownAllBtn_Click(object sender, EventArgs e)
        {
            ProgramStop.StopProgramsAll();

            Task.Delay(5000);

            ProgramStatusCheck.ProgramCheck();
            UpdateUI();
        }

        private async void VCAutoDubBtn_Click(object sender, EventArgs e)
        {
            ProgramStop.StopSingleProgram("VCAutoDub");

            await Task.Delay(5000);

            ProgramStatusCheck.ProgramCheck();
            UpdateUI();
            //ProgramStatusCheck.ProgramCheck();
            //UpdateUI();

        }

        private void MusicSyncBtn_Click(object sender, EventArgs e)
        {
            ProgramStop.StopSingleProgram("MusicSync");

            ProgramStatusCheck.ProgramCheck();
            UpdateUI();
        }

        private void RunLogsUploadBtn_Click(object sender, EventArgs e)
        {
            ProgramStop.StopSingleProgram("RunLogsUpload");

            ProgramStatusCheck.ProgramCheck();
            UpdateUI();
        }

        private void TransferConvertBtn_Click(object sender, EventArgs e)
        {
            ProgramStop.StopSingleProgram("TransferConvert");

            ProgramStatusCheck.ProgramCheck();
            UpdateUI();
        }

        private void DeviceServerBtn_Click(object sender, EventArgs e)
        {
            ProgramStop.StopSingleProgram("DeviceServer");

            ProgramStatusCheck.ProgramCheck();
            UpdateUI();
        }

        private void FtpServerBtn_Click(object sender, EventArgs e)
        {
            ProgramStop.StopSingleProgram("FtpServer");

            ProgramStatusCheck.ProgramCheck();
            UpdateUI();
        }

        private void FileServerBtn_Click(object sender, EventArgs e)
        {
            ProgramStop.StopSingleProgram("FileServer");

            ProgramStatusCheck.ProgramCheck();
            UpdateUI();
        }

        private void RepeatersSingleBtn_Click(object sender, EventArgs e)
        {
            ProgramStop.StopSingleProgram("Repeater");

            ProgramStatusCheck.ProgramCheck();
            UpdateUI();
        }

        private void RepeatersAllBtn_Click(object sender, EventArgs e)
        {
            while (Process.GetProcessesByName("Repeater").Length > 0)
            {
                ProgramStop.StopSingleProgram("Repeater");
            }

            ProgramStatusCheck.ProgramCheck();
            UpdateUI();
        }
    }
}
