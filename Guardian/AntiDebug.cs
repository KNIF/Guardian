using System;
using System.Collections;
using System.Diagnostics;
using System.Threading;
using System.Collections.Generic;

namespace Guardian
{
    internal class AntiDebug : Main
    {
        internal static void Initialize()
        {
            new Thread(new ThreadStart(ByteEqualityComparer)).Start();
        }

        static bool MEMORYBASICINFORMATION()
        {
            bool flag = false;
            IEnumerator enumerator = Process.GetCurrentProcess().Modules.GetEnumerator();
            while (enumerator.MoveNext())
            {
                if (((ProcessModule)enumerator.Current).ModuleName.EndsWith(".ni.dll"))
                {
                    flag = true;
                }
            }
            return Debugger.IsAttached | !flag;
        }

        static void ByteEqualityComparer()
        {
            string[] blacklist = new string[]
            {
                "codecracker",
                "x96dbg",
                "de4dot",
                "ilspy",
                "graywolf",
                "die",
                "simpleassemblyexplorer",
                "megadumper",
                "x64netdumper",
                "hxd",
                "petools",
                "protection_id",
                "ollydbg",
                "x32dbg",
                "x64dbg",
                "ida -",
                "charles",
                "dnspy",
                "simpleassembly",
                "peek",
                "httpanalyzer",
                "httpdebug",
                "fiddler",
                "wireshark",
                "proxifier",
                "mitmproxy",
                "processhacker",
                "memoryedit",
                "memoryscanner",
                "memory scanner"
            };
            List<string> whitelist = new List<string>()
            {
                "winstore.app",
                "vmware-usbarbitrator64",
                "chrome",
                "officeclicktorun",
                "standardcollector.service",
                "chrome",
                "devenv",
                "svchost"
            };
            Debugger.Log(0, null, "%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s%s");
            for (;;)
            {
                if (Debugger.IsAttached || Debugger.IsLogging() || MEMORYBASICINFORMATION())
                {
                    Process.GetCurrentProcess().Kill();
                }
                foreach (Process process in Process.GetProcesses())
                {
                    if (process != Process.GetCurrentProcess())
                    {
                        for (int i = 0; i < blacklist.Length; i++)
                        {
                            if (process.ProcessName.ToLower().Contains(blacklist[i]) && !whitelist.Contains(process.ProcessName.ToLower()))
                            {
                                MemberFilter(string.Concat(new object[]{
                                "START CMD /C \"COLOR 4 && TITLE Guardian by KNIF#0001 && ECHO. && echo   ██████╗ ██╗   ██╗ █████╗ ██████╗ ██████╗ ██╗ █████╗ ███╗   ██╗ && echo  ██╔════╝ ██║   ██║██╔══██╗██╔══██╗██╔══██╗██║██╔══██╗████╗  ██║ && echo  ██║  ███╗██║   ██║███████║██████╔╝██║  ██║██║███████║██╔██╗ ██║ && echo  ██║   ██║██║   ██║██╔══██║██╔══██╗██║  ██║██║██╔══██║██║╚██╗██║ && echo  ╚██████╔╝╚██████╔╝██║  ██║██║  ██║██████╔╝██║██║  ██║██║ ╚████║ && echo   ╚═════╝  ╚═════╝ ╚═╝  ╚═╝╚═╝  ╚═╝╚═════╝ ╚═╝╚═╝  ╚═╝╚═╝  ╚═══╝ && ECHO ----------------------------------------------------------------- && ECHO Debugger or Program modification tool detected {1}! Please close ",
                                process.ProcessName,
                                " and try again! && ECHO ----------------------------------------------------------------- && TIMEOUT 10\""}));
                                try {
                                    process.Kill();
                                }
                                catch (Exception) {
                                    Process.GetCurrentProcess().Kill();
                                }
                            }
                            if (process.MainWindowTitle.ToLower().Contains(blacklist[i]) && !whitelist.Contains(process.MainWindowTitle.ToLower()))
                            {
                                MemberFilter(string.Concat(new object[]{
                                "START CMD /C \"COLOR 4 && TITLE Guardian by KNIF#0001 && ECHO. && echo   ██████╗ ██╗   ██╗ █████╗ ██████╗ ██████╗ ██╗ █████╗ ███╗   ██╗ && echo  ██╔════╝ ██║   ██║██╔══██╗██╔══██╗██╔══██╗██║██╔══██╗████╗  ██║ && echo  ██║  ███╗██║   ██║███████║██████╔╝██║  ██║██║███████║██╔██╗ ██║ && echo  ██║   ██║██║   ██║██╔══██║██╔══██╗██║  ██║██║██╔══██║██║╚██╗██║ && echo  ╚██████╔╝╚██████╔╝██║  ██║██║  ██║██████╔╝██║██║  ██║██║ ╚████║ && echo   ╚═════╝  ╚═════╝ ╚═╝  ╚═╝╚═╝  ╚═╝╚═════╝ ╚═╝╚═╝  ╚═╝╚═╝  ╚═══╝ && ECHO ----------------------------------------------------------------- && ECHO Debugger or Program modification tool detected {2}! Please close ",
                                process.ProcessName,
                                " and try again! && ECHO ----------------------------------------------------------------- && TIMEOUT 10\""}));
                                try {
                                    process.Kill();
                                }
                                catch (Exception) {
                                    Process.GetCurrentProcess().Kill();
                                }
                            }
                        }
                    }
                }
                Thread.Sleep(1000);
            }
        }
    }
}
