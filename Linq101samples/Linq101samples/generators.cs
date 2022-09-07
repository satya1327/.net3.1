//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Linq101samples
//{
//    internal class generators
//    {
//        public void RangeOfIntegers()
//        {
//            var numbers = from n in Enumerable.Range(100, 50)
//                          select (number: n, evenodd: n % 2 == 0 ? "even" : "odd");
//            foreach (var i in numbers)
//            {
//                Console.WriteLine("The number {0} is {1}", i.number, i.evenodd);
//            }

//            Console.WriteLine("---------------------------------------------------------------");
//        }

//        public void EvenOdd()
//        {
//            int[] numbers = { 1, 2, 4, 5, 3, 6, 7, 8, 9 };
//            var evenOdd = numbers.ToDictionary(k => k, v => v % 2 == 1 ? "odd" : "even");
//            foreach(KeyValuePair<int,string> dic in evenOdd)
//            {
//                Console.WriteLine($"Number is {dic.Key} and status is {dic.Value}");
//            }
//        }
//        public void repeatNumber()
//        {
//            var numbers = Enumerable.Repeat(7, 10);
//            foreach (var i in numbers)
//            {
//                Console.WriteLine(i);
//            }
//        }
//    }

//    public class mainBlock
//    {
//        static void Main(string[] args)
//        {
//            generators g = new generators();
//            g.EvenOdd();
//            g.repeatNumber();
//            g.RangeOfIntegers();
//        }

//    }
//}
