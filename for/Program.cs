using System;

namespace ff
{
    class Program
    {
        static void Main(string[] args)
        {
            int i =10;
            for (i=0;i<10;i++)
            {
                Console.WriteLine("the values are {0}" ,i);
            }
            Console.WriteLine("next one output is as below");
            int[] num =  {6,7,8,3,4,1};
            foreach(int n in num )
            {
                Console.WriteLine("the values are {0}",n);
            }
        }
    }
}
