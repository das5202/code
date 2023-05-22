using System;

namespace structu
{
    public struct cust
    {
        private  int id;

        public int ID
        {
            set{this.id=value;}
            get{return this.id;}
        }
    
        
    }
      class Program
      {

       public static void Main(string[] args)
        {
            cust c=new cust();
            c.ID=5;
            Console.WriteLine(c.ID);
            
        }
    }
}


