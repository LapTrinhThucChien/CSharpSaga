// See https://aka.ms/new-console-template for more information
using LinqDemo;
using System.Collections;

//Linq query data from datasource (collection, entity framework, database, xml...)

////Query syntax linq
//var productEvenIds = from productId in productIds
//                     where productId > 4
//                     select productId; //collection inherit from IEnumerabe interface

//foreach (var productId in productEvenIds)
//{
//    Console.WriteLine("Product Id {0} which is even.", productId);
//}

////Method syntax linq => lambda expression
//var productEvenIds2 = productIds.Where(productId => productId % 2 == 0)
//    .Select(productId => productId); //collection inherit from IEnumerabe interface

//foreach (var productId in productEvenIds2)
//{
//    Console.WriteLine("Product Id {0} which is even.", productId);
//}


//productIds.Count();
//productIds.Average();
//productIds.Max();
//productIds.Min();
//productIds.Sum();

//productIds.First();
//productIds.Last();
//productIds.ToArray();
//productIds.ToList();


//var products = new List<Product>
//{
//    new Product { Id = 3, Name = "Mazda"},
//    new Product { Id = 1, Name = "Honda city"},
//    new Product { Id = 2, Name = "Kia morning"},
//    new Product { Id = 6, Name = "Mescerdes"},
//    new Product { Id = 4, Name = "Lamborgini"},
//}; //List<Product> : IEnumerabel<Product>

////Id = 3 vs 2 best seller
//var bestSellerProducts = products.Where(p => p.Id == 3 || p.Id == 2)
//    .Select(p => new BestSellerProduct
//    {
//        ProductId = p.Id,
//        ProductName = p.Name,
//    }); //collection => IEnumerabel<BestSellerProduct>

//foreach (var product in bestSellerProducts)
//{
//    Console.WriteLine(product.ProductName);
//}

//var nameProductList = products.Select(p => p.Name); //Collection => IEnumerabel<string>
//foreach(var name in nameProductList)
//{
//    Console.WriteLine(name);
//}

//Frist Name, Last name of old object

//new object => Fullname = First Name + ' ' + last Name

//var studentsIdentified = products.Where(product => product.Id == 2)
//    .Select(product => new Product { Id = product.Id, Name = product.Name });

//var selectProductsWithOrderById = products.OrderBy(x => x.Id); //ASC
//foreach(var product in selectProductsWithOrderById)
//{
//    Console.WriteLine($"{product.Name} with id {product.Id}");
//}


//var selectProductsWithOrderByDescendingId = products.OrderByDescending(x => x.Id);
//foreach (var product in selectProductsWithOrderByDescendingId)
//{
//    Console.WriteLine($"{product.Name} with id {product.Id}");
//}

//var productName = products.Where(product => product.Id == 2)
//    .Select(product => product.Name);




//var studentsCityGroupList = studentList.GroupBy(s => s.City).Select(s => new StudentGroup
//{
//    Key = s.Key,
//    Count = s.Count()
//});

//foreach(var studentGroup in studentsCityGroupList)
//{
//    Console.WriteLine($"City: {studentGroup.Key} - Cout: {studentGroup.Count}");
//}
//IEnumerable<IGrouping<string, object>>
//IEnumerable<IGrouping<City, List<Student>>>
/*
 * {
 *      =="CA", {
 *           new Student(),
 *            new Student()
 *      }==> IGrouping <key, List<objecct>>
 *      
 *      =="NYC", {
 *      new Student(),
 *      new Student(),
 *      new Student(),
 *      }==> IGrouping <key, List<objecct>>
 * }
 * 
 * group by sql
 * 
 * */

//foreach (var studentGroup in studentsCityGroupList)
//{
//    Console.WriteLine($"City: {studentGroup.Key}");  //Key - city
//    foreach(var student in studentGroup) //studentGroup: key - List<student>
//    {
//        Console.WriteLine($"Name: {student.StudentName}");
//    }
//}


//var skipStuentsUptoIndexTwo = studentList.Skip(2);
//var takeStudentsUptoIndexTwo = studentList.Take(2);


//var firstStudent = studentList.First(x => x.StudentID % 2 == 0);
//var firstOrDefaultStudent = studentList.FirstOrDefault(x => x.StudentID == 1);
//var singleStudent = studentList.Single(x => x.StudentID == 1);
//var singleOrDefaultStudent = studentList.SingleOrDefault(x => x.StudentID == 1);


var studentList = new[] {
        new Student() { StudentID = 1, StudentName = "John Nigel", Mark = 73, City ="NYC"} ,
        new Student() { StudentID = 2, StudentName = "Alex Roma",  Mark = 49 , City ="CA"} ,
        new Student() { StudentID = 3, StudentName = "Noha Shamil",  Mark = 80 , City ="CA"} ,
        new Student() { StudentID = 4, StudentName = "James Palatte" , Mark = 60, City ="NYC"} ,
        new Student() { StudentID = 5, StudentName = "Ron Jenova" , Mark = 80 , City ="NYC"}
    };


var students = studentList.Where(s => s.City == "CA").Select(s => s.StudentName).ToList(); //IEnumerabel<string>
//=> List<string> Array[string]


Console.WriteLine(students[0]);

//page 1: 2
//page 2: 2
//page 3: 1

//5 elements
//page: 2 elements
//Amount of page: 5/2 + 1 = 3page

//var studentListPage1 = studentList.Take(2);
//Console.WriteLine("Page 1");
//foreach(var student in studentListPage1)
//{
//    Console.WriteLine(student.StudentName);
//}   


//var studentListPage2 = studentList.Skip(2).Take(2);
//Console.WriteLine("Page 2");
//foreach (var student in studentListPage2)
//{
//    Console.WriteLine(student.StudentName);
//}

//var studentListPage3 = studentList.Skip(4).Take(1);
//Console.WriteLine("Page 3");
//foreach (var student in studentListPage3)
//{
//    Console.WriteLine(student.StudentName);
//}



//var students = studentList.Where(s => s.Mark == 80).Select(s => s.StudentName);// IEnumerable<string>

//var fristStudent = studentList.First(s => s.Mark == 80); //student . Exception if not found select top 1
//Console.WriteLine($"Frist: {fristStudent.StudentName}");

//var fristOrDefaultStudent = studentList.FirstOrDefault(s => s.Mark == 81); //student null
//if(fristOrDefaultStudent != null)
//    Console.WriteLine($"Frist or default: {fristOrDefaultStudent.StudentName}");
//else
//    Console.WriteLine($"Frist or default: null");

//var productIds = new int[6] { 1, 2, 3, 9, 4, 7 };
//var singleOrDefaultProductId = productIds.SingleOrDefault(p => p %2 == 0); // default of int 0
//Console.WriteLine(singleOrDefaultProductId);




//var hasAllStudentsPassed = studentList.All(x => x.Mark > 50);
//if (hasAllStudentsPassed)
//    Console.WriteLine("All student Passed");
//else
//    Console.WriteLine("Some students Failed");

//var hasAnyStudentHighScore = studentList.Any(x => x.Mark > 80);
//if (hasAnyStudentHighScore)
//    Console.WriteLine("Having hight score");
//else
//    Console.WriteLine("Not found student having hight score");


//var studentListGroupByCity = studentList.GroupBy(x => x.City);


Console.ReadLine();
