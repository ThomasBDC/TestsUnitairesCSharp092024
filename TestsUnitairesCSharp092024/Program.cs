// See https://aka.ms/new-console-template for more information

using TestsUnitairesCSharp092024;

Console.WriteLine("Bienvenue dans mon application de vérification de mot de passe");

Test_IsPasswordOk();
void Test_IsPasswordOk()
{
    string passwordStrong = "blablabladpis fhpdiof hspfsfd";
    string passwordWeak = "bla";
    bool IsOKStrong = PasswordVerificator.IsPasswordOk(passwordStrong);
    if (IsOKStrong)
    {
        Console.WriteLine("Le test fonctionne");
    }
    else
    {
        Console.WriteLine("Le test ne fonctionne pas");
    }

    bool IsOKWeak = PasswordVerificator.IsPasswordOk(passwordWeak);
    if (IsOKWeak == false)
    {
        Console.WriteLine("Le test fonctionne");
    }
    else
    {
        Console.WriteLine("Le test ne fonctionne pas");
    }

}
