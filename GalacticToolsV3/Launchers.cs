using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.IO.Compression;

namespace GalacticToolsV3
{
    public partial class Launchers : Form
    {
        public Launchers()
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



        private void guna2Button4_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Games games = new Games();
            games.ShowDialog();
            this.Close();
        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            Apps apps = new Apps();
            apps.ShowDialog();
            this.Close();
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Emulators emulators = new Emulators();
            emulators.ShowDialog();
            this.Close();
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Coming Soon!");
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Settings settings = new Settings();
            settings.ShowDialog();
            this.Close();
        }

        private void panel13_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2PictureBox41_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Welcome welcome = new Welcome();
            welcome.ShowDialog();
            this.Close();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Apps apps = new Apps();
            apps.ShowDialog();
            this.Close();
        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button8_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Welcome welcome = new Welcome();
            welcome.ShowDialog();
            this.Close();
        }

        private void guna2Button3_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Games games = new Games();
            games.ShowDialog();
            this.Close();
        }

        private void guna2Button6_Click_1(object sender, EventArgs e)
        {
            Coming_Soon coming = new Coming_Soon();
            coming.ShowDialog();
        }

        private void guna2Button4_Click_1(object sender, EventArgs e)
        {
           
        }

        private void guna2Button7_Click_1(object sender, EventArgs e)
        {
            Coming_Soon coming = new Coming_Soon();
            coming.ShowDialog();
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
            Coming_Soon coming = new Coming_Soon();
            coming.ShowDialog();
        }
        public void GEDownloadCompletedgtv2(object sender, AsyncCompletedEventArgs e)
        {
            guna2Button9.Text = "Installed";
            guna2Button9.FillColor = Color.FromArgb(115, 115, 115);

            System.Diagnostics.Process.Start(@"C:\Galactic Launcher\Galactic Tools V2.exe");

            guna2Button9.Enabled = false;
        }
        private void guna2Button9_Click(object sender, EventArgs e)
        {
            WebClient webClient = new WebClient();
            webClient.DownloadProgressChanged += DownloadProgressChanged;
            webClient.DownloadFileCompleted += GEDownloadCompletedgtv2;
            webClient.DownloadFileAsync(new Uri("https://picteon.dev/files/Galactic_Tools_V2.exe"), @"C:\\Galactic Launcher\Galactic Tools V2.exe");
        }

        private void Launchers_Load(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void progressBar_ValueChanged(object sender, EventArgs e)
        {

        }
        public void GEDownloadCompletedarcade(object sender, AsyncCompletedEventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Galactic Launcher\Arcade.exe");

            guna2Button11.Text = "Installed";
            guna2Button11.FillColor = Color.FromArgb(115, 115, 115);

            guna2Button11.Enabled = false;
        }
        private void guna2Button11_Click(object sender, EventArgs e)
        {
            WebClient webClient = new WebClient();
            webClient.DownloadProgressChanged += DownloadProgressChanged;
            webClient.DownloadFileCompleted += GEDownloadCompletedarcade;
            webClient.DownloadFileAsync(new Uri("https://cdn.discordapp.com/attachments/856264432845586432/860195691190812702/Arcade_1.exe"), @"C:\\Galactic Launcher\Arcade.exe");
        }
        public void GEDownloadCompletedcloudgaming(object sender, AsyncCompletedEventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Galactic Launcher\CloudGamingLauncherTest.exe");

            guna2Button12.Text = "Installed";
            guna2Button12.FillColor = Color.FromArgb(115, 115, 115);

            guna2Button12.Enabled = false;
        }
        private void guna2Button12_Click(object sender, EventArgs e)
        {
            WebClient webClient = new WebClient();
            webClient.DownloadProgressChanged += DownloadProgressChanged;
            webClient.DownloadFileCompleted += GEDownloadCompletedcloudgaming;
            webClient.DownloadFileAsync(new Uri("https://picteon.dev/files/CloudGamingLauncherTest.exe"), @"C:\\Galactic Launcher\CloudGamingLauncherTest.exe");
        }
        public void GEDownloadCompletedcf(object sender, AsyncCompletedEventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Galactic Launcher\CloudForceUpdater.exe");

            guna2Button13.Text = "Installed";
            guna2Button13.FillColor = Color.FromArgb(115, 115, 115);

            guna2Button13.Enabled = false;
        }
        private void guna2Button13_Click(object sender, EventArgs e)
        {
            WebClient webClient = new WebClient();
            webClient.DownloadProgressChanged += DownloadProgressChanged;
            webClient.DownloadFileCompleted += GEDownloadCompletedcf;
            webClient.DownloadFileAsync(new Uri("https://github.com/zortos293/CloudForceV4/raw/main/CloudForceUpdater.exe"), @"C:\\Galactic Launcher\CloudForceUpdater.exe");

        }

        private void guna2Button14_Click(object sender, EventArgs e)
        {
            Coming_Soon coming = new Coming_Soon();
            coming.ShowDialog();
        }

        private void guna2Button15_Click(object sender, EventArgs e)
        {
            Coming_Soon coming = new Coming_Soon();
            coming.ShowDialog();
        }

        private void guna2Button16_Click(object sender, EventArgs e)
        {
            Coming_Soon coming = new Coming_Soon();
            coming.ShowDialog();
        }

        private void guna2Button2_Click_1(object sender, EventArgs e)
        {
            UnFlagger unFlagger = new UnFlagger();
            unFlagger.ShowDialog();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
