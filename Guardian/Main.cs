using System;
using System.Diagnostics;
using System.Net;
using System.Windows.Forms;

namespace Guardian
{
    public class Main
    {
        public static void Start(string licenseKey, bool AntiDump, bool AntiDebug, bool AntiEmulation, bool AntiNet)
        {
            WebRequest.DefaultWebProxy = new WebProxy();

            bool active = false;
            string ws = "";

            try {
                ws = new WebClient().DownloadString("https://guardian.dedev.io/?k=" + licenseKey);
            }
            catch (Exception ex) {
                MessageBox.Show("Error while attempting to activate Guardian.\nThis application won't be protected by Guardian.\n\nPress OK to continue.", "Guardian by KNIF#0001", MessageBoxButtons.OK, MessageBoxIcon.Error);
                active = false;
            }

            if (ws == "YES") {
                active = true;
            }
            else {
                active = false;
            }

            if (active == true) {
                if (AntiDump)
                    Guardian.AntiDump.Initialize();
                if (AntiDebug)
                    Guardian.AntiDebug.Initialize();
                if (AntiEmulation)
                    Guardian.AntiEmulation.Initialize();
                if (AntiNet)
                    Guardian.AntiNet.Initialize();
            }
            else {
                MessageBox.Show("Guardian is not licensed.\nYou need to enter a valid product key to use this tool.\nThis application won't be protected by Guardian.\nAdd KNIF#0001 on Discord to buy a license key.\n\nPress OK to continue.", "Guardian by KNIF#0001", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public static void Start(string licenseKey, string urlForHashCheck, bool AntiDump, bool AntiDebug, bool AntiEmulation, bool AntiNet)
        {
            WebRequest.DefaultWebProxy = new WebProxy();

            bool active = false;
            string ws = "";

            try {
                ws = new WebClient().DownloadString("https://guardian.dedev.io/?k=" + licenseKey);
            }
            catch (Exception ex) {
                MessageBox.Show("Error while attempting to activate Guardian.\nThis application won't be protected by Guardian.\n\nPress OK to continue.", "Guardian by KNIF#0001", MessageBoxButtons.OK, MessageBoxIcon.Error);
                active = false;
            }

            if (ws == "YES") {
                active = true;
            }
            else {
                active = false;
            }

            if (active == true) {
                if (!string.IsNullOrEmpty(urlForHashCheck))
                    Guardian.AntiTamper.Initialize(urlForHashCheck);
                if (AntiDump)
                    Guardian.AntiDump.Initialize();
                if (AntiDebug)
                    Guardian.AntiDebug.Initialize();
                if (AntiEmulation)
                    Guardian.AntiEmulation.Initialize();
                if (AntiNet)
                    Guardian.AntiNet.Initialize();
            }
            else {
                MessageBox.Show("Guardian is not licensed.\nYou need to enter a valid product key to use this tool.\nThis application won't be protected by Guardian.\nAdd KNIF#0001 on Discord to buy a license key.\n\nPress OK to continue.", "Guardian by KNIF#0001", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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
