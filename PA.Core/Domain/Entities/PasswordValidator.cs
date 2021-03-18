using System.Linq;
using System.Text.RegularExpressions;

namespace PA.Core.Domain.Entities
{
    public class PasswordValidator
    {
        private const int LENGTH = 9;

        private const string INVALID_CHAR = @"`´{[}]~ç?/|\.,<>:;?_=§ªº°";

        private const string REGEX_STRING = "[^ A-Za-z0-9]";

        public PasswordValidator(string password)
        {
            Password = password;
        }

        public string Password { get; private set; }

        public bool PasswordIsValid()
        {
            var valid = true;

            var invalid = false;

            if (Check())
            {
                return valid;
            }

            return invalid;
        }

        private bool Check()
        {
            Regex rgxCharactersEspecial = new Regex(REGEX_STRING);

            return Password.Length >= LENGTH
                && Password.Any(char.IsLower)
                && Password.Any(char.IsDigit)
                && Password.Any(char.IsUpper)
                && rgxCharactersEspecial.IsMatch(Password)
                && !Password.Any(char.IsWhiteSpace)
                && !Password.Any(a => Password.Where(b => char.ToUpper(a) == char.ToUpper(b)).Count() > 1)
                && !Password.Any(c => INVALID_CHAR.Contains(c));
        }

    }
}
