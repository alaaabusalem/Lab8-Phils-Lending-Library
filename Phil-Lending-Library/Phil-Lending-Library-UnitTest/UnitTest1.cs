using System.Collections.Generic;
using Phil_Lending_Library.Classes;
using Phil_Lending_Library.Interfaces;

namespace Phil_Lending_Library_UnitTest
{
	public class UnitTest1
	{
		[Fact]
		void AddBookToLibraryTest()
		{
			// Arrange
			Library AlaaLibrary = new Library();
			AlaaLibrary.Add("Book1", "A", "A", 50);
			AlaaLibrary.Add("Book2", "A", "A", 50);
			AlaaLibrary.Add("Book3", "A", "A", 50);
			// Act
			int count = AlaaLibrary.GetCountOfBooks();
			// Assert
			Assert.Equal(3, count);
		}

		[Fact]
		void BorrowingBookFromLibraryTest()
		{
			// Arrange
			Library AlaaLibrary = new Library();
			AlaaLibrary.Add("Book1", "A", "A", 50);
			AlaaLibrary.Add("Book2", "A", "A", 50);
			AlaaLibrary.Add("Book3", "A", "A", 50);
			// Act
			Book book =AlaaLibrary.Borrow("Book3");
			 

			// Assert
			Assert.DoesNotContain(book, AlaaLibrary);
		}

		[Fact]
		void BorrowingMissingTitleTest()
		{
			// Arrange
			Library AlaaLibrary = new Library();
			AlaaLibrary.Add("Book1", "A", "A", 50);
			AlaaLibrary.Add("Book2", "A", "A", 50);
			AlaaLibrary.Add("Book3", "A", "A", 50);
			// Act
			Book book=AlaaLibrary.Borrow("Book5");
			// Assert
			Assert.Equal(null, book);
		}

		[Fact]
		void ReturnedBookAgainInTheLibraryTest()
		{
			// Arrange
			Library AlaaLibrary = new Library();
			AlaaLibrary.Add("Book1", "A", "A", 50);
			AlaaLibrary.Add("Book2", "A", "A", 50);
			AlaaLibrary.Add("Book3", "A", "A", 50);
			// Act
			Book book = AlaaLibrary.Borrow("Book3");
			AlaaLibrary.Return(book);
			// Assert
			Assert.Contains(book, AlaaLibrary);
		}

		[Fact]
		void BackpackPackTest()
		{
			// Arrange
			Backpack<int> backpack= new Backpack<int>();
			backpack.Pack(1);
			backpack.Pack(2);
			backpack.Pack(3);
			// Act
			
			// Assert
			Assert.Contains(3, backpack);
		}

		[Fact]
		void BackpackUnPackTest()
		{
			// Arrange
			Backpack<int> backpack = new Backpack<int>();
			backpack.Pack(1);
			backpack.Pack(2);
			backpack.Pack(3);
			// Act
			int returend = backpack.Unpack(2);
			// Assert
			Assert.DoesNotContain(returend, backpack);
		}

	}
}