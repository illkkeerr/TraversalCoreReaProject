using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
	public class DestinationManager : IGenericService<Destination>
	{
		public Destination TGetById(int id)
		{
			throw new NotImplementedException();
		}

		public void TAdd(Destination t)
		{
			throw new NotImplementedException();
		}

		public void TDelete(Destination t)
		{
			throw new NotImplementedException();
		}

		public List<Destination> TGetList(Destination t)
		{
			throw new NotImplementedException();
		}

		public void TUpdate(Destination t)
		{
			throw new NotImplementedException();
		}
	}
}
