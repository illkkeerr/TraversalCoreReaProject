﻿using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
	public class ContactManager : IContactService
	{
		public Contact TGetById(int id)
		{
			throw new NotImplementedException();
		}

		public void TAdd(Contact t)
		{
			throw new NotImplementedException();
		}

		public void TDelete(Contact t)
		{
			throw new NotImplementedException();
		}

		public List<Contact> TGetList()
		{
			throw new NotImplementedException();
		}

		public void TUpdate(Contact t)
		{
			throw new NotImplementedException();
		}
	}
}
