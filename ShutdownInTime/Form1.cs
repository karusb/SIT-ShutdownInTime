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

namespace ShutdownInTime
{
    public partial class Form1 : Form
    {
        decimal seconds = 0;
        decimal requestedSeconds = 0;
        Timer timer;
        public Form1()
        {
            InitializeComponent();
            hourNumeric.Value = SIT.Properties.Settings.Default.userHours;
            minuteNumeric.Value = SIT.Properties.Settings.Default.userMinutes;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer = new Timer();
            timer.Interval = (1000);
            timer.Tick += new EventHandler(timer_Tick);
        }

        string ShutdownInitiateCmd()
        {
            return "shutdown /s /t " + seconds.ToString();
        }

        string ShutdownForceNowCmd()
        {
            return "shutdown /f /p";
        }

        string ShutdownAbortCmd()
        {
            return "shutdown /a";
        }

        private bool ParseInput()
        {
            var hours = hourNumeric.Value;
            var mins = minuteNumeric.Value;

            seconds = (hours * 60 * 60) + (mins * 60);
            requestedSeconds = seconds;

            return seconds > 0;
        }
        private void ResetUi()
        {
            StartButton.Text = "Start";
            StartButton.BackColor = Color.OliveDrab;
            panel1.Visible = true;
            progressBar1.Value = 0;
            RemainingLabel.Text = "000";
            countDownPanel.Visible = false;
        }
        private void SetActiveUi()
        {
            StartButton.Text = "Stop";
            StartButton.BackColor = Color.Firebrick;
            panel1.Visible = false;
            RemainingLabel.Text = seconds.ToString();
            countDownPanel.Visible = true;
        }
        private void UpdateUi()
        {
            RemainingLabel.Text = seconds.ToString();
            progressBar1.Value = ((int)(seconds * 100m / requestedSeconds));
        }
        private void StartButton_Click(object sender, EventArgs e)
        {
            if (timer.Enabled)
            {
                timer.Stop();
                ExecuteCommandSync(ShutdownAbortCmd());
                ResetUi();
            }
            else
            {
                if (ParseInput())
                {
                    ExecuteCommandSync(ShutdownInitiateCmd());
                    SetActiveUi();
                    timer.Start();
                }
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            seconds -= 1;
            UpdateUi();
            Application.DoEvents();
        }

        public void ExecuteCommandSync(object command)
        {
            try
            {
                ProcessStartInfo procStartInfo =
                    new ProcessStartInfo("cmd.exe", "/c " + command);

                // redirected to the Process.StandardOutput StreamReader.
                procStartInfo.RedirectStandardOutput = true;
                procStartInfo.UseShellExecute = false;
                // Do not create the black window.
                procStartInfo.CreateNoWindow = true;

                Process proc = new Process();
                proc.StartInfo = procStartInfo;
                proc.Start();
                string result = proc.StandardOutput.ReadToEnd();

                // Display the command output.
                Console.WriteLine(result);
            }
            catch (Exception objException)
            {
                // Log the exception
            }
        }

        private void forceShutdownButton_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("All applications will be forced to close and computer will shutdown NOW. Force shutdown?", "Forced Shutdown", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            if (result == DialogResult.OK) 
                ExecuteCommandSync(ShutdownForceNowCmd());
        }

        private void minuteNumeric_ValueChanged(object sender, EventArgs e)
        {
            if (minuteNumeric.Value < 1)
                minuteNumeric.Value = 1;

            SIT.Properties.Settings.Default.userMinutes = minuteNumeric.Value;
            SIT.Properties.Settings.Default.Save();
        }

        private void hourNumeric_ValueChanged(object sender, EventArgs e)
        {
            SIT.Properties.Settings.Default.userHours = hourNumeric.Value;
            SIT.Properties.Settings.Default.Save();
        }
    }
}
