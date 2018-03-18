using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

			var checkLength= CheckLength();
			if (checkLength != CheckCode.Success)
			{
				return checkLength;
			}

			if (!IsValidSymbols())
			{
				return CheckCode.InvalidSymbols;
			}

			return CheckCode.Success;
		}

		private bool IsValidSymbols()
		{
			var regex = new Regex("^[A-Za-z0-9]+$");
			return regex.IsMatch(_login);
				
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
