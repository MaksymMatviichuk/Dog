using Newtonsoft.Json;
using SampleHierarchies.Interfaces.Services;
using System.Xml;
using Formatting = Newtonsoft.Json.Formatting;

namespace SampleHierarchies.Services
{
    public class JsonDataService<T> : IDataService<T>
    {
        public void SaveData(List<T> data, string filePath)
        {
            string jsonData = JsonConvert.SerializeObject(data, Formatting.Indented);
            File.WriteAllText(filePath, jsonData);
            Console.WriteLine("Data saved to " + filePath);
        }

        public List<T> LoadData(string filePath)
        {
            if (File.Exists(filePath))
            {
                string jsonData = File.ReadAllText(filePath);
                List<T> data = JsonConvert.DeserializeObject<List<T>>(jsonData);
                Console.WriteLine("Data loaded from " + filePath);
                return data;
            }
            else
            {
                return new List<T>();
            }
        }

    }
}
