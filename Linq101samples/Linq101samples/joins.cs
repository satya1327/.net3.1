//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using Try101LinqSamples;

//namespace Linq101samples
//{
//    internal class joins
//    {

//        public static List<Product> GetProductList() => Products.ProductList;
//        public List<Customer> GetCustomerList() => Customers.CustomerList;

//        public class category
//        {
//            public string categories { get; set; }
//        }


//        public static int GroupJoinQquery()
//        {

//            string[] categories = {
//                "Beverages",
//                "Condiments",
//                "Vegetables",
//                "Dairy Products",
//                "Seafood"
//            };





//            List<Product> products = GetProductList();

//            var result = categories.GroupJoin(products, caty => caty, pro => pro.Category, (caty, pro) => new { key = caty, products = pro });
//            //var result = from c in categories
//            //             join p in products on c equals p.Category into g
//            //             select (category: c, products: g);
//            foreach (var i in result)
//            {
//                Console.WriteLine("-------------------------------------------------------");
//                Console.WriteLine("product name is :"+ i.key);
//                Console.WriteLine("-------------------------------------------------------");
//                foreach (var j in i.products)
//                {
//                    Console.WriteLine(j.ProductName);

//                }
//            }

//            return 1;
//        }






//        public class language
//        {
//            public string languageName { get; set; }
//            public int id { get; set; }
//        }
//        public class persons
//        {
//            public int languageId { get; set; }
//            public string PersonName { get; set; }
//        }

//        public static void groupJoins()
//        {
//            persons[] person = new persons[]
//            {
//                new persons(){languageId=1,PersonName="satya"},

//                new persons(){languageId=2,PersonName="subha"},

//                new persons(){languageId=3,PersonName="kamala"},

//                new persons(){languageId=4,PersonName="saroj"},
//            };

//            language[] languages = new language[]
//            {
//               new language(){id=1,languageName="spanish"},
//               new language(){id=2,languageName="english"}

//            };

//            //var result = languages.GroupJoin(person, lang => lang.id, per => per.languageId,
//            //    (lang, per) => new { speaking = lang.languageName, personspeak = per });
//            //foreach(var lan in result)
//            //{
//            //    Console.WriteLine("Person speaks:{0}", lan.speaking);
//            //    foreach(var i in lan.personspeak)
//            //    {
//            //        Console.WriteLine(i.PersonName);
//            //    }
//            //}

//            var result = person.Join(languages, per => per.languageId, lang => lang.id, (per, lang) => per);
//            foreach (var i in result)
//            {
//                Console.WriteLine(i.PersonName);
//            }


//        }

//        public static int GroupBy()
//        {
//            int[] numbers = { 1, 2, 4, 5, 8, 5, 8, 7, 5, 2 };
//            var result = numbers.GroupBy(n => n % 5 == 0);
//            foreach (IGrouping<bool, int> res in result)
//            {
//                if (res.Key == true)

//                    Console.WriteLine("The numbers are divisible by 5");
//                else
//                    Console.WriteLine("The number is not divisible by 5");

//                foreach (int values in res)
//                {
//                    Console.WriteLine(values);
//                }


//            }
//            return 0;
//        }

//        public static int leftOuterJoin()
//        {
//            string[] categories = {
//                "Beverages",
//                "Condiments",
//                "Vegetables",
//                "Dairy Products",
//                "Seafood"
//            };

//            List<Product> products = GetProductList();
//            var result = from c in categories
//                         join p in products on c equals p.Category into g
//                         from p in g.DefaultIfEmpty()
//                         select (category: c, productss: p == null ? "no products" : p.ProductName);



//            foreach(var i in result)
//            {
//                Console.WriteLine($"{i.productss}:{i.category}");
//            }
//            return 0;
//        }

//        static void Main(string[] args)
//        {
//            joins.groupJoins();
//            joins.GroupBy();
//            joins.GroupJoinQquery();
//            joins.leftOuterJoin();

//        }



//    }
//}