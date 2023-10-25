using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadatak25._10._02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite nekakav tekst");
            string s1=Console.ReadLine();
            Console.WriteLine(s1.Replace(" ", "_"));
            Console.ReadKey();
        }
    }
}
