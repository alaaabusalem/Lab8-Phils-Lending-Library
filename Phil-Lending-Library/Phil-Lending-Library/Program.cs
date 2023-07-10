using Phil_Lending_Library.Classes;

namespace Phil_Lending_Library
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Book newBook=new Book() { FirstName="Book6",LastName="A",NumOfPages=77};	

       // Testing branch C
			Library AlaaLibrary = new Library();
			AlaaLibrary.Add("Book1","A","A",50);
			AlaaLibrary.Add("Book2", "A", "A", 50);
			AlaaLibrary.Add("Book3", "A", "A", 50);
			AlaaLibrary.Add("Book4", "A", "A", 50);
			AlaaLibrary.Add("Book5", "A", "A", 50);
         Backpack<Book> myBackpack= new Backpack<Book>();	

			string process = "";
			while(process != "3")
			{
				Console.WriteLine("Enter the number of Process you want:\n1. Borrow a book and Pack it to your E-Backpack\n2. Unpack a book and Return it to the Library\n3. exit");
				process=Console.ReadLine();
				if(process == "1")
				{
					Console.WriteLine("Enter the name of Book you want to borrow:");
					string title = Console.ReadLine();
					Book book=AlaaLibrary.Borrow(title);
					if (book == null) { Console.WriteLine("the book title does't exist my it borrowed right now"); }
					else { myBackpack.Pack(book);
						Console.WriteLine($"book {book.Title} is now in your E-Backpack.");
					}	
				}

				if(process == "2") { 
				Console.WriteLine("Enter the the Index of book you want to return");
				 string index=Console.ReadLine();
				 Book book=	myBackpack.Unpack(Int32.Parse(index));
					if (book == null) { Console.WriteLine("this book does't exist in you E-Backpack"); }
					else
					{
						AlaaLibrary.Return(book);
						Console.WriteLine("the book is Unpacked and returned to the Library");
					}
				}

			}

		}
	}
}