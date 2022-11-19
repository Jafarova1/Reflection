
using Indexer_Reflection.Models;
using Indexer_Reflexion.Controllers;
using Indexer_Reflexion.Models;
using Indexer_Reflexion.Service;
using Indexer_Reflexion.Service.Interface;
using System.Reflection;

//PersonController.GetFullDatas();
//BookController.GetCount();

//EmployeeController.GetEmployeesSalaryAverage();

//Console.WriteLine(GetBook());
//static Book  GetBook()
//{
//    Book book= new Book { Name="Xosrov",Author="Nizami"};

//    return book;
//}

//PersonController.GetFilteredPersonPowCount();


//Person person1 = new();
//person1.Age = 18;
//Person person2 = new();
//person2.Age = 28;


//Console.WriteLine(person1>person2);


//List<int> nums = new List<int>() { 1, 2, 3, 5 };
//Console.WriteLine(nums[1]);

//Book book1 = new Book { Name = "Xosrov1", Author = "Nizami1" };
//Book book2 = new Book { Name = "Xosrov2", Author = "Nizami2" };
//Book book3 = new Book { Name = "Xosrov3", Author = "Nizami3" };

//Library library = new();
//library[0]=book1;
//library[1] = book2;
//library[2] = book3;

//Console.WriteLine(library[0].Name + "-" + library[0].Author);
//Console.WriteLine(library[1].Name + "-" + library[1].Author);
//Console.WriteLine(library[2].Name + "-" + library[2].Author);


Assembly assembly =Assembly.GetExecutingAssembly();
foreach (var item in assembly.GetTypes())
{
	foreach (var item2 in item.GetMembers())
	{
		Console.WriteLine(item2);
	}
}
















