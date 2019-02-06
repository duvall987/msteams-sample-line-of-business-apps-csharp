﻿using System.Configuration;
namespace CrossVertical.Announcement.Helper
{
    public static class ApplicationSettings
    {
        public static string AppName { get; set; } = "Company Communicator";

        public static string AppFeature { get; set; } = "message";

        public static string BaseUrl { get; set; }

        public static string ConnectionName { get; set; }

        public static string AppId { get; set; }

        public static string AppSecret { get; set; }

        static ApplicationSettings()
        {
            ConnectionName = ConfigurationManager.AppSettings["ConnectionName"];
            BaseUrl = ConfigurationManager.AppSettings["BaseUri"];

            AppId = ConfigurationManager.AppSettings["MicrosoftAppId"];
            AppSecret = ConfigurationManager.AppSettings["MicrosoftAppPassword"];
        }
    }
}