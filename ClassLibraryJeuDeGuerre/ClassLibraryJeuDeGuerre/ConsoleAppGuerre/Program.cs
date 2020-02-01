using ClassLibraryGuerre;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppGuerre
{
    class Program
    {
        static void Main(string[] args)
        {
            Arme maArme = new Arme(9);

            Console.WriteLine(maArme.ToString());


            Console.ReadKey();
        }
    }
}
