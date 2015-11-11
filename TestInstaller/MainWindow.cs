using EDMInstaller;
using System;
using System.IO;
using System.Windows.Forms;

namespace TestInstaller
{
    public partial class MainWindow : Form
    {
        private string InstallLocation = "Install Location";
        public static string filename = Application.StartupPath + "/mod.properties";
        public static string Forge = Application.StartupPath + "/forge.properties";
        public static bool V1_8;
        public static bool V1_7;


        public MainWindow()
        {
            InitializeComponent();
            SetModDetails();
            Json.genDefaults();
            Json.instance.run();
        }

        /// <summary>
        /// getting names from file
        /// </summary>
        public void SetModDetails()
        {
            Props.Load(filename);
            ForgeProps.Load(Forge);
            
            ModInstall.Text = Props.Name;
            ForgeInstall.Text = ForgeProps.Name;
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
                Json.forge.value = "true";
                Json.instance.run();
                Console.WriteLine(Json.forge.value.ToString());
            }
            else
            {
                Json.forge.value = "false";
                Json.instance.run();
                Console.WriteLine(Json.forge.value.ToString());
            }
        }

        private void ModInstall_CheckedChanged(object sender, EventArgs e)
        {
            if (ModInstall.Checked)
            {
                Json.mod.value = "true";
                Json.instance.run();
                Console.WriteLine(Json.mod.value.ToString());
            }
            else
            {
                Json.mod.value = "false";
                Json.instance.run();
                Console.WriteLine(Json.mod.value.ToString());
            }
        }

        private void InstallButton_Click(object sender, EventArgs e)
        {
            if (Json.mod.value == "true")
            {
                Console.WriteLine("It Worked!!!");
                if (!File.Exists(Application.StartupPath + "/" + Props.Jar + "-" + Props.Version1_8 + ".jar"))
                {
                    DownloadFiles.downloadMod();
                }
                else if (!File.Exists(Application.StartupPath + "/" + Props.Jar + "-" + Props.Version1_7 + ".jar"))
                {
                    DownloadFiles.downloadMod();
                }
                else
                {
                    MessageBox.Show("Already Downloaded. Moving file...");
                }

                if (!File.Exists(InstallLocation + "/mods/1.8/" + Props.Jar + "-" + Props.Version1_8 + ".jar"))
                {
                    if (MainWindow.V1_8 == true)
                    {
                        Directory.CreateDirectory(InstallLocation + "/mods/1.8/");
                        File.Move(Application.StartupPath + "/" + Props.Jar + "-" + Props.Version1_8 + ".jar", InstallLocation + "/mods/1.8/" + Props.Jar + "-" + Props.Version1_8 + ".jar");
                    }
                    
                }
                else if (!File.Exists(InstallLocation + "/mods/1.7.10/" + Props.Jar + "-" + Props.Version1_7 + ".jar"))
                {
                    if (MainWindow.V1_7 == true)
                    {
                        Directory.CreateDirectory(InstallLocation + "/mods/1.7.10/");
                        File.Move(Application.StartupPath + "/" + Props.Jar + "-" + Props.Version1_7 + ".jar", InstallLocation + "/mods/1.7.10" + Props.Jar + "-" + Props.Version1_7 + ".jar");
                    }
                }
                else
                {
                    MessageBox.Show("Mod is already installed");
                }
            }
            else
            {
                Console.WriteLine("Oops!! Something went wrong!! " + Json.mod.name.ToString() + " was not vaild or the config was tampered with, so no install happened.");
            }

            if (Json.forge.value == "true")
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
                Console.WriteLine("Version set to 1.8");
                V1_8 = true;
                V1_7 = false;
                Console.WriteLine(V1_8.ToString());
                ModInstall.Text = Props.Name +" "+ Props.Version1_8;
                ForgeInstall.Text = ForgeProps.Name + " " + ForgeProps.Version1_8;

            }
            if (VersionSelector.SelectedItem.ToString() == "1.7.10")
            {
                Console.WriteLine("Version set to 1.7.10");
                V1_8 = false;
                V1_7 = true;
                Console.WriteLine(V1_7.ToString());
                ModInstall.Text = Props.Name + " " + Props.Version1_7;
                ForgeInstall.Text = ForgeProps.Name + " " + ForgeProps.Version1_7;
            }    
        }
    }
}