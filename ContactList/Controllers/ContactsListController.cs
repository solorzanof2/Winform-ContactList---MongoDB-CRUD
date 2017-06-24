using ContactList.Interfaces;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactList.Controllers
{
	public class ContactsListController : ICrud
	{

		private const string DATABASE = "ContactsDB";
		private const string COLLECTION = "List";
		private string _connectionString = "mongodb://localhost";
		private MongoClient _client;
		private IMongoDatabase _db;

		private string _currentId;

		private IMongoCollection<Contact> _contactList;
		private List<Contact> _listOfContacts;

		private Contact _currentContact;

		public string CurrentId
		{
			get
			{
				return _currentId;
			}
			set
			{
				if (value.Equals("0"))
				{
					_currentId = value;
					_currentContact = new Contact();
				}
				else
				{
					_currentId = value;
					_currentContact = _contactList.Find(c => c.Id.Equals(ObjectId.Parse(_currentId))).FirstOrDefault();
				}
			}
		}
		public IMongoCollection<Contact> ContactList
		{
			get
			{
				return _contactList;
			}
			set
			{
				_contactList = value;
			}
		}
		public List<Contact> ListOfContacts
		{
			get
			{
				return _listOfContacts;
			}
		}
		public Contact CurrentContact
		{
			get
			{
				return _currentContact;
			}
			set
			{
				_currentContact = value;
			}
		}

		public ContactsListController()
		{
			_currentId = "0";
			_listOfContacts = new List<Contact>();
			_currentContact = new Contact();

			_client = new MongoClient(_connectionString);
			_db = _client.GetDatabase(DATABASE);
		}

		public void CreateContact(Contact data)
		{
			_contactList.InsertOne(data);
			UpdateList();
		}

		public long DeleteContact(string id)
		{
			var oid = ObjectId.Parse(id);
			var result = _contactList.DeleteOne(c => c.Id.Equals(oid));
			if (result.DeletedCount.Equals(1))
			{
				UpdateList();
			}
			return result.DeletedCount;
		}

		public void ReadContacts()
		{
			_contactList = _db.GetCollection<Contact>(DATABASE);
			UpdateList();
		}

		public long UpdateContact()
		{
			var result = _contactList.ReplaceOne(c => c.Id.Equals(_currentContact.Id), _currentContact);
			UpdateList();
			return result.ModifiedCount;
		}

		private void UpdateList()
		{
			var list = _contactList.Find(Builders<Contact>.Filter.Empty).ToListAsync();
			_listOfContacts = list.Result;
		}
	}
}
