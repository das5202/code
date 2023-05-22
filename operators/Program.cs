using System;

namespace operators
{
    class Program
    {
        static void Main(string[] args)
        {
            int i =10;
            int u=5;
            Console.WriteLine("value is " +i/u);
            int k = i%u;
            Console.WriteLine("value is {0}",k );

            int a=10;
            if(a==10)
            {
                Console.WriteLine("true");

            }
            if(a!=9)
            {
                Console.WriteLine("false");
            }
            int b=2;
            int c=3;
            if(b==2&&c==3)
            {
                Console.WriteLine("both true");
            
            }
            int d=1;
            int e=5;
            if(d==1||e==9)
            {
                Console.WriteLine("one true");
            }
            int x=10;
            int y=2;
            bool  z= (x>y)? true:false;
            Console.WriteLine("value is {0}",z);
        }
    }
}
