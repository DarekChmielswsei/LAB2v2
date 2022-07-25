using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB2v2
{
    public class Buyer : Person 
    {
        List<Product> tasks = new List<Product>();
        public Buyer(string name, int age) : base(name, age) 
        {

        }
        public void AddProduct(Product product) 
        {
            tasks.Add(product);
        }
        public void RemoveProduct(int index) 
        {
            tasks.RemoveAt(index);
        }
        public override void Print(string prefix)
        {
            Console.WriteLine($"{prefix}Buyer: " + name.ToString() + " (" + this.age + " y.o.)");
            if (tasks.Count > 0)
            {
                Console.WriteLine($"{prefix}{prefix}-- Products: --");
                foreach (Product product in tasks)
                {
                    Console.Write(prefix);
                    product.Print(prefix);
                }
            }
        }
    }
}
