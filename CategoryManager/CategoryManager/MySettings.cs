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
