using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlonWork_14
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Cat cat = new Cat("Алиса", "");
            string voice = cat.Say();



            Console.WriteLine(cat.ShowInfo());

            Console.ReadKey();

        }
    }
}
