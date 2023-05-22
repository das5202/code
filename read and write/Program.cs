using System;
namespace read
{
class program
{
    public static void Main(string[]args)
    {
        Console.WriteLine("enter your name");
        string name = Console.ReadLine();
        Console.WriteLine("hello "+ name);
        Console.WriteLine("hello {0}",name);
    
    }

}
}
