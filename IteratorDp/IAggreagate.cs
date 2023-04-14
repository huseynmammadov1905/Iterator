
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorDp
{
	public interface IAggreagate
	{
		IIterator CreateIterator();
	}
}
