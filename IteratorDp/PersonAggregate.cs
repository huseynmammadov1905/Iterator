using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorDp
{
	public class PersonAggregate : IAggreagate
	{
		List<Person> persons = new();


		public void Add(Person person)
		{
			persons.Add(person);
		}

		public Person GetPerson(int id)
		{
			return persons[id];
		}
		public int Count { get { return persons.Count; } }
		public IIterator CreateIterator()
		{
		return	new PersonIterator(this);
		}
	}
}
