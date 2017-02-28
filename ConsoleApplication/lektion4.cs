
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    public class lektion4
    {
        public static void Run()
        {
           
          var calculator = new Calculator();
       

         
           string operation="+";
           do
          {
            Console.WriteLine("indtast et tal");
            string numberText = Console.ReadLine();
            int number=int.Parse(numberText);
            
            
            if (operation == "+")
            {
                calculator.Add(number);
            }
            else if (operation == "-")
            {
                calculator.minus(number);
            }
            else if (operation == "*")
            {
                calculator.multiply(number);
            }
            else if (operation == "/")
            {
                calculator.divide(number);
            }
            else if (operation !="=")
            {
            
            }
            else
            {
                Console.WriteLine("det er ikke et tegn");
            }
          
            Console.WriteLine("indtast +,-,*,/,=");         
            operation = Console.ReadLine();
          
            if (operation !="+" && operation !="-" && operation !="*" && operation !="/" && operation !="=")
            {
              Console.WriteLine("det er ikke et tegn");
            }
                
        } while(operation !="=");

        int resultat=calculator.Resultat();
        Console.Write("Resutat: ");
        Console.WriteLine(resultat);
        


        }
    }
}