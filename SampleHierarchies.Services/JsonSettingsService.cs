using Newtonsoft.Json;
using SampleHierarchies.Data;
using SampleHierarchies.Interfaces.Data;
using SampleHierarchies.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleHierarchies.Services
{
    public class JsonSettingsService 
    {
        private readonly string _filePath;

        public JsonSettingsService(string filePath)
        {
            _filePath = filePath;
        }

        public ISettings LoadSettings()
        {
            if (File.Exists(_filePath))
            {
                string jsonData = File.ReadAllText(_filePath);
                return JsonConvert.DeserializeObject<Settings>(jsonData);
            }
            else
            {
                return new Settings();
            }
        }

        public void SaveSettings(ISettings settings)
        {
            string jsonData = JsonConvert.SerializeObject(settings, Formatting.Indented);
            File.WriteAllText(_filePath, jsonData);
        }
    }
}
