using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializationApp
{
    [Serializable]
    public class Person
    {
        [NonSerialized]
        private Guid _id;
        public Guid Id {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }
        public string FullName { get; set; }
        public int Age { get; set; }
        public DateTime BirthDate { get; set; }

        public Person()
        {
            Id = Guid.NewGuid();
        }
    }
}

