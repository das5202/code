using System;

namespace bbb
{
    class Program
    {
        static void Main(string[] args)
        {
            int a,b;
            Console.WriteLine("enter a value");
             a=Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("enter b value");
             b=Convert.ToInt32(Console.ReadLine());
             if(a>b)
            
            {
                Console.WriteLine("a is large");
            }
            else if(a<b)
            {
                Console.WriteLine("b is large");
            }
            else
            {
                Console.WriteLine("both are equal");
            }
            Console.ReadLine();

        }
    }
}
 