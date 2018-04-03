﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Exchange.WebServices.Data;
using System.Xml.Serialization;
using System.Security;

namespace CategoryManager
{
    public partial class FrmMain : Form
    {
        string User, URL, Key;
        SecureString Password;
        bool UseDefaultCredentials, IgnoreCertificateErrors, AllowRedirection, UseAutodiscover;
        private ExchangeHelper EWSHelper = new ExchangeHelper();
        private ExchangeHelper TargetHelper = new ExchangeHelper();
        private ExchangeService EWSService, TargetEWS;
        private static readonly LogHelper log = new LogHelper();

        private bool ConnectionState = false;
        private bool Connected
        {
            get
            {
                return ConnectionState;
            }
            set
            {
                ConnectionState = value;
                // Enable or disable Import/Export/Transfer
                if (Connected)
                {
                    btnImport.Enabled = true;
                    btnExport.Enabled = true;
                    tabControlTools.Visible = true;
                    btnConnect.Enabled = false;
                }
                else
                {
                    btnImport.Enabled = false;
                    btnExport.Enabled = false;
                    btnCopy.Enabled = false;
                    tabControlTools.Visible = false;
                    btnConnect.Enabled = true;
                }
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Exit();
        }

        private void Exit()
        {
            log.WriteDebugLog("Closing main window.");
            this.Close();
        }

        MySettings Settings = new MySettings();

        private void SettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowSettings();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exit();
        }

        private void BtnConnect_Click(object sender, EventArgs e)
        {
            btnConnect.Enabled = false;
            lblAction.Text = "Establishing connection to EWS endpoint...";
           
            if (ConnectToExchange())
            {
                Connected = true;
                lblAction.Text = "Connected to " + EWSService.Url.ToString();
            }
            else
            {
                Connected = false;
            }
        }

        private void ImportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ImportCategories();
        }

        private void BtnTransfer_Click(object sender, EventArgs e)
        {
            btnCopy.Enabled = false;
            lblAction.Text = "Please wait...";
            CopyCategories();
            btnCopy.Enabled = true;
        }

        private void ImportCategories()
        {
            OpenFileDialog OpenFile = new OpenFileDialog
            {
                Filter = "Serialized Categories|*.xml",
                Title = "Select a file name to save"
            };
            DialogResult result = OpenFile.ShowDialog();

            if (result == DialogResult.OK)
            {
                int imported = CategoryHelper.Import(EWSService, OpenFile.FileName, chkClearOnImport.Checked);
                if (imported > 0)
                {
                    lblAction.Text = string.Format("{0} Categories successfully imported", imported);
                }
                else
                {
                    lblAction.Text = "No categories where imported. Check log or import file.";
                }
            }
        }

