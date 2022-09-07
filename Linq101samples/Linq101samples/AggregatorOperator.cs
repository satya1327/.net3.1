//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using Try101LinqSamples;
//using static System.Console;

//namespace Linq101samples
//{
//    internal class AggregatorOperator
//    {
//        public List<Product> GetProductList() => Products.ProductList;
//        public List<Customer> GetCustomerList() => Customers.CustomerList;

//        public  int CountSyntax()
//        {
//            int[] factOf300 = { 2, 2, 3, 5, 5 };
//            int uniqueFactors = factOf300.Distinct().Count();
//            WriteLine($"The unique factors are {uniqueFactors} of factOf300");
//            return 0;

//        }
//        public int countConditional()
//        {
//            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
//            int  oddnumbers = numbers.Count(n => n % 2 == 1);
//            WriteLine($"the count of odd numbers are {oddnumbers} of numbers");
//            return 0;


//        }

//        public int orderCount()
//        {
//            List<Customer> customers = GetCustomerList();
//            var OrderCount = from c in customers
//                             select (c.CustomerID, orderCount: c.Orders.Count());
//            foreach(var i in OrderCount)
//            {
//                WriteLine($"the customer id is {i.CustomerID} and the order is {i.orderCount}");
//            }
//            return 1;


//        }

//        public int CategoryGroupCount()
//        {
//            List<Product> products = GetProductList();
//            var CategoryCount = from p in products
//                                group p by p.Category into g
//                                select (Category:g.Key, productCount: g.Count());
//            foreach(var c in CategoryCount)
//            {
//                WriteLine($"category:{c.Category} , Count:{c.productCount}");

//            }

//            WriteLine("--------------------------------------------------------------------");
//            return 1;


//        }

//        public int ProductNamGroupCount()
//        {
//            List<Product> products = GetProductList();
//            var ProductNameCount = from p in products
//                                   group p by p.ProductName into g
//                                   select (ProductName: g.Key, count: g.Count());
//            foreach(var i in ProductNameCount)
//            {
//                WriteLine($"ProductName:{i.ProductName} , count{i.count}");

//            }
//            WriteLine("----------------------------------------------------------");

//            return 1;
//        }

//        public int SumSyntax()
//        {
//            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
//            double sumations = numbers.Sum();
//            WriteLine($"Sum of the number is {sumations}");
//            return 0;
//        }

//        public int sumprojection()
//        {
//            string[] arr = { "satya", "subha", "kamala", "saroj" };
//            double sumproj = arr.Sum(x => x.Length);
//            WriteLine($"The word count is{sumproj}");
//            return 0;


//        }

//        public int GroupByProductCategory()
//        {
//            List<Product> products = GetProductList();
//            var GroupByProductCategory = from p in products
//                                         group p by p.Category into g
//                                         select (category: g.Key, totalUnitPrice: g.Sum(x => x.UnitsInStock));
//            foreach(var i in GroupByProductCategory)
//            {
//                WriteLine($"category:{i.category} , unitStock:{i.totalUnitPrice}");
//            }
//            return 0;


//        }

//        public int MinSyntax()
//        {
//            int[] arr = { 1, 2, 4, 5, 8, 5, 63, 45, 4 };
//            int minimum = arr.Min();
//            WriteLine($"minimum is {minimum}");
//            return 0;

//        }


//        public int minProjection()
//        {
//            string[] str = { "satya", "subhashree", "kamala" };

//            double shortestName = str.Min(x=>x.Length);
//            WriteLine($"The shortest name length is {shortestName}");
//            return 0;

                
                
//        }

//        public int minUnitPrice()
//        {
//            List<Product> products = GetProductList();
//            var minimumUnit = from p in products
//                              group p by p.Category into g
//                              select (category: g.Key, minUnitPrice: g.Min(x => x.UnitPrice));
//            foreach(var i in minimumUnit)
//            {
//                WriteLine($"Category{i.category} , minUnitPrice:{i.minUnitPrice}");
//            }
//            return 0;

//        }

//        public int minimumEachGroupInCategory()
//        {
//            List<Product> products = GetProductList();
//            var minimumProductList = from p in products
//                                     group p by p.Category into g
//                                     let minimum = g.Min(x => x.UnitPrice)
//                                     select (Category: g.Key, CheapestProducts: g.Where(x => x.UnitPrice == minimum));
//            foreach(var i in minimumProductList)
//            {
//                WriteLine($"Category{i.Category}");
//                foreach(var px in i.CheapestProducts)
//                {
//                    WriteLine($"\tproduct:{px}");
//                }
//            }
//            return 1;

//        }

//        public int averageSyntax()
//        {
//            int[] arr = { 1, 2, 4, 5, 7, 8, 5, 8, 2 };
//            double avg=  arr.Average();
//            WriteLine($"average is {avg}");
//            return 0;

//        }
//        public int averageProjection()
//        {
//            string[] str = { "satya", "subhashree", "kamala" };
//            double words = str.Average(x => x.Length);
//            WriteLine($"The average length is {words}");
//            return 0;

//        }

//        public int CategoryAverageunitPrice()
//        {
//            List<Product> products = GetProductList();
//            var AverageUnit = from p in products
//                              group p by p.Category into g
                              
//                              select (category: g.Key, averageUnitPrice: g.Average(x=>x.UnitPrice));
//            foreach(var i in AverageUnit)
//            {
//                WriteLine($"Category:{i.category} , average price  is {i.averageUnitPrice}");

             

//            }
//            return 0;

//        }

//        public int AggregateSyntax()
//        {
//            #region aggregate-syntax
//            double[] doubles = { 1.7, 2.3, 1.9, 4.1, 2.9 };

//            double product = doubles.Aggregate((runningProduct, nextFactor) => runningProduct * nextFactor);

//            Console.WriteLine($"Total product of all numbers: {product}");
//            #endregion
//            return 0;
//        }


//        public int SeededAggregate()
//        {
//            #region aggregate-seeded
//            double startBalance = 100.0;

//            int[] attemptedWithdrawals = { 20, 10, 40, 50, 10, 70, 30 };

//            double endBalance =
//                attemptedWithdrawals.Aggregate(startBalance,
//                    (balance, nextWithdrawal) =>
//                        ((nextWithdrawal <= balance) ? (balance - nextWithdrawal) : balance));

//            Console.WriteLine($"Ending balance: {endBalance}");
//            #endregion
//            return 0;
//        }



//        static void Main(string[] args)
//        {
//            AggregatorOperator agg = new AggregatorOperator();
//            agg.CountSyntax();
//            agg.countConditional();
//            agg.orderCount();
//            agg.CategoryGroupCount();
//            agg.ProductNamGroupCount();
//            agg.SumSyntax();
//            agg.sumprojection();
//            agg.GroupByProductCategory();
//            agg.MinSyntax();
//            agg.minProjection();
//            agg.minUnitPrice();
//            agg.minimumEachGroupInCategory();
//            agg.averageSyntax();
//            agg.averageProjection();
//            agg.CategoryAverageunitPrice();
//            agg.AggregateSyntax();
//            agg.SeededAggregate();









//        }
//    }
    
//}
