using System;
using static System.Console;

internal class Program
{
    int[] arr = new int[3];

	public int this[int index]
	{
	
		set { 
		
		if(index>=0 && index < arr.Length)
			{
				if (value > 0)
				{
					arr[index] = value;
				}
				else
				{
					WriteLine("Value is invalid!!!");
				}

			}
			else
			{
				WriteLine("index is invalid!!!");
			}
		
		
		}
		get
		{
			return arr[index];
		}
	}
	static void Main(string [] args)
	{
		Program p = new Program();
		p[5] = -5;
		WriteLine(p[0]);
		ReadLine();
	}
}

// used to which type of data we are going to store in array or collection.we can't use propoties or getter or setter method to store because it holds single data...