using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginService.Domain
{
    public class Login
    {
		private string _login;

		public Login(string login)
		{
			_login = login;
		}

		public CheckCode Check()
		{
			if (string.IsNullOrEmpty(_login))
			{
				return CheckCode.Empty;
			}

			return CheckLength();
		}

		private CheckCode CheckLength()
		{
			if (_login.Length < 4)
			{
				return CheckCode.TooShort;
			}

			if (_login.Length > 8)
			{
				return CheckCode.TooLong;
			}

			return CheckCode.Success;
		}
	}
}
