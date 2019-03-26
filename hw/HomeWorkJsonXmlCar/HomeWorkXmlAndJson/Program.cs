using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace HomeWorkXmlAndJson
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car
            {
                Model = "Toyota Camry 70",
                Number = "123qqq01",
                Engine = 2.4,
                Color = "red"
            };
            Car car2 = new Car
            {
                Model = "Audi r8",
                Number = "001iii01",
                Engine = 3.2,
                Color = "black"
            };
            Car car3 = new Car
            {
                Model = "BMW X6",
                Number = "789zzz02",
                Engine = 3.0,
                Color = "blue"
            };

            List<Car> cars = new List<Car> { car1, car2, car3 };

            JsonSerializer serializer = new JsonSerializer();
            using (StreamWriter sw = new StreamWriter("jsonCar.json"))
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                serializer.Serialize(writer, cars);
            }


            var serializerXml = new XmlSerializer(typeof(List<Car>));
            using (var stream = File.Create("xmlCar.xml"))
            {
                serializerXml.Serialize(stream, cars);
            }
            Console.ReadLine();
        }

    }
}
