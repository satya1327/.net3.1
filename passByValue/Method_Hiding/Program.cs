using System;
using static System.Console;
namespace MethodHiding
{
     class Parent
    {
        public void show()
        {
            WriteLine("This is parent class")
;        }
    }

    class child:Parent
    {
        public new void  show()
        {
            //1.base.show();
            //WriteLine("This is child class");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            child c = new child();
            //2.((Parent)c).show();
            //parent p=new child();
            //3.p.show();
            c.show();
        }
    }

}