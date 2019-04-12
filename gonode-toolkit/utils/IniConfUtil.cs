using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.InteropServices;

public class IniConfUtil
{
    [DllImport("kernel32")]
    private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);
    [DllImport("kernel32")]
    private static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);

    private static string _iniPath;

    public static void Init(string path)
    {
        if (!File.Exists(path))
        {
            File.Create(path);
        }
        _iniPath = path;
    }

    public static void Set(string section, string key, string val)
    {
        WritePrivateProfileString(section, key, val, _iniPath);
    }

    public static string Get(string section, string key)
    {
        StringBuilder temp = new StringBuilder(500);
        int i = GetPrivateProfileString(section, key, "", temp, 500, _iniPath);
        return temp.ToString();
    }
}

