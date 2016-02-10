using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApplicationTemplate01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ToolStripMenuItemFileExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            Properties.Settings.Default.Size = this.Size;
            Properties.Settings.Default.Location = this.Location;
            Properties.Settings.Default.Save();
        }

        private bool ShowMenue
        {
            get
            {
                return Properties.Settings.Default.ShowMenu;
            }
            set
            {
                Properties.Settings.Default.ShowMenu = value;
                ToolStripMenuItemSettingShowMenu.Checked = value;
                menuStrip1.Visible = value;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            ShowMenue = Properties.Settings.Default.ShowMenu;

            this.Text = Application.ProductName;
            this.MinimumSize =
                new System.Drawing.Size(300, 100);
            this.Size = Properties.Settings.Default.Size;

            this.Location =
                Properties.Settings.Default.Location;
            if (this.Left < Screen.GetWorkingArea(this).Left ||
                this.Left >= Screen.GetWorkingArea(this).Right)
                this.Left = 100;
            if (this.Top < Screen.GetWorkingArea(this).Top ||
                this.Top >= Screen.GetWorkingArea(this).Bottom)
                this.Top = 100;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Alt) menuStrip1.Visible = true;
        }

        private void menuStrip1_MenuDeactivate(object sender, EventArgs e)
        {
            if (!ShowMenue) menuStrip1.Visible = false;
        }

        private void ToolStripMenuItemSettingShowMenu_Click(object sender, EventArgs e)
        {
            ShowMenue = !ShowMenue;
        }

        private void ToolStripMenuItemHelpReadme_Click(object sender, EventArgs e)
        {
            string s = System.IO.Path.GetDirectoryName(
                Application.ExecutablePath);
            s = System.IO.Path.Combine(s, "readme.txt");
            if (System.IO.File.Exists(s))
                System.Diagnostics.Process.Start(s);
            else
                MessageBox.Show(s + "が見付かりません",
                    "エラー");
        }

        private void ToolStripMenuItemHelpWeb_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(
                "http://software.nikkeibp.co.jp/");
        }

        private void ToolStripMenuItemHelpVersion_Click(object sender, EventArgs e)
        {
            string s = "";
            s = Application.ProductName + " " +
                Application.ProductVersion +
                " (2012/02/29)" + Environment.NewLine;

            System.Diagnostics.FileVersionInfo
                fileVersionInfo = (
                System.Diagnostics.FileVersionInfo.
                GetVersionInfo(Application.ExecutablePath));
            string copyright =
                fileVersionInfo.LegalCopyright.ToString();
            s += copyright + Environment.NewLine;

            s += "実行ファイル:" + Environment.NewLine +
                Application.ExecutablePath +
                Environment.NewLine + "(";
            if (Environment.Is64BitProcess)
                s += "64";
            else
                s += "32";
            s += "ビット・プロセスとして稼働) " +
                Environment.NewLine + Environment.NewLine;

            Microsoft.VisualBasic.Devices.Computer my
                = new Microsoft.VisualBasic.Devices.
                Computer();
            s += "オペレーションシステム :" +
                Environment.NewLine + my.Info.OSFullName +
                " " + my.Info.OSVersion + " ";
            if (Environment.Is64BitOperatingSystem)
                s += "64";
            else
                s += "32";
            s += "ビット";

            MessageBox.Show(s, "バージョン情報");
        }
    }
}
