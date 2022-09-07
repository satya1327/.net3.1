//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Linq101samples
//{
//    internal class grouping
//    {
//        public int GroupingRemainder()
//        {
//            int[] arr = { 1, 2, 4, 5, 6, 8, 5, 6, 2, 8, 7, 10, 2, 533, 1, 515, 12, 1453 };
//            var divisibleByRemainder = from a in arr
//                                       group a by a % 5 into g
//                                       select (remainders: g.Key, numbers: g);
//            foreach(var i in divisibleByRemainder)
//            {
//                Console.WriteLine($"The remainders are {i.remainders}");
//                foreach(var m in i.numbers)
//                {
//                    Console.WriteLine($"the dividends are :{m}");
//                }

//            }
//            return 1;

//        }


//        public int findEvenodd()
//        {
//            int[] arr = { 1, 2, 4, 5, 7, 1, 5, 7 };
//            var dev = arr.Select(m => m % 2 == 0 ? "even" : "odd").ToArray();
//            foreach(var i in dev)
//            {
//                Console.WriteLine($"numbers:{i}");
//            }
//            return 0;
//        }

//        static void Main(string[] args)
//        {
//            grouping g = new grouping();
//            g.GroupingRemainder();
//            g.findEvenodd();
//        }
//    }
//}
