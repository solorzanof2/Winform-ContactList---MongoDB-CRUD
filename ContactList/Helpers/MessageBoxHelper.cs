namespace ContactList.Helpers
{
	public static class MessageBoxHelper
	{

		public const string ERROR_TITLE = "ContactList | Error Message";
		public const string WARNING_TITLE = "ContactList | Warning Message";
		public const string QUESTION_TITLE = "ContactList | Question Message";

		public const string INSERT_CANCEL_QUESTION_MESSAGE = "Do you confirm that do you want to cancel the current insertion?";
		public const string UPDATE_CANCEL_QUESTION_MESSAGE = "Do you confirm that do you want to cancel the current update";
		public const string QUESTION_MESSAGE = "Are you sure that do you want to remove the contact {0} from the list?";

		public const string EXCEPTION_WRONG_EMAIL = "The email {0} is not valid, please check it and try again";

		public const string EXCEPTION_EMPTY_FIELD = "The field {0} cannot be empty";

		public const string EXCEPTION_CONTACT_REMOVE = "An error occurred while trying to remove the contact {0} from the list";

		public const string EXCEPTION_CREATE_CONTACT = "An error occurred while trying to insert the contact {0} into the database";
		public const string EXCEPTION_READ_COLLECTION = "An error occurred while trying to read the contacts collection from database";
		public const string EXCEPTION_UPDATE_CONTACT = "An error occurred while trying to update the contact {0} into the database collection";
		public const string EXCEPTION_DELETE_CONTACT = "An error occurred while trying to delete the contact {0} from the database collection";

	}
}
