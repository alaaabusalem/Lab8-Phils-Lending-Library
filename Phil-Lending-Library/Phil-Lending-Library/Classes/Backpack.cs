using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Phil_Lending_Library.Interfaces;

namespace Phil_Lending_Library.Classes
{
	public class Backpack<T> : IBag<T>
	{

		private List<T> Items;
		
        public Backpack()
		{
			Items=new List<T>();

		}
		public IEnumerator<T> GetEnumerator()
		{
			foreach(var item in Items)
			{
				yield return item;
			}
		}

		public void Pack(T item)
		{
			Items.Add(item);
		}

		public T Unpack(int index)
		{
			if(index< Items.Count && index>=0)
			{
			var item = Items[index];
				Items.RemoveAt(index);
				return item;
			}
			return default(T);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			foreach (var item in Items)
			{
				yield return item;
			}
		}

		
	}
}
