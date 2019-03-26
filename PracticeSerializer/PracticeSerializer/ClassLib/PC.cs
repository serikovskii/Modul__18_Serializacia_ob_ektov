using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeSerializer.ClassLib
{
    [Serializable]
    public class PC
    {
        public string Model { get; set; }
        public int Id { get; set; }
        public int Price { get; set; }
        public string MadeIn { get; set; }
        public bool power;
        //public PC(string model, int id, int price, string madeIn)
        //{
        //    Model = model;
        //    Id = id;
        //    Price = price;
        //    MadeIn = madeIn;
        //    power = false;
        //}

        public void PowerPC(bool power)
        {
            if (power)
                Console.WriteLine("Komp on"); 
            else
                Console.WriteLine("Komp off");
        }
    }
}
