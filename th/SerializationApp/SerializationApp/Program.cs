using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Newtonsoft.Json;
using System.Net;

namespace SerializationApp
{
    /*class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person
            {
                FullName = "П.П Керсанов",
                Age = 46,
                BirthDate = new DateTime(1956, 05, 06)
            };

            var serializer = new BinaryFormatter();

            using (var stream = File.Create("data.bin"))
            {
                serializer.Serialize(stream, person);
            }

            using (var stream = File.OpenRead("data.bin"))
            {
                var result = serializer.Deserialize(stream) as Person;

                Console.WriteLine($"{result.Id}, { result.BirthDate}");
            }
        }
    }*/

    /*class Program
    {
         static void Main(string[] args)
         {
             Person person = new Person
             {
                 FullName = "П.П Керсанов",
                 Age = 46,
                 BirthDate = new DateTime(1956, 05, 06)
             };

             //string json = JsonConvert.SerializeObject(person);
             //Person result = JsonConvert.DeserializeObject<Person>(json);

             //var serializer = new XmlSerializer(typeof(Person));

             //using (var stream = File.Create("data.xml"))
             //{
             //    serializer.Serialize(stream, person);
             //}

             //using (var stream = File.OpenRead("data.xml"))
             //{
             //    var result = serializer.Deserialize(stream) as Person;

             //    Console.WriteLine($"{result.Id}, { result.BirthDate}");
             //}
         }
    }*/


    class Program
    {
        static void Main(string[] args)
        {

            using (WebClient client = new WebClient()) // all
            {
                string json = client.DownloadString("http://hp-api.herokuapp.com/api/characters");
                PersonHarry[] result = JsonConvert.DeserializeObject<PersonHarry[]>(json);
                Console.WriteLine("Yes");
            }
            using (WebClient client = new WebClient()) // student
            {
                string json = client.DownloadString("http://hp-api.herokuapp.com/api/characters/students");
                PersonHarry[] result = JsonConvert.DeserializeObject<PersonHarry[]>(json);
                Console.WriteLine("Yes");
            }
            using (WebClient client = new WebClient())  // staff
            {
                string json = client.DownloadString("http://hp-api.herokuapp.com/api/characters/staff");
                PersonHarry[] result = JsonConvert.DeserializeObject<PersonHarry[]>(json);
                Console.WriteLine("Yes");
            }
            using (WebClient client = new WebClient()) 
            {
                string json = client.DownloadString("http://hp-api.herokuapp.com/api/characters/house/gryffindor");
                PersonHarry[] result = JsonConvert.DeserializeObject<PersonHarry[]>(json);
                Console.WriteLine("Yes");
            }

        }
    }
}
