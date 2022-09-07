using System;
using static System.Console;

namespace passbyref
{
    public class program
    {
       public string name { get; set; }
        public int num { get; set; }
        public static program operator +(program obj1,program obj2)
        {
            program obj3 = new program();
            obj3.name = obj1.name + obj2.name;
            obj3.num = obj1.num + obj2.num;
            return obj3;
        }

        static void Main(string[] args)
        {
            program obj1 = new program();
            obj1.name = "satyajit";
            obj1.num = 10;
            program obj2 = new program();
            obj2.name = "Das";
            obj2.num = 10;
            program obj3 = new program();
            obj3 = obj1 + obj2;
            WriteLine(obj3.name+" "+obj3.num);
            
        }
    }

}


