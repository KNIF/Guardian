using System.Diagnostics;
using System.IO;

namespace Guardian
{
    internal class AntiNet : Main
    {
        internal static void Initialize()
        {
            VerifyNet();
        }

        static void VerifyNet()
        {
            try {
                string text = File.ReadAllText("C:\\Windows\\System32\\Drivers\\etc\\hosts").ToLower();
                if (text.Contains("crack"))
                {
                    MemberFilter(string.Concat(new object[]
                    {
                        "START CMD /C \"COLOR 4 && TITLE Guardian by KNIF#0001 && ECHO. && echo   ██████╗ ██╗   ██╗ █████╗ ██████╗ ██████╗ ██╗ █████╗ ███╗   ██╗ && echo  ██╔════╝ ██║   ██║██╔══██╗██╔══██╗██╔══██╗██║██╔══██╗████╗  ██║ && echo  ██║  ███╗██║   ██║███████║██████╔╝██║  ██║██║███████║██╔██╗ ██║ && echo  ██║   ██║██║   ██║██╔══██║██╔══██╗██║  ██║██║██╔══██║██║╚██╗██║ && echo  ╚██████╔╝╚██████╔╝██║  ██║██║  ██║██████╔╝██║██║  ██║██║ ╚████║ && echo   ╚═════╝  ╚═════╝ ╚═╝  ╚═╝╚═╝  ╚═╝╚═════╝ ╚═╝╚═╝  ╚═╝╚═╝  ╚═══╝ && ECHO ----------------------------------------------------------------- && ECHO malicious hosts file detected! Please close and try again! && ECHO ----------------------------------------------------------------- && TIMEOUT 10\""
                    }));
                    Process.GetCurrentProcess().Kill();
                }
            } catch { }
        }
    }
}
