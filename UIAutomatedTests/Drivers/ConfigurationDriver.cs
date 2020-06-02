using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIAutomatedTests.Drivers
{
    public class ConfigurationDriver 
    { 

        private const string BaseUrlConfigFieldName = "baseUrl";
        private readonly Lazy<IConfiguration> _configurationLazy;
        public string BaseUrl { get; }

        public ConfigurationDriver()
        {
            //_configurationLazy = new Lazy<IConfiguration>(GetConfiguration);
            //BaseUrl = ConfigurationManager.AppSettings["Baseurl"];
        }

        public IConfiguration Configuration => _configurationLazy.Value;

        //public string BaseUrl => Configuration[BaseUrlConfigFieldName];

        private IConfiguration GetConfiguration()
        {
            var configurationBuilder = new Microsoft.Extensions.Configuration.ConfigurationBuilder();

            string directoryName = Path.GetDirectoryName(typeof(ConfigurationDriver).Assembly.Location);
            configurationBuilder.AddJsonFile(Path.Combine(directoryName, @"test-appsettings.json"));

            return configurationBuilder.Build();
        }
    }
}
