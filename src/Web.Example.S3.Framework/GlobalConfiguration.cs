using System;
using System.Configuration;

namespace Web.Example.S3.Framework
{
    public class GlobalConfiguration
    {
        public static Uri BaseUrl => new Uri(ConfigurationManager.AppSettings["BaseUrl"]);
    }
}
