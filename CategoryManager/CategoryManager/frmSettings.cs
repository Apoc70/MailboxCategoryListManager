using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CategoryManager
{
    public partial class FrmSettings : Form
    {
        private MySettings formSettings = new MySettings();
        private string Key;

        public FrmSettings(MySettings mySettings)
        {
            InitializeComponent();
            LoadSettings();
        }

        private void LoadSettings()
        {
            Key = formSettings.Key;
            if (formSettings.UseDefaultCredentials)
            {
                chkUseDefaultCredentials.Checked = true;
            }
            else
            {
                chkUseDefaultCredentials.Checked = false;
            }

            txtUser.Text = formSettings.User;
            if (formSettings.Password.Length > 0)
            {
                txtPassword.Enabled = false;
                btnChangePassword.Enabled = true;
            }
            if (formSettings.UseAutodiscover)
            {
                chkAutodiscover.Checked = true;
            }
            else
            {
                chkAutodiscover.Checked = false;
                txtUrl.Text = formSettings.URL;
            }

            chkIgnoreCertificateErrors.Checked = formSettings.IgnoreCertificateErrors;
            chkAlloRedirection.Checked = formSettings.AllowRedirection;
        }

        private void chkDefaultCredentials_CheckedChanged(object sender, EventArgs e)
        {
            if (chkUseDefaultCredentials.Checked)
            {
                txtUser.Enabled = false;
                txtPassword.Enabled = false;
            }
            else
            {
                txtUser.Enabled = true;
                txtPassword.Enabled = true;
            }
            
        }

        private void chkAutodiscover_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAutodiscover.Checked)
            {
                txtUrl.Enabled = false;
            }
            else
            {
                txtUrl.Enabled = true;
            }
        }


        private void btnOK_Click(object sender, EventArgs e)
        {
            bool checkSucceded = false;

            formSettings.Key = formSettings.Key;
            

            // check if there are user and password set
            if (!chkUseDefaultCredentials.Checked)
            {
                if (txtPassword.Enabled)
                {
                    if ((txtUser.Text.Length == 0) || (txtPassword.Text.Length == 0))
                    {
                        MessageBox.Show("Please enter a user name and password", "Validation error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        checkSucceded = false;
                    }
                    else
                    {
                        formSettings.User = txtUser.Text;
                        formSettings.Password = EncryptionHelper.EncryptString(txtPassword.Text, EncryptionHelper.Base64Decode(Key), 8);
                        checkSucceded = true;
                    }
                }
                else
                {
                    checkSucceded = true;
                }
            }
            else
            {
                formSettings.UseDefaultCredentials = chkUseDefaultCredentials.Checked;
                checkSucceded = true;
            }

            
            if (!(chkAutodiscover.Checked))
            {
                if (txtUrl.Text.Length == 0)
                {
                    MessageBox.Show("Please enter valid URL", "Validation error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    checkSucceded = false;
                }
                else if ((txtUrl.Text.StartsWith("https://")) || (txtUrl.Text.StartsWith("http://")))
                {
                    formSettings.URL = txtUrl.Text;
                    checkSucceded = true;
                    
                }
                else
                {
                    MessageBox.Show("Please enter valid URL", "Validation error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    checkSucceded = false;
                }
                
            }
            else
            {
                formSettings.UseAutodiscover = chkUseDefaultCredentials.Checked;
                formSettings.URL = "";
            }
            if (checkSucceded)
            {
                formSettings.IgnoreCertificateErrors = chkIgnoreCertificateErrors.Checked;
                formSettings.AllowRedirection = chkAlloRedirection.Checked;
                formSettings.UseDefaultCredentials = chkUseDefaultCredentials.Checked;
                formSettings.UseAutodiscover = chkAutodiscover.Checked;
                formSettings.SaveSettings();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            txtPassword.Enabled = true;
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {
            txtPassword.Enabled = true;
            btnChangePassword.Enabled = false;
        }
    }
}
