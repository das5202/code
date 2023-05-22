using System;

namespace clasobmeth
{
    class Program
    {
        public void hi()
        {
            Console.WriteLine("welcome");
        }
        public int sum(int a, int b){
            int add=a+b;
            return add;
        }
        public void  a( ref int i)
        {
             i=101;

        }
        public static void Main(string[] args)
        {
            Program p = new Program();
            p.hi();
            int add=p.sum(10,20);
            Console.WriteLine("{0}",add); 
            int j=0;

            p.a( ref j);
            Console.WriteLine(j);
        }         
        
    }
}
