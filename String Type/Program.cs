using System;

namespace String_Type
{
    class Program
    {
        static void Main(string[] args)
        {
           string Name ="\"devika\"";
           Console.WriteLine(Name);
           Name="hello\ndevika\ndasari" ;
            Console.WriteLine(Name);
           Name="c\\devikas\\kd\\" ;
           Console.WriteLine(Name);
           Name=@"c\\devikas\\kd\\" ;
                      Console.WriteLine(Name);

        }
    }
}
