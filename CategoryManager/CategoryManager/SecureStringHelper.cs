using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace CategoryManager
{
    public class SecureStringHelper
    {
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
