using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB2v2
{
    public class Fruit : Product
    {
        public int Count { get => count; set => count = value; } 
        private int count; 
        public Fruit(string name, int count) : base(name) 
        {
            this.count = count; 
        }
        public override void Print(string prefix)
        {
            Console.WriteLine($"{prefix}" + this.name + "(" + this.count + " fruits)");
        }
    }
}
