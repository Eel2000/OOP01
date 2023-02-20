using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBank.Utils
{
    public class Cryptor
    {
        /// <summary>
        /// Crypte the given password (string) into a base 64 format string.
        /// </summary>
        /// <param name="password"></param>
        /// <returns>crypted password</returns>
        public static string EncryptPassword(string password)
        {
            var bytes = Encoding.UTF8.GetBytes(password);
            var cryptedPwd = Convert.ToBase64String(bytes);

            return cryptedPwd;
        }

        /// <summary>
        /// Decrypt the given passowrd(encrypted).
        /// </summary>
        /// <param name="password"></param>
        /// <returns>string the original string.</returns>
        public static string DecryptPassword(string password)
        {
            var orginalStringByte = Convert.FromBase64String(password);
            var originalString = Encoding.UTF8.GetString(orginalStringByte);

            return originalString;
        }
    }
}
