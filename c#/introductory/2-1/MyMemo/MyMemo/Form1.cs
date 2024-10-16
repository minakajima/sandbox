﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyMemo
{
    public partial class Form1 : Form
    {
        const string ApplicationName = "MyMemo";　// アプリ名
        const string RegistryKey =
            @"Software\NikkeiSoftware" +
            ApplicationName;
        private string FilePath;

        private string FileNameValue = "";

        private bool EditedValue;

        private string PrintString;

        private string FileName
        {
            get { return FileNameValue; }
            set
            {
                FileNameValue = value;
                if(value != "")
                {
                    FilePath =
                        System.IO.Path.GetDirectoryName(value);
                }
                Edited = false;
            }
        }

        private bool Edited
        {
            get { return EditedValue; }
            set
            {
                EditedValue = value;
                UpdateStatus();
            }
        }
        private void UpdateStatus()
        {
            string s = ApplicationName;
            if( FileName != "")
            {
                s += " - " + FileName;
            }
            if (Edited) s += "(変更あり) ";
            this.Text = s;

            if (FileName == "" || !Edited || textBoxMain.TextLength == 0)
                MenuItemFileSave.Enabled = false;
            else
                MenuItemFileSave.Enabled = true;

            if (!Edited || textBoxMain.TextLength == 0)
                MenuItemFileSaveAs.Enabled = false;
            else
                MenuItemFileSaveAs.Enabled = true;

            bool b = textBoxMain.TextLength == 0;
            MenuItemFilePrint.Enabled = !b;
            MenuItemFilePrintPreview.Enabled = !b;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FileName = "";
            textBoxMain.Multiline = true;
            textBoxMain.ScrollBars = ScrollBars.Vertical;
            textBoxMain.Dock = DockStyle.Fill;
            saveFileDialog1.Filter = "テキスト文章|*.txt|すべてのファイル|*.*";
            fontDialog1.ShowEffects = false;
            fontDialog1.AllowScriptChange = false;

            Microsoft.Win32.RegistryKey regKey =
                Microsoft.Win32.Registry.CurrentUser.
                CreateSubKey(RegistryKey);
            // ファイルパス設定の読み込み
            FilePath = regKey.GetValue("FilePath",
                System.Environment.GetFolderPath(
                System.Environment.SpecialFolder.MyDocuments)).
                ToString();
            // フォント設定の読み込み
            string name =
                regKey.GetValue("FontName", "ＭＳ ゴシック").ToString();
            Single size = Single.Parse(regKey.GetValue("FontSize", 12).ToString());
            bool bold = bool.Parse(regKey.GetValue("FontBold", false).ToString());
            bool italic = bool.Parse(regKey.GetValue("FontItalic", false).ToString());
            System.Drawing.FontStyle style = new System.Drawing.FontStyle();
            if (bold) style = System.Drawing.FontStyle.Bold;
            if (italic) style = style ^ System.Drawing.FontStyle.Italic;
            textBoxMain.Font = new System.Drawing.Font(name, size, style);

            // ウィンドウが小さくなり過ぎないように
            const int initialWidth = 400;
            const int initialHeight = 200;
            this.MinimumSize = new System.Drawing.Size(
                initialWidth, initialHeight);

            // ウィンドウの位置と大きさを読み込み
            const int initialLeft = 100;
            const int initialTop = 100;
            int l = int.Parse(regKey.GetValue("Left", initialLeft).ToString());
            int t = int.Parse(regKey.GetValue("Top", initialTop).ToString());
            int w = int.Parse(regKey.GetValue("Width", initialWidth).ToString());
            int h = int.Parse(regKey.GetValue("Height", initialHeight).ToString());
            if (l < Screen.GetWorkingArea(this).Left ||
                l >= Screen.GetWorkingArea(this).Right)
                l = initialLeft;
            if (t < Screen.GetWorkingArea(this).Top ||
                t >= Screen.GetWorkingArea(this).Bottom)
                t = initialTop;
            this.SetDesktopBounds(l, t, w, h);

            // 不要なものは無効にする
            MenuItemEdit_DropDownOpened(sender, e);

            // 印刷設定
            printDialog1.Document = printDocument1;

            // 印刷プレビュー
            printPreviewDialog1.Document = printDocument1;

            // コマンド引数でファイル名を受け取る
            if (1 < Environment.GetCommandLineArgs().Length)
            {
                string[] args = Environment.GetCommandLineArgs();
                LoadFile(args[1]);
            }
        }

        private void MenuItemFileExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MenuItemFileOpen_Click(object sender, EventArgs e)
        {
            if (!AskGiveUpText()) return;

            openFileDialog1.InitialDirectory = FilePath;
            openFileDialog1.FileName = "";
            if (DialogResult.OK == openFileDialog1.ShowDialog())
            {
                LoadFile(openFileDialog1.FileName);
            }
        }
           
        private void LoadFile(string value)
        {
            if (System.IO.File.Exists(value))
            {
                textBoxMain.Text = System.IO.File.ReadAllText(
                     value, Encoding.GetEncoding(
                         "Shift_JIS"));
                textBoxMain.Select(0, 0);
                FileName = value;

            }
            else
            {
                MessageBox.Show(value + "が見つかりません",
                    ApplicationName);
            }
        }

        private void MenuItemFileSaveAs_Click(object sender, EventArgs e)
        {
            saveFileDialog1.InitialDirectory = FilePath;
            saveFileDialog1.FileName = System.IO.Path.GetFileName(FileName);
            if(DialogResult.OK == saveFileDialog1.ShowDialog())
            {
                SaveFile(saveFileDialog1.FileName);
            }
        }

        private void SaveFile(string value)
        {
            System.IO.File.WriteAllText(value, textBoxMain.Text,
                System.Text.Encoding.GetEncoding("Shift_JIS"));
            FileName = value;
        }

        private void MenuItemFileSave_Click(object sender, EventArgs e)
        {
            SaveFile(FileName);
        }

        private void textBoxMain_TextChanged(object sender, EventArgs e)
        {
            Edited = true;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!AskGiveUpText()) e.Cancel = true;
        }

        private bool AskGiveUpText()
        {
            if (!Edited || textBoxMain.TextLength == 0)
                return true;
            if (DialogResult.Yes ==
                MessageBox.Show("編集内容を破棄しますか?",
                ApplicationName, MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning)) return true;
            else
                return false;

        }

        private void MenuItemFileNew_Click(object sender, EventArgs e)
        {
            if (!AskGiveUpText()) return;
            textBoxMain.Clear();
            FileName = "";
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Microsoft.Win32.RegistryKey regKey =
                Microsoft.Win32.Registry.CurrentUser.
                CreateSubKey(RegistryKey);
            // フォント設定を覚える
            regKey.SetValue("FilePath", FilePath);
            regKey.SetValue("FontName", textBoxMain.Font.Name);
            regKey.SetValue("FontSize", textBoxMain.Font.Size);
            regKey.SetValue("FontBold", textBoxMain.Font.Bold);
            regKey.SetValue("FontItalic", textBoxMain.Font.Italic);
            // ウィンドウの位置と大きさを覚える
            regKey.SetValue("Left", DesktopBounds.Left);
            regKey.SetValue("Top", DesktopBounds.Top);
            regKey.SetValue("Width", DesktopBounds.Width);
            regKey.SetValue("Height", DesktopBounds.Height);
        }

        private void MenuItemFont_Click(object sender, EventArgs e)
        {
            fontDialog1.Font = textBoxMain.Font;
            if (DialogResult.OK == fontDialog1.ShowDialog())
                textBoxMain.Font = fontDialog1.Font;
        }

        private void MenuItemEditUndo_Click(object sender, EventArgs e)
        {
            textBoxMain.Undo();
        }

        private void MenuItemEditCut_Click(object sender, EventArgs e)
        {
            textBoxMain.Cut();
        }

        private void MenuItemEditCopy_Click(object sender, EventArgs e)
        {
            textBoxMain.Copy();
        }

        private void MenuItemEditPaste_Click(object sender, EventArgs e)
        {
            textBoxMain.Paste();
        }

        private void MenuItemEditDelete_Click(object sender, EventArgs e)
        {
            textBoxMain.SelectedText = "";
        }

        private void MenuItemEditSelectAll_Click(object sender, EventArgs e)
        {
            textBoxMain.SelectAll();
        }

        private void MenuItemEdit_DropDownOpened(object sender, EventArgs e)
        {
            MenuItemEditPaste.Enabled =
                Clipboard.ContainsText();

            bool b = textBoxMain.SelectionLength == 0;
            MenuItemEditCut.Enabled  = !b;
            MenuItemEditCopy.Enabled = !b;
            MenuItemEditDelete.Enabled = !b;

            b = textBoxMain.TextLength == 0;
            MenuItemEditSelectAll.Enabled = !b;
        }

        private void MenuItemEdit_DropDownClosed(object sender, EventArgs e)
        {
            MenuItemEditDelete.Enabled = false;
        }

        private void MenuItemHelpReadMe_Click(object sender, EventArgs e)
        {
            string s = System.IO.Path.GetDirectoryName(
                Application.ExecutablePath);
            s = System.IO.Path.Combine(s, "README.TXT");
            if (System.IO.File.Exists(s))
                System.Diagnostics.Process.Start(s);
            else
                MessageBox.Show(s + "が見つかりません",
                    ApplicationName);
        }

        private void MenuItemHelpWeb_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(
                "http://software.nikkeibp.co.jp/");
        }

        private void MenuItemHelpVersion_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ApplicationName + " 0.01" +
                Environment.NewLine +
                "(c)2009-2015 Mikio Nakajima", "バージョン情報");
        }

        private void MenuItemFilePrint_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == printDialog1.ShowDialog())
            {
                SetPrintDocument1();
                printDocument1.Print();
            }
        }

        private void SetPrintDocument1()
        {
            PrintString = textBoxMain.Text;
            printDocument1.DefaultPageSettings.Margins =
                new System.Drawing.Printing.Margins(20, 60, 20, 60);
            printDocument1.DocumentName = FileName;
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int charactersOnPage = 0;
            int linePerPage = 0;
            e.Graphics.MeasureString(PrintString, textBoxMain.Font,
                e.MarginBounds.Size,
                System.Drawing.StringFormat.GenericTypographic,
                out charactersOnPage, out linePerPage);
            e.Graphics.DrawString(PrintString, textBoxMain.Font,
                System.Drawing.Brushes.Black, e.MarginBounds,
                System.Drawing.StringFormat.GenericTypographic);
            PrintString = PrintString.Substring(charactersOnPage);
            if (PrintString.Length > 0)
                e.HasMorePages = true;
            else
                e.HasMorePages = false;
            PrintString = textBoxMain.Text;
        }

        private void MenuItemFilePrintPreview_Click(object sender, EventArgs e)
        {
            SetPrintDocument1();
            printPreviewDialog1.ShowDialog();
        }
    }
}
