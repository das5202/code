namespace hiii
{
    using System;
     public class old
    {
        public void hello()
        {
            Console.WriteLine("totla number is 2");

        }
    }
      public class now:old{
        public new void hello()
        {
            Console.Writeline("rakesh,20/n swapna,20");
        }
      }
      class gow
      {
         static public  void Main()
        now n =new now();
        n.hello();
      }
}