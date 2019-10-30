using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace itfantasy.gonode.toolkit
{
    public class Conf
    {
        public static string Name { get; set; }
        public static string[] Services { get; set; }
        public static string Bat { get; set; }
        public static string Logdir { get; set; }
        public static bool Auto { get; set; }

        public static void LoadConfig()
        {
            IniConfUtil.Init(OS.exePath + "conf.ini");
            Name = IniConfUtil.Get("toolkit", "Name");
            Services = IniConfUtil.Get("toolkit", "Services").Split(';');
            Logdir = IniConfUtil.Get("toolkit", "Logdir");
            Auto = IniConfUtil.Get("toolkit", "Auto") != "";

            if (BatFileExists)
            {
                Bat = FileIOUtil.ReadFile(BatFilePath);
            }
        }

        public static void SaveConfig()
        {
            IniConfUtil.Set("toolkit", "Name", Name);
            IniConfUtil.Set("toolkit", "Services", String.Join(";", Services));
            IniConfUtil.Set("toolkit", "Logdir", Logdir);
            IniConfUtil.Set("toolkit", "Auto", Auto ? "1" : "");

            FileIOUtil.CreateFile(BatFilePath, Bat);
        }

        public static bool BatFileExists
        {
            get
            {
                return FileIOUtil.FileExists(BatFilePath);
            }
        }

        public static string BatFilePath
        {
            get
            {
                return OS.exePath + "scripts.bat";
            }
        }
    }
}
