using System;
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
        private string FileNameValue = "";
        private string FileName
        {
            get { return FileNameValue; }
            set
            {
                string s = ApplicationName;
                if(value != "")
                {
                    s += " - " + value;
                }
                this.Text = s;
                FileNameValue = value;
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Text = ApplicationName;
            textBoxMain.Multiline = true;
            textBoxMain.ScrollBars = ScrollBars.Vertical;
            textBoxMain.Dock = DockStyle.Fill;
            saveFileDialog1.Filter = "テキスト文章|*.txt|すべてのファイル|*.*";
        }

        private void MenuItemFileExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MenuItemFileOpen_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            if (DialogResult.OK == openFileDialog1.ShowDialog())
            {
                LoadFile(openFileDialog1.FileName);
            }
        }
           
        private void LoadFile(string value)
        {
            textBoxMain.Text = System.IO.File.ReadAllText(
                value, Encoding.GetEncoding(
                    "Shift_JIS"));
            textBoxMain.Select(0, 0);
            FileName = value;
        }

        private void MenuItemFileSaveAs_Click(object sender, EventArgs e)
        {
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
    }
}
