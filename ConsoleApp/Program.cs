using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Problem p = new Problem();
            List<Item> items = new List<Item>();
            Console.WriteLine("Write the capacity of a bag: ");
            p.capacity = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Write the number of items: ");
            p.numberOfElements = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Write the seed number: ");
            p.seed = Convert.ToInt32(Console.ReadLine());
            p.Elements();
            items = p.Solution();
            foreach(Item i in items)
            {
                Console.WriteLine(i.ToString());
            }
            Console.ReadLine();
        }
    }
}
