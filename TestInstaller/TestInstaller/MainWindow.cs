using Microsoft.VisualBasic.FileIO;
using System;
using System.IO;
using System.Windows.Forms;

namespace TestInstaller
{
    public partial class MainWindow : Form
    {
        private string InstallLocation = "Install Location";

        public MainWindow()
        {
            InitializeComponent();
            Json.genDefaults();
            Json.instance.run();
        }

        private void FindButton_Click(object sender, EventArgs e)
        {
            FolderBrowser.RootFolder = Environment.SpecialFolder.ApplicationData;
            // Show the FolderBrowserDialog
            DialogResult result = FolderBrowser.ShowDialog();
            if (result == DialogResult.OK)
            {
                FileLocation.Text = FolderBrowser.SelectedPath;
                InstallLocation = FolderBrowser.SelectedPath;
            }
        }

        private void FolderBrowser_HelpRequest(object sender, EventArgs e)
        {
        }

        private void ForgeInstall_CheckedChanged(object sender, EventArgs e)
        {
            if (ForgeInstall.Checked)
            {
                Json.config.value = "true";
                Json.instance.run();
                Console.WriteLine(Json.config.value.ToString());
            }
            else
            {
                Json.config.value = "false";
                Json.instance.run();
                Console.WriteLine(Json.config.value.ToString());
            }
        }

        private void EDMInstall_CheckedChanged(object sender, EventArgs e)
        {
            if (EDMInstall.Checked)
            {
                Json.es.value = "true";
                Json.instance.run();
                Console.WriteLine(Json.es.value.ToString());
            }
            else
            {
                Json.es.value = "false";
                Json.instance.run();
                Console.WriteLine(Json.es.value.ToString());
            }
        }

        private void InstallButton_Click(object sender, EventArgs e)
        {
            if (Json.es.value == "true")
            {
                Console.WriteLine("It Worked!!!");
                if (!File.Exists(Application.StartupPath + "/EDM.jar"))
                {
                    DownloadFiles.downloadEDM();
                }
                else
                {
                    MessageBox.Show("Already Downloaded. Moving file...");
                }

                if (!File.Exists(InstallLocation + "/mods/EDM.jar"))
                {
                    FileSystem.MoveFile(Application.StartupPath + "/EDM.jar", InstallLocation + "/mods/EDM.jar", UIOption.AllDialogs, UICancelOption.DoNothing);
                    //File.Move(Application.StartupPath + "/EDM.jar", InstallLocation + "/mods/EDM.jar");
                }
                else
                {
                    MessageBox.Show("Mod is already installed");
                }
            }
            else
            {
                Console.WriteLine("Oops!! Something went wrong!! " + Json.es.name.ToString() + " was not vaild or the config was tampered with, so no install happened.");
            }

            if (Json.config.value == "true")
            {
                DownloadFiles.DownloadForge();
                System.Diagnostics.Process.Start(Application.StartupPath + "/forge.exe");
            }
            else
            {
                Console.WriteLine("Oops!! Something went wrong!!");
            }
        }

        private void VersionSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (VersionSelector.SelectedItem.ToString() == "1.8")
            {
                Console.WriteLine("hi");
            }
            if(VersionSelector.SelectedItem.ToString() == "1.7.10")
            {
                Console.WriteLine("hello");
            }
        }
    }
}