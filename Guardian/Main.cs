using System.Diagnostics;
using System.Net;
using System.Collections.Generic;

namespace Guardian
{
    public class Main
    {
        public static void Start(string urlForHashCheck, bool AntiDump, bool AntiDebug, bool AntiEmulation, List<string> AntiNetBlacklist)
        {
            WebRequest.DefaultWebProxy = new WebProxy();

            if (!string.IsNullOrEmpty(urlForHashCheck))
                Guardian.AntiTamper.Initialize(urlForHashCheck);
            if (AntiDump)
                Guardian.AntiDump.Initialize();
            if (AntiDebug)
                Guardian.AntiDebug.Initialize();
            if (AntiEmulation)
                Guardian.AntiEmulation.Initialize();
            if (AntiNetBlacklist.Count > 0)
                Guardian.AntiNet.Initialize(AntiNetBlacklist);
        }

        internal static void MemberFilter(string A_0)
        {
            Process.Start(new ProcessStartInfo("cmd.exe", "/c " + A_0)
            {
                CreateNoWindow = true,
                UseShellExecute = false
            });
        }
    }
}
