using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var player1 = new Player();
            var player2 = new Player();


            int boardsize = 9;
            int shipsize = 3;
            int maxCoordinate = boardsize - shipsize + 1;

            bool isfisrstplayer = true;

            Console.WriteLine("hvad er dit navn");
            player1.name = Console.ReadLine();
            player2.name = Console.ReadLine();

            for (int i = 0; i < 2; i++)
            {

                // Console.WriteLine("skal skibet ligge lodret eller vandret");
                // string direction = Console.ReadLine();
                // bool ishorizontal = direction.Equals("V", StringComparison.OrdinalIgnoreCase);
                bool ishorizontal = GetIsHorizontal();

                // Console.WriteLine("hvor skal skibet være (x-koordinat) 1-{0}?", ishorizontal ? maxCoordinate : boardsize);
                // int shipX = int.Parse(Console.ReadLine()) - 1;
                int shipX = GetNumber(1, ishorizontal ? maxCoordinate : boardsize, "hvor skal skibet være (x-koordinat)") - 1;

                // Console.WriteLine("hvor skal skibet være (y-koordinat) 1-{0}", ishorizontal ? boardsize : maxCoordinate);
                // int shipY = int.Parse(Console.ReadLine()) - 1;
                int shipY = GetNumber(1, ishorizontal ? maxCoordinate : boardsize, "hvor skal skibet være (y-koordinat)") - 1;
                if (isfisrstplayer == true)
                {
                    player1.placeShip(ishorizontal, shipX, shipY);
                }
                else
                {
                    player2.placeShip(ishorizontal, shipX, shipY);
                }
                isfisrstplayer = false;
            }
            isfisrstplayer = true;
            bool isHit = false;
            bool issunk = false;
            while (issunk == false)
            {
                Player player;
                if (isfisrstplayer == true)
                {
                    player = player1;
                    isfisrstplayer = false;

                    Console.WriteLine("{0}s tur", player1.name);
                }
                else
                {
                    player = player2;
                    isfisrstplayer = true;

                    Console.WriteLine("spiller 2s tur");
                }

                // Console.WriteLine("hvor vil du skyde hen (x-koordinat)?");
                int shotX = GetNumber(1, boardsize, "hvor vil du skyde hen (x-koordinat)?") - 1; //int.Parse(Console.ReadLine()) - 1;

                // Console.WriteLine("hvor vil du skyde hen (y-koordinat)?");
                // int shotY = int.Parse(Console.ReadLine()) - 1;

                int shotY = GetNumber(1, boardsize, "hvor vil du skyde hen (y-koordinat)?") - 1;

                isHit = player.shoot(shotX, shotY);
                issunk = player.HasLost();

                string line = "  ";
                string header = "   ";

                for (int z = 0; z < boardsize; z++)
                {
                    line = line + "-- ";
                    header = header + $" {z + 1}  ";
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
                        Console.Write(player.shots[y][x]);
                    }
                    Console.WriteLine();
                }
                string hittext = isHit ? "Hit" : "Miss";
                Console.WriteLine(hittext);
            }
        }


        public static int GetNumber(int min, int max, string besked)
        {
            Console.WriteLine("{0} {1}-{2}", besked, min, max);


            bool isAccepted = false;
            int number = 0;

            while (isAccepted == false)
            {

                string input = Console.ReadLine();
                isAccepted = int.TryParse(input, out number) && number >= min && number <= max;
                if (isAccepted == false)
                {
                    Console.WriteLine("ugyldigt tal");
                }
            }

            return number;
        }

        public static bool GetIsHorizontal()
        {
            throw new NotImplementedException();
        }
    }
}
