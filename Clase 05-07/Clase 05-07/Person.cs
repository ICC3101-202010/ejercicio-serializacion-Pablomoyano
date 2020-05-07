using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_05_07
{
    [Serializable]
    public class Person
    {
        public string name;
        public string lastname;
        public int age;
        public Person(string name, string lastname, int age)
        { this.name = name;
            this.lastname = lastname;
            this.age = age;
        }
    }
}
