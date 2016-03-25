namespace Calc01
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
            this.buttonEqual = new System.Windows.Forms.Button();
            this.buttonMemory = new System.Windows.Forms.Button();
            this.buttonRecall = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonDivide = new System.Windows.Forms.Button();
            this.buttonMultiply = new System.Windows.Forms.Button();
            this.buttonSubstract = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDot = new System.Windows.Forms.Button();
            this.buttonPlusMinus = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.labelMain = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FToolStripMenuItemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemSetting = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemSettingShowMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemHelpReadme = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemHelpWeb = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemHelpVersion = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
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
            this.toolStripContainer1.ContentPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toolStripContainer1.ContentPanel.Controls.Add(this.buttonEqual);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.buttonMemory);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.buttonRecall);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.buttonClear);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.buttonDivide);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.buttonMultiply);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.buttonSubstract);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.buttonAdd);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.buttonDot);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.buttonPlusMinus);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.button0);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.button3);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.button2);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.button1);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.button6);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.button5);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.button4);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.button9);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.button8);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.button7);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.labelMain);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(292, 196);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.LeftToolStripPanelVisible = false;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.RightToolStripPanelVisible = false;
            this.toolStripContainer1.Size = new System.Drawing.Size(292, 220);
            this.toolStripContainer1.TabIndex = 0;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.menuStrip1);
            // 
            // buttonEqual
            // 
            this.buttonEqual.Location = new System.Drawing.Point(228, 153);
            this.buttonEqual.Name = "buttonEqual";
            this.buttonEqual.Size = new System.Drawing.Size(48, 30);
            this.buttonEqual.TabIndex = 20;
            this.buttonEqual.Text = "=";
            this.buttonEqual.UseVisualStyleBackColor = true;
            this.buttonEqual.Click += new System.EventHandler(this.Button_Click);
            // 
            // buttonMemory
            // 
            this.buttonMemory.Location = new System.Drawing.Point(228, 117);
            this.buttonMemory.Name = "buttonMemory";
            this.buttonMemory.Size = new System.Drawing.Size(48, 30);
            this.buttonMemory.TabIndex = 19;
            this.buttonMemory.Text = "M";
            this.buttonMemory.UseVisualStyleBackColor = true;
            this.buttonMemory.Click += new System.EventHandler(this.Button_Click);
            // 
            // buttonRecall
            // 
            this.buttonRecall.Location = new System.Drawing.Point(228, 81);
            this.buttonRecall.Name = "buttonRecall";
            this.buttonRecall.Size = new System.Drawing.Size(48, 30);
            this.buttonRecall.TabIndex = 18;
            this.buttonRecall.Text = "R";
            this.buttonRecall.UseVisualStyleBackColor = true;
            this.buttonRecall.Click += new System.EventHandler(this.Button_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(228, 45);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(48, 30);
            this.buttonClear.TabIndex = 17;
            this.buttonClear.Text = "C";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.Button_Click);
            // 
            // buttonDivide
            // 
            this.buttonDivide.Location = new System.Drawing.Point(174, 153);
            this.buttonDivide.Name = "buttonDivide";
            this.buttonDivide.Size = new System.Drawing.Size(48, 30);
            this.buttonDivide.TabIndex = 16;
            this.buttonDivide.Text = "/";
            this.buttonDivide.UseVisualStyleBackColor = true;
            this.buttonDivide.Click += new System.EventHandler(this.Button_Click);
            // 
            // buttonMultiply
            // 
            this.buttonMultiply.Location = new System.Drawing.Point(174, 117);
            this.buttonMultiply.Name = "buttonMultiply";
            this.buttonMultiply.Size = new System.Drawing.Size(48, 30);
            this.buttonMultiply.TabIndex = 15;
            this.buttonMultiply.Text = "*";
            this.buttonMultiply.UseVisualStyleBackColor = true;
            this.buttonMultiply.Click += new System.EventHandler(this.Button_Click);
            // 
            // buttonSubstract
            // 
            this.buttonSubstract.Location = new System.Drawing.Point(174, 81);
            this.buttonSubstract.Name = "buttonSubstract";
            this.buttonSubstract.Size = new System.Drawing.Size(48, 30);
            this.buttonSubstract.TabIndex = 14;
            this.buttonSubstract.Text = "-";
            this.buttonSubstract.UseVisualStyleBackColor = true;
            this.buttonSubstract.Click += new System.EventHandler(this.Button_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(174, 45);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(48, 30);
            this.buttonAdd.TabIndex = 13;
            this.buttonAdd.Text = "+";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.Button_Click);
            // 
            // buttonDot
            // 
            this.buttonDot.Location = new System.Drawing.Point(120, 153);
            this.buttonDot.Name = "buttonDot";
            this.buttonDot.Size = new System.Drawing.Size(48, 30);
            this.buttonDot.TabIndex = 12;
            this.buttonDot.Text = ".";
            this.buttonDot.UseVisualStyleBackColor = true;
            this.buttonDot.Click += new System.EventHandler(this.Button_Click);
            // 
            // buttonPlusMinus
            // 
            this.buttonPlusMinus.Location = new System.Drawing.Point(66, 152);
            this.buttonPlusMinus.Name = "buttonPlusMinus";
            this.buttonPlusMinus.Size = new System.Drawing.Size(48, 30);
            this.buttonPlusMinus.TabIndex = 11;
            this.buttonPlusMinus.Text = "±";
            this.buttonPlusMinus.UseVisualStyleBackColor = true;
            this.buttonPlusMinus.Click += new System.EventHandler(this.Button_Click);
            // 
            // button0
            // 
            this.button0.Location = new System.Drawing.Point(12, 153);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(48, 30);
            this.button0.TabIndex = 10;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.Button_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(120, 117);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(48, 30);
            this.button3.TabIndex = 9;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(66, 116);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(48, 30);
            this.button2.TabIndex = 8;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 117);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(48, 30);
            this.button1.TabIndex = 7;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(120, 81);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(48, 30);
            this.button6.TabIndex = 6;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.Button_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(66, 80);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(48, 30);
            this.button5.TabIndex = 5;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Button_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 81);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(48, 30);
            this.button4.TabIndex = 4;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(120, 45);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(48, 30);
            this.button9.TabIndex = 3;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.Button_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(66, 44);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(48, 30);
            this.button8.TabIndex = 2;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.Button_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(12, 45);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(48, 30);
            this.button7.TabIndex = 1;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.Button_Click);
            // 
            // labelMain
            // 
            this.labelMain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelMain.Location = new System.Drawing.Point(12, 18);
            this.labelMain.Name = "labelMain";
            this.labelMain.Size = new System.Drawing.Size(264, 23);
            this.labelMain.TabIndex = 0;
            this.labelMain.Text = "label1";
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
            this.menuStrip1.Size = new System.Drawing.Size(292, 24);
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
            this.ToolStripMenuItemHelpReadme.Click += new System.EventHandler(this.ToolStripMenuItemHelpReadme_Click);
            // 
            // ToolStripMenuItemHelpWeb
            // 
            this.ToolStripMenuItemHelpWeb.Name = "ToolStripMenuItemHelpWeb";
            this.ToolStripMenuItemHelpWeb.Size = new System.Drawing.Size(178, 22);
            this.ToolStripMenuItemHelpWeb.Text = "Webサイトを表示(&W)";
            this.ToolStripMenuItemHelpWeb.Click += new System.EventHandler(this.ToolStripMenuItemHelpWeb_Click);
            // 
            // ToolStripMenuItemHelpVersion
            // 
            this.ToolStripMenuItemHelpVersion.Name = "ToolStripMenuItemHelpVersion";
            this.ToolStripMenuItemHelpVersion.Size = new System.Drawing.Size(178, 22);
            this.ToolStripMenuItemHelpVersion.Text = "バージョン情報(&V)";
            this.ToolStripMenuItemHelpVersion.Click += new System.EventHandler(this.ToolStripMenuItemHelpVersion_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 220);
            this.Controls.Add(this.toolStripContainer1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
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
        private System.Windows.Forms.Label labelMain;
        private System.Windows.Forms.Button buttonDot;
        private System.Windows.Forms.Button buttonPlusMinus;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonEqual;
        private System.Windows.Forms.Button buttonMemory;
        private System.Windows.Forms.Button buttonRecall;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonDivide;
        private System.Windows.Forms.Button buttonMultiply;
        private System.Windows.Forms.Button buttonSubstract;
        private System.Windows.Forms.Button buttonAdd;
    }
}

