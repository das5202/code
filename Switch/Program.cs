using System;

namespace Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("enter number:");
            n = Convert.ToInt32(Console.ReadLine());
            switch(n)
            {
            case 10:
              Console.WriteLine("the number is 10");
              break;
            case 20:
              Console.WriteLine("the number is 20");
              break;
            default:
              Console.WriteLine("the number is not 10 & 20");
              break;
            }
        }
    }
}
