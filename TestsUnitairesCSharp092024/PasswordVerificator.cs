using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestsUnitairesCSharp092024
{
    public static class PasswordVerificator
    {
        public static bool IsPasswordOk(string password)
        {
            if (password == null)
            {
                return false;
            }
            else
            {
                if (password.Length > 16)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
