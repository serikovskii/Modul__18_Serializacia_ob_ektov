using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Создать класс Car и описать его минимум 4-мя свойствами. 
Создать по этому классу вручную .json и .xml файл 
описывающий какой-либо объект класса Car*/
namespace HomeWorkXmlAndJson
{
    [Serializable]
    public class Car
    {
        public string Model { get; set; }
        public string Number { get; set; }
        public double Engine { get; set; }
        public string Color { get; set; }
    }


}
