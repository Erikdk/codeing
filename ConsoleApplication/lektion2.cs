using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    public class lektion2
    {
        public static void Run()
        {
            Console.WriteLine("indtast x");
            string x = Console.ReadLine();
            int talX;
            if (int.TryParse(x,out talX) == false)
            {
                Console.WriteLine("fejl");
                return;
            }
            
            Console.WriteLine("Indtast y");
            string y = Console.ReadLine();
            int talY;
            if (int.TryParse(y,out talY) == false)
            {
                Console.WriteLine("fejl, men prøv igen med et tal");
                y = Console.ReadLine();
                if (int.TryParse(y,out talY) == false)
            {
                 Console.WriteLine("fejl IGEN");
                 return;
            }
            }
            
            Console.WriteLine("x + y er");
            Console.WriteLine(talX + talY);
        }
    }
}