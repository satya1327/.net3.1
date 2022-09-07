//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Linq101samples
//{
//    internal class conversions
//    {
//        public int convertToArray()
//        {
//            double[] doubles = { 1.2, 1.5, 1.8, 1.6 };
//            var sortedDoubles = from s in doubles
//                                orderby s descending
//                                select s;
//            var doublesArray = sortedDoubles.ToArray();
//            Console.WriteLine("Every other double array from highest to lowest");
//            for(double d= doublesArray.Length-1; d>=0; d--)
//            {
//                Console.WriteLine(d);
//            }
//            return 0;

//        }

//        public int convrtToList()
//        {
//            string[] arr = { "satya", "chintu", "subha", "kamala" };
//            var sortedwords = from s in arr
//                              orderby s descending
//                              select s;
//            var ConvertToList = sortedwords.ToList();
//            foreach(var i in ConvertToList)
//            {
//                Console.WriteLine(i);

//            }
//            return 0;
//        }

//        public int Dictionaryofsorted()
//        {
//            var scoreRedcords = new[] {new {Name="satya",score=80},
//                                        new {Name="shivam",score=90},
//                                        new {Name="samrat",score=70}
                                      
//                                      };
//            var Dictionaryofsorted = scoreRedcords.ToDictionary(s=>s.Name);
           
//                Console.WriteLine("satya :{0}", Dictionaryofsorted["satya"]);
        
//            return 0;

//        }

//        public int convertSelectedItems()
//        {
//            object[] numbers = { null, 1.0, "two", 3, "four", 5 };
//            var doubles = numbers.OfType<double>();
//            Console.WriteLine("The double numbers are:");
//            foreach(var i in doubles)
//            {
//                Console.WriteLine(i);
//            }
//            return 0;

//        }
//        static void Main(string[] args)
//        {
//            conversions c = new conversions();
//            c.convertToArray();
//            c.convrtToList();
//            c.Dictionaryofsorted();
//            c.convertSelectedItems();
//        }


//    }
//}
