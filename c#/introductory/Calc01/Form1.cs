using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc01
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

        private enum Operations
        {
            None, Add, Subtract, Multiply, Divide
        }
        private Operations Operation;

        private double DisplayValueValue, HiddenValue;
        private double DisplayValue
        {
            get { return DisplayValueValue; }
            set
            {
                DisplayValueValue = value;
                if (!(labelMain.Text.Contains(".") && 
                        labelMain.Text.EndsWith("0")))
                    try
                    {
                        labelMain.Text =
                            ((decimal)value).ToString();
                    }
                    catch (Exception)
                    {
                        labelMain.Text = value.ToString();

                    }
            }
        }

        private bool IsNewValue;
        private double Memory = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;

            this.Text = Application.ProductName;

            //this.MinimumSize =
            //    new System.Drawing.Size(300, 100);
            //this.Size = Properties.Settings.Default.Size;
            //ShowMenue = Properties.Settings.Default.ShowMenu;

            ShowMenue = true;
            ToolStripMenuItemSetting.Visible = false;

            this.Location =
                Properties.Settings.Default.Location;
            if (this.Left < Screen.GetWorkingArea(this).Left ||
                this.Left >= Screen.GetWorkingArea(this).Right)
                this.Left = 100;
            if (this.Top < Screen.GetWorkingArea(this).Top ||
                this.Top >= Screen.GetWorkingArea(this).Bottom)
                this.Top = 100;

            labelMain.TextAlign =
                System.Drawing.ContentAlignment.MiddleRight;
            Initalize();
        }

        private void Initalize()
        {
            HiddenValue = 0;
            DisplayValue = 0;
            IsNewValue = true;
            Operation = Operations.None;
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

        private void Button_Click(
            object sender, EventArgs e)
        {
            Button_Click(((Button)sender).Text.ToCharArray()[0]);

        }
        private void Button_Click(char c)
        {
            c = char.ToUpper(c);
            switch(c)
            {
                case '+':
                    UpdateValues();
                    Operation = Operations.Add; break;
                case '-':
                    UpdateValues();
                    Operation = Operations.Subtract; break;
                case '*':
                    UpdateValues();
                    Operation = Operations.Multiply; break;
                case '/':
                    UpdateValues();
                    Operation = Operations.Divide; break;
                case '=':
                    UpdateValues();
                    Operation = Operations.None; break;
                case 'C':
                    Initalize();
                    UpdateValues();
                    break;
                case '±':
                case 'P':
                    if (!IsNewValue)
                    {
                        if (labelMain.Text.StartsWith("-"))
                            labelMain.Text =
                                labelMain.Text.Substring(1);
                        else
                            labelMain.Text = "-" + labelMain.Text;
                        SetDisplayValueFormText();
                    }break;
                case '.':
                    if (IsNewValue) labelMain.Text = "0";
                    if (!labelMain.Text.Contains("."))
                        labelMain.Text += c;
                    IsNewValue = false;
                    break;
                case 'B':
                    labelMain.Text = labelMain.Text.Substring(
                        0, labelMain.Text.Length - 1);
                    if (labelMain.Text == "")
                        labelMain.Text = "0";
                    SetDisplayValueFormText();
                    IsNewValue = false;
                    break;
                case '0':
                case '1': case '2': case '3':
                case '4': case '5': case '6': case '7':
                case '8': case '9':
                    if (IsNewValue) labelMain.Text = "";
                    labelMain.Text += c;
                    SetDisplayValueFormText();
                    IsNewValue = false;
                    break;
                case 'M':
                    Memory = DisplayValue;
                    break;
                case 'R':
                    DisplayValue = Memory;
                    IsNewValue = false;
                    break;
            }
        }

        private void UpdateValues()
        {
            if (!IsNewValue)
            {
                switch (Operation)
                {
                    case Operations.None:
                        HiddenValue = DisplayValue; break;
                    case Operations.Add:
                        HiddenValue += DisplayValue; break;
                    case Operations.Subtract:
                        HiddenValue -= DisplayValue; break;
                    case Operations.Multiply:
                        HiddenValue *= DisplayValue; break;
                    case Operations.Divide:
                        HiddenValue /= DisplayValue; break;

                }
                IsNewValue = true;
                DisplayValue = HiddenValue;
            }
        }

        private void SetDisplayValueFormText()
        {
            try
            {
                DisplayValue = double.Parse(labelMain.Text);
            }
            catch (Exception)
            {
                DisplayValue = 0;
            }
            
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Button_Click(e.KeyChar);
        }

        protected override bool ProcessDialogKey(Keys keyData)
        {
            switch(keyData & Keys.KeyCode)
            {
                case Keys.Enter:
                    Button_Click('='); break;
                case Keys.Back:
                    Button_Click('B'); break;
                case Keys.Escape:
                    Button_Click('C'); break;
                default:
                    return base.ProcessDialogKey(keyData);
            }
            return true;
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
