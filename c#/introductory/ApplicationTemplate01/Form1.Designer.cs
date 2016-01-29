namespace ApplicationTemplate01
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FToolStripMenuItemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemSetting = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemSettingShowMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemHelpReadme = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemHelpWeb = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemHelpVersion = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripContainer1
            // 
            this.toolStripContainer1.BottomToolStripPanelVisible = false;
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(284, 237);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.LeftToolStripPanelVisible = false;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.RightToolStripPanelVisible = false;
            this.toolStripContainer1.Size = new System.Drawing.Size(284, 261);
            this.toolStripContainer1.TabIndex = 0;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.menuStrip1);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FToolStripMenuItemFile,
            this.ToolStripMenuItemSetting,
            this.ToolStripMenuItemHelp});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.MenuDeactivate += new System.EventHandler(this.menuStrip1_MenuDeactivate);
            // 
            // FToolStripMenuItemFile
            // 
            this.FToolStripMenuItemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemFileExit});
            this.FToolStripMenuItemFile.Name = "FToolStripMenuItemFile";
            this.FToolStripMenuItemFile.Size = new System.Drawing.Size(69, 20);
            this.FToolStripMenuItemFile.Text = " ファイル(&F)";
            // 
            // ToolStripMenuItemFileExit
            // 
            this.ToolStripMenuItemFileExit.Name = "ToolStripMenuItemFileExit";
            this.ToolStripMenuItemFileExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.ToolStripMenuItemFileExit.Size = new System.Drawing.Size(155, 22);
            this.ToolStripMenuItemFileExit.Text = "終了(&X)";
            this.ToolStripMenuItemFileExit.Click += new System.EventHandler(this.ToolStripMenuItemFileExit_Click);
            // 
            // ToolStripMenuItemSetting
            // 
            this.ToolStripMenuItemSetting.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemSettingShowMenu});
            this.ToolStripMenuItemSetting.Name = "ToolStripMenuItemSetting";
            this.ToolStripMenuItemSetting.Size = new System.Drawing.Size(57, 20);
            this.ToolStripMenuItemSetting.Text = "設定(&S)";
            // 
            // ToolStripMenuItemSettingShowMenu
            // 
            this.ToolStripMenuItemSettingShowMenu.Name = "ToolStripMenuItemSettingShowMenu";
            this.ToolStripMenuItemSettingShowMenu.Size = new System.Drawing.Size(199, 22);
            this.ToolStripMenuItemSettingShowMenu.Text = "常にメニューを表示する(&M)";
            this.ToolStripMenuItemSettingShowMenu.Click += new System.EventHandler(this.ToolStripMenuItemSettingShowMenu_Click);
            // 
            // ToolStripMenuItemHelp
            // 
            this.ToolStripMenuItemHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemHelpReadme,
            this.ToolStripMenuItemHelpWeb,
            this.ToolStripMenuItemHelpVersion});
            this.ToolStripMenuItemHelp.Name = "ToolStripMenuItemHelp";
            this.ToolStripMenuItemHelp.Size = new System.Drawing.Size(65, 20);
            this.ToolStripMenuItemHelp.Text = "ヘルプ(&H)";
            // 
            // ToolStripMenuItemHelpReadme
            // 
            this.ToolStripMenuItemHelpReadme.Name = "ToolStripMenuItemHelpReadme";
            this.ToolStripMenuItemHelpReadme.Size = new System.Drawing.Size(178, 22);
            this.ToolStripMenuItemHelpReadme.Text = "readme.txtを表示(&R)";
            // 
            // ToolStripMenuItemHelpWeb
            // 
            this.ToolStripMenuItemHelpWeb.Name = "ToolStripMenuItemHelpWeb";
            this.ToolStripMenuItemHelpWeb.Size = new System.Drawing.Size(178, 22);
            this.ToolStripMenuItemHelpWeb.Text = "Webサイトを表示(&W)";
            // 
            // ToolStripMenuItemHelpVersion
            // 
            this.ToolStripMenuItemHelpVersion.Name = "ToolStripMenuItemHelpVersion";
            this.ToolStripMenuItemHelpVersion.Size = new System.Drawing.Size(178, 22);
            this.ToolStripMenuItemHelpVersion.Text = "バージョン情報(&V)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.toolStripContainer1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FToolStripMenuItemFile;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemFileExit;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemSetting;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemSettingShowMenu;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemHelp;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemHelpReadme;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemHelpWeb;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemHelpVersion;
    }
}

