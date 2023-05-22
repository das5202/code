using System;

namespace inheritance
{
    class employee
    {
        public string firstname;
        public string lastname;
            public void fullname()
            {


               Console.WriteLine( firstname+""+lastname);
            }
    }
    class yearemp:employee
    {
        public float yearsal;
    }
    class partemp:employee
    {
        public float hoursal;
    }
//part 2 example 
    class animal
    {
        public void hh()
        {
        Console.WriteLine("i'm animal");
        }

    }
    class dog:animal
    {
        public void jj()
        {

        
        Console.WriteLine("i'm dog part of animal family");
        }
    }
    

    class Program
    {
       static void Main(string[] args)
        {
            yearemp y=new yearemp();
            y.firstname="devika";
            y.lastname="dasari";
            y.yearsal=500000000;
            y.fullname();
            partemp p=new partemp();
            p.firstname="dasari";
            p.lastname="devika";
            p.hoursal=500000000;
            p.fullname();
            animal a=new animal();
    a.hh();
    dog b=new dog();
    b.jj();

        }
    }                       
}
