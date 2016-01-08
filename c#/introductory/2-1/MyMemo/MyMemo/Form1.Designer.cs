namespace MyMemo
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuItemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemFileNew = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemFileSave = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemFileSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemFileSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItemFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.設定SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemFont = new System.Windows.Forms.ToolStripMenuItem();
            this.textBoxMain = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.MenuItemEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemEditUndo = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemEditSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItemEditCut = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemEditCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemEditPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemEditDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItemEditSelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemFile,
            this.MenuItemEdit,
            this.設定SToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 26);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuItemFile
            // 
            this.MenuItemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemFileNew,
            this.MenuItemFileOpen,
            this.MenuItemFileSave,
            this.MenuItemFileSaveAs,
            this.MenuItemFileSeparator1,
            this.MenuItemFileExit});
            this.MenuItemFile.Name = "MenuItemFile";
            this.MenuItemFile.Size = new System.Drawing.Size(85, 22);
            this.MenuItemFile.Text = "ファイル(&F)";
            // 
            // MenuItemFileNew
            // 
            this.MenuItemFileNew.Name = "MenuItemFileNew";
            this.MenuItemFileNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.MenuItemFileNew.Size = new System.Drawing.Size(202, 22);
            this.MenuItemFileNew.Text = "新規(&N)";
            this.MenuItemFileNew.Click += new System.EventHandler(this.MenuItemFileNew_Click);
            // 
            // MenuItemFileOpen
            // 
            this.MenuItemFileOpen.Name = "MenuItemFileOpen";
            this.MenuItemFileOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.MenuItemFileOpen.Size = new System.Drawing.Size(202, 22);
            this.MenuItemFileOpen.Text = "開く(&O)...";
            this.MenuItemFileOpen.Click += new System.EventHandler(this.MenuItemFileOpen_Click);
            // 
            // MenuItemFileSave
            // 
            this.MenuItemFileSave.Name = "MenuItemFileSave";
            this.MenuItemFileSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.MenuItemFileSave.Size = new System.Drawing.Size(202, 22);
            this.MenuItemFileSave.Text = "上書き保存(&S)";
            this.MenuItemFileSave.Click += new System.EventHandler(this.MenuItemFileSave_Click);
            // 
            // MenuItemFileSaveAs
            // 
            this.MenuItemFileSaveAs.Name = "MenuItemFileSaveAs";
            this.MenuItemFileSaveAs.Size = new System.Drawing.Size(202, 22);
            this.MenuItemFileSaveAs.Text = "名前を付けて保存(&A)...";
            this.MenuItemFileSaveAs.Click += new System.EventHandler(this.MenuItemFileSaveAs_Click);
            // 
            // MenuItemFileSeparator1
            // 
            this.MenuItemFileSeparator1.Name = "MenuItemFileSeparator1";
            this.MenuItemFileSeparator1.Size = new System.Drawing.Size(199, 6);
            // 
            // MenuItemFileExit
            // 
            this.MenuItemFileExit.Name = "MenuItemFileExit";
            this.MenuItemFileExit.Size = new System.Drawing.Size(202, 22);
            this.MenuItemFileExit.Text = "終了(&X)";
            this.MenuItemFileExit.Click += new System.EventHandler(this.MenuItemFileExit_Click);
            // 
            // 設定SToolStripMenuItem
            // 
            this.設定SToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemFont});
            this.設定SToolStripMenuItem.Name = "設定SToolStripMenuItem";
            this.設定SToolStripMenuItem.Size = new System.Drawing.Size(62, 22);
            this.設定SToolStripMenuItem.Text = "設定(&S)";
            // 
            // MenuItemFont
            // 
            this.MenuItemFont.Name = "MenuItemFont";
            this.MenuItemFont.Size = new System.Drawing.Size(152, 22);
            this.MenuItemFont.Text = "フォント";
            this.MenuItemFont.Click += new System.EventHandler(this.MenuItemFont_Click);
            // 
            // textBoxMain
            // 
            this.textBoxMain.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBoxMain.Location = new System.Drawing.Point(0, 29);
            this.textBoxMain.Name = "textBoxMain";
            this.textBoxMain.Size = new System.Drawing.Size(100, 23);
            this.textBoxMain.TabIndex = 1;
            this.textBoxMain.TextChanged += new System.EventHandler(this.textBoxMain_TextChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // MenuItemEdit
            // 
            this.MenuItemEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemEditUndo,
            this.MenuItemEditSeparator1,
            this.MenuItemEditCut,
            this.MenuItemEditCopy,
            this.MenuItemEditPaste,
            this.MenuItemEditDelete,
            this.MenuItemSeparator2,
            this.MenuItemEditSelectAll});
            this.MenuItemEdit.Name = "MenuItemEdit";
            this.MenuItemEdit.Size = new System.Drawing.Size(61, 22);
            this.MenuItemEdit.Text = "編集(&E)";
            // 
            // MenuItemEditUndo
            // 
            this.MenuItemEditUndo.Name = "MenuItemEditUndo";
            this.MenuItemEditUndo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.MenuItemEditUndo.Size = new System.Drawing.Size(201, 22);
            this.MenuItemEditUndo.Text = "元に戻す(&U)";
            this.MenuItemEditUndo.Click += new System.EventHandler(this.MenuItemEditUndo_Click);
            // 
            // MenuItemEditSeparator1
            // 
            this.MenuItemEditSeparator1.Name = "MenuItemEditSeparator1";
            this.MenuItemEditSeparator1.Size = new System.Drawing.Size(198, 6);
            // 
            // MenuItemEditCut
            // 
            this.MenuItemEditCut.Name = "MenuItemEditCut";
            this.MenuItemEditCut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.MenuItemEditCut.Size = new System.Drawing.Size(201, 22);
            this.MenuItemEditCut.Text = "切り取り(&X)";
            this.MenuItemEditCut.Click += new System.EventHandler(this.MenuItemEditCut_Click);
            // 
            // MenuItemEditCopy
            // 
            this.MenuItemEditCopy.Name = "MenuItemEditCopy";
            this.MenuItemEditCopy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.MenuItemEditCopy.Size = new System.Drawing.Size(201, 22);
            this.MenuItemEditCopy.Text = "コピー(&C)";
            this.MenuItemEditCopy.Click += new System.EventHandler(this.MenuItemEditCopy_Click);
            // 
            // MenuItemEditPaste
            // 
            this.MenuItemEditPaste.Name = "MenuItemEditPaste";
            this.MenuItemEditPaste.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.MenuItemEditPaste.Size = new System.Drawing.Size(201, 22);
            this.MenuItemEditPaste.Text = "貼り付け(&P)";
            this.MenuItemEditPaste.Click += new System.EventHandler(this.MenuItemEditPaste_Click);
            // 
            // MenuItemEditDelete
            // 
            this.MenuItemEditDelete.Name = "MenuItemEditDelete";
            this.MenuItemEditDelete.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.MenuItemEditDelete.Size = new System.Drawing.Size(201, 22);
            this.MenuItemEditDelete.Text = "削除(&L)";
            this.MenuItemEditDelete.Click += new System.EventHandler(this.MenuItemEditDelete_Click);
            // 
            // MenuItemSeparator2
            // 
            this.MenuItemSeparator2.Name = "MenuItemSeparator2";
            this.MenuItemSeparator2.Size = new System.Drawing.Size(198, 6);
            // 
            // MenuItemEditSelectAll
            // 
            this.MenuItemEditSelectAll.Name = "MenuItemEditSelectAll";
            this.MenuItemEditSelectAll.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.MenuItemEditSelectAll.Size = new System.Drawing.Size(201, 22);
            this.MenuItemEditSelectAll.Text = "すべて選択(&A)";
            this.MenuItemEditSelectAll.Click += new System.EventHandler(this.MenuItemEditSelectAll_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.textBoxMain);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuItemFile;
        private System.Windows.Forms.ToolStripMenuItem MenuItemFileExit;
        private System.Windows.Forms.TextBox textBoxMain;
        private System.Windows.Forms.ToolStripMenuItem MenuItemFileNew;
        private System.Windows.Forms.ToolStripMenuItem MenuItemFileOpen;
        private System.Windows.Forms.ToolStripMenuItem MenuItemFileSave;
        private System.Windows.Forms.ToolStripMenuItem MenuItemFileSaveAs;
        private System.Windows.Forms.ToolStripSeparator MenuItemFileSeparator1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem 設定SToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuItemFont;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ToolStripMenuItem MenuItemEdit;
        private System.Windows.Forms.ToolStripMenuItem MenuItemEditUndo;
        private System.Windows.Forms.ToolStripSeparator MenuItemEditSeparator1;
        private System.Windows.Forms.ToolStripMenuItem MenuItemEditCut;
        private System.Windows.Forms.ToolStripMenuItem MenuItemEditCopy;
        private System.Windows.Forms.ToolStripMenuItem MenuItemEditPaste;
        private System.Windows.Forms.ToolStripMenuItem MenuItemEditDelete;
        private System.Windows.Forms.ToolStripSeparator MenuItemSeparator2;
        private System.Windows.Forms.ToolStripMenuItem MenuItemEditSelectAll;
    }
}

