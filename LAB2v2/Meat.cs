using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB2v2
{
    public class Meat : Product
    {
        protected double Weight { get; set; }  
        public double weight;  
        public Meat(string name, double weight) : base(name) 
        {
            this.name = name; 
            this.weight = weight;  
        }
        public override void Print(string prefix)
        {
            Console.WriteLine($"{prefix}" + this.name + "(" + this.weight + " kg)");  
        }
    }
}
