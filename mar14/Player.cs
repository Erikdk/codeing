namespace ConsoleApplication
{   class Player
    {
        private bool[][] board;
      private  char[][] shots;

      public Player()
      {
                  int boardsize = 9;
         board = new bool[boardsize] [];
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
             for(int i = 0; i< shipsize; i++)
             {
                int x = ishorizontal
                ? shipX + i
                : shipY;
                
                int y = ishorizontal
                ? shipX
                : shipY + i;
             }
      }

        public bool shoot(int x,int y)
        {
                            isHit = board[shotX][shotY];
                board[shotX][shotY] = false;
                issunk = IsShipSunk(board);

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
               
        }

        public bool HasLost()
        {
            return false;
        }





    }
}











}