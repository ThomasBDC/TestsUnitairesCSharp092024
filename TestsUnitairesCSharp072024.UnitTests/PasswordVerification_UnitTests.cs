using TestsUnitairesCSharp092024;

namespace TestsUnitairesCSharp072024.UnitTests
{
	[TestClass]
	public class PasswordVerification_UnitTests
	{
		[TestMethod]
		public void Password_ShouldBeUnBreakable()
		{
			string passwordStrong = "oKIA*e3Xv_8J@QE";
			PasswordStrength strengthPassword = PasswordVerificator.IsPasswordOk(passwordStrong);
			PasswordStrength expected = PasswordStrength.Unbreakable;
			Assert.AreEqual(expected, strengthPassword, $"Le mot de passe est {strengthPassword}, alors qu'il devrait être {expected}");
		}

		[TestMethod]
		public void Password_ShouldBeStrong()
		{
			string passwordStrong = "L}]#F%M=C%>@G`%";
			PasswordStrength strengthPassword = PasswordVerificator.IsPasswordOk(passwordStrong);

			PasswordStrength expected = PasswordStrength.Strong;
			Assert.AreEqual(expected, strengthPassword, $"Le mot de passe est {strengthPassword}, alors qu'il devrait être {expected}");
		}

		[TestMethod]
		public void Password_ShouldBeMedium()
		{
			string passwordStrong = "nE1K1Xiy5l";
			PasswordStrength strengthPassword = PasswordVerificator.IsPasswordOk(passwordStrong);

			PasswordStrength expected = PasswordStrength.Medium;
			Assert.AreEqual(expected, strengthPassword, $"Le mot de passe est {strengthPassword}, alors qu'il devrait être {expected}");

		}
		[TestMethod]
		public void Password_ShouldBeWeak()
		{
			string passwordStrong = "OHAXTn";
			PasswordStrength strengthPassword = PasswordVerificator.IsPasswordOk(passwordStrong);

			PasswordStrength expected = PasswordStrength.Weak;
			Assert.AreEqual(expected, strengthPassword, $"Le mot de passe est {strengthPassword}, alors qu'il devrait être {expected}");

		}
	}
}