using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarWPF
{
    internal class Converter
    {
        

        public static void Ser<T>(ObservableCollection<T> SelectedControls)
        {
           
            string json = JsonConvert.SerializeObject(SelectedControls);
            File.WriteAllText("C:\\Users\\gruzd\\Рабочий стол\\CalendarDays.json", json);
        }


        public static T Deser<T>()
        {
 
            if (File.Exists("C:\\Users\\gruzd\\Рабочий стол\\CalendarDays.json"))
            {
                string json = File.ReadAllText("C:\\Users\\gruzd\\Рабочий стол\\CalendarDays.json");
                T toDoList = JsonConvert.DeserializeObject<T>(json);
                return toDoList;
            }
            else
            {
                File.Create("C:\\Users\\gruzd\\Рабочий стол\\Notes.json");
                string json = File.ReadAllText("C:\\Users\\gruzd\\Рабочий стол\\CalendraDays.json");
                T toDoList = JsonConvert.DeserializeObject<T>(json);
                return toDoList;
            }

        }
    }
}
