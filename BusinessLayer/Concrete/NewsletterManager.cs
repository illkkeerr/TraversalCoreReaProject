using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
	public class NewsletterManager : IGenericService<Newsletter>
	{
		public Newsletter TGetById(int id)
		{
			throw new NotImplementedException();
		}

		public void TAdd(Newsletter t)
		{
			throw new NotImplementedException();
		}

		public void TDelete(Newsletter t)
		{
			throw new NotImplementedException();
		}

		public List<Newsletter> TGetList(Newsletter t)
		{
			throw new NotImplementedException();
		}

		public void TUpdate(Newsletter t)
		{
			throw new NotImplementedException();
		}
	}
}
