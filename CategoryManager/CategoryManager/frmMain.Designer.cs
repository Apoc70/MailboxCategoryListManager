namespace CategoryManager
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LblMailbox = new System.Windows.Forms.Label();
            this.txtMailbox = new System.Windows.Forms.TextBox();
            this.chkImpersonate = new System.Windows.Forms.CheckBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            this.tabControlTools = new System.Windows.Forms.TabControl();
            this.tabPageImporrtExport = new System.Windows.Forms.TabPage();
            this.chkClearOnImport = new System.Windows.Forms.CheckBox();
            this.tabCopyTransfer = new System.Windows.Forms.TabPage();
            this.chkClearTargetListBeforeImport = new System.Windows.Forms.CheckBox();
            this.chkTargetMailboxImpersonate = new System.Windows.Forms.CheckBox();
            this.lblTargetMailbox = new System.Windows.Forms.Label();
            this.txtTargetAddress = new System.Windows.Forms.TextBox();
            this.statusStripFrmMain = new System.Windows.Forms.StatusStrip();
            this.lblAction = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip.SuspendLayout();
            this.tabControlTools.SuspendLayout();
            this.tabPageImporrtExport.SuspendLayout();
            this.tabCopyTransfer.SuspendLayout();
            this.statusStripFrmMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(12, 4, 0, 4);
            this.menuStrip.Size = new System.Drawing.Size(1348, 44);
            this.menuStrip.TabIndex = 2;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(64, 36);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(215, 38);
            this.settingsToolStripMenuItem.Text = "S&ettings...";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.SettingsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(215, 38);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // LblMailbox
            // 
            this.LblMailbox.AutoSize = true;
            this.LblMailbox.Location = new System.Drawing.Point(24, 104);
            this.LblMailbox.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LblMailbox.Name = "LblMailbox";
            this.LblMailbox.Size = new System.Drawing.Size(93, 25);
            this.LblMailbox.TabIndex = 3;
            this.LblMailbox.Text = "Mailbox:";
            // 
            // txtMailbox
            // 
            this.txtMailbox.Location = new System.Drawing.Point(238, 98);
            this.txtMailbox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtMailbox.Name = "txtMailbox";
            this.txtMailbox.Size = new System.Drawing.Size(518, 31);
            this.txtMailbox.TabIndex = 4;
            this.txtMailbox.TextChanged += new System.EventHandler(this.TxtMailbox_TextChanged);
            // 
            // chkImpersonate
            // 
            this.chkImpersonate.AutoSize = true;
            this.chkImpersonate.Location = new System.Drawing.Point(36, 160);
            this.chkImpersonate.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.chkImpersonate.Name = "chkImpersonate";
            this.chkImpersonate.Size = new System.Drawing.Size(162, 29);
            this.chkImpersonate.TabIndex = 5;
            this.chkImpersonate.Text = "Impersonate";
            this.chkImpersonate.UseVisualStyleBackColor = true;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(238, 148);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(150, 44);
            this.btnConnect.TabIndex = 6;
            this.btnConnect.Text = "C&onnect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.BtnConnect_Click);
            // 
            // btnImport
            // 
            this.btnImport.Enabled = false;
            this.btnImport.Location = new System.Drawing.Point(12, 29);
            this.btnImport.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(150, 44);
            this.btnImport.TabIndex = 7;
            this.btnImport.Text = "I&mport...";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.BtnImport_Click);
            // 
            // btnExport
            // 
            this.btnExport.Enabled = false;
            this.btnExport.Location = new System.Drawing.Point(572, 29);
            this.btnExport.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(150, 44);
            this.btnExport.TabIndex = 8;
            this.btnExport.Text = "Ex&port...";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.BtnExport_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.Enabled = false;
            this.btnCopy.Location = new System.Drawing.Point(200, 125);
            this.btnCopy.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(150, 44);
            this.btnCopy.TabIndex = 11;
            this.btnCopy.Text = "&Copy";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.BtnTransfer_Click);
            // 
            // tabControlTools
            // 
            this.tabControlTools.Controls.Add(this.tabPageImporrtExport);
            this.tabControlTools.Controls.Add(this.tabCopyTransfer);
            this.tabControlTools.Location = new System.Drawing.Point(30, 237);
            this.tabControlTools.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabControlTools.Name = "tabControlTools";
            this.tabControlTools.SelectedIndex = 0;
            this.tabControlTools.Size = new System.Drawing.Size(846, 327);
            this.tabControlTools.TabIndex = 12;
            this.tabControlTools.Visible = false;
            // 
            // tabPageImporrtExport
            // 
            this.tabPageImporrtExport.Controls.Add(this.chkClearOnImport);
            this.tabPageImporrtExport.Controls.Add(this.btnImport);
            this.tabPageImporrtExport.Controls.Add(this.btnExport);
            this.tabPageImporrtExport.Location = new System.Drawing.Point(8, 39);
            this.tabPageImporrtExport.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabPageImporrtExport.Name = "tabPageImporrtExport";
            this.tabPageImporrtExport.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabPageImporrtExport.Size = new System.Drawing.Size(830, 280);
            this.tabPageImporrtExport.TabIndex = 0;
            this.tabPageImporrtExport.Text = "Import/Export";
            this.tabPageImporrtExport.UseVisualStyleBackColor = true;
            // 
            // chkClearOnImport
            // 
            this.chkClearOnImport.AutoSize = true;
            this.chkClearOnImport.Location = new System.Drawing.Point(12, 85);
            this.chkClearOnImport.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.chkClearOnImport.Name = "chkClearOnImport";
            this.chkClearOnImport.Size = new System.Drawing.Size(260, 29);
            this.chkClearOnImport.TabIndex = 10;
            this.chkClearOnImport.Text = "Clear list before import";
            this.chkClearOnImport.UseVisualStyleBackColor = true;
            // 
            // tabCopyTransfer
            // 
            this.tabCopyTransfer.Controls.Add(this.chkClearTargetListBeforeImport);
            this.tabCopyTransfer.Controls.Add(this.chkTargetMailboxImpersonate);
            this.tabCopyTransfer.Controls.Add(this.lblTargetMailbox);
            this.tabCopyTransfer.Controls.Add(this.txtTargetAddress);
            this.tabCopyTransfer.Controls.Add(this.btnCopy);
            this.tabCopyTransfer.Location = new System.Drawing.Point(8, 39);
            this.tabCopyTransfer.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabCopyTransfer.Name = "tabCopyTransfer";
            this.tabCopyTransfer.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabCopyTransfer.Size = new System.Drawing.Size(830, 280);
            this.tabCopyTransfer.TabIndex = 1;
            this.tabCopyTransfer.Text = "Copy";
            this.tabCopyTransfer.UseVisualStyleBackColor = true;
            // 
            // chkClearTargetListBeforeImport
            // 
            this.chkClearTargetListBeforeImport.AutoSize = true;
            this.chkClearTargetListBeforeImport.Location = new System.Drawing.Point(18, 177);
            this.chkClearTargetListBeforeImport.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.chkClearTargetListBeforeImport.Name = "chkClearTargetListBeforeImport";
            this.chkClearTargetListBeforeImport.Size = new System.Drawing.Size(260, 29);
            this.chkClearTargetListBeforeImport.TabIndex = 14;
            this.chkClearTargetListBeforeImport.Text = "Clear list before import";
            this.chkClearTargetListBeforeImport.UseVisualStyleBackColor = true;
            // 
            // chkTargetMailboxImpersonate
            // 
            this.chkTargetMailboxImpersonate.AutoSize = true;
            this.chkTargetMailboxImpersonate.Location = new System.Drawing.Point(18, 133);
            this.chkTargetMailboxImpersonate.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.chkTargetMailboxImpersonate.Name = "chkTargetMailboxImpersonate";
            this.chkTargetMailboxImpersonate.Size = new System.Drawing.Size(162, 29);
            this.chkTargetMailboxImpersonate.TabIndex = 13;
            this.chkTargetMailboxImpersonate.Text = "Impersonate";
            this.chkTargetMailboxImpersonate.UseVisualStyleBackColor = true;
            // 
            // lblTargetMailbox
            // 
            this.lblTargetMailbox.AutoSize = true;
            this.lblTargetMailbox.Location = new System.Drawing.Point(12, 48);
            this.lblTargetMailbox.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTargetMailbox.Name = "lblTargetMailbox";
            this.lblTargetMailbox.Size = new System.Drawing.Size(161, 25);
            this.lblTargetMailbox.TabIndex = 13;
            this.lblTargetMailbox.Text = "Target Mailbox:";
            // 
            // txtTargetAddress
            // 
            this.txtTargetAddress.Location = new System.Drawing.Point(200, 42);
            this.txtTargetAddress.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtTargetAddress.Name = "txtTargetAddress";
            this.txtTargetAddress.Size = new System.Drawing.Size(312, 31);
            this.txtTargetAddress.TabIndex = 12;
            this.txtTargetAddress.TextChanged += new System.EventHandler(this.TxtTargetAddress_TextChanged);
            // 
            // statusStripFrmMain
            // 
            this.statusStripFrmMain.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.statusStripFrmMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblAction});
            this.statusStripFrmMain.Location = new System.Drawing.Point(0, 598);
            this.statusStripFrmMain.Name = "statusStripFrmMain";
            this.statusStripFrmMain.Padding = new System.Windows.Forms.Padding(2, 0, 28, 0);
            this.statusStripFrmMain.Size = new System.Drawing.Size(1348, 37);
            this.statusStripFrmMain.TabIndex = 13;
            this.statusStripFrmMain.Text = "statusStrip1";
            // 
            // lblAction
            // 
            this.lblAction.Name = "lblAction";
            this.lblAction.Size = new System.Drawing.Size(164, 32);
            this.lblAction.Text = "No action yet.";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1348, 635);
            this.Controls.Add(this.statusStripFrmMain);
            this.Controls.Add(this.tabControlTools);
            this.Controls.Add(this.LblMailbox);
            this.Controls.Add(this.txtMailbox);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.chkImpersonate);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.Text = "Manage Categories";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.tabControlTools.ResumeLayout(false);
            this.tabPageImporrtExport.ResumeLayout(false);
            this.tabPageImporrtExport.PerformLayout();
            this.tabCopyTransfer.ResumeLayout(false);
            this.tabCopyTransfer.PerformLayout();
            this.statusStripFrmMain.ResumeLayout(false);
            this.statusStripFrmMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label LblMailbox;
        private System.Windows.Forms.TextBox txtMailbox;
        private System.Windows.Forms.CheckBox chkImpersonate;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.TabControl tabControlTools;
        private System.Windows.Forms.TabPage tabPageImporrtExport;
        private System.Windows.Forms.TabPage tabCopyTransfer;
        private System.Windows.Forms.Label lblTargetMailbox;
        private System.Windows.Forms.TextBox txtTargetAddress;
        private System.Windows.Forms.CheckBox chkTargetMailboxImpersonate;
        private System.Windows.Forms.StatusStrip statusStripFrmMain;
        private System.Windows.Forms.ToolStripStatusLabel lblAction;
        private System.Windows.Forms.CheckBox chkClearOnImport;
        private System.Windows.Forms.CheckBox chkClearTargetListBeforeImport;
    }
}

