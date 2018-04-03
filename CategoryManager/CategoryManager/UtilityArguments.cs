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