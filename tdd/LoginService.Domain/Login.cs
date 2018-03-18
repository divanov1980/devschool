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
			return CheckCode.Success;
		}
	}
}
