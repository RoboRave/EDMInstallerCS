using EDMInstaller;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Windows.Forms;

namespace TestInstaller
{
    public class Json
    {
        public static Json instance = new Json();
        private string RunLocation = Application.StartupPath;

        public static Forge forge = new Forge();
        public static Mod mod = new Mod();

        // makes defauls for Mod
        public static void genDefaults()
        {
            forge.name = ForgeProps.Name;
            forge.value = "false";
            mod.name = Props.Name;
            mod.value = "false";
            Console.WriteLine("Generated defaults");
        }

        public void run()
        {
            File.WriteAllText(RunLocation + "/config.json", JsonConvert.SerializeObject(forge));
            File.WriteAllText(RunLocation + "/config.json", JsonConvert.SerializeObject(mod));
            // serialize JSON directly to a file
            using (StreamWriter file = File.CreateText(RunLocation + "/config.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, forge);
                serializer.Serialize(file, mod);
            }
        }
    }
}