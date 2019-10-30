using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Runtime.InteropServices;  

public class OS
{
    public static string exePath
    {
        get
        {
            return System.Windows.Forms.Application.StartupPath + "\\";
        }
    }

    public static string GetProcessNameByPath(string path)
    {
        string[] infos = path.Split('\\');
        return infos[infos.Length - 1];
    }

    public static void KillProcessByPath(string path)
    {
        System.Diagnostics.Process[] processList = System.Diagnostics.Process.GetProcesses();
        foreach (System.Diagnostics.Process process in processList)
        {
            try
            {
                if (process.MainModule.FileName.Equals(@path, StringComparison.OrdinalIgnoreCase))
                {
                    process.Kill();
                }
            }
            catch { }
        }
    }

    public static void KillProcess(string name)
    {
        System.Diagnostics.Process[] processList = System.Diagnostics.Process.GetProcesses();
        foreach (System.Diagnostics.Process process in processList)
        {
            if (process.ProcessName == name)
            {
                process.Kill();
            }
        }
    }

    public static bool CheckProcessExistByPath(string path)
    {
        System.Diagnostics.Process[] processList = System.Diagnostics.Process.GetProcesses();
        foreach (System.Diagnostics.Process process in processList)
        {
            try
            {
                if (process.MainModule.FileName.Equals(@path, StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
            }
            catch { }
        }
        return false;
    }

    public static bool CheckProcessExist(string name)
    {
        System.Diagnostics.Process[] processList = System.Diagnostics.Process.GetProcesses();
        foreach (System.Diagnostics.Process process in processList)
        {
            if (process.ProcessName == name)
            {
                return true;
            }
        }
        return false;
    }

    public static bool ExeFile(string path, bool wait=false)
    {
        try
        {
            Process proc = System.Diagnostics.Process.Start(path);
            if (wait)
            {
                proc.WaitForExit();
            }
            return true;
        }
        catch
        {
            return false;
        }
    }

    //dosCommand Dos命令语句
    public static string Execute(string dosCommand)
    {
        return Execute(dosCommand, 10);
    }
    /// <summary>
    /// 执行DOS命令，返回DOS命令的输出
    /// </summary>
    /// <param name="dosCommand">dos命令</param>
    /// <param name="milliseconds">等待命令执行的时间（单位：毫秒），
    /// 如果设定为0，则无限等待</param>
    /// <returns>返回DOS命令的输出</returns>
    public static string Execute(string command, int seconds)
    {
        string output = ""; //输出字符串
        if (command != null && !command.Equals(""))
        {
            Process process = new Process();//创建进程对象
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = "cmd.exe";//设定需要执行的命令
            startInfo.Arguments = "/C " + command;//“/C”表示执行完命令后马上退出
            startInfo.UseShellExecute = false;//不使用系统外壳程序启动
            startInfo.RedirectStandardInput = false;//不重定向输入
            startInfo.RedirectStandardOutput = true; //重定向输出
            startInfo.CreateNoWindow = false;//不创建窗口
            process.StartInfo = startInfo;
            try
            {
                if (process.Start())//开始进程
                {
                    if (seconds == 0)
                    {
                        process.WaitForExit();//这里无限等待进程结束
                    }
                    else
                    {
                        process.WaitForExit(seconds); //等待进程结束，等待时间为指定的毫秒
                    }
                    output = process.StandardOutput.ReadToEnd();//读取进程的输出
                }
            }
            catch
            {
            }
            finally
            {
                if (process != null)
                    process.Close();
            }
        }
        return output;
    }

    #region ------------------> runtime
    [DllImport("user32.dll", EntryPoint = "FindWindow")]
    extern static IntPtr FindWindow(string lpClassName, string lpWindowName);
    [DllImport("user32.dll", EntryPoint = "ShowWindow")]
    static extern bool ShowWindow(IntPtr hwnd, int nCmdShow); 
    [DllImport("user32.dll", EntryPoint = "GetSystemMenu")]
    extern static IntPtr GetSystemMenu(IntPtr hWnd, IntPtr bRevert);
    [DllImport("user32.dll", EntryPoint = "RemoveMenu")]
    extern static IntPtr RemoveMenu(IntPtr hMenu, uint uPosition, uint uFlags);

    private const int SW_HIDE = 0x00;
    private const int SW_SHOW = 0x0001;
    #endregion

    public static void ShowCmd(string svc)
    {
        IntPtr h = FindWindow(null, svc);
        ShowWindow(h, SW_SHOW);   
    }

    public static void HideCmd(string svc)
    {
        IntPtr h = FindWindow(null, svc);
        ShowWindow(h, SW_HIDE);
    }
}

