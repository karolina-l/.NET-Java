using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random(3);
            int a = random.Next(29); 
            Console.WriteLine(a);
            Console.ReadLine();
        }
    }
}
// klasa na przedmiot - konstruktor
// klasa na rezultat
// klasa na problem - dodawanie przedmiotu - seed wybierany tutaj
