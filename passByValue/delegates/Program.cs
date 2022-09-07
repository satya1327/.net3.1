using System;
using static System.Console;


namespace Delegates
{

    public delegate void calculation(int a,int b);

    class Program
    {
        public static void addition(int a,int b)
        {
            int result = a + b;
            WriteLine(result);

        }

        public static void substraction(int a, int b)
        {
            int result = a - b;
            WriteLine(result);

        }
        public static void multiplication(int a,int b)
        {
            int result = a * b;
            WriteLine(result);

        }
        public static void division(int a, int b)
        {
             int result = a / b;
                WriteLine(result);

        }
        
        static void Main(string[] args)
        {
            calculation c = new calculation(addition);
            c += substraction;
            c += multiplication;
            c += division;
            c(8, 4);
           
        }
    }



}