using System;

namespace typeconversion
{
    class Program
    {
        static void Main(string[] args)
        {
            int i =10;
            float f = i;
            Console.WriteLine("value is :"+ f);
            float d =100.05f;
            int o= (int)d;
            Console.WriteLine("value is :"+ o);
            string n ="100";
            int g=int.Parse(n);
            Console.WriteLine(g);
            int j =10;
            string h = Convert.ToString(j);
            Console.WriteLine(h);
        }
    }
}
