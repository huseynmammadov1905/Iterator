using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorDp
{
	public interface IIterator
	{
		bool HasItem();
		Person Next();

		Person Current();
	}
}
