using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class FileService
    {
        public void SaveJson(object objectToSerialize, string filePath)
        {
            string json = JsonConvert.SerializeObject(
                        objectToSerialize,
                        Formatting.Indented,
                        new JsonSerializerSettings()
                        {
                            ContractResolver = new
                            Newtonsoft.Json.Serialization
                            .CamelCasePropertyNamesContractResolver()
                        });
            using (TextWriter writer = new StreamWriter(filePath))
            {
                writer.Write(json);
            }
        }
        public T LoadJson<T>(string path)
        {
            string json = File.ReadAllText(path);
            return JsonConvert.DeserializeObject<T>(json);
        }
    }
}
