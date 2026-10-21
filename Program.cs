using LINQ.Models;
using static LINQ.DataSources.Source;
namespace G_NET_84_LINQ02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region LINQ Assignment

            #region 01
            //Console.WriteLine("---------- Q1 ----------");

            //var result01 = ProductList.OrderByDescending(p => p.UnitPrice).Take(3);

            //foreach (var product in result01)
            //    Console.WriteLine(product);
            #endregion

            #region 02
            //Console.WriteLine("---------- Q2 ----------");

            //int pageNumber = 2;
            //int pageSize = 5;

            //var result02 = ProductList.Skip((pageNumber - 1) * pageSize).Take(pageSize);

            //foreach (var product in result02)
            //    Console.WriteLine(product);
            #endregion

            #region 03
            //Console.WriteLine("---------- Q3 ----------");

            //var result03 = ProductList.OrderBy(p => p.UnitPrice).TakeWhile(p => p.UnitPrice < 25m);

            //foreach (var product in result03)
            //    Console.WriteLine(product);
            #endregion

            #region 04
            //Console.WriteLine("---------- Q4 ----------");

            //bool allSeafoodInStock = ProductList
            //                         .Where(p => p.Category == "Seafood")
            //                         .All(p => p.UnitsInStock > 0);

            //Console.WriteLine($"All Seafood in stock? {allSeafoodInStock}");
            #endregion

            #region 05
            //Console.WriteLine("---------- Q5 ----------");

            //int[] ids = { 3, 9, 13, 18 };

            //Console.WriteLine($"Contains(9): {ids.Contains(9)}");
            #endregion

            #region 06
            //Console.WriteLine("---------- Q6 ----------");

            //var result06 = ProductList.GroupBy(p => p.Category);

            //result06 = from p in ProductList
            //           group p by p.Category;

            //foreach (var group in result06)
            //{
            //    Console.WriteLine($"[{group.Key}]  ({group.Count()} products)");
            //    foreach (var product in group)
            //        Console.WriteLine($"    {product.ProductName}");
            //}
            #endregion

            #region 07
            //Console.WriteLine("---------- Q7 ----------");

            //var result07 = ProductList.GroupBy(p => p.Category)
            //                          .Select(g => new
            //                          {
            //                              Category = g.Key,
            //                              ProductNames = g.Select(p => p.ProductName)
            //                          });

            //foreach (var group in result07)
            //{
            //    Console.WriteLine($"[{group.Category}]");
            //    foreach (var name in group.ProductNames)
            //        Console.WriteLine($"    {name}");
            //}
            #endregion

            #region 08
            //Console.WriteLine("---------- Q8 ----------");

            //var result08 = ProductList.GroupBy(p => p.Category)
            //                          .Where(g => g.Count() > 3)
            //                          .Select(g => new { CategoryName = g.Key, CountOfProducts = g.Count() });

            //foreach (var item in result08)
            //    Console.WriteLine(item);
            #endregion

            #region 09
            //Console.WriteLine("---------- Q9 ----------");

            //var result09 = from c in CustomerList
            //               group c by c.Country
            //               into countryGroup
            //               select new
            //               {
            //                   Country = countryGroup.Key,
            //                   Count = countryGroup.Count(),
            //                   TotalOrderValue = countryGroup.Sum(cust => cust.Orders.Sum(o => o.Total))
            //               };

            //foreach (var item in result09)
            //    Console.WriteLine(item);
            #endregion

            #region 10
            //Console.WriteLine("---------- Q10 ----------");

            //var totalUnitsInStock = ProductList.Sum(p => p.UnitsInStock);

            //Console.WriteLine($"Total units in stock: {totalUnitsInStock}");
            #endregion

            #region 11
            //Console.WriteLine("---------- Q11 ----------");

            //var cheapestPrice = ProductList.Min(p => p.UnitPrice);
            //var highestPrice = ProductList.Max(p => p.UnitPrice);

            //Console.WriteLine($"Cheapest price: {cheapestPrice:C2}");
            //Console.WriteLine($"Most expensive price: {highestPrice:C2}");
            #endregion

            #region 12
            //Console.WriteLine("---------- Q12 ----------");

            //var result12 = ProductList.Select(p => p.Category).Distinct();

            //foreach (var category in result12)
            //    Console.WriteLine(category);
            #endregion

            #region 13
            //Console.WriteLine("---------- Q13 ----------");

            //int[] setA = { 1, 3, 5, 7, 9, 11, 13 };
            //int[] setB = { 3, 6, 9, 12, 15, 13 };

            //var result13 = setA.Except(setB);

            //foreach (var id in result13)
            //    Console.WriteLine(id);
            #endregion

            #region 14
            //Console.WriteLine("---------- Q14 ----------");

            //string[] list1 = { "Germany", "France", "UK", "Spain" };
            //string[] list2 = { "france", "SPAIN", "Italy" };

            //var result14 = list1.Except(list2, StringComparer.OrdinalIgnoreCase);

            //foreach (var country in result14)
            //    Console.WriteLine(country);
            #endregion

            #region 15
            Console.WriteLine("---------- Q15 ----------");

            Dictionary<int, Product> productsDictionary = ProductList.ToDictionary(p => p.ProductID);

            Console.WriteLine(productsDictionary[18]);
            #endregion

            #region 16
            Console.WriteLine("---------- Q16 ----------");

            var result16 = ProductList.First(p => p.UnitPrice > 50m);

            Console.WriteLine(result16);
            #endregion

            #region 17
            Console.WriteLine("---------- Q17 ----------");

            var result17 = ProductList.FirstOrDefault(p => p.UnitPrice > 500m);

            Console.WriteLine(result17?.ToString() ?? "null");
            #endregion

            #region 18
            Console.WriteLine("---------- Q18 ----------");

            var result18 = Enumerable.Range(1, 10).Select(n => $"7 x {n} = {7 * n}");

            foreach (var line in result18)
                Console.WriteLine(line);
            #endregion

            #region 19
            Console.WriteLine("---------- Q19 ----------");

            var result19 = Enumerable.Range(1, 30).Where(n => n % 2 == 0);

            foreach (var number in result19)
                Console.Write($"{number} ");
            Console.WriteLine();
            #endregion

            #region 20
            Console.WriteLine("---------- Q20 ----------");

            var result20 = ProductList.Take(3).Select(p => p.ProductName)
                                      .Concat(CustomerList.Take(3).Select(c => c.CustomerName));

            foreach (var name in result20)
                Console.WriteLine(name);
            #endregion

            #region 21
            Console.WriteLine("---------- Q21 ----------");

            var result21 = ProductList.Zip(CustomerList, (p, c) => $"{p.ProductName} sold to {c.CustomerName}");

            foreach (var line in result21)
                Console.WriteLine(line);
            #endregion

            #endregion
        }
    }
}
