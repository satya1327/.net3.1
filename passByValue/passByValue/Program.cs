using System;
using static System.Console;
internal class program
{

    //by pass by value method the value does not updated in the declaratiu=on only update in method.
    public static int Addition(int a)
    {
        a = a + 10;
        return a;


    }

    //by reference the value get updated when it change in method
    public static void PassByrefencewithref(ref int b)
    {
        b = b + 15;
        WriteLine(b);


    }

    //no need of declare the value at declaration time
    public static void PassByOutparameter(out int c)
    {
        c = 20;
        WriteLine(c);

    }

    static void Main(string[] args)
    {
        int a = 5;
        int c=program.Addition(a);
        WriteLine(c);
       WriteLine(a);
        int b = 15;
        program.PassByrefencewithref(ref b);
        WriteLine(b);

        int values;
        program.PassByOutparameter(out values);
        WriteLine(values);



    }
}
