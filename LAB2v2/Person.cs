using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB2v2
{
    public class Person : IThing
    {
        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        public string name;
        public int age;
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public virtual void Print(string prefix)
        {

        }
    }
}