        private void ExportCategories()
        {
            SaveFileDialog SaveFile = new SaveFileDialog
            {
                Filter = "Serialized Categories|*.xml",
                Title = "Select a file name to save"
            };
            DialogResult result = SaveFile.ShowDialog();

            if (result == DialogResult.OK)
            {
                if (SaveFile.FileName != "")
                {
                    try
                    {
                        int tmpExport = CategoryHelper.Export(EWSService, SaveFile.FileName);
                        // Do we have more then 0 categories? If not the export will be failing
                        if (tmpExport > 0)
                        {
                            lblAction.Text = string.Format("{0} Categories exported successfully to {1}", tmpExport, SaveFile.FileName);
                        }
                        else
                        {
                            MessageBox.Show("Error on exporting. Please consult the log file.", "Export error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch(System.ArgumentNullException)
                    {
                        MessageBox.Show("The category list empty. No file written", "Nothing to export", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }

        }

        private void CopyCategories()
        {
            if (txtTargetAddress.Text.Length != 0)
            {

                lblAction.Text = "Conneting to target mailbox...";
                try
                {
                    TargetEWS = TargetHelper.Service(Settings.UseDefaultCredentials, Settings.User, Password, txtTargetAddress.Text, Settings.AllowRedirection, chkTargetMailboxImpersonate.Checked, Settings.IgnoreCertificateErrors);
                    lblAction.Text = "Connected to target mailbox";
                    log.WriteErrorLog(string.Format("Connected to mailbox \"{0}\" successfully", txtTargetAddress.Text));
                }
                catch
                {
                    MessageBox.Show("Error connecting to target mailbox. Check mailbox name and permissions.", "Connection error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    log.WriteErrorLog(string.Format("Connection to mailbox \"{0}\" failed", txtTargetAddress.Text));
                }

                if (TargetEWS != null)
                {
                    int tmpCopy = CategoryHelper.CopyCategories(EWSService, TargetEWS, chkClearTargetListBeforeImport.Checked);
                    if (tmpCopy > 0)
                    {
                        lblAction.Text = string.Format("{0} categories copied", tmpCopy);
                    }
                    else
                    {
                        lblAction.Text = "Error on copying.";
                        MessageBox.Show("Error on copying. Please consult the log file.", "Export error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Enter a target address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnImport_Click(object sender, EventArgs e)
        {
            // Import
            ImportCategories();
        }

        private void BtnExport_Click(object sender, EventArgs e)
        {
            // Export
            ExportCategories();
        }

        private void TxtTargetAddress_TextChanged(object sender, EventArgs e)
        {
            if (txtTargetAddress.Text.Length > 0)
            {
                btnCopy.Enabled = true;
            }
            else
            {
                btnCopy.Enabled = false;
            }
        }

        private void TxtMailbox_TextChanged(object sender, EventArgs e)
        {
            if (Connected)
            {
                Connected = false;
            }
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            log.WriteDebugLog("frmMain loaded.");
            LoadSettings();
        }

        private void LoadSettings()
        {
            Key = Settings.Key;
            if (Settings.User.Length > 0)
            {
                User = Settings.User;
            }
            if (Settings.Password.Length > 0)
            {
                Password = SecureStringHelper.StringToSecureString(EncryptionHelper.DecryptString(Settings.Password, EncryptionHelper.Base64Decode(Key), 8));
            }
            if ((Settings.URL.StartsWith("http://")) || (Settings.URL.StartsWith("https://")))
            {
                URL = Settings.URL;
            }
            else
            {
                URL = "";
            }
            UseDefaultCredentials = Settings.UseDefaultCredentials;
            IgnoreCertificateErrors = Settings.IgnoreCertificateErrors;
            AllowRedirection = Settings.AllowRedirection;
            UseAutodiscover = Settings.UseAutodiscover;
        }

        private void SaveSettings()
        {
            Settings.User = User;
            Settings.Password = EncryptionHelper.EncryptString(SecureStringHelper.SecureStringToString(Password), EncryptionHelper.Base64Decode(Key), 8);
            if ((URL.StartsWith("http://")) || (URL.StartsWith("https://")))
            {
                Settings.URL = URL;
            }
            else
            {
                Settings.URL = "";
            }
            Settings.UseDefaultCredentials = UseDefaultCredentials;
            Settings.IgnoreCertificateErrors = IgnoreCertificateErrors;
            Settings.AllowRedirection = AllowRedirection;
            Settings.UseAutodiscover = UseAutodiscover;
            Settings.Key = Key;
            Settings.SaveSettings();
        }

        public FrmMain()
        {
            InitializeComponent();
        }

        private void BtnSettings_Click(object sender, EventArgs e)
        {
            ShowSettings();
        }

        private void ShowSettings()
        {
            FrmSettings formSettings = new FrmSettings(Settings);
            formSettings.ShowDialog();

            if (formSettings.DialogResult == DialogResult.OK)
            {
                LoadSettings();
                formSettings.Dispose();
            }
            else
            {
                formSettings.Dispose();
            }
        }

        private bool ConnectToExchange()
        {
            // Check if URL is set
            if (Settings.URL == "")
            {
                // Use Autodiscover
                try
                {
                    EWSService = EWSHelper.Service(Settings.UseDefaultCredentials, Settings.User, Password, txtMailbox.Text, Settings.AllowRedirection, chkImpersonate.Checked, Settings.IgnoreCertificateErrors); ;
                    if (EWSService != null)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                catch
                {
                    MessageBox.Show("Error on connect to EWS", "Connection error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Connected = false;
                }
            }
            else
            {
                // Use URL
                try
                {
                    EWSService = EWSHelper.Service(Settings.UseDefaultCredentials, Settings.User, Password, txtMailbox.Text, Settings.URL, chkImpersonate.Checked, Settings.IgnoreCertificateErrors);
                    if (EWSService != null)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                catch
                {
                    MessageBox.Show("Error on connect to EWS", "Connection error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Connected = false;
                }
            }
            return false;
        }
    }
}