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
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
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

        private void Settings_Load(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }


        private void DarkMode_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {
            this.AutoScroll = true;
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void ShowPassword_CheckedChanged_1(object sender, EventArgs e)
        {
            
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void DarkMode_CheckedChanged_1(object sender, EventArgs e)
        {
            
            {
                Coming_Soon coming = new Coming_Soon();
                coming.ShowDialog();
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        

       

        private void guna2Button9_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Coming Soon!");
        }

        

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2CircleButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Info info = new Info();
            info.ShowDialog();
            this.Close();
        }

       

        private void guna2Button10_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button11_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Welcome welcome = new Welcome();
            welcome.ShowDialog();
            this.Close();
        }

        private void guna2Button10_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Games games = new Games();
            games.ShowDialog();
            this.Close();
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Apps apps = new Apps();
            apps.ShowDialog();
            this.Close();
        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            Emulators emulators = new Emulators();
            emulators.ShowDialog();
            this.Close();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Launchers launchers = new Launchers();
            launchers.ShowDialog();
            this.Close();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Coming Soon!");
        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.Path = guna2TextBox2.Text;
            Properties.Settings.Default.Save();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            Coming_Soon coming = new Coming_Soon();
            coming.ShowDialog();
        }

        private void fbd_HelpRequest(object sender, EventArgs e)
        {

        }

        private void guna2Button3_Click_1(object sender, EventArgs e)
        {
            
        }
    }
}
