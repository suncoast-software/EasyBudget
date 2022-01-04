using EasyBudget.Data.Configuration;
using EasyBudget.Services.Interfaces;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Text;

namespace EasyBudget.Services
{
    internal class DataService: IDataService
    {
        public ConfigJson GetConfigurationJson()
        {
            var configFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Configuration", "config.json");
            using var fs = File.OpenRead(configFile);
            using var sr = new StreamReader(fs, new UTF8Encoding(false));
            var json = sr.ReadToEnd();

            var configJson = JsonConvert.DeserializeObject<ConfigJson>(json);

            return configJson;
        }
    }
}
