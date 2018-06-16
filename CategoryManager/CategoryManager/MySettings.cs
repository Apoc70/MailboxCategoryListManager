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
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace CategoryManager
{
    public class MySettings
    {
        public string User
        {
            get
            {
                return Properties.Settings.Default.User;
            }
            set
            {
                Properties.Settings.Default.User = value;
            }
        }

        public string Password
        {
            get
            {
                return Properties.Settings.Default.Password;
            }
            set
            {
                Properties.Settings.Default.Password = value;
            }
        }

        public string URL
        {
            get
            {
                return Properties.Settings.Default.URL;
            }
            set
            {
                Properties.Settings.Default.URL = value;
            }
        }

        public bool UseDefaultCredentials
        {
            get
            {
                return Properties.Settings.Default.UseDefaultCredentials;
            }
            set
            {
                Properties.Settings.Default.UseDefaultCredentials = value;
            }
        }

        public bool IgnoreCertificateErrors
        {
            get
            {
                return Properties.Settings.Default.IgnoreCertificateError;
            }
            set
            {
                Properties.Settings.Default.IgnoreCertificateError = value;
            }
        }

        public bool AllowRedirection
        {
            get
            {
                return Properties.Settings.Default.AllowRedirection;
            }
            set
            {
                Properties.Settings.Default.AllowRedirection = value;
            }
        }

        public bool UseAutodiscover
        {
            get
            {
                return Properties.Settings.Default.UseAutodiscover;
            }
            set
            {
                Properties.Settings.Default.UseAutodiscover = value;
            }
        }

        public string Key
        {
            get
            {
                if (Properties.Settings.Default.Key == "" || Properties.Settings.Default.Key == null)
                {
                    return EncryptionHelper.GetRandomKey(256);
                }
                else
                {
                    return EncryptionHelper.Base64Decode(Properties.Settings.Default.Key);
                }
            }
            set
            {
                if (value != "")
                {
                    Properties.Settings.Default.Key = EncryptionHelper.Base64Encode(value);
                }
            }
        }

        public void SaveSettings()
        {
            Properties.Settings.Default.Save();
        }
    }
}
