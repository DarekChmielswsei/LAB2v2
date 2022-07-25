using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB2v2
{
    public class Product : IThing
    {
        public string Name { get => name; set => name = value; }  
        public string name;
        public Product(string name)
        {
            this.name = name; 
        }
        public virtual void Print(string prefix)
        {

        }
    }
}
