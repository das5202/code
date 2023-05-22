using System;

namespace methodpar
{
    class Program
    {

        public  void a(int i)
        {
            i=101;

        }
         public  void b(ref int l)
        {
            l=101;

        }
        public void all(int fn,int sn,out int  totol,out  int product)
        {
            totol=fn+sn;
            product=fn*sn; 
        }   
        public void show(params int[] a)
        {
            for(int i=0;i<a.Length;i++)                                                                                                                
            {
                Console.WriteLine(a[i]);
            }

        }
        static void Main(string[] args)                  
        {
            Program c=new Program();
            //pass by value
            int j=0;
            Console.WriteLine(j);
            //pass by reference
            int k=0;
            c.b(ref k);
            Console.WriteLine(k);
            //out parameter
            int tot=0;
            int pro=0;
            c.all(10,20, out tot,out pro);
            Console.WriteLine("sum is {0} && product is {1}",  tot,  pro);
            //params
            c.show(1,2,3,4);  
            
        }
    }
}
