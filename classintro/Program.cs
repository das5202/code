using System;
namespace me
{
    class pro
    {
        string first;
        string last;
        public pro(string First,string Last)
        {
            this.first=First;
            this.last=Last;
        }
        public void meth()
        {
            Console.WriteLine("full name is {0}",this.first+" "+this.last);
        }
        public static void Main(string[] args)
        {
            pro p=new pro("devika","dasari");
            p.meth();               

        }                                                                                                           
    }                               
}                                                    