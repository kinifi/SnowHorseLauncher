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
using System.IO;

namespace SnowHorseLauncher
{
    public partial class MainWindow : Form
    {

        private bool isRunning = false;
        private string mCurrentWorkingPath;

        public MainWindow()
        {
            InitializeComponent();

            //check if snowhorse is running already
            OnSNOWHORSEisRunning();

            //get the current working directory
            mCurrentWorkingPath = Directory.GetCurrentDirectory();

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
            snowhorsegame.StartInfo.FileName = mCurrentWorkingPath + "/Game/SNOWHORSE.exe";
            snowhorsegame.Start();
        }

        /// <summary>
        /// Checks if SNOW HORSE is already running on this computer or not
        /// </summary>
        private void OnSNOWHORSEisRunning()
        {

            const string gamename = "SNOWHORSE";

            //change the text to allow for snow horse to run
            button1.Enabled = true;
            button1.Text = "PLAY";
            isRunning = false;
            Console.WriteLine("SNOWHORSE is not running");

            //get a list of the processes on this computer
            Process[] processlist = Process.GetProcesses();
            //iterate through the list and check if snow horse is one of them
            foreach (Process theprocess in processlist)
            {
                if (theprocess.ProcessName == gamename)
                {
                    button1.Text = "Running";
                    button1.Enabled = false;
                    Console.WriteLine("SNOWHORSE is running");
                    isRunning = true;
                }

            }


        }

        /// <summary>
        /// the Play Button to run SNOWHORSE.exe
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            //check if snow horse is running 
            OnSNOWHORSEisRunning();

            //check if snowhorse is running 
            if (isRunning == false)
            {
                launchSNOWHORSE();

                OnSNOWHORSEisRunning();

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

        /// <summary>
        /// If the user clicks the refresh button the snowhorse button text will refresh its status
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RefreshButton_Click(object sender, EventArgs e)
        {
            OnSNOWHORSEisRunning();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {

        }

        private void MainWindow_Deactivate(Object sender, EventArgs e)
        {

            Console.WriteLine("Main Window is Deactivated");
            //check if snowhorse is running or not and update the button appropriately
            OnSNOWHORSEisRunning();

        }

        private void MainWindow_Activated(object sender, System.EventArgs e)
        {

            Console.WriteLine("Main Window is Activated");
            //check if snowhorse is running or not and update the button appropriately
            OnSNOWHORSEisRunning();
        }

    }
}
