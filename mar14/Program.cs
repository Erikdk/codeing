using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var board = new bool[][]
            {
            new bool[]{false, false, false, false},
            new bool[]{false, false, false, false},
            new bool[]{false, false, false, false},
            new bool[]{false, false, false, false}
            };

            var shots = new char[][]
            {
            new char[]{' ', ' ', ' ', ' '},
            new char[]{' ', ' ', ' ', ' '},
            new char[]{' ', ' ', ' ', ' '},
            new char[]{' ', ' ', ' ', ' '}
            };



            // skibets placering
            board[3][0] = true;
            bool isHit = false;
            while (isHit == false )
            {

                Console.WriteLine("hvor vil du skyde hen (x-koordinat)?");
                int shotX = int.Parse(Console.ReadLine());

                Console.WriteLine("hvor vil du skyde hen (y-koordinat)?");
                int shotY = int.Parse(Console.ReadLine());

                isHit = board[shotX][shotY];
                if (isHit)
                {
                    shots[shotX][shotY] = 'X';
                    Console.WriteLine("du ramte");

                }
                else
                {
                    shots[shotX][shotY] = '*';
                    Console.WriteLine("du missede");
                }

                for (int x = 0; x < 4; x++)
                {   
                    Console.WriteLine("|-------|");
                    for (int y = 0; y < 4; y++)
                    {
                        Console.Write("|");
                        Console.Write(shots[x][y]);

                    }
                    Console.WriteLine();

                }


            }


        }


    }
}
