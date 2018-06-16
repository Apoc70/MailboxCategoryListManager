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
namespace CategoryManager
{
    /// <summary>
    /// Description of UtilityArguments.
    /// </summary>
    public class UtilityArguments : InputArguments
    {
        public string Mailbox
        {
            get
            {
                return GetValue("-mailbox");
            }
        }

        protected bool GetBoolValue(string key)
        {
            string adjustedKey;
            if (ContainsKey(key, out adjustedKey))
            {
                bool res;
                bool.TryParse(_parsedArguments[adjustedKey], out res);
                return res;
            }
            return false;
        }

        protected bool GetSwitchValue(string key)
        {
            string adjustedKey;
            if (ContainsKey(key, out adjustedKey))
            {
                return true;
            }
            return false;
        }

        public bool Help
        {
            get
            {
                return GetSwitchValue("-help");
            }
        }

        public string ImportFile
        {
            get
            {
                return GetValue("-import");
            }
        }

        public string ExportFile
        {
            get
            {
                return GetValue("-export");
            }
        }

        public bool IgnoreCertificate
        {
            get
            {
                return GetSwitchValue("-ignorecertificate");
            }
        }

        public string URL
        {
            get
            {
                return GetValue("-url");
            }
        }

        public bool AllowRedirection
        {
            get
            {
                return GetSwitchValue("-allowredirection");
            }
        }

        public string User
        {
            get
            {
                return GetValue("-user");
            }
        }

        public string Password
        {
            get
            {
                return GetValue("-password");
            }
        }

        public bool Impersonate
        {
            get
            {
                return GetSwitchValue("-impersonate");
            }
        }

        public bool ClearOnImport
        {
            get
            {
                return GetSwitchValue("-clearonimport");
            }
        }

        public bool UseSettings
        {
            get
            {
                return GetSwitchValue("-usesettings");
            }
        }

        public UtilityArguments(string[] args) : base(args)
        {
        }
    }
}