namespace ConsoleApplication
{
    
    public class Calculator
    {
        int _resultat = 0;

        public void Add(int x)
        {
            _resultat = _resultat + x;
        }
         public void minus(int x)
        {
            _resultat = _resultat - x;
        }
         public void multiply(int x)
        {
            _resultat = _resultat * x;
        }       
         public void divide(int x)
        {
            _resultat = _resultat / x;
        }       
       
       
       
       
       
       
       
       
        public int Resultat()
        {
            return _resultat;
        }
    }



}
