using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestsUnitairesCSharp092024
{
    public static class PasswordVerificator
    {
        private static string allNumerics = "0123456789";
		private static string charsMAJ = "AZERTYUIOPQSDFGHJKLMWXCVBN";
		private static string charsMIN = "azertyuiopqsdfghjklmwxcvbn";
		private static string specialChars = "!@#$%^&*()-_+=[]{}\\|;:'\",.<>/?`~¡¿¢£€¥©®™§°µ±×÷¶†‡";

		public static PasswordStrength IsPasswordOk(string password)
        {
            int securityPoints = 0;
            securityPoints += (password.Length*2);

            //Vérifier la présence des éléments suivants : MAJ, MIN, SpecialChars, Numerics
            bool haveNumerics = IsStringContainsOneOfThisString(password, allNumerics);
            bool haveMAJ = IsStringContainsOneOfThisString(password, charsMAJ);
            bool haveMIN = IsStringContainsOneOfThisString(password, charsMIN);
            bool haveSpecial = IsStringContainsOneOfThisString(password, specialChars);     

            if (haveNumerics)
			{
                securityPoints += 10;
            }
			if (haveMAJ)
			{
				securityPoints += 10;
			}
			if (haveMIN)
			{
				securityPoints += 10;
			}
			if (haveSpecial)
			{
				securityPoints += 20;
			}

			/*
				80 et + -> Incassable
				60 et 79 -> Strong
				40 et 59 -> Medium
				0 et 39 -> Weak
			*/
			switch (securityPoints)
			{
				case >= 80:
					return PasswordStrength.Unbreakable;
				case >= 60:
					return PasswordStrength.Strong;
				case >= 40:
					return PasswordStrength.Medium;
				default:
					return PasswordStrength.Weak;
			}
			
        }

        private static bool IsStringContainsOneOfThisString(string password, string TestingString)
        {
			bool passwordContainsElement = password.Any(character => TestingString.Contains(character));
            return passwordContainsElement;
		}
    }

    public enum PasswordStrength
	{
		Weak,
		Medium,
		Strong,
        Unbreakable
	}
}
