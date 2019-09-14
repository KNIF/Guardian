using System.Diagnostics;
using System.IO;
using System.Collections.Generic;

namespace Guardian
{
    internal class AntiNet : Main
    {
        internal static void Initialize(List<string> blacklist)
        {
            VerifyNet(blacklist);
        }

        static void VerifyNet(List<string> blacklist)
        {
            try {
                string hosts = File.ReadAllText("C:\\Windows\\System32\\Drivers\\etc\\hosts").ToLower();

                foreach (string s in blacklist) {
                    if (hosts.Contains(s.ToLower())) {
                        MemberFilter(string.Concat(new object[]
                        {
                            "START CMD /C \"COLOR 4 && TITLE Guardian by KNIF#0001 && ECHO. && echo   ██████╗ ██╗   ██╗ █████╗ ██████╗ ██████╗ ██╗ █████╗ ███╗   ██╗ && echo  ██╔════╝ ██║   ██║██╔══██╗██╔══██╗██╔══██╗██║██╔══██╗████╗  ██║ && echo  ██║  ███╗██║   ██║███████║██████╔╝██║  ██║██║███████║██╔██╗ ██║ && echo  ██║   ██║██║   ██║██╔══██║██╔══██╗██║  ██║██║██╔══██║██║╚██╗██║ && echo  ╚██████╔╝╚██████╔╝██║  ██║██║  ██║██████╔╝██║██║  ██║██║ ╚████║ && echo   ╚═════╝  ╚═════╝ ╚═╝  ╚═╝╚═╝  ╚═╝╚═════╝ ╚═╝╚═╝  ╚═╝╚═╝  ╚═══╝ && ECHO ----------------------------------------------------------------- && ECHO malicious hosts file detected! Please close and try again! && ECHO ----------------------------------------------------------------- && TIMEOUT 10\""
                        }));
                        Process.GetCurrentProcess().Kill();
                    }
                }
            } catch { }
        }
    }
}
