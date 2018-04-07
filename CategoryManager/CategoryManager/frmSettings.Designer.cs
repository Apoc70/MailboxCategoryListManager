namespace CategoryManager
{
    partial class FrmSettings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSettings));
            this.grpCredentials = new System.Windows.Forms.GroupBox();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.chkUseDefaultCredentials = new System.Windows.Forms.CheckBox();
            this.grpConnectionSettings = new System.Windows.Forms.GroupBox();
            this.chkAlloRedirection = new System.Windows.Forms.CheckBox();
            this.chkIgnoreCertificateErrors = new System.Windows.Forms.CheckBox();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.lblURL = new System.Windows.Forms.Label();
            this.chkAutodiscover = new System.Windows.Forms.CheckBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.grpCredentials.SuspendLayout();
            this.grpConnectionSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpCredentials
            // 
            this.grpCredentials.Controls.Add(this.btnChangePassword);
            this.grpCredentials.Controls.Add(this.txtPassword);
            this.grpCredentials.Controls.Add(this.txtUser);
            this.grpCredentials.Controls.Add(this.lblPassword);
            this.grpCredentials.Controls.Add(this.lblUsername);
            this.grpCredentials.Controls.Add(this.chkUseDefaultCredentials);
            resources.ApplyResources(this.grpCredentials, "grpCredentials");
            this.grpCredentials.Name = "grpCredentials";
            this.grpCredentials.TabStop = false;
            // 
            // btnChangePassword
            // 
            resources.ApplyResources(this.btnChangePassword, "btnChangePassword");
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.UseVisualStyleBackColor = true;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // txtPassword
            // 
            resources.ApplyResources(this.txtPassword, "txtPassword");
            this.txtPassword.Name = "txtPassword";
            // 
            // txtUser
            // 
            resources.ApplyResources(this.txtUser, "txtUser");
            this.txtUser.Name = "txtUser";
            this.txtUser.TextChanged += new System.EventHandler(this.txtUser_TextChanged);
            // 
            // lblPassword
            // 
            resources.ApplyResources(this.lblPassword, "lblPassword");
            this.lblPassword.Name = "lblPassword";
            // 
            // lblUsername
            // 
            resources.ApplyResources(this.lblUsername, "lblUsername");
            this.lblUsername.Name = "lblUsername";
            // 
            // chkUseDefaultCredentials
            // 
            resources.ApplyResources(this.chkUseDefaultCredentials, "chkUseDefaultCredentials");
            this.chkUseDefaultCredentials.Checked = true;
            this.chkUseDefaultCredentials.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkUseDefaultCredentials.Name = "chkUseDefaultCredentials";
            this.chkUseDefaultCredentials.UseVisualStyleBackColor = true;
            this.chkUseDefaultCredentials.CheckedChanged += new System.EventHandler(this.chkDefaultCredentials_CheckedChanged);
            // 
            // grpConnectionSettings
            // 
            this.grpConnectionSettings.Controls.Add(this.chkAlloRedirection);
            this.grpConnectionSettings.Controls.Add(this.chkIgnoreCertificateErrors);
            this.grpConnectionSettings.Controls.Add(this.txtUrl);
            this.grpConnectionSettings.Controls.Add(this.lblURL);
            this.grpConnectionSettings.Controls.Add(this.chkAutodiscover);
            resources.ApplyResources(this.grpConnectionSettings, "grpConnectionSettings");
            this.grpConnectionSettings.Name = "grpConnectionSettings";
            this.grpConnectionSettings.TabStop = false;
            // 
            // chkAlloRedirection
            // 
            resources.ApplyResources(this.chkAlloRedirection, "chkAlloRedirection");
            this.chkAlloRedirection.Checked = true;
            this.chkAlloRedirection.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAlloRedirection.Name = "chkAlloRedirection";
            this.chkAlloRedirection.UseVisualStyleBackColor = true;
            // 
            // chkIgnoreCertificateErrors
            // 
            resources.ApplyResources(this.chkIgnoreCertificateErrors, "chkIgnoreCertificateErrors");
            this.chkIgnoreCertificateErrors.Name = "chkIgnoreCertificateErrors";
            this.chkIgnoreCertificateErrors.UseVisualStyleBackColor = true;
            // 
            // txtUrl
            // 
            resources.ApplyResources(this.txtUrl, "txtUrl");
            this.txtUrl.Name = "txtUrl";
            // 
            // lblURL
            // 
            resources.ApplyResources(this.lblURL, "lblURL");
            this.lblURL.Name = "lblURL";
            // 
            // chkAutodiscover
            // 
            resources.ApplyResources(this.chkAutodiscover, "chkAutodiscover");
            this.chkAutodiscover.Checked = true;
            this.chkAutodiscover.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAutodiscover.Name = "chkAutodiscover";
            this.chkAutodiscover.UseVisualStyleBackColor = true;
            this.chkAutodiscover.CheckedChanged += new System.EventHandler(this.chkAutodiscover_CheckedChanged);
            // 
            // btnOK
            // 
            resources.ApplyResources(this.btnOK, "btnOK");
            this.btnOK.Name = "btnOK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            resources.ApplyResources(this.btnCancel, "btnCancel");
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FrmSettings
            // 
            this.AcceptButton = this.btnOK;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.grpConnectionSettings);
            this.Controls.Add(this.grpCredentials);
            this.Name = "FrmSettings";
            this.ShowInTaskbar = false;
            this.grpCredentials.ResumeLayout(false);
            this.grpCredentials.PerformLayout();
            this.grpConnectionSettings.ResumeLayout(false);
            this.grpConnectionSettings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpCredentials;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.CheckBox chkUseDefaultCredentials;
        private System.Windows.Forms.GroupBox grpConnectionSettings;
        private System.Windows.Forms.CheckBox chkIgnoreCertificateErrors;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.Label lblURL;
        private System.Windows.Forms.CheckBox chkAutodiscover;
        private System.Windows.Forms.CheckBox chkAlloRedirection;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnChangePassword;
    }
}