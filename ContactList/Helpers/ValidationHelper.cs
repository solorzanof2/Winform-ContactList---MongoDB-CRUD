using ContactList.Enums;
using System.Text.RegularExpressions;

namespace ContactList.Helpers
{
	public static class ValidationHelper
	{

		public static EmailVerification VerifyEmail(string email)
		{
			//LightCoral
			EmailVerification response = EmailVerification.None;
			if (!string.IsNullOrWhiteSpace(email))
			{
				Regex reg = new Regex(@"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*");
				response = (reg.IsMatch(email))
					? EmailVerification.True
					: EmailVerification.False;
			}
			return response;
		}

	}
}
