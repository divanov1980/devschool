using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginService.Domain
{
	public enum CheckCode
	{
		Unknown=0,
		Success =1,
		TooLong =2,
		TooShort =3,
		Empty =4,
		InvalidCharacters = 5
	}
}
