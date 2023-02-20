using MlkPwgen;

namespace MyBank.Utils
{
    public class AccountNumberGenerator
    {
        public static string Generate(int length = 30)
        {
            return "U-A" + PasswordGenerator.Generate(length, Sets.Upper);
        }
    }
}
