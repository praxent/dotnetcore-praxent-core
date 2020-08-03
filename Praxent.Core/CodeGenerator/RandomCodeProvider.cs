using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace Praxent.Core.CodeGenerator
{
    public class RandomCodeProvider : IRandomCodeProvider
    {
        // TODO: Build stronger string generator
        public string Generate(int length)
        {
            var chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890_-".ToCharArray();
            var data = new byte[length];
            using (var crypto = new RNGCryptoServiceProvider())
            {
                crypto.GetBytes(data);
            }
            var result = new StringBuilder(length);
            foreach (var byteSample in data)
            {
                result.Append(chars[byteSample % (chars.Length)]);
            }

            // Security fix: Identity checks for lowercase, uppercase and digit combination by default for password strength
            var str = result.ToString();
            var strengthCheck = str.Any(char.IsLower) && str.Any(char.IsUpper) && str.Any(char.IsDigit);
            // TODO: Escape potential Infinite Recursion here.
            if (!strengthCheck)
            {
                str = Generate(length);
            }

            return str;
        }
    }
}