using System.ComponentModel.DataAnnotations;

namespace CleanArchitecture
{
    static class Util
    {
        public static bool EmailIsValid(string email)
        {
            return new EmailAddressAttribute().IsValid(email);
        }
    }
}
