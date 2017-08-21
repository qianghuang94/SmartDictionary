﻿// Copyright © Qiang Huang, All rights reserved.

using System.Configuration;

namespace SmartDictionary.Common
{
    public static class Configuration
    {
        public static string DatabaseName()
        {
            return ConfigurationManager.AppSettings.Get("DatabaseName") ?? "default.sqlite";
        }

        public static bool DebugEnable()
        {
            var debugEnable = ConfigurationManager.AppSettings.Get("DebugEnable") ?? "false";
            return bool.Parse(debugEnable);
        }
    }
}