namespace Task29_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //dbContext.Categories.Add(new Models.Category() { CategoryName = "New Category From C# " });
            //dbContext.Categories.Update(new Models.Category() { CategoryId = 12, CategoryName = "UPDATED 2 USING C# " });
            //dbContext.Categories.Remove(new Models.Category() { CategoryId = 12 });
            //dbContext.SaveChanges(); 





            //var Staffs = dbContext.Staffs.ToList();
            //foreach (var item in Staffs)
            //{
            //    Console.WriteLine($"Id : {item.StaffId}, Name: {item.FirstName + " " + item.LastName}");
            //}

            //var Staffs = dbContext.Staffs.OrderBy(e=>e.FirstName).ThenBy(e=>e.LastName).ToList();
            //foreach (var item in Staffs)
            //{
            //    Console.WriteLine($"Id : {item.StaffId}, Name: {item.FirstName + " " + item.LastName}");
            //}

            //var Staffs = dbContext.Staffs.Where(e=>e.StaffId>=5).OrderBy(e => e.StaffId).ToList();
            //foreach (var item in Staffs)
            //{
            //    Console.WriteLine($"Id : {item.StaffId}, Name: {item.FirstName + " " + item.LastName}");
            //}

            //var Staffs = dbContext.Staffs.Where(e => e.FirstName.Contains("o")).OrderBy(e => e.StaffId).ToList();
            //foreach (var item in Staffs)
            //{
            //    Console.WriteLine($"Id : {item.StaffId}, Name: {item.FirstName + " " + item.LastName}");
            //}






            //var staff = dbContext.Staffs.AsNoTracking().FirstOrDefault(e => e.StaffId == 1);

            //staff.FirstName = "Osama111";
            //staff.LastName = "Shaaban111";
            //dbContext.SaveChanges();

            //Console.WriteLine($"Id : {staff.StaffId} , Name : {staff.FirstName + " " + staff.LastName} ");



            //var count1 = dbContext.Products.Count(e);
            //var count2 = dbContext.Products.Count(e => e.ModelYear == 2016);
            //var min = dbContext.Products.Min(e=>e.ListPrice);
            //var max = dbContext.Products.Max(e => e.ListPrice);
            //var average = dbContext.Products.Average(e => e.ListPrice);
            //var sum = dbContext.Products.Sum(e => e.ListPrice);
            //Console.WriteLine(count1);
            //Console.WriteLine(count2);
            //Console.WriteLine(min);
            //Console.WriteLine(max);
            //Console.WriteLine(average);
            //Console.WriteLine(sum);




            //var CustomerState = dbContext.Customers.GroupBy(e => e.State).Select(e => new {

            //    StateName = e.Key,
            //    count = e.Count() 

            //});

            //foreach (var item in CustomerState)
            //{
            //    Console.WriteLine($"State Name : {item.StateName} count : {item.count}");
            //}




            //var ProductJoinWithCategory = dbContext.Products.Include(p => p.Category).Select(e => new{
            //    e.ProductName,
            //    e.Category.CategoryName
            //});

            //var ProductJoinWithCategory = dbContext.Products.ToList();

            //foreach (var item in ProductJoinWithCategory)
            //{
            //    Console.WriteLine($"ProductName : {item.ProductName} --> Category : {item.CategoryName}");
            //}




        }
    }
}
