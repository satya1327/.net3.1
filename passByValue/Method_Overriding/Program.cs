using System;
using static System.Console;
namespace Method_overriding
{
    class parent
    {
        public virtual void Show()
        {
            WriteLine("This is the parent class");

        }
    }
    class child : parent
    {
        public override void Show()
        {
            base.Show();
            //WriteLine("This is the child method");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            child p = new child();
            p.Show();
        }
    }
}

//virtual keyword allows to make some changes on the override method.