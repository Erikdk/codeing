
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    public class lektion3
    {
        public static void Run()
        {
             Console.WriteLine("Dette er en lommeregner");
            
            
            
            Console.WriteLine("skriv plus, minus, gange eller dividere");
            string kommando = Console.ReadLine();
           
            Console.WriteLine("første tal");
            string x = Console.ReadLine();
            float talX;
            if (float.TryParse(x,out talX) == false)
            {
                Console.WriteLine("fejl prøv et tal");
                return;
            }
         


            Console.WriteLine("andet tal");
            string y = Console.ReadLine();
            float talY;
            if (float.TryParse(y,out talY) == false)
            {
                Console.WriteLine("fejl, men prøv igen med et tal");
                y = Console.ReadLine();
                if (float.TryParse(y,out talY) == false)
                {
                    Console.WriteLine("fejl IGEN");
                    return;
                }            }
            

      
            if (kommando=="plus" ||kommando== "+")
            {
            
               Console.Write("Det er ");
                Console.WriteLine(talX + talY);
            }
            else if (kommando=="minus" ||kommando=="-")
            {
                Console.Write("Det er ");
                Console.WriteLine(talX - talY);
            }
            else if (kommando=="gange" ||kommando=="*")
            {
                Console.Write("Det er ");
                Console.WriteLine(talX * talY);           

            }             
            else if (kommando=="dividere" ||kommando=="/")
            {
                Console.Write("Det er ");
                Console.WriteLine(talX / talY);           
            }
        


        }
    }
}