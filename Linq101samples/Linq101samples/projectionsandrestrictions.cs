//using System.Linq;
//using System.Collections.Generic;
//using static System.Console;

//namespace Try101LinqSamples
//{
//    internal class joiprojectionsandrestrictions
//    {
//        //public static void Restrictions()
//        //{
//        //    int length;
//        //    WriteLine("please enter the legth of an array: ");
//        //    length = Convert.ToInt32(ReadLine());
//        //    WriteLine("please enter the elements of an array");
//        //    int[] arrnumbers = new int[10];
//        //    for(int i = 0; i < length; i++)
//        //    {
//        //        arrnumbers[i] = Convert.ToInt32(ReadLine());
//        //    }
            
//        //    var result =  arrnumbers.Where(x => x >= 4 && x <= 7);
//        //    foreach(var i in result)
//        //    {
//        //        WriteLine($"{i} and the type is {arrnumbers.GetType().Name}");
//        //    }
//        //}


//        public class person
//        {
//            public string Name { get; set; }
//            public int age { get; set; }
//        }
//        public static void SimplewithObjects()
//        {
//            person[] persons =
//            {
//                new person{Name="satya",age=25},
//                new person{Name="subha",age=27},
//                new person{Name="kamala",age=52},
//                new person{Name="saroj",age=58}
//            };

//            var destinction = persons.Where(p => p.age > 27);
//            foreach(var i in destinction)
//            {
//                WriteLine($"The name is {i.Name} and age is {i.age}");
//            }

//        }

//        public static void Orderby()
//        {
//            var carList = new List<string>
//            {
//                "satya","chintu","kamala","subha","saroj"
//            };

//            var queryperform = carList.OrderBy(x => x);
//            foreach(string s in queryperform)
//            {
//                Console.WriteLine("The name are in ascending order {0}", s);

//            }
//        }

//        public static void withSelect()
//        {
//            decimal[] numbers = { 1.2M, 4.5M, 6.5M };
//            var result = numbers.Where((x,i)=>x>2 && i>=1).Select(n => Math.Floor(n));
//            foreach(var i in result)
//            {
//                WriteLine(i);
//            }
//        }
//        public static void Anonymous()
//        {
//            double[] number = { 30D, 60D, 90D };
//            var result = number.Select(a => new { angle = a, cos = Math.Cos(a), sin = Math.Sin(a) });
//            foreach(var i in result)
//            {
//                WriteLine("The number of degree is {0}, sin of it is {1} ,cos of it is {2}", i.angle, i.sin, i.cos);
//            }
//        }

//        public static void printValueandkey()
//        {
//            string[] arr = { "one", "two", "three" };
//            var result = arr.Select((w, i) => new
//            {
//                index = i,
//                value = w

//            });

//            foreach(var i in result)
//            {
//                WriteLine("The index is {0} and value is {1}", i.index, i.value);
//            }

//        }

//        public static void SelectManyOpertor()
//        {
//            string[] fruits = { "Banana", "orange", "apple" };
//            int[] quantity = { 1, 2, 3 };
//            var result = fruits.SelectMany(f => quantity, (f, q) => new
//            {
//                fruits = f,
//                quantity = q
//            });
//            foreach(var o in result)
//            {
//                WriteLine(o.fruits + " " + o.quantity);
//            }
//        }

//        public class car
//        {
//            public string name { get; set; }
//            public double HorsePower { get; set; }
//        }

//        public static void OrderbyHorsePower()
//        {
//            car[] cars =
//            {
//                new car{name="bugati",HorsePower=750.25},
//                new car{name="Lamborgini",HorsePower=1025.25},
//                new car{name="Audi",HorsePower=985.25}

//            };

//            var sortedorder = cars.OrderByDescending(x => x.HorsePower);
//            foreach(var i in sortedorder)
//            {
//                Console.WriteLine("The car name is new car {0}  and horsePower is {1}", i.name, i.HorsePower);
//            }
//        }

//        public static  void orderByDates()
//        {
//            var dates = new DateTime[]
//            {
//                new DateTime(2015,02,05),
//                new DateTime(2017,04,05),
//                new DateTime(2019,08,05),

//            };
//            var result = dates.OrderBy(x => x);
//            foreach(var i in result)
//            {
//                Console.WriteLine("The sorted order is {0}", i);

//            }

//        }

//        public static void reverse()
//        {
//            char[] chars = { 's', 'a', 't', 'y', 'a' };
//            var result = chars.Reverse();
//           foreach(var x in result)
//            {
//                Console.Write(x+" ");
//                Console.WriteLine();

//            }

//        }

//        public static void OrderByThenBy()
//        {
//            string[] arraysofstring = { "satya", "kamala", "subha", "saroj", "soumya" };
//            var result = arraysofstring.OrderBy(x => x.Length).ThenByDescending(x => x);
//            Console.WriteLine("The list of arrays  are:");
//            foreach(var x in result)
//            {
//                Console.WriteLine(x);

//            }

//        }





//        static void Main(string[] args)
//        {
//            joiprojectionsandrestrictions.SimplewithObjects();
//            joiprojectionsandrestrictions.withSelect();
//            joiprojectionsandrestrictions.Anonymous();
//            joiprojectionsandrestrictions.printValueandkey();
//            joiprojectionsandrestrictions.SelectManyOpertor();
//            joiprojectionsandrestrictions.Orderby();
//            joiprojectionsandrestrictions.OrderbyHorsePower();
//            joiprojectionsandrestrictions.orderByDates();
//            joiprojectionsandrestrictions.reverse();
//            joiprojectionsandrestrictions.OrderByThenBy();

//            ReadLine();
//        }
//    }
//}