using System;

namespace ContactList.Exceptions
{
	public class EmptyFieldException : Exception
	{

		public EmptyFieldException() { }

		public EmptyFieldException(string message) : base(message) { }

	}
}
