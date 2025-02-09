using System.Globalization;
using System.Text.RegularExpressions;
namespace LINQ_Session2_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Element Operators - Immediate Execution

            #region First,Last,FirstOrDefault,LastOrDefault Part01
            //ProductList = new List<product>();

            //var result = ProductList.First;

            //result = ProductList.Last;

            //Console.WriteLine(result.Productname); 
            #endregion

            #region First,Last,FirstOrDefault,LastOrDefault Part02
            //var Result = ProductList.First(P => P.UnitStock == 0);
            // Result = ProductList.FirstOrDefault(P => P.UnitStock == 0);

            //var Result = ProductList.Last(P => P.UnitStock == 0);

            //Console.WriteLine(Result?.ProductName ?? "NA"); 
            #endregion

            #region ElementAdd, ElementAddOrDefault
            // var Result = ProductList.ElementAt(10);
            // var Result = ProductList.ElementAtOrDefault(10);

            // cw(Result?.ProductName ?? "NA"); 
            #endregion

            #region Single , SingleOrDefault
            // var DiscountedProduct = new List<Product>() {ProductList[0], ProductList[1]};
            // var Result = DiscountedProduct.Single();

            //var Result = ProductList.Single(P => P.ProductID == 1); 

            // var Result = ProductList.Single(P => P.ProductId == 10);

            // var Result = ProductList.Single(P => P.UnitPricw > 1000);

            //Rsult = ProductList.SingleOrDefault(P => P.ProductId == 1);
            //Rsult = ProductList.SingleOrDefault(P => P.ProductId == 1000, new Product());

            //cw(Result?.ProductName ?? "NA");  

            #endregion
            #endregion

            #region Aggregation Operators - Immediate Execution

            #region Count() , TryGetNonEnumeratedCount() [.Net 6.0 New Feature]

            // var Result = ProductList.Count();
            // var Result = ProductList.Count(P => P.UnitStock == 0);

            // IEnumerable<int> Numbers = Enumerable.Range(1, 100); // 1 to 100
            // var Result = Numbers.Count();

            //Numbers.TryGetNonEnumeratedCount(out Count);

            // Count = ProductList.Where(P => P.UnitStock == 0).Count();
            // Count = ProductList.Count(P => P.UnitStock == 0);

            // ProductList.Where(P => P.UnitStock == 0).TryGetNonEnumeratedCount(out Count);

            // Console.WriteLine(Result); 
            #endregion

            #region Sum() , Average()

            // var Result = ProductList.Sum(P => P.UnitStock);
            // var Result = ProductList.Average(P => P.UnitStock);

            // Console.WriteLine(Result);
            #endregion

            #region Min() , Max() , MinBy() , MaxBy()

            // var MaxProduct = ProductList.Max();
            // MaxProduct = ProductList.Max( new ProductComparer());

            // MaxProduct = ProductList.MaxBy(P => P.UnitPrice);
            // MaxProduct = ProductList.MaxBy(P => P.UnitsInStock);
            // MaxProduct = ProductList.MaxBy(P => P.UnitPrice, new IntComparer());

            // var MinProduct = ProductList.Min();
            // MinProduct = ProductList.Min(new ProductComparer());

            // MinProduct = ProductList.MinBy(P => P.UnitPrice);
            // MinProduct = ProductList.MinBy(P => P.UnitsInStock);

            // console.WriteLine(MaxProduct);

            // var MaxPrice = ProductList.Max(P => P.UnitPrice);

            // var Result = ProductList.Max(P => P.ProductName);

            // var MinPrice = ProductList.Min(P => P.UnitPrice);

            // var Result = ProductList.Min(P => P.ProductName);

            //Console.WriteLine(Result);

            #endregion

            #region Aggregate

            //string [] Names = ["Sachin", "Nsr", "Eldin", "Hamdy"];

            // string FullName = Names.Aggregate((str01, str02) => str01 + " " + str02);
            // FullName = Names.Aggregate("Mr.", (str01, str02) => str01 + " " + str02);
            // FullName = Names.Aggregate("Mr.", (str01, str02) => str01 + " " + str02, str => str.ToUpper());

            // Console.WriteLine(FullName);
            #endregion

            #endregion

            #region Conversion (Casting) Operators - Immediate Execution

            // List<Product> List = ProductList.Where(P => P.UnitStock == 0).ToList();

            // Product[] Array = ProductList.Where(P => P.UnitStock == 0).ToArray();

            // Dictionary < long, Producct> Dictionary01 = ProductList.Where (P => P.UnitStock == 0)
            // .ToDictionary(P => P.ProductID);

            // Dictionary < long, Producct> Dictionary02 = ProductList.Where (P => P.UnitStock == 0)
            // .ToDictionary(P => P.ProductID, P => P.ProductName);

            // Dictionary02 = ProductList.Where(P => P.UnitStock == 0).ToHashSet();

            // HashSet<Product> HashSet = ProductList.Where(P => P.UnitStock == 0).ToHashSet();

            // hashSet<Product> HashSet = ProductList.Where(P => P.UnitStock == 0).ToHashSet(new ProductComparer());

            // var sortedCollection = ProductList.Where(P => P.UnitStock == 0).ToImmutableSortedSet();


            #endregion

            #region Generation Operators

            // The Only Way for calling Theses Methods (Operators) is by using Enumerable Class

            // var Result = Enumerable.Range(0, 100); // 0 to 99

            // var Result = Enumerable.Repeat<Product> (new Product(), 100);

            // var Result = Enumerable.Empty<Product>();

            // foreach (var item in Result)
            // Console.WriteLine(item);
            #endregion

            #region Set Operators - Union Family Operators


            // var Seq01 = Enumerable.Range(0, 100); // 0 to 99
            // var Seq02 = Enumerable.Range(50, 100); // 50 to 149

            // var Result = Seq01.Union(Seq02); // Merging the two sequences and removing the duplicates

            // Result = Seq01.Concat(Seq02); // Merging the two sequences without removing the duplicates

            // Result = Seq01.Distinct(); // Removing the duplicates from the sequence

            // Result = Seq01.Intersect(Seq02); // [50, 51, 52, 53, 54, 55, 56, 57, 58, 59]

            // Result = Seq01.Except(Seq02); [0 To 49]


            // foreach (var item in Result)
            // Console.WriteLine(item); 

            #endregion

            #region Quantifier Operators - Return Boolean Value


            // Console.Writeline(
            // ProductList.Any()
            // ProductList.Any(P=> P.UnitInstock == 0 )
            // ProductList.All(P=> P.UnitInstock > 0 )
            //ProductList.Contains(Product)
            //ProductList.Contains(Product , new ProductEqualityComparer())
            // ); 

            #endregion

            #region Transformation Operators - Zip

            // List<string> Words = new List<string>() {"Ten" , "Twenty" ,"Thirty" , "Fourty" };
            // int [] Numbers = [10,20,30,40,50,60,70];

            //var Result = NumberS.Zip(words);
            //var Result = NumberS.Zip(words , (number , word) => $" {number} = {word} ");
            //var Result = NumberS.Zip(words , [1, 2, 3]); // C# 10.0 New Feature.

            // foreach(var item in Result)
            // Console.WriteLine(item);
            #endregion

            #region Partitioning Operators - Take, Skip , TakeLast, SkipLast , TakeWhile , SkipWhile

            #region Take , TakeLast , Skip , SkipLast

            // var Result = ProductList.Where (P => P.UnitsInStock > 0).Take(5);
            //  Result = ProductList.Where (P => P.UnitsInStock > 0).Take(5);

            //  Result = ProductList.Where (P => P.UnitsInStock > 0).Skip(5);
            //  Result = ProductList.Where (P => P.UnitsInStock > 0).SkipLast(5);

            //var PageSize = 10;
            //var pageIndex = 4;




            // foreach(var product in Result)
            //  Console.Writeline(product); 
            #endregion

            #region TakeWhile, SkipWhile
            // int [] Numbers = [1, 2, 3, 4, 5, 7 ,6, 9, 2];

            // var Result = Numbers.Where((number) => number % 3 != 0);


            // foreach(var product in Result)
            //  Console.Writeline(product);  
            #endregion
            #endregion

            #region Let / Into


            //// aeiouAEIOU

            //List<string> Names = new List<string>() { "Ahmed", "Mahmoud", "Rana", "Shahd" };

            //var Result = from N in Names
            //             select Regex.Replace(N, "[aeiouAEIOU]", string.Empty);

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

        }
    }
}
