using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace CategoryManager
{
    /// <summary>
    /// Helper class for SecureString
    /// </summary>
    public class SecureStringHelper
    {
        /// <summary>
        /// Change a string to a SecureString
        /// </summary>
        /// <param name="value">String need to be secured</param>
        /// <returns>SecureString</returns>
        public static SecureString StringToSecureString(string value)
        {
            if (value != null)
            {
                var secure = new SecureString();
                foreach (char c in value)
                {
                    secure.AppendChar(c);
                }
                return secure;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Change a SecureString into a String
        /// </summary>
        /// <param name="value">SecureString needs to be changed</param>
        /// <returns>String</returns>
        public static string SecureStringToString(SecureString value)
        {
            if (value != null)
            {
                IntPtr valuePtr = IntPtr.Zero;
                try
                {
                    valuePtr = Marshal.SecureStringToGlobalAllocUnicode(value);
                    return Marshal.PtrToStringUni(valuePtr);
                }
                finally
                {
                    Marshal.ZeroFreeGlobalAllocUnicode(valuePtr);
                }
            }
            else
            {
                return "";
            }
        }
    }
}
