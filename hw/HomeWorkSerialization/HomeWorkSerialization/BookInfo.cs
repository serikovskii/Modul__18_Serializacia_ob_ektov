using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkSerialization
{
    public class BookInfo : System.Attribute
    {
        public string Language { get; set; }
       
        public BookInfo(string language)
        {
            Language = language;
        }

    }
}
