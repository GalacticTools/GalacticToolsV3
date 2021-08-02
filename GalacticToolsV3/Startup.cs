using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using System.Web;
using DiscordRPC;

namespace GalacticToolsV3
{
    public partial class Startup : Form
    {
       
        public Startup()
        {
            InitializeComponent();
            CenterToScreen();
            client = new DiscordRpcClient("864584527233024023");
            client.Initialize();
            client.SetPresence(new RichPresence()
            {
                Details = "On Galatic Tools V3",
                State = "Online",
                Timestamps = Timestamps.Now,
                Assets = new Assets()
                {
                    LargeImageKey = "cock",
                    LargeImageText = "cock",
                }
            });
           
        }
        public DiscordRpcClient client;
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

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Welcome welcome = new Welcome();
            welcome.ShowDialog();
            this.Close();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://docs.google.com/document/d/1npB-pX_TAJHJOPJtUSqp8UUIIBSz8eR1pzhpyx9s2pc/edit?usp=sharing");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("DM NotOverTaken#0001 or ItzDrake#9999 To change the password \nOr Join the discord server at https://discord.gg/XayFrhB2Y4");
        }

        private void guna2CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            loginButton.FillColor = Color.FromArgb(50, 50, 50);

            loginButton.Enabled = true;
            
        }

        private void CLose_Click(object sender, EventArgs e)
        {

        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginSettings loginsettings = new LoginSettings();
            loginsettings.ShowDialog();
            this.Close();
        }
    }
}
