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
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Alt) menuStrip1.Visible = true;
        }

        private void menuStrip1_MenuDeactivate(object sender, EventArgs e)
        {
            if (ShowMenue) menuStrip1.Visible = false;
        }

        private void ToolStripMenuItemSettingShowMenu_Click(object sender, EventArgs e)
        {
            ShowMenue = !ShowMenue;
        }
    }
}
