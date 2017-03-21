using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("hvor stor skal pladen være (4-9)");
        int boardsize = int.Parse(Console.ReadLine()); 
        while (boardsize < 4 || boardsize > 9)
            {
                Console.WriteLine("ugyltigt nummer prøv igen");
                boardsize = int.Parse(Console.ReadLine());
            }
            
            var board = new bool[boardsize] [];
            var shots = new char[boardsize][];
            for (int i = 0; i < boardsize; i++)
            {
              board[i] = new bool[boardsize];
              shots[i] = new char[boardsize];
              for (int j = 0; j < boardsize; j++)
              {
                  board[i][j] = false;
                  shots[i][j] = ' ';
              }
            
            }

            int shipsize = 3;
            int maxCoordinate = boardsize - shipsize + 1;

            Console.WriteLine("skal skibet ligge lodret eller vandret");
            string direction = Console.ReadLine();
            bool ishorizontal = direction.Equals("V", StringComparison.OrdinalIgnoreCase);
            


            // var board = new bool[][]
            // // {
            // // new bool[]{false, false, false, false},
            // // new bool[]{false, false, false, false},
            // // new bool[]{false, false, false, false},
            // // new bool[]{false, false, false, false}
            // // };

            // var shots = new char[][]
            // {
            // new char[]{' ', ' ', ' ', ' '},
            // new char[]{' ', ' ', ' ', ' '},
            // new char[]{' ', ' ', ' ', ' '},
            // new char[]{' ', ' ', ' ', ' '}
            // };


            Console.WriteLine("hvor skal skibet være (x-koordinat) 1-{0}?", ishorizontal ? maxCoordinate : boardsize);
            int shipX = int.Parse(Console.ReadLine()) -1;

            Console.WriteLine("hvor skal skibet være (y-koordinat) 1-{0}", ishorizontal ? boardsize : maxCoordinate);
            int shipY = int.Parse(Console.ReadLine())-1;

             for(int i = 0; i< shipsize; i++)
             {
                int x=shipX
                int y=shipY
                board[x][y] = true;
                 

             }
          
            // skibets placering
            board[shipX][shipY] = true;
            bool isHit = false;
            while (isHit == false )
            {




                Console.WriteLine("hvor vil du skyde hen (x-koordinat)?");
                int shotX = int.Parse(Console.ReadLine())-1;

                Console.WriteLine("hvor vil du skyde hen (y-koordinat)?");
                int shotY = int.Parse(Console.ReadLine())-1;

                isHit = board[shotX][shotY];

                string hittext;
                if (isHit)
                {
                    shots[shotY][shotX] = 'X';
                    hittext = "du ramte";

                }
                else
                {
                    shots[shotY][shotX] = '*';
                    hittext = "du missede";
                }
                string line = "  ";
                string header ="   ";

                for(int z=0; z<boardsize;z++)
                {
                    line = line + "- - -";
                    header = header + $" {z+1}  ";
                }
               
               
                Console.Clear();

                
        
                Console.WriteLine(header);
                for (int y = 0; y < boardsize; y++)
                {   
                    Console.WriteLine(line);
                    Console.Write(y + 1);
                    for (int x = 0; x < boardsize; x++)
                    {
                        Console.Write(" | ");
                        Console.Write(shots[y][x]);

                    }
                    Console.WriteLine();

                }

                Console.WriteLine(hittext);
            }


        }


    }
}
