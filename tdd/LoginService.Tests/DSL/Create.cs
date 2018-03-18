using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginService.Tests.DSL
{
	public static class Create
	{
		public static LoginFather Login()
		{
			return new LoginFather();
		}
	}
}
