using TestsUnitairesCSharp092024;

namespace TestsUnitairesCSharp072024.UnitTests
{
    [TestClass]
    public class PasswordVerification_UnitTests
    {
        [TestMethod]
        public void Password_ShouldBeStrong()
        {
            string passwordStrong = "hspsdf skjsdh fkdsjhf dskjfh sdkfjfsfd";
            bool IsOKStrong = PasswordVerificator.IsPasswordOk(passwordStrong);

            Assert.IsTrue(IsOKStrong, "Le mot de passe n'est pas fort, alors qu'il devrait");
        }

        [TestMethod]
        public void Password_ShouldBeWeak()
        {
            string passwordStrong = "hspsdf";
            bool IsOKStrong = PasswordVerificator.IsPasswordOk(passwordStrong);

            Assert.IsFalse(IsOKStrong, "Le mot de passe est fort, alors qu'il ne devrait pas");
        }
    }
}