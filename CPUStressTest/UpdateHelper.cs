using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace CPUStressTest
{
    public class UpdateHelper
    {
        public const string DOWNLOAD_LOCATION = "https://1drv.ms/u/s!AkIXwL8E7qSqgTSZTv_CuUf1rPVR?e=b2OiGc";
        public const string UPDATE_MANUAL_LOCATION = "https://1drv.ms/p/s!AkIXwL8E7qSqgTWWgjsKcJNdv7pT?e=VGuRsd";

        public async static Task OpenDownloadLocation()
        {
            await Task.Run(() =>
            {
                Process.Start(@"C:\Program Files (x86)\Google\Chrome\Application\chrome.exe", DOWNLOAD_LOCATION);
            });
        }

        public async static Task OpenInstallationManual()
        {
            await Task.Run(() =>
            {
                Process.Start(@"C:\Program Files (x86)\Google\Chrome\Application\chrome.exe", UPDATE_MANUAL_LOCATION);
            });
        }
    }
}
