using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
	public class FeatureManager : IGenericService<Feature>
	{
		public void TAdd(Feature t)
		{
			throw new NotImplementedException();
		}

		public void TDelete(Feature t)
		{
			throw new NotImplementedException();
		}

		public Feature TGetById(int id)
		{
			throw new NotImplementedException();
		}

		public List<Feature> TGetList(Feature t)
		{
			throw new NotImplementedException();
		}

		public void TUpdate(Feature t)
		{
			throw new NotImplementedException();
		}
	}
}
