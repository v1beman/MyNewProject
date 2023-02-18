using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.IO;
using Microsoft.Xaml.Behaviors.Media;
using System.Collections.ObjectModel;

namespace Pract_2
{
    internal class Converter
    {
        private readonly string Path;

        public Converter(string path)
        {
            Path = path;
        }
        

        public static void Ser(ObservableCollection<Model> toDoList)
        {
            string json = JsonConvert.SerializeObject(toDoList);
            File.WriteAllText("C:\\Users\\gruzd\\Рабочий стол\\Notes.json", json);
        }

        public  ObservableCollection<Model> Deser()
        {
            if (File.Exists(Path))
            {
                string json = File.ReadAllText("C:\\Users\\gruzd\\Рабочий стол\\Notes.json");
                ObservableCollection<Model> toDoList = JsonConvert.DeserializeObject<ObservableCollection<Model>>(json);
                return toDoList;
            }
            else
            {
                File.Create("C:\\Users\\gruzd\\Рабочий стол\\Notes.json");
                string json = File.ReadAllText("C:\\Users\\gruzd\\Рабочий стол\\Notes.json");
                ObservableCollection<Model> toDoList = JsonConvert.DeserializeObject<ObservableCollection<Model>>(json);
                return toDoList;
            }

        }
    }
}
