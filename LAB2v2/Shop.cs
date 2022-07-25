using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB2v2
{
    public class Shop : IThing 
    {
        public string Name { get => name; set => name = value; } 
        public string name;
        public Person[] people = new Person[5];
        public Product[] products = new Product[5];
        public Shop(string name, Person[] people, Product[] products) 
        {
            this.name = name; 
            this.people = people; 
            this.products = products; 
        }
        public void Print()
        {
            Console.WriteLine("Shop: " + name.ToString());
            Console.WriteLine("-- People: --");
            foreach (Person? p in people)
            {
                p.Print("\t");
            }

            Console.WriteLine("-- Products: --");
            foreach (Product? p in products)
            {
                p.Print("\t");
            }
        }
    }
}
