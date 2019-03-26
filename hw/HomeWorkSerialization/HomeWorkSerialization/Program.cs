using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkSerialization
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Book> books = new List<Book>
            {
                new Book() { Name = "Мастер и Маргарита", Author = "Михаил Булгаков", Price = 5000, Date = new DateTime(1940,09,15)},
                new Book() { Name = "АЗиЯ", Author = "Олжас Сулейменов", Price = 3000, Date = new DateTime(1989,09,20)},
                new Book() { Name = "Путь Абая", Author = "Мухтар Ауэзов", Price = 6000, Date = new DateTime(1942,02,17)}
            };
            var serializer = new BinaryFormatter();
            using (var stream = File.Create("books.bin"))
            {
                serializer.Serialize(stream, books);
            }
            using (FileStream fs = new FileStream("books.bin", FileMode.OpenOrCreate))
            {
                List<Book> rezBooks = (List<Book>)serializer.Deserialize(fs);
                foreach (Book book in rezBooks)
                {
                    Console.WriteLine(book.Name + " - " + book.Author + " - " + book.Date.ToString("d") + " - " + book.Price +"тенге");
                }
            }
        }
    }
}