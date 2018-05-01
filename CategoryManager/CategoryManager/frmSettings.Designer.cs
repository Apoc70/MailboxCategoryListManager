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
            this.grpCredentials.Location = new System.Drawing.Point(24, 23);
            this.grpCredentials.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.grpCredentials.Name = "grpCredentials";
            this.grpCredentials.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.grpCredentials.Size = new System.Drawing.Size(816, 263);
            this.grpCredentials.TabIndex = 0;
            this.grpCredentials.TabStop = false;
            this.grpCredentials.Text = "Credentials";
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Enabled = false;
            this.btnChangePassword.Location = new System.Drawing.Point(18, 208);
            this.btnChangePassword.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(214, 44);
            this.btnChangePassword.TabIndex = 5;
            this.btnChangePassword.Text = "Change &Password";
            this.btnChangePassword.UseVisualStyleBackColor = true;
            this.btnChangePassword.Click += new System.EventHandler(this.BtnChangePassword_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Enabled = false;
            this.txtPassword.Location = new System.Drawing.Point(136, 148);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(600, 31);
            this.txtPassword.TabIndex = 4;
            // 
            // txtUser
            // 
            this.txtUser.Enabled = false;
            this.txtUser.Location = new System.Drawing.Point(136, 98);
            this.txtUser.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(600, 31);
            this.txtUser.TabIndex = 3;
            this.txtUser.TextChanged += new System.EventHandler(this.TxtUser_TextChanged);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(12, 156);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(112, 25);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Password:";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(8, 100);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(116, 25);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "Username:";
            // 
            // chkUseDefaultCredentials
            // 
            this.chkUseDefaultCredentials.AutoSize = true;
            this.chkUseDefaultCredentials.Checked = true;
            this.chkUseDefaultCredentials.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkUseDefaultCredentials.Location = new System.Drawing.Point(18, 54);
            this.chkUseDefaultCredentials.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.chkUseDefaultCredentials.Name = "chkUseDefaultCredentials";
            this.chkUseDefaultCredentials.Size = new System.Drawing.Size(264, 29);
            this.chkUseDefaultCredentials.TabIndex = 0;
            this.chkUseDefaultCredentials.Text = "Use default credentials";
            this.chkUseDefaultCredentials.UseVisualStyleBackColor = true;
            this.chkUseDefaultCredentials.CheckedChanged += new System.EventHandler(this.ChkDefaultCredentials_CheckedChanged);
            // 
            // grpConnectionSettings
            // 
            this.grpConnectionSettings.Controls.Add(this.chkAlloRedirection);
            this.grpConnectionSettings.Controls.Add(this.chkIgnoreCertificateErrors);
            this.grpConnectionSettings.Controls.Add(this.txtUrl);
            this.grpConnectionSettings.Controls.Add(this.lblURL);
            this.grpConnectionSettings.Controls.Add(this.chkAutodiscover);
            this.grpConnectionSettings.Location = new System.Drawing.Point(24, 317);
            this.grpConnectionSettings.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.grpConnectionSettings.Name = "grpConnectionSettings";
            this.grpConnectionSettings.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.grpConnectionSettings.Size = new System.Drawing.Size(816, 237);
            this.grpConnectionSettings.TabIndex = 1;
            this.grpConnectionSettings.TabStop = false;
            this.grpConnectionSettings.Text = "Connection settings";
            // 
            // chkAlloRedirection
            // 
            this.chkAlloRedirection.AutoSize = true;
            this.chkAlloRedirection.Checked = true;
            this.chkAlloRedirection.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAlloRedirection.Location = new System.Drawing.Point(12, 140);
            this.chkAlloRedirection.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.chkAlloRedirection.Name = "chkAlloRedirection";
            this.chkAlloRedirection.Size = new System.Drawing.Size(202, 29);
            this.chkAlloRedirection.TabIndex = 4;
            this.chkAlloRedirection.Text = "Allow redirection";
            this.chkAlloRedirection.UseVisualStyleBackColor = true;
            // 
            // chkIgnoreCertificateErrors
            // 
            this.chkIgnoreCertificateErrors.AutoSize = true;
            this.chkIgnoreCertificateErrors.Location = new System.Drawing.Point(12, 94);
            this.chkIgnoreCertificateErrors.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.chkIgnoreCertificateErrors.Name = "chkIgnoreCertificateErrors";
            this.chkIgnoreCertificateErrors.Size = new System.Drawing.Size(269, 29);
            this.chkIgnoreCertificateErrors.TabIndex = 3;
            this.chkIgnoreCertificateErrors.Text = "Ignore Certificate errors";
            this.chkIgnoreCertificateErrors.UseVisualStyleBackColor = true;
            // 
            // txtUrl
            // 
            this.txtUrl.Enabled = false;
            this.txtUrl.Location = new System.Drawing.Point(320, 44);
            this.txtUrl.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(416, 31);
            this.txtUrl.TabIndex = 2;
            // 
            // lblURL
            // 
            this.lblURL.AutoSize = true;
            this.lblURL.Location = new System.Drawing.Point(244, 50);
            this.lblURL.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblURL.Name = "lblURL";
            this.lblURL.Size = new System.Drawing.Size(60, 25);
            this.lblURL.TabIndex = 1;
            this.lblURL.Text = "URL:";
            // 
            // chkAutodiscover
            // 
            this.chkAutodiscover.AutoSize = true;
            this.chkAutodiscover.Checked = true;
            this.chkAutodiscover.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAutodiscover.Location = new System.Drawing.Point(12, 48);
            this.chkAutodiscover.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.chkAutodiscover.Name = "chkAutodiscover";
            this.chkAutodiscover.Size = new System.Drawing.Size(213, 29);
            this.chkAutodiscover.TabIndex = 0;
            this.chkAutodiscover.Text = "Use Autodiscover";
            this.chkAutodiscover.UseVisualStyleBackColor = true;
            this.chkAutodiscover.CheckedChanged += new System.EventHandler(this.ChkAutodiscover_CheckedChanged);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(24, 652);
            this.btnOK.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(150, 44);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "&OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(690, 652);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(150, 44);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // FrmSettings
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(916, 737);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.grpConnectionSettings);
            this.Controls.Add(this.grpCredentials);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "FrmSettings";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
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