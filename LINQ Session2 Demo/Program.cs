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
        }
    }
}
