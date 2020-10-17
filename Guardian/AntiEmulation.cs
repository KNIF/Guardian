using System;
using System.Diagnostics;
using System.Management;
using System.Runtime.InteropServices;
using System.Threading;

namespace Guardian
{
    internal class AntiEmulation : Main
    {
        [DllImport("kernel32.dll")]
        static extern IntPtr GetModuleHandle(string lpModuleName);

        internal static void Initialize()
        {
            VM();
            Sandboxie();
            AssemblyHashAlgorithm();
        }

        static void VM()
        {
            using (var searcher = new ManagementObjectSearcher("Select * from Win32_ComputerSystem"))
            {
                using (var items = searcher.Get())
                {
                    foreach (var item in items)
                    {
                        if (item["Manufacturer"].ToString().ToLower() == "microsoft corporation" &&
                            item["Model"].ToString().ToUpperInvariant().Contains("VIRTUAL")
                            || item["Manufacturer"].ToString().ToLower().Contains("vmware")
                            || item["Model"].ToString() == "VirtualBox")
                        {
                            CmdWindow(string.Concat(new object[]
                            {
                                "START CMD /C \"COLOR 4 && TITLE Guardian by KNIF#0001 && ECHO. && echo   ██████╗ ██╗   ██╗ █████╗ ██████╗ ██████╗ ██╗ █████╗ ███╗   ██╗ && echo  ██╔════╝ ██║   ██║██╔══██╗██╔══██╗██╔══██╗██║██╔══██╗████╗  ██║ && echo  ██║  ███╗██║   ██║███████║██████╔╝██║  ██║██║███████║██╔██╗ ██║ && echo  ██║   ██║██║   ██║██╔══██║██╔══██╗██║  ██║██║██╔══██║██║╚██╗██║ && echo  ╚██████╔╝╚██████╔╝██║  ██║██║  ██║██████╔╝██║██║  ██║██║ ╚████║ && echo   ╚═════╝  ╚═════╝ ╚═╝  ╚═╝╚═╝  ╚═╝╚═════╝ ╚═╝╚═╝  ╚═╝╚═╝  ╚═══╝ && ECHO ----------------------------------------------------------------- && ECHO Virtual Machine detected! Please close and try again on a Windows Desktop! && ECHO ----------------------------------------------------------------- && TIMEOUT 10\""
                            }));
                            Process.GetCurrentProcess().Kill();
                        }
                    }
                }
            }

            foreach (var searcher in new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_VideoController")
                .Get())
            {
                if (searcher.GetPropertyValue("Name").ToString().Contains("VMware") &&
                    searcher.GetPropertyValue("Name").ToString().Contains("VBox"))
                {
                    CmdWindow(string.Concat(new object[]
                    {
                        "START CMD /C \"COLOR 4 && TITLE Guardian by KNIF#0001 && ECHO. && echo   ██████╗ ██╗   ██╗ █████╗ ██████╗ ██████╗ ██╗ █████╗ ███╗   ██╗ && echo  ██╔════╝ ██║   ██║██╔══██╗██╔══██╗██╔══██╗██║██╔══██╗████╗  ██║ && echo  ██║  ███╗██║   ██║███████║██████╔╝██║  ██║██║███████║██╔██╗ ██║ && echo  ██║   ██║██║   ██║██╔══██║██╔══██╗██║  ██║██║██╔══██║██║╚██╗██║ && echo  ╚██████╔╝╚██████╔╝██║  ██║██║  ██║██████╔╝██║██║  ██║██║ ╚████║ && echo   ╚═════╝  ╚═════╝ ╚═╝  ╚═╝╚═╝  ╚═╝╚═════╝ ╚═╝╚═╝  ╚═╝╚═╝  ╚═══╝ && ECHO ----------------------------------------------------------------- && ECHO Virtual Machine detected! Please close and try again on a Windows Desktop! && ECHO ----------------------------------------------------------------- && TIMEOUT 10\""
                    }));
                    Process.GetCurrentProcess().Kill();
                }
            }
        }

        static void Sandboxie()
        {
            if (GetModuleHandle("SbieDll.dll").ToInt32() != 0)
            {
                CmdWindow(string.Concat(new object[]
                {
                    "START CMD /C \"COLOR 4 && TITLE Guardian by KNIF#0001 && ECHO. && echo   ██████╗ ██╗   ██╗ █████╗ ██████╗ ██████╗ ██╗ █████╗ ███╗   ██╗ && echo  ██╔════╝ ██║   ██║██╔══██╗██╔══██╗██╔══██╗██║██╔══██╗████╗  ██║ && echo  ██║  ███╗██║   ██║███████║██████╔╝██║  ██║██║███████║██╔██╗ ██║ && echo  ██║   ██║██║   ██║██╔══██║██╔══██╗██║  ██║██║██╔══██║██║╚██╗██║ && echo  ╚██████╔╝╚██████╔╝██║  ██║██║  ██║██████╔╝██║██║  ██║██║ ╚████║ && echo   ╚═════╝  ╚═════╝ ╚═╝  ╚═╝╚═╝  ╚═╝╚═════╝ ╚═╝╚═╝  ╚═╝╚═╝  ╚═══╝ && ECHO ----------------------------------------------------------------- && ECHO Program start up on Sandboxie Emulation detected! Please close and try again! && ECHO ----------------------------------------------------------------- && TIMEOUT 10\""
                }));
                Process.GetCurrentProcess().Kill();
            }
        }

        static void AssemblyHashAlgorithm()
        {
            int num = new Random().Next(3000, 10000);
            DateTime now = DateTime.Now;
            Thread.Sleep(num);
            if ((DateTime.Now - now).TotalMilliseconds < (double) num)
            {
                CmdWindow(string.Concat(new object[]
                {
                    "START CMD /C \"COLOR 4 && TITLE Guardian by KNIF#0001 && ECHO. && echo   ██████╗ ██╗   ██╗ █████╗ ██████╗ ██████╗ ██╗ █████╗ ███╗   ██╗ && echo  ██╔════╝ ██║   ██║██╔══██╗██╔══██╗██╔══██╗██║██╔══██╗████╗  ██║ && echo  ██║  ███╗██║   ██║███████║██████╔╝██║  ██║██║███████║██╔██╗ ██║ && echo  ██║   ██║██║   ██║██╔══██║██╔══██╗██║  ██║██║██╔══██║██║╚██╗██║ && echo  ╚██████╔╝╚██████╔╝██║  ██║██║  ██║██████╔╝██║██║  ██║██║ ╚████║ && echo   ╚═════╝  ╚═════╝ ╚═╝  ╚═╝╚═╝  ╚═╝╚═════╝ ╚═╝╚═╝  ╚═╝╚═╝  ╚═══╝ && ECHO ----------------------------------------------------------------- && ECHO Emulation detected! Please close and try again! && ECHO ----------------------------------------------------------------- && TIMEOUT 10\""
                }));
                Process.GetCurrentProcess().Kill();
            }
        }
    }
}