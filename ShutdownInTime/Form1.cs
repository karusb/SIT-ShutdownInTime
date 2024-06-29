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
        int selection = 0;
        int seconds = 0;
        Timer timer;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void DKradio_CheckedChanged(object sender, EventArgs e)
        {
            selection = 1;
        }

        private void SaatRadio_CheckedChanged(object sender, EventArgs e)
        {
            selection = 2;
        }

        private void SaatDKradio_CheckedChanged(object sender, EventArgs e)
        {
            selection = 3;
        }

        private void StartButton_Click(object sender, EventArgs e)
        {

            timer = new Timer();
            timer.Interval = (1000);


            string cmdtext = InputBox.Text;
            string[] bothtext = new string[2];
            int mins = 0;
            int hours = 0;

            if(cmdtext.Contains(":") && selection == 3)
            {
                bothtext = cmdtext.Split(':');
                hours= int.Parse(bothtext[0]);
                mins = int.Parse(bothtext[1]);
                seconds = (hours * 60 * 60) + (mins * 60);
            }
            else if (selection == 2)
            {
                hours = int.Parse(cmdtext);
                seconds = (hours * 60 * 60);
            }
            else if(selection == 1)
            {
                mins = int.Parse(cmdtext);
                seconds = (mins * 60);
            }
            //RemainingLabel.Text = hours.ToString() + " : " + mins.ToString();
            string command = "shutdown /s /t " + seconds.ToString();
            ExecuteCommandSync(command);
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            timer.Stop();
            ExecuteCommandSync("shutdown /a");
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            seconds -= 1;
            RemainingLabel.Text = seconds.ToString() ;
            Application.DoEvents();
        }
        /// <span class="code-SummaryComment"><summary></span>
        /// Executes a shell command synchronously.
        /// <span class="code-SummaryComment"></summary></span>
        /// <span class="code-SummaryComment"><param name="command">string command</param></span>
        /// <span class="code-SummaryComment"><returns>string, as output of the command.</returns></span>
        public void ExecuteCommandSync(object command)
        {
            try
            {
                // create the ProcessStartInfo using "cmd" as the program to be run,
                // and "/c " as the parameters.
                // Incidentally, /c tells cmd that we want it to execute the command that follows,
                // and then exit.
                System.Diagnostics.ProcessStartInfo procStartInfo =
                    new System.Diagnostics.ProcessStartInfo("cmd.exe", "/c " + command);

                // The following commands are needed to redirect the standard output.
                // This means that it will be redirected to the Process.StandardOutput StreamReader.
                procStartInfo.RedirectStandardOutput = true;
                procStartInfo.UseShellExecute = false;
                // Do not create the black window.
                procStartInfo.CreateNoWindow = true;
                // Now we create a process, assign its ProcessStartInfo and start it
                System.Diagnostics.Process proc = new System.Diagnostics.Process();
                proc.StartInfo = procStartInfo;
                proc.Start();
                // Get the output into a string
                string result = proc.StandardOutput.ReadToEnd();
                // Display the command output.
                Console.WriteLine(result);
            }
            catch (Exception objException)
            {
                // Log the exception
            }
        }
    }
}
