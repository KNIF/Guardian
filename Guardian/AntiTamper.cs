using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Security.Cryptography;

namespace Guardian
{
    internal class AntiTamper : Main
    {
        internal static void Initialize(string URL)
        {
            string assemblyPath = Process.GetCurrentProcess().MainModule.FileName;
            try
            {
                using (var md5 = MD5.Create())
                {
                    using (var stream = File.OpenRead(assemblyPath))
                    {
                        using (WebClient wc = new WebClient())
                        {
                            var hashmd5 = md5.ComputeHash(stream);
                            string result = BitConverter.ToString(hashmd5).Replace("-", "").ToLowerInvariant();
                            string hash = wc.DownloadString(URL);
                            if (hash != result)
                            {
                                CmdWindow(string.Concat(new object[]
                                {
                                    "START CMD /C \"COLOR 4 && TITLE Guardian by KNIF#0001 && ECHO. && echo   ██████╗ ██╗   ██╗ █████╗ ██████╗ ██████╗ ██╗ █████╗ ███╗   ██╗ && echo  ██╔════╝ ██║   ██║██╔══██╗██╔══██╗██╔══██╗██║██╔══██╗████╗  ██║ && echo  ██║  ███╗██║   ██║███████║██████╔╝██║  ██║██║███████║██╔██╗ ██║ && echo  ██║   ██║██║   ██║██╔══██║██╔══██╗██║  ██║██║██╔══██║██║╚██╗██║ && echo  ╚██████╔╝╚██████╔╝██║  ██║██║  ██║██████╔╝██║██║  ██║██║ ╚████║ && echo   ╚═════╝  ╚═════╝ ╚═╝  ╚═╝╚═╝  ╚═╝╚═════╝ ╚═╝╚═╝  ╚═╝╚═╝  ╚═══╝ && ECHO ----------------------------------------------------------------- && ECHO File has been modified! This may be a virus, download the original file from the server! && ECHO ----------------------------------------------------------------- && TIMEOUT 10\""
                                }));
                                Process.GetCurrentProcess().Kill();
                            }
                        }
                    }
                }
            }
            catch
            {
            }
        }
    }
}