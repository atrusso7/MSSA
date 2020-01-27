using System;
using System.Diagnostics;

namespace PowerShellScripts
{
    class Program
    {
        static void Main(string[] args)
        {
            Base64EncodedCommand("Get-WMIObject -Class Win32_ComputerSystem");
            Base64EncodedCommand("Get-WMIObject -Class Win32_BIOS");
            Base64EncodedCommand("Get-WMIObject -Class Win32_Baseboard");
        }
        static void Base64EncodedCommand(string command)
        {
            var psCommmand = command;
            var psCommandBytes = System.Text.Encoding.Unicode.GetBytes(psCommmand);
            var psCommandBase64 = Convert.ToBase64String(psCommandBytes);

            ProcessStartInfo startInfo = new ProcessStartInfo()
            {
                FileName = "powershell.exe",
                Arguments = $"-NoProfile -ExecutionPolicy unrestricted -EncodedCommand {psCommandBase64}",
                UseShellExecute = false
            };
            Process.Start(startInfo);
        }
    }
}
