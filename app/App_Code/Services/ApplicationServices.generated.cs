﻿using MyCompany.Handlers;
using MyCompany.Web;
using System.Web.Configuration;

namespace MyCompany.Services
{
	public class AppFrameworkConfig
    {
        
        public virtual void Initialize()
        {
            ApplicationServices.FrameworkAppName = "HRDeploy";
            ApplicationServices.Version = "8.7.4.0";
            ApplicationServices.JqmVersion = "1.4.6";
            ApplicationServices.HostVersion = "1.2.4.0";
            CompilationSection compilation = ((CompilationSection)(WebConfigurationManager.GetSection("system.web/compilation")));
            bool releaseMode = !(compilation.Debug);
            AquariumExtenderBase.EnableMinifiedScript = releaseMode;
            AquariumExtenderBase.EnableCombinedScript = releaseMode;
            ApplicationServices.EnableMinifiedCss = releaseMode;
            ApplicationServices.EnableCombinedCss = releaseMode;
            BlobFactoryConfig.Initialize();
        }
    }
}
