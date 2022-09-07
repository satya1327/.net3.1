using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Try101LinqSamples;

namespace Linq101samples
{
    internal class ordering
    {

        public static List<Product> GetProductList() =>Products.ProductList;
        public List<Customer> GetAllCustomer() => Customers.CustomerList;


        public static void OrderWords()
        {
            string[] words = { "apple", "cat", "banana" };
            var result = from f in words
                         orderby f ascending
                         select f;
            foreach(var i in result)
            {
                Console.WriteLine(i);
            }
        }
        public static void OrderbyProperty()
        {
            string[] words = { "apple", "cat", "banana" };
            var result = from f in words
                         orderby f.Length
                         select f;
            foreach(var i in result)
            {
                Console.WriteLine(i);
            }

        }

        //public static void OrderByProducts()
        //{
        //    List<Product> products = GetProductList();

        //    var result = from p in products
        //                 orderby p.ProductName
        //                 select p;
        //    foreach(var i in result)
        //    {
        //        Console.WriteLine(i);
        //    }

        //}
        public static int OrderingReversal()
        {
            #region reverse
            string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            var reversedIDigits = (
                from digit in digits
                where digit.Contains('o')
                select digit)
                .Reverse();

            Console.WriteLine("A backwards list of the digits with a second character of 'i':");
            foreach (var d in reversedIDigits)
            {
                Console.WriteLine(d);
            }
            #endregion
            return 0;
        }

        static void Main(string[] args)
        {
            ordering.OrderWords();
            ordering.OrderbyProperty();
            //ordering.OrderByProducts();
            ordering.OrderingReversal();

        }


    }
}
