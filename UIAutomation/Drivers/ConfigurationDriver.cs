using Microsoft.Extensions.Configuration;
using System;
using System.Configuration;
using System.IO;

namespace UIAutomation.Drivers
{
    public class ConfigurationDriver
    {
        private const string BaseUrlConfigFieldName = "baseUrl";
        private readonly Lazy<IConfiguration> _configurationLazy;


        public ConfigurationDriver()
        {
            _configurationLazy = new Lazy<IConfiguration>(GetConfiguration);
            //BaseUrl = ConfigurationManager.AppSettings["baseUrl"];
        }

        public IConfiguration Configuration => _configurationLazy.Value;

        public string BaseUrl => ConfigurationManager.AppSettings["baseUrl"];


        private IConfiguration GetConfiguration()
        {
            var configurationBuilder = new Microsoft.Extensions.Configuration.ConfigurationBuilder();

            string directoryName = Path.GetDirectoryName(typeof(ConfigurationDriver).Assembly.Location);
            configurationBuilder.AddJsonFile(Path.Combine(directoryName, @"test-appsettings.json"));

            return configurationBuilder.Build();
        }
    }
}
