// MIT License
// 
// Copyright (c) 2018 Thomas Stensitzki, Torsten Schlopsnies
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.
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
