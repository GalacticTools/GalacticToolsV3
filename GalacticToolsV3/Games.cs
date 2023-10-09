using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.IO.Compression;
using System.Runtime.InteropServices;

namespace GalacticToolsV3
{
    public partial class Games : Form
    {
        public Games()
        {
            InitializeComponent();
            Directory.CreateDirectory(@"C:\Galactic Launcher");
        }

        public void DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            double receive = double.Parse(e.BytesReceived.ToString());
            double total = double.Parse(e.TotalBytesToReceive.ToString());
            double percentage = receive / total * 100;

            Invoke(new MethodInvoker(delegate ()
            {
                progressBar.Minimum = 0;
                IblStatus.Text = $"{string.Format("{0:0#}", percentage)}%";
                progressBar.Value = int.Parse(Math.Truncate(percentage).ToString());
            }));




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

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Settings settings = new Settings();
            settings.ShowDialog();
            this.Close();
        }

        private void guna2CircleButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Info info = new Info();
            info.ShowDialog();
            this.Close();
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox19_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void panel61_Paint(object sender, PaintEventArgs e)
        {

        }

      

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            Apps apps = new Apps();
            apps.ShowDialog();
            this.Close();
        }

        

        

        

        private void guna2PictureBox60_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox30_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint_2(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button34_Click(object sender, EventArgs e)
        {
        }
        public void GEDownloadCompletedAC1(object sender, AsyncCompletedEventArgs e)
        {
           
        }

        private void guna2Button45_Click(object sender, EventArgs e)
        {
           
        }
        public void GEDownloadCompletedmine(object sender, AsyncCompletedEventArgs e)
        {
          
        }

        private void guna2Button52_Click(object sender, EventArgs e)
        {
          
        }
        public void GEDownloadCompletedro(object sender, AsyncCompletedEventArgs e)
        {
           
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            
        }
       
        public void GEDownloadCompleteddesktopboi(object sender, AsyncCompletedEventArgs e)
        {

        }

        private void Games_Load(object sender, EventArgs e)
        {

        }

        

        private void guna2Button3_Click_1(object sender, EventArgs e)
        {
            
        }

        private void guna2Button8_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Welcome welcome = new Welcome();
            welcome.ShowDialog();
            this.Close();
        }

        private void guna2Button5_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Apps apps = new Apps();
            apps.ShowDialog();
            this.Close();
        }

        private void guna2Button6_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Emulators emulators = new Emulators();
            emulators.ShowDialog();
            this.Close();
        }

        private void guna2Button4_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Launchers launchers = new Launchers();
            launchers.ShowDialog();
            this.Close();
        }

        private void guna2Button7_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Coming Soon!");
        }
        public void GEDownloadCompletedboblox(object sender, AsyncCompletedEventArgs e)
        {
            string gaepath = @"C:\Galactic Launcher\";
            string gaeZipFile = @"C:\Galactic Launcher\Roblox.zip";

            ZipFile.ExtractToDirectory(gaeZipFile, gaepath);

            File.Delete(@"C:\Galactic Launcher\Roblox.zip");

            System.Diagnostics.Process.Start(@"C:\Galactic Launcher\Roblox\Versions\version-995b3631bc754ce1\RobloxPlayerLauncher.exe");

            guna2Button10.Text = "Installed";
            guna2Button10.FillColor = Color.FromArgb(115, 115, 115);

            guna2Button10.Enabled = false;
        }
        private void guna2Button10_Click(object sender, EventArgs e)
        {
            WebClient webClient = new WebClient();
            webClient.DownloadProgressChanged += DownloadProgressChanged;
            webClient.DownloadFileCompleted += GEDownloadCompletedboblox;
            webClient.DownloadFileAsync(new Uri("https://picteon.dev/files/Roblox.zip"), @"C:\\Galactic Launcher\Roblox.zip");
        }

        private void progressBar_ValueChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        public void GEDownloadCompletedminecraft(object sender, AsyncCompletedEventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Galactic Launcher\Minecraft.exe");

            guna2Button1.Text = "Installed";
            guna2Button1.FillColor = Color.FromArgb(115, 115, 115);

            guna2Button1.Enabled = false;
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            WebClient webClient = new WebClient();
            webClient.DownloadProgressChanged += DownloadProgressChanged;
            webClient.DownloadFileCompleted += GEDownloadCompletedminecraft;
            webClient.DownloadFileAsync(new Uri("https://launcher.mojang.com/download/Minecraft.exe"), @"C:\\Galactic Launcher\Minecraft.exe");
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            UnFlagger unFlagger = new UnFlagger();
            unFlagger.ShowDialog();
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            
        }
    }
}
