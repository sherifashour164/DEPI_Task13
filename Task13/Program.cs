using static Task13.ListGenerators;
namespace Task13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region LINQ - Element Operators

            #region 1. Get the first Product out of Stock
            //var firstOutOfStock = ProductList.First(p => p.UnitsInStock == 0);

            //Console.WriteLine("First product out of stock:");
            //Console.WriteLine(firstOutOfStock);
            #endregion

            #region 2. First product whose Price > 1000, or null if none
            //var firstExpensiveOrNull = ProductList.FirstOrDefault(p => p.UnitPrice > 1000);

            //Console.WriteLine("First product priced above 1000 (or null):");
            //Console.WriteLine(firstExpensiveOrNull is null ? "null" : firstExpensiveOrNull.ToString());
            #endregion

            #region 3. Retrieve the second number greater than 5
            //int[] numbersArr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var secondGreaterThan5 = numbersArr.Where(n => n > 5).ElementAt(1);

            //Console.WriteLine("Second number greater than 5:");
            //Console.WriteLine(secondGreaterThan5);
            #endregion

            #endregion


            #region LINQ - Aggregate Operators

            #region 1. Count of odd numbers in the array
            //int[] numbersArr2 = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var oddCount = numbersArr2.Count(n => n % 2 != 0);

            //Console.WriteLine("Count of odd numbers:");
            //Console.WriteLine(oddCount);
            #endregion

            #region 2. List of customers and how many orders each has
            //// Fluent Syntax
            //var customersOrdersCount = CustomerList.Select(c => new
            //{
            //    c.CustomerName,
            //    OrdersCount = c.Orders.Length
            //});

            //// Query Syntax
            ////var customersOrdersCount = from c in CustomerList
            ////                           select new { c.CustomerName, OrdersCount = c.Orders.Length };

            //Console.WriteLine("Orders count per customer:");
            //foreach (var c in customersOrdersCount)
            //    Console.WriteLine($"{c.CustomerName}: {c.OrdersCount} order(s)");
            #endregion

            #region 3. List of categories and how many products each has
            //// Fluent Syntax
            //var productsPerCategory = ProductList.GroupBy(p => p.Category)
            //                                      .Select(g => new
            //                                      {
            //                                          Category = g.Key,
            //                                          Count = g.Count()
            //                                      });

            //// Query Syntax
            ////var productsPerCategory = from p in ProductList
            ////                          group p by p.Category into g
            ////                          select new { Category = g.Key, Count = g.Count() };

            //Console.WriteLine("Products count per category:");
            //foreach (var c in productsPerCategory)
            //    Console.WriteLine($"{c.Category}: {c.Count} product(s)");
            #endregion

            #region 4. Get the total of the numbers in an array
            //int[] numbersArr3 = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var numbersTotal = numbersArr3.Sum();

            //Console.WriteLine("Total of the numbers:");
            //Console.WriteLine(numbersTotal);
            #endregion

            string[] dictionaryWords = File.ReadAllLines("dictionary_english.txt");

            #region 5. Total number of characters of all words in dictionary_english.txt
            //var totalCharacters = dictionaryWords.Sum(w => w.Length);

            //Console.WriteLine("Total number of characters of all words:");
            //Console.WriteLine(totalCharacters);
            #endregion

            #region 6. Length of the shortest word in dictionary_english.txt
            //var shortestWordLength = dictionaryWords.Min(w => w.Length);

            //Console.WriteLine("Length of the shortest word:");
            //Console.WriteLine(shortestWordLength);
            #endregion

            #region 7. Length of the longest word in dictionary_english.txt
            //var longestWordLength = dictionaryWords.Max(w => w.Length);

            //Console.WriteLine("Length of the longest word:");
            //Console.WriteLine(longestWordLength);
            #endregion

            #region 8. Average length of the words in dictionary_english.txt
            //var averageWordLength = dictionaryWords.Average(w => w.Length);

            //Console.WriteLine("Average length of the words:");
            //Console.WriteLine(averageWordLength);
            #endregion

            #region 9. Total units in stock for each product category
            //// Fluent Syntax
            //var unitsPerCategory = ProductList.GroupBy(p => p.Category)
            //                                   .Select(g => new
            //                                   {
            //                                       Category = g.Key,
            //                                       TotalUnits = g.Sum(p => p.UnitsInStock)
            //                                   });

            //// Query Syntax
            ////var unitsPerCategory = from p in ProductList
            ////                       group p by p.Category into g
            ////                       select new { Category = g.Key, TotalUnits = g.Sum(p => p.UnitsInStock) };

            //Console.WriteLine("Total units in stock per category:");
            //foreach (var c in unitsPerCategory)
            //    Console.WriteLine($"{c.Category}: {c.TotalUnits} unit(s)");
            #endregion

            #region 10. Cheapest price among each category's products
            //// Fluent Syntax
            //var cheapestPerCategory = ProductList.GroupBy(p => p.Category)
            //                                      .Select(g => new
            //                                      {
            //                                          Category = g.Key,
            //                                          CheapestPrice = g.Min(p => p.UnitPrice)
            //                                      });

            //// Query Syntax
            ////var cheapestPerCategory = from p in ProductList
            ////                          group p by p.Category into g
            ////                          select new { Category = g.Key, CheapestPrice = g.Min(p => p.UnitPrice) };

            //Console.WriteLine("Cheapest price per category:");
            //foreach (var c in cheapestPerCategory)
            //    Console.WriteLine($"{c.Category}: {c.CheapestPrice}");
            #endregion

            #region 11. Products with the lowest price in each category (Use LET)
            //// Query Syntax (let)
            //var lowestPricedProducts = from p in ProductList
            //                           group p by p.Category into g
            //                           let minPrice = g.Min(p => p.UnitPrice)
            //                           select new
            //                           {
            //                               Category = g.Key,
            //                               Products = g.Where(p => p.UnitPrice == minPrice)
            //                           };

            //// Fluent Syntax
            ////var lowestPricedProducts = ProductList.GroupBy(p => p.Category)
            ////                                       .Select(g => new { g, minPrice = g.Min(p => p.UnitPrice) })
            ////                                       .Select(x => new
            ////                                       {
            ////                                           Category = x.g.Key,
            ////                                           Products = x.g.Where(p => p.UnitPrice == x.minPrice)
            ////                                       });

            //Console.WriteLine("Lowest priced products per category:");
            //foreach (var c in lowestPricedProducts)
            //{
            //    Console.WriteLine(c.Category);
            //    foreach (var p in c.Products)
            //        Console.WriteLine($"   {p}");
            //}
            #endregion

            #region 12. Highest price among each category's products
            //// Fluent Syntax
            //var highestPerCategory = ProductList.GroupBy(p => p.Category)
            //                                     .Select(g => new
            //                                     {
            //                                         Category = g.Key,
            //                                         HighestPrice = g.Max(p => p.UnitPrice)
            //                                     });

            //// Query Syntax
            ////var highestPerCategory = from p in ProductList
            ////                         group p by p.Category into g
            ////                         select new { Category = g.Key, HighestPrice = g.Max(p => p.UnitPrice) };

            //Console.WriteLine("Highest price per category:");
            //foreach (var c in highestPerCategory)
            //    Console.WriteLine($"{c.Category}: {c.HighestPrice}");
            #endregion

            #region 13. Products with the highest price in each category
            //// Query Syntax (let)
            //var highestPricedProducts = from p in ProductList
            //                            group p by p.Category into g
            //                            let maxPrice = g.Max(p => p.UnitPrice)
            //                            select new
            //                            {
            //                                Category = g.Key,
            //                                Products = g.Where(p => p.UnitPrice == maxPrice)
            //                            };

            //// Fluent Syntax
            ////var highestPricedProducts = ProductList.GroupBy(p => p.Category)
            ////                                        .Select(g => new { g, maxPrice = g.Max(p => p.UnitPrice) })
            ////                                        .Select(x => new
            ////                                        {
            ////                                            Category = x.g.Key,
            ////                                            Products = x.g.Where(p => p.UnitPrice == x.maxPrice)
            ////                                        });

            //Console.WriteLine("Highest priced products per category:");
            //foreach (var c in highestPricedProducts)
            //{
            //    Console.WriteLine(c.Category);
            //    foreach (var p in c.Products)
            //        Console.WriteLine($"   {p}");
            //}
            #endregion

            #region 14. Average price of each category's products
            //// Fluent Syntax
            //var averagePerCategory = ProductList.GroupBy(p => p.Category)
            //                                     .Select(g => new
            //                                     {
            //                                         Category = g.Key,
            //                                         AveragePrice = g.Average(p => p.UnitPrice)
            //                                     });

            //// Query Syntax
            ////var averagePerCategory = from p in ProductList
            ////                         group p by p.Category into g
            ////                         select new { Category = g.Key, AveragePrice = g.Average(p => p.UnitPrice) };

            //Console.WriteLine("Average price per category:");
            //foreach (var c in averagePerCategory)
            //    Console.WriteLine($"{c.Category}: {c.AveragePrice:F2}");
            #endregion

            #endregion


            #region LINQ - Set Operators

            #region 1. Unique Category names from Product List
            //// Fluent Syntax
            //var uniqueCategories = ProductList.Select(p => p.Category).Distinct();

            //// Query Syntax
            ////var uniqueCategories = (from p in ProductList
            ////                        select p.Category).Distinct();

            //Console.WriteLine("Unique categories:");
            //foreach (var c in uniqueCategories)
            //    Console.WriteLine(c);
            #endregion

            #region 2. Unique first letter from both product and customer names
            //// Fluent Syntax
            //var uniqueFirstLetters = ProductList.Select(p => p.ProductName[0])
            //                                     .Union(CustomerList.Select(c => c.CustomerName[0]));

            //// Query Syntax
            ////var uniqueFirstLetters = (from p in ProductList select p.ProductName[0])
            ////                         .Union(from c in CustomerList select c.CustomerName[0]);

            //Console.WriteLine("Unique first letters from products and customers:");
            //foreach (var l in uniqueFirstLetters)
            //    Console.Write($"{l} ");
            //Console.WriteLine();
            #endregion

            #region 3. Common first letter from both product and customer names
            //// Fluent Syntax
            //var commonFirstLetters = ProductList.Select(p => p.ProductName[0])
            //                                     .Intersect(CustomerList.Select(c => c.CustomerName[0]));

            //// Query Syntax
            ////var commonFirstLetters = (from p in ProductList select p.ProductName[0])
            ////                         .Intersect(from c in CustomerList select c.CustomerName[0]);

            //Console.WriteLine("Common first letters:");
            //foreach (var l in commonFirstLetters)
            //    Console.Write($"{l} ");
            //Console.WriteLine();
            #endregion

            #region 4. First letters of product names that are not first letters of customer names
            //// Fluent Syntax
            //var productOnlyLetters = ProductList.Select(p => p.ProductName[0])
            //                                     .Except(CustomerList.Select(c => c.CustomerName[0]));

            //// Query Syntax
            ////var productOnlyLetters = (from p in ProductList select p.ProductName[0])
            ////                         .Except(from c in CustomerList select c.CustomerName[0]);

            //Console.WriteLine("First letters of products that are not first letters of customers:");
            //foreach (var l in productOnlyLetters)
            //    Console.Write($"{l} ");
            //Console.WriteLine();
            #endregion

            #region 5. Last three characters of each customer and product name (with duplicates)
            //// Fluent Syntax
            //var lastThreeChars = ProductList.Select(p => p.ProductName.Substring(Math.Max(0, p.ProductName.Length - 3)))
            //                                 .Concat(CustomerList.Select(c => c.CustomerName.Substring(Math.Max(0, c.CustomerName.Length - 3))));

            //// Query Syntax
            ////var lastThreeChars = (from p in ProductList select p.ProductName.Substring(Math.Max(0, p.ProductName.Length - 3)))
            ////                     .Concat(from c in CustomerList select c.CustomerName.Substring(Math.Max(0, c.CustomerName.Length - 3)));

            //Console.WriteLine("Last three characters of all names:");
            //foreach (var s in lastThreeChars)
            //    Console.WriteLine(s);
            #endregion

            #endregion


            #region LINQ - Partitioning Operators

            #region 1. First 3 orders from customers in Washington
            //// Fluent Syntax
            //var first3WashingtonOrders = CustomerList.Where(c => c.Region == "WA")
            //                                          .SelectMany(c => c.Orders)
            //                                          .Take(3);

            //// Query Syntax
            ////var first3WashingtonOrders = (from c in CustomerList
            ////                              where c.Region == "WA"
            ////                              from o in c.Orders
            ////                              select o).Take(3);

            //Console.WriteLine("First 3 orders from Washington customers:");
            //foreach (var o in first3WashingtonOrders)
            //    Console.WriteLine(o);
            #endregion

            #region 2. All but the first 2 orders from customers in Washington
            //// Fluent Syntax
            //var skipFirst2WashingtonOrders = CustomerList.Where(c => c.Region == "WA")
            //                                              .SelectMany(c => c.Orders)
            //                                              .Skip(2);

            //// Query Syntax
            ////var skipFirst2WashingtonOrders = (from c in CustomerList
            ////                                  where c.Region == "WA"
            ////                                  from o in c.Orders
            ////                                  select o).Skip(2);

            //Console.WriteLine("Washington orders except the first 2:");
            //foreach (var o in skipFirst2WashingtonOrders)
            //    Console.WriteLine(o);
            #endregion

            #region 3. Elements from the beginning until a number is less than its position
            //int[] numbersPart1 = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var takeUntilLessThanIndex = numbersPart1.TakeWhile((n, index) => n >= index);

            //Console.WriteLine("Elements until a number is less than its position:");
            //foreach (var n in takeUntilLessThanIndex)
            //    Console.WriteLine(n);
            #endregion

            #region 4. Elements starting from the first element divisible by 3
            //int[] numbersPart2 = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var startFromDivisibleBy3 = numbersPart2.SkipWhile(n => n % 3 != 0);

            //Console.WriteLine("Elements starting from the first one divisible by 3:");
            //foreach (var n in startFromDivisibleBy3)
            //    Console.WriteLine(n);
            #endregion

            #region 5. Elements starting from the first element less than its position
            //int[] numbersPart3 = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var startFromLessThanIndex = numbersPart3.SkipWhile((n, index) => n >= index);

            //Console.WriteLine("Elements starting from the first one less than its position:");
            //foreach (var n in startFromLessThanIndex)
            //    Console.WriteLine(n);
            #endregion

            #endregion


            #region LINQ - Quantifiers

            #region 1. Any word in dictionary_english.txt contains the substring 'ei'
            //var anyContainsEi = dictionaryWords.Any(w => w.Contains("ei"));

            //Console.WriteLine("Is there any word containing 'ei'?");
            //Console.WriteLine(anyContainsEi);
            #endregion

            #region 2. Grouped list of products for categories with at least one product out of stock
            //// Fluent Syntax
            //var categoriesWithOutOfStock = ProductList.GroupBy(p => p.Category)
            //                                           .Where(g => g.Any(p => p.UnitsInStock == 0));

            //// Query Syntax
            ////var categoriesWithOutOfStock = from p in ProductList
            ////                               group p by p.Category into g
            ////                               where g.Any(p => p.UnitsInStock == 0)
            ////                               select g;

            //Console.WriteLine("Categories with at least one product out of stock:");
            //foreach (var g in categoriesWithOutOfStock)
            //{
            //    Console.WriteLine(g.Key);
            //    foreach (var p in g)
            //        Console.WriteLine($"   {p}");
            //}
            #endregion

            #region 3. Grouped list of products for categories where all products are in stock
            //// Fluent Syntax
            //var categoriesAllInStock = ProductList.GroupBy(p => p.Category)
            //                                       .Where(g => g.All(p => p.UnitsInStock > 0));

            //// Query Syntax
            ////var categoriesAllInStock = from p in ProductList
            ////                           group p by p.Category into g
            ////                           where g.All(p => p.UnitsInStock > 0)
            ////                           select g;

            //Console.WriteLine("Categories where all products are in stock:");
            //foreach (var g in categoriesAllInStock)
            //{
            //    Console.WriteLine(g.Key);
            //    foreach (var p in g)
            //        Console.WriteLine($"   {p}");
            //}
            #endregion

            #endregion


            #region LINQ - Grouping Operators

            #region 1. Partition a list of numbers by their remainder when divided by 5
            //List<int> numbersList = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };

            //// Fluent Syntax
            //var groupedByRemainder = numbersList.GroupBy(n => n % 5);

            //// Query Syntax
            ////var groupedByRemainder = from n in numbersList
            ////                         group n by n % 5;

            //foreach (var g in groupedByRemainder.OrderBy(g => g.Key))
            //{
            //    Console.WriteLine($"Numbers with a remainder of {g.Key} when divided by 5:");
            //    foreach (var n in g)
            //        Console.WriteLine(n);
            //}
            #endregion

            #region 2. Partition a list of words by their first letter (dictionary_english.txt)
            //// Fluent Syntax
            //var groupedByFirstLetter = dictionaryWords.Where(w => w.Length > 0)
            //                                          .GroupBy(w => w[0]);

            //// Query Syntax
            ////var groupedByFirstLetter = from w in dictionaryWords
            ////                           where w.Length > 0
            ////                           group w by w[0];

            //// The dictionary is huge, so we print each letter with its words count
            //foreach (var g in groupedByFirstLetter)
            //    Console.WriteLine($"{g.Key}: {g.Count()} word(s)");
            #endregion

            #region 3. Group words that consist of the same characters (custom comparer)
            //string[] anagramsArr = { "from", "salt", "earn", " last", "near", "form" };

            //var anagramGroups = anagramsArr.GroupBy(w => w, new AnagramComparer());

            //foreach (var g in anagramGroups)
            //{
            //    foreach (var w in g)
            //        Console.WriteLine(w);
            //    Console.WriteLine("...");
            //}
            #endregion

            #endregion
        }
    }

    // Custom comparer: two words are equal if they consist of the same characters
    // (the words are trimmed first because of the leading spaces in the input array)
    internal class AnagramComparer : IEqualityComparer<string>
    {
        public bool Equals(string? x, string? y)
        {
            return Normalize(x) == Normalize(y);
        }

        public int GetHashCode(string obj)
        {
            return Normalize(obj).GetHashCode();
        }

        private static string Normalize(string? word)
        {
            var chars = (word ?? string.Empty).Trim().ToCharArray();
            Array.Sort(chars);
            return new string(chars);
        }
    }
}
