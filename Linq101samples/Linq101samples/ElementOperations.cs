//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using Try101LinqSamples;

//namespace Linq101samples
//{
//    internal class ElementOperations
//    {
//        public List<Product> Getallproduct() => Products.ProductList;
//        public List<Customer> Getallcustomer() => Customers.CustomerList;


//        public int firstElement()
//        {
//            List<Product> products = Getallproduct();

//            var product12 = ((from p in products
//                             where p.ProductID == 12
//                             select p).FirstOrDefault());

//            Console.WriteLine(product12);
//            return 0;

//        }
//        public int startwithfirstElement()
//        {
//            string[] strings = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
//            string startsWitho = strings.First(s => s[0] == 'o');
//            Console.WriteLine($"A string starting with 'o':{startsWitho}");
//            return 0;

//        }
//        public int MaybeFirstMatchingElement()
//        {
//            List<Product> products = Getallproduct();

//            var product789 = products.FirstOrDefault(p => p.ProductID == 12);

//            Console.WriteLine($"Product 789 exists: {product789 != null}");

//            return 0;
//        }

//        public int ElementAtPosition()
//        {
//            #region element-at
//            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

//            int fourthLowNum = (
//                from n in numbers
//                where n > 5
//                select n)
//                .ElementAt(2);  // second number is index 1 because sequences use 0-based indexing

//            Console.WriteLine($"Second number > 5: {fourthLowNum}");
//            #endregion
//            return 0;
//        }


//    }

//    public class Executions
//    {
//        static void Main(string[] args)
//        {
//            ElementOperations e = new ElementOperations();
//            e.firstElement();
//            e.startwithfirstElement();
//            e.MaybeFirstMatchingElement();
//            e.ElementAtPosition();

//        }
//    }
//}
