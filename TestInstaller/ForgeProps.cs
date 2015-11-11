using System;
using System.IO;

namespace EDMInstaller
{
    public class ForgeProps
    {
        public static string Name;
        public static string Version1_8;
        public static string Version1_7;
        private static JavaProperties props = new JavaProperties();
        private static FileStream stream = null;

        public static void Load(string FileName)
        {
            try
            {
                stream = new FileStream(FileName, FileMode.Open);
                props.Load(stream);
                Console.WriteLine(stream.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                // Handle the exception.
            }
            finally
            {
                if (stream != null)
                {
                    stream.Close();
                }
            }
            Name = props.GetProperty("mod.name");
            Version1_7 = props.GetProperty("mod.version1_7");
            Version1_8 = props.GetProperty("mod.version1_8");
        }
    }
}