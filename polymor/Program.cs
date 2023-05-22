using System;
//overload
class dev
{
    public int add(int a,int b)
    {
        int sum =a+b;
        return sum;
    }
    public int add(int a,int b,int c)
    {
        int sum =a+b+c;
        return sum;
    }
}
//override

class Dog
{
    public virtual void bark()
    {
        Console.WriteLine("barking");
    }
}
class Cat:Dog
{
    public override void bark()
    {
        Console.WriteLine("meowing");
    }
}


    class pr
    {
        public static void Main(String[] args)
        {
            dev d=new dev();
            int x=d.add(5,6);
            Console.WriteLine("the sum is:"+x);
            int y=d.add(5,6,7);
            Console.WriteLine("the sum is :"+y);
            Dog e=new Cat();
        e.bark();
        }
    }
