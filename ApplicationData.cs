using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace Ready2PlayApis
{
    /// <summary>
    /// Determine source Api
    /// </summary>
    public enum ESourceApi { None = 0, Official, ScreenScrapper, RawG, Igdb, SteamGrid, GitHub }

    public static class ApplicationData
    {
        /// <summary>
        /// Common constants
        /// </summary>
        /// 
        public static readonly string AppName = "Ready2PlayManager";
        public static readonly Version AppVersion = Assembly.GetExecutingAssembly().GetName().Version;
        public static readonly string AppVersionString = $"{AppVersion.Major}.{AppVersion.Minor}-{AppVersion.Build}";
        public static readonly string LanguageAndVersion = "csharp/netcoreapp3.0";
        public static readonly string
            OsNameAndVersion = System.Runtime.InteropServices.RuntimeInformation.OSDescription;

        /// <summary>
        /// All keys
        /// </summary>
        public static readonly string IgdbKey = "";
        public static readonly string SteamGridKey = "";
        public static readonly string RawgKey = "";

        public static Dictionary<string, object> AccountsParameters = new Dictionary<string, object>()
        {
            { "DevId", "" },
            { "DevPassword", "" },
            { "SoftName", "" },
            { "Output", "json" }
        };

        public static class Paths
        {
            private static DirectoryInfo folderBase => Directory.CreateDirectory(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
                "Ready2PlayManager"));

            public static DirectoryInfo Database => folderBase.CreateSubdirectory("Database");
            public static DirectoryInfo Cache => folderBase.CreateSubdirectory("Cache");
        }
    }
}
