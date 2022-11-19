using System.ComponentModel;
using Task1.Models;

List<Library> library = new List<Library>();
Library library1 = new Library { Name = "C#-n esaslari" };
Library library2 = new Library { Name = "Python-un esaslari" };
Library library3 = new Library { Name = "SQL-in esaslari" };

library.Add(library1);
library.Add(library2);
library.Add(library3);


List<Book> books = new List<Book>();
Book book1 = new Book { Name = "C#" };
Book book2 = new Book { Name = "Python" };
Book book3 = new Book { Name = "SQL" };
books.Add(book1);
books.Add(book2);
books.Add(book3);

library1.Add(book1);
library2.Add(book2);
library3.Add(book3);
foreach (var item in library)
{
	foreach (var item1 in books)
	{
		Console.WriteLine(item1.Name);
	}
}










