using PracticeSerializer.ClassLib;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace DeserializConsolAppNew
{
    class Program
    {
        static void Main(string[] args)
        {
            var serializer = new BinaryFormatter();
            using (FileStream stream = new FileStream("listSerial.txt", FileMode.Open))
            {
                List<PC> resultPC = (List<PC>)serializer.Deserialize(stream);
                foreach(var pc in resultPC)
                {
                    Console.WriteLine($"Model - {pc.Model}, id - {pc.Id}, made in - {pc.MadeIn}, price - {pc.Price}");
                }
            }
        }
    }
}
