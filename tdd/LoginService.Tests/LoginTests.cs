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
		public void Check_ReturnSuccess()
		{
			//Arrange
			var login = new Login("test2048");

			//Act
			var code = login.Check();

			//Assert
			Assert.AreEqual(CheckCode.Success, code);
		}

		[Test]
		public void Check_ReturnEmpty()
		{
			//Arrange
			var login = new Login("");

			//Act
			var code = login.Check();

			//Assert
			Assert.AreEqual(CheckCode.Empty, code);
		}

		[Test]
		public void Check_ReturnTooShort()
		{
			//Arrange
			var login = new Login("t11");

			//Act
			var code = login.Check();

			//Assert
			Assert.AreEqual(CheckCode.TooShort, code);
		}

		[Test]
		public void Check_ReturnTooLong()
		{
			//Arrange
			var login = new Login("testtesttesttest");

			//Act
			var code = login.Check();

			//Assert
			Assert.AreEqual(CheckCode.TooLong, code);
		}
	}
}
