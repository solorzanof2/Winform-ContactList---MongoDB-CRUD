using MongoDB.Bson;
using System;

namespace ContactList
{
	public class Contact
	{

		private ObjectId _id;
		private string _name;
		private string _email;
		private string _phone;
		private DateTime _birth;

		public ObjectId Id
		{
			get
			{
				return _id;
			}
			set
			{
				_id = value;
			}
		}
		public string Name
		{
			get
			{
				return _name;
			}
			set
			{
				_name = value;
			}
		}
		public string Email
		{
			get
			{
				return _email;
			}
			set
			{
				_email = value;
			}
		}
		public string Phone
		{
			get
			{
				return _phone;
			}
			set
			{
				_phone = value;
			}
		}
		public DateTime Birth
		{
			get
			{
				return _birth;
			}
			set
			{
				_birth = value;
			}
		}

		public Contact()
		{
			_name = "0";
			_email = "0";
			_phone = "0";
			_birth = new DateTime();
		}

		public Contact(bool isEmpty)
		{
			_name = "";
			_email = "";
			_phone = "";
			_birth = new DateTime();
		}

	}
}
