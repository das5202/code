using System;

namespace encap
{
    class student
    {
        private int id;
        private string name;
        public int ID
        {
            get{return this.id;}
            set{this.id=value;}
        }
        public string NAME{
            get{return name;}
            set{name=value;}
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            
            student s=new student();
            s.ID=1;
            s.NAME="devika";
            Console.WriteLine(s.ID);
            Console.WriteLine(s.NAME);
        }
    }
}
