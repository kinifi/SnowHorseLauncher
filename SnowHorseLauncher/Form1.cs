using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnowHorseLauncher
{
    public partial class MainWindow : Form
    {

        private bool isRunning = false;

        public MainWindow()
        {
            InitializeComponent();

            //check if snowhorse is running already
            OnSNOWHORSEisRunning();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void webBrowser1_DocumentCompleted_1(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void launchSNOWHORSE()
        {
            Process snowhorsegame = new Process();
            //TODO: Change this path to be the path of the game exe
            snowhorsegame.StartInfo.FileName = "C:\\Program Files (x86)\\Forge\\Forge.exe";
            snowhorsegame.Start();
        }

        /// <summary>
        /// Checks if SNOW HORSE is already running on this computer or not
        /// </summary>
        private void OnSNOWHORSEisRunning()
        {

            //const string gamename = "SNOWHORSE";
            //for debugging
            string gamename = "Discord";

            //get a list of the processes on this computer
            Process[] processlist = Process.GetProcesses();
            //iterate through the list and check if snow horse is one of them
            foreach (Process theprocess in processlist)
            {
                if (theprocess.ProcessName == gamename)
                {
                    button1.Text = "SNOWHORSE is running";
                    button1.Enabled = false;
                    Console.WriteLine("SNOWHORSE is running");
                    isRunning = true;
                }
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            //check if snow horse is running 
            OnSNOWHORSEisRunning();

            //check if snowhorse is running 
            if (isRunning == false)
            {
                launchSNOWHORSE();
            }

        }

        private void webBrowser2_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

            if(CheckForInternetConnection() == true)
            {
                //do nothing we have internet
            }
            else
            {
                //we dont have internet
                //disable the news
                NewsBrowser.Visible = false;
                noInternetIcon.Visible = true;
            }


        }

        public static bool CheckForInternetConnection()
        {
            try
            {
                using (var client = new WebClient())
                {
                    using (var stream = client.OpenRead("http://www.google.com"))
                    {
                        return true;
                    }
                }
            }
            catch
            {
                return false;
            }
        }


    }
}
