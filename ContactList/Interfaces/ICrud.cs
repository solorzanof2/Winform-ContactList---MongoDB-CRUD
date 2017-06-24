using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactList.Interfaces
{
	public interface ICrud
	{

		void CreateContact(Contact data);
		void ReadContacts();
		long UpdateContact();
		long DeleteContact(string id);

	}
}
