using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
	public class GuideManager : IGenericService<Guide>
	{
		public Guide TGetById(int id)
		{
			throw new NotImplementedException();
		}

		public void TAdd(Guide t)
		{
			throw new NotImplementedException();
		}

		public void TDelete(Guide t)
		{
			throw new NotImplementedException();
		}

		public List<Guide> TGetList()
		{
			throw new NotImplementedException();
		}

		public void TUpdate(Guide t)
		{
			throw new NotImplementedException();
		}
	}
}
