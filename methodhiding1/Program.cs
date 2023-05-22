using System;

namespace methodhiding1
{
    public class ol 
    {
        public void hello()
        {
            Console.WriteLine("welcome");
        }
    }
   public  class nww:ol
    {
        public new void hello()
        {
            base.hello();
            Console.WriteLine("welcome to new");
        }
    }
    
    
    class Program
    {
        static void Main(string[] args)
        {
            nww n=new nww();
            n.hello();
            
        }
    }
}
