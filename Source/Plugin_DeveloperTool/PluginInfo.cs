﻿using System.Reflection;
using Altman.Plugin;

namespace Plugin_DeveloperTool
{
    public class PluginInfo : IPluginInfo
    {
        public string Name
        {
			get { return "DeveloperTool"; }
        }
        public string FileName
        {
            get { return Assembly.GetExecutingAssembly().ManifestModule.Name; }
        }
        public string Version
        {
            get { return Assembly.GetExecutingAssembly().GetName().Version.ToString(); }
        }
        public string Author
        {
            get { return "Keepwn"; }
        }
        public string Description
        {
			get { return "Help Developers To Test"; }
        }
    }
}