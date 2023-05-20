using System.IO;
using Newtonsoft.Json;

namespace SerDeserLib
{
    public static class Class1
    {
        public static void Serialize<T>(T obj, string Path)
        {
            string json = JsonConvert.SerializeObject(obj);
            File.WriteAllText(Path, json);
        }

        public static T Deserialize<T>(string Path)
        {
            string json = File.ReadAllText(Path);
            return JsonConvert.DeserializeObject<T>(json);
        }
    }
}
