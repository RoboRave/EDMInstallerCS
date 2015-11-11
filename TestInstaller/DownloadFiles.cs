using EDMInstaller;
using System;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace TestInstaller
{
    internal class DownloadFiles
    {
        public static void downloadMod()
        {
            if (File.Exists(Application.StartupPath + "/"+Props.Jar + "-" + Props.Version1_8+".jar"))
            {
                MessageBox.Show("Hey, You Already Downloaded it. Moving file.");
            }
            else if (File.Exists(Application.StartupPath + "/" + Props.Jar + "-" + Props.Version1_7 + ".jar"))
            {
                    MessageBox.Show("Hey, You Already Downloaded it. Moving file.");
            }
            else
            {
                using (var client = new WebClient())
                {
                    if (MainWindow.V1_8)
                    {
                        client.DownloadFile(Props.URL1_8, Props.Jar + "-" + Props.Version1_8 + ".jar");
                    }
                    else if (MainWindow.V1_7 == true)
                    {
                        client.DownloadFile(Props.URL1_7, Props.Jar + "-" + Props.Version1_7 + ".jar");
                    }
                    
                }
            }
        }

        public static void DownloadForge()
        {
            if (File.Exists(Application.StartupPath + "/forge.exe"))
            {
                Console.WriteLine("Already Downloaded Forge, going to install.");
            }
            else
            {
                using (var client = new WebClient())
                {
                    if (MainWindow.V1_8 == true)
                    {
                        Console.WriteLine("http://files.minecraftforge.net/maven/net/minecraftforge/forge/" + ForgeProps.Version1_8 + "/forge-" + ForgeProps.Version1_8 + "-installer-win.exe");
                        client.DownloadFile("http://files.minecraftforge.net/maven/net/minecraftforge/forge/"+ForgeProps.Version1_8 +"/forge-"+ForgeProps.Version1_8+"-installer-win.exe", "forge.exe");
                    }else if(MainWindow.V1_7 == true)
                    {
                        client.DownloadFile("http://files.minecraftforge.net/maven/net/minecraftforge/forge/"+ForgeProps.Version1_7 + "/forge-" + ForgeProps.Version1_7 +"-installer-win.exe", "forge.exe");
                    }
                    Console.WriteLine("Downloaded Forge");
                }
            }
        }
    }
}