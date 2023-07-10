using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Phil_Lending_Library.Interfaces;

namespace Phil_Lending_Library.Classes
{
	public class Library : ILibrary
	{
		//List<Book> Books = new List<Book>();
		private Dictionary<string, Book> Books;

		public int Count { get; }

		public Library() {

			Books = new Dictionary<string, Book>();
		}	
		public void Add(string title, string firstName, string lastName, int numberOfPages)
		{
			Books.Add(title,new Book(title,firstName, lastName, numberOfPages));
			
			
			
		}

		public Book Borrow(string title)
		{
			if (Books.Count == 0) return null;
			foreach(var item in Books.Keys)
			{
				if (item==title)
				{
					
					Book book = Books[item];
					Books.Remove(item);	
					return book;
				}
			}
			return null;
		}

		public IEnumerator<Book> GetEnumerator()
		{
			
			foreach (var item in Books.Keys)
			{

				yield return Books[item];
			}
		}
		IEnumerator IEnumerable.GetEnumerator()
		{
			foreach (var item in Books.Keys)
			{

				yield return Books[item];
			}
		}
		public void Return(Book book)
		{
			foreach (var item in Books.Keys)
			{
				if (item == book.Title)
				{

					break;
				}
			}
			Books.Add(book.Title,book);

		}

		

		public int GetCountOfBooks()
		{
			return Books.Count;	
		}
	}
}
