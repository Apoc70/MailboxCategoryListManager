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
            resources.ApplyResources(this.menuStrip, "menuStrip");
            this.menuStrip.Name = "menuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            resources.ApplyResources(this.fileToolStripMenuItem, "fileToolStripMenuItem");
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            resources.ApplyResources(this.settingsToolStripMenuItem, "settingsToolStripMenuItem");
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.SettingsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            resources.ApplyResources(this.exitToolStripMenuItem, "exitToolStripMenuItem");
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // LblMailbox
            // 
            resources.ApplyResources(this.LblMailbox, "LblMailbox");
            this.LblMailbox.Name = "LblMailbox";
            // 
            // txtMailbox
            // 
            resources.ApplyResources(this.txtMailbox, "txtMailbox");
            this.txtMailbox.Name = "txtMailbox";
            this.txtMailbox.TextChanged += new System.EventHandler(this.TxtMailbox_TextChanged);
            // 
            // chkImpersonate
            // 
            resources.ApplyResources(this.chkImpersonate, "chkImpersonate");
            this.chkImpersonate.Name = "chkImpersonate";
            this.chkImpersonate.UseVisualStyleBackColor = true;
            // 
            // btnConnect
            // 
            resources.ApplyResources(this.btnConnect, "btnConnect");
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.BtnConnect_Click);
            // 
            // btnImport
            // 
            resources.ApplyResources(this.btnImport, "btnImport");
            this.btnImport.Name = "btnImport";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.BtnImport_Click);
            // 
            // btnExport
            // 
            resources.ApplyResources(this.btnExport, "btnExport");
            this.btnExport.Name = "btnExport";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.BtnExport_Click);
            // 
            // btnCopy
            // 
            resources.ApplyResources(this.btnCopy, "btnCopy");
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.BtnTransfer_Click);
            // 
            // tabControlTools
            // 
            resources.ApplyResources(this.tabControlTools, "tabControlTools");
            this.tabControlTools.Controls.Add(this.tabPageImporrtExport);
            this.tabControlTools.Controls.Add(this.tabCopyTransfer);
            this.tabControlTools.Name = "tabControlTools";
            this.tabControlTools.SelectedIndex = 0;
            // 
            // tabPageImporrtExport
            // 
            this.tabPageImporrtExport.Controls.Add(this.chkClearOnImport);
            this.tabPageImporrtExport.Controls.Add(this.btnImport);
            this.tabPageImporrtExport.Controls.Add(this.btnExport);
            resources.ApplyResources(this.tabPageImporrtExport, "tabPageImporrtExport");
            this.tabPageImporrtExport.Name = "tabPageImporrtExport";
            this.tabPageImporrtExport.UseVisualStyleBackColor = true;
            // 
            // chkClearOnImport
            // 
            resources.ApplyResources(this.chkClearOnImport, "chkClearOnImport");
            this.chkClearOnImport.Name = "chkClearOnImport";
            this.chkClearOnImport.UseVisualStyleBackColor = true;
            // 
            // tabCopyTransfer
            // 
            this.tabCopyTransfer.Controls.Add(this.chkClearTargetListBeforeImport);
            this.tabCopyTransfer.Controls.Add(this.chkTargetMailboxImpersonate);
            this.tabCopyTransfer.Controls.Add(this.lblTargetMailbox);
            this.tabCopyTransfer.Controls.Add(this.txtTargetAddress);
            this.tabCopyTransfer.Controls.Add(this.btnCopy);
            resources.ApplyResources(this.tabCopyTransfer, "tabCopyTransfer");
            this.tabCopyTransfer.Name = "tabCopyTransfer";
            this.tabCopyTransfer.UseVisualStyleBackColor = true;
            // 
            // chkClearTargetListBeforeImport
            // 
            resources.ApplyResources(this.chkClearTargetListBeforeImport, "chkClearTargetListBeforeImport");
            this.chkClearTargetListBeforeImport.Name = "chkClearTargetListBeforeImport";
            this.chkClearTargetListBeforeImport.UseVisualStyleBackColor = true;
            // 
            // chkTargetMailboxImpersonate
            // 
            resources.ApplyResources(this.chkTargetMailboxImpersonate, "chkTargetMailboxImpersonate");
            this.chkTargetMailboxImpersonate.Name = "chkTargetMailboxImpersonate";
            this.chkTargetMailboxImpersonate.UseVisualStyleBackColor = true;
            // 
            // lblTargetMailbox
            // 
            resources.ApplyResources(this.lblTargetMailbox, "lblTargetMailbox");
            this.lblTargetMailbox.Name = "lblTargetMailbox";
            // 
            // txtTargetAddress
            // 
            resources.ApplyResources(this.txtTargetAddress, "txtTargetAddress");
            this.txtTargetAddress.Name = "txtTargetAddress";
            this.txtTargetAddress.TextChanged += new System.EventHandler(this.TxtTargetAddress_TextChanged);
            // 
            // statusStripFrmMain
            // 
            this.statusStripFrmMain.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.statusStripFrmMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblAction});
            resources.ApplyResources(this.statusStripFrmMain, "statusStripFrmMain");
            this.statusStripFrmMain.Name = "statusStripFrmMain";
            // 
            // lblAction
            // 
            this.lblAction.Name = "lblAction";
            resources.ApplyResources(this.lblAction, "lblAction");
            // 
            // FrmMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.statusStripFrmMain);
            this.Controls.Add(this.tabControlTools);
            this.Controls.Add(this.LblMailbox);
            this.Controls.Add(this.txtMailbox);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.chkImpersonate);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.Name = "FrmMain";
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

