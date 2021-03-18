using PA.Core.Domain.Entities;
using System;
using Xunit;

namespace PA.XUnit.Test.Core
{
    public class UnitTestPasswordValidator
    {
        readonly PasswordValidator _passwordValidator;

        [Theory]
        [InlineData("", false)]
        [InlineData("aa", false)]
        [InlineData("ab", false)]
        [InlineData("AAAbbbCc!", false)]
        [InlineData("AbTp9!foo", false)]
        [InlineData("AbTp9!foA", false)]
        [InlineData("AbTp9 fok", false)]
        [InlineData("AbTp9!fokA", false)]
        [InlineData("AbTp9!fok", true)]
        public void ValidatePassword(string password, bool expectedResult)
        {
            
            var passwordValidator = new PasswordValidator(password);

         
            bool result = passwordValidator.PasswordIsValid();

         
            Assert.Equal(expectedResult, result);
        }
    }
}
