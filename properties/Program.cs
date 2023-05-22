using System;

namespace properties
{
    class student
    {
        public  string name{get;set;}
        public int roll{get;set;}
        public string city{get;set;}

    }
    class Program
    {
        static void Main(string[] args)
        {
            student s=new student();
            //setting data
            s.name="devika";
            s.roll=32;
            s.city="palakol";
            //getting data
            Console.WriteLine(s.name);
            Console.WriteLine(s.roll);
            Console.WriteLine(s.city);
        }
    }
}
