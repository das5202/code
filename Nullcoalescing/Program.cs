using System;

namespace Nullcoalescing
{
    class Program
    {
        static void Main(string[] args)
        {

            int available;
            int ? sale = null;
            available = sale??0;
            Console.WriteLine("total avaliable  {0}",available);
            
        }
    }
}
