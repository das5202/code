using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[5];
            num[0]=1;
            num[1]=2;
            num[2]=3;
            Console.WriteLine("value is "+num[0]);
            String[] name={"acv","vbn","mnb"};
            Console.WriteLine("value is "+name[1]);
            Char[] nam={'a','v','m'};
            Console.WriteLine("value is "+nam[1]);
            Console.WriteLine("enter village:");
           string[] vil=new string[5];
           int i;
           Console.WriteLine("enter village names:");
           for(i=0;i<vil.Length;i++)
           {
            Console.WriteLine("position of {0}",i);
            vil[i]=Convert.ToString(Console.ReadLine());
           }
           Console.WriteLine("village names are:");
           for(i=0;i<vil.Length;i++)
           {
            Console.WriteLine("{0}",vil[i]);
           }

           int[] a=new int[10];
           
           Console.WriteLine("enter values :");
           for(i=0;i<a.Length;i++)
           {
            Console.WriteLine("positon of {0}",i);
            a[i]=Convert.ToInt32(Console.ReadLine());

           }
           Console.WriteLine("values are :");
           for(i=0;i<a.Length;i++)
           {
            Console.WriteLine("{0}",a[i]);
           }
            
            
        }
    }
}
