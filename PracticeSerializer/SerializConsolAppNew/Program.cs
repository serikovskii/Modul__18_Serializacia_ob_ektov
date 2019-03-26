using PracticeSerializer.ClassLib;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace SerializConsolAppNew
{
    class Program
    {
        static void Main(string[] args)
        {
            List<PC> pc = new List<PC>
            {
                new PC() {Model = "Dell", Id = 1, MadeIn = "USA", Price = 1000},
                new PC() {Model = "Apple", Id = 2, MadeIn = "USA", Price = 1500 },
                new PC() {Model = "Asus", Id = 3, MadeIn = "China", Price = 900}
            };
            var serializer = new BinaryFormatter();
            using (var stream = File.Open("listSerial.txt", FileMode.OpenOrCreate))
            {
                serializer.Serialize(stream, pc);
            }
        }
    }
}
