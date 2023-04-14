using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorDp
{
	public class PersonIterator : IIterator
	{
		PersonAggregate aggregate;
		int currentIndex;

		public PersonIterator(PersonAggregate aggregate)
		{
			this.aggregate = aggregate;
		}
		public Person Current()
		{
			return aggregate.GetPerson(currentIndex);
		}

		public bool HasItem()
		{
			if (currentIndex < aggregate.Count)
			{
				return true;
			}
			return false;
		}

		public Person Next()
		{
			if(HasItem())
			{
				return aggregate.GetPerson(currentIndex++);
			}
			return new Person();
		}
	}
}
