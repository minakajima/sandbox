// See https://aka.ms/new-console-template for more information
using System;
using System.Windows.Forms;

namespace windowApp_sample
{
    public static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }

    public class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Handle the form closing event
            // You can add your custom logic here
        }

        private void InitializeComponent()
        {
            this.Text = "My Windows App";
            this.Size = new System.Drawing.Size(400, 300);
            this.FormClosing += MainForm_FormClosing;

            // Create a new button
            Button closeButton = new Button();
            closeButton.Text = "Close";
            closeButton.Location = new System.Drawing.Point(150, 200);

            // Add a click event handler
            closeButton.Click += (sender, e) => {
                this.Close();
            };

            // Add the button to the form
            this.Controls.Add(closeButton);

            // Add your other controls and logic here
          }
    }
}
