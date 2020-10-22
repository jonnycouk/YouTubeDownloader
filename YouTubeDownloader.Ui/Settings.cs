using System;
using System.Configuration;

namespace YouTubeDownloader.Ui
{
    public static class Settings
    {
        public static string Get(string key)
        {
            return ConfigurationSettings.AppSettings.Get(key);
        }
    }
}
