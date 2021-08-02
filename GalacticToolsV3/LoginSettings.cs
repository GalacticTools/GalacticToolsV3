using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GalacticToolsV3
{
    public partial class LoginSettings : Form
    {
        public LoginSettings()
        {
            InitializeComponent();
            CenterToScreen();
            if (Properties.Settings.Default.DarkTheme == true)
            {
                DarkMode.Checked = true;
            }
            else
            {
                DarkMode.Checked = false;
            }
        }
        public string RandomGenerator()
        {
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            var numbers = "0123456789";
            var stringChars = new char[8];
            var random = new Random();

            for (int i = 0; i < 2; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }
            for (int i = 2; i < 6; i++)
            {
                stringChars[i] = numbers[random.Next(numbers.Length)];
            }
            for (int i = 6; i < 8; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }

            var finalString = new String(stringChars);
            this.Text = finalString;
            return (finalString);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LoginSettings_Load(object sender, EventArgs e)
        {

        }

        private void guna2ToggleSwitch1_CheckedChanged(object sender, EventArgs e)
        {
            if (DarkMode.Checked == true)
            {
                Properties.Settings.Default.DarkTheme = true;
                this.BackColor = Color.FromArgb(41, 36, 46);
                Close.BackColor = Color.FromArgb(41, 36, 46);
                Minimize.BackColor = Color.FromArgb(41, 36, 46);
               
            }
            else
            {
                Properties.Settings.Default.DarkTheme = false;
                this.BackColor = Color.White;
                Close.BackColor = Color.White;
                Minimize.BackColor = Color.White;
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Startup login = new Startup();
            login.ShowDialog();
            this.Close();
        }
    }
}
