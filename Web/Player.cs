namespace ConsoleApplication
{
   public class Player
    {
        public bool[][] board;
        public char[][] shots;

        public string name;

        public Player()
        {
            int boardsize = 9;
            board = new bool[boardsize][];
            shots = new char[boardsize][];
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
        }


        public void placeShip(bool ishorizontal, int shipX, int shipY)

        {
            int shipsize = 3;
            for (int i = 0; i < shipsize; i++)
            {
                int x = ishorizontal
                ? shipX + i
                : shipX;

                int y = ishorizontal
                ? shipY
                : shipY + i;

                board[x][y] = true;
            }
        }

        public bool shoot(int x, int y)
        {
            bool isHit = board[x][y];
            board[x][y] = false;

            if (isHit)
            {
                shots[x][y] = 'X';
            }
            else
            {
                shots[x][y] = '*';
            }

            return isHit;
        }

        public bool HasLost()
        {
            bool isNotSunk = false;
            for (int x = 0; x < board.Length; x++)
            {
                var row = board[x];
                for (int y = 0; y < row.Length; y++)
                {
                    isNotSunk |= row[y];
                }

            }
            return isNotSunk == false;
        }










    }
}