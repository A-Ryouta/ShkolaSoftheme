using System;
using System.ComponentModel.DataAnnotations;

namespace MobileOperator
{
    public class AccountValidationAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            var account = value as MobileAccount;

            if (account != null
                && (account.BirthDate >= new DateTime(2005, 01, 01) || account.BirthDate <= new DateTime(1900, 01, 01)))
            {
                ErrorMessage = "You`re too young or probably dead";
                return false;
            }

            return true;
        }
    }
}
