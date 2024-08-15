/*
 * VersionChecker.cs
 * Nuff said..
 */

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Timers;

namespace vatACARS
{
    public static class VersionChecker
    {
        public static VersionInfo updateInfo;
        private static Logger logger = new Logger("VersionChecker");
        private static System.Timers.Timer timer;

        public static void StartListening()
        {
            logger.Log("Service started.");
            timer = new System.Timers.Timer();
            timer.Elapsed += CheckTimer;
            timer.AutoReset = true; // Keep the timer running
            timer.Interval = 1.8e06;
            timer.Enabled = true;

            _ = CheckLatestVersion();
        }

        private static async Task CheckLatestVersion()
        {
            logger.Log("Checking for updates...");
            using (var httpClient = new HttpClient())
            {
                string liveVersion = await httpClient.GetStringTaskAsync("/versions/latest"); //needs to pull from a new palce for pilot client.
                if (liveVersion == "")
                {
                    logger.Log("Failed to retrieve latest version information!");
                    return;
                }
                updateInfo = JsonConvert.DeserializeObject<VersionInfo>(liveVersion);
                Version currentVersion = AppData.CurrentVersion;
                logger.Log($"Current Version: {currentVersion} | Latest Version: {updateInfo.version}");
                if (updateInfo.version > currentVersion)
                {
                    logger.Log("Update found, stopping the timer & showing update dialog.");
                    timer.Enabled = false;
                    UpdatePopupForm updatePopup = new UpdatePopupForm();
                    updatePopup.ShowDialog();
                }
            }
            logger.Log("Finished.");
        }

        private static void CheckTimer(object sender, ElapsedEventArgs e)
        {
            _ = CheckLatestVersion();
        }
    }

    public class VersionInfo
    {
        public List<string> Changes { get; set; }
        public DateTime ReleaseDateTime { get; set; }
        public Version version { get; set; }
    }
}