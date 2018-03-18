using LoginService.Domain;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginService.Tests
{
	[TestFixture]
	public class LoginTests
    {
		[Test]
		public void Check_Success()
		{
			//Arrange
			var login = new Login("test2048");

			//Act
			var code = login.Check();

			//Assert
			Assert.AreEqual(CheckCode.Success, code);
		}
    }
}
