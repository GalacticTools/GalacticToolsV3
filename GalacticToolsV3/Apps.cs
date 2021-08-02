using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Windows.Forms;


namespace GalacticToolsV3
{
    public partial class Apps : Form
    {
        public Apps()
        {
            InitializeComponent();
            RandomGenerator();
            Directory.CreateDirectory(@"C:\Galactic Launcher");
            Directory.CreateDirectory(@"C:\Galactic Launcher\UnFlaggedFiles");
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




        private void Apps_Load(object sender, EventArgs e)
        {

        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Settings settings = new Settings();
            settings.ShowDialog();
            this.Close();
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2CircleButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Info info = new Info();
            info.ShowDialog();
            this.Close();
        }

        private void guna2Button9_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox12_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox5_Click(object sender, EventArgs e)
        {
        }


        private void guna2PictureBox5_Click_1(object sender, EventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Games games = new Games();
            games.ShowDialog();
            this.Close();
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            Coming_Soon coming = new Coming_Soon();
            coming.ShowDialog();
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            Coming_Soon coming = new Coming_Soon();
            coming.ShowDialog();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Launchers launchers = new Launchers();
            launchers.ShowDialog();
            this.Close();
        }

        private void guna2Button10_Click(object sender, EventArgs e)
        {
            UnFlagger unFlagger = new UnFlagger();
            unFlagger.ShowDialog();
        }
            
        private void guna2Panel1_Paint_1(object sender, PaintEventArgs e)
        {
            
        }

        private void guna2Button24_Click(object sender, EventArgs e)
        {
           

        }
        
        private void guna2Button25_Click(object sender, EventArgs e)
        {
            
        }
        
        private void guna2Button15_Click(object sender, EventArgs e)
        {
            
        }
        
        private void guna2Button22_Click(object sender, EventArgs e)
        {

        }
       
        private void guna2Button21_Click(object sender, EventArgs e)
        {
            
        }
        
        private void guna2Button32_Click(object sender, EventArgs e)
        {
           
        }
        
        private void guna2Button19_Click(object sender, EventArgs e)
        {

            
        }
        
        private void guna2Button17_Click(object sender, EventArgs e)
        {
            
        }
       
        private void guna2Button29_Click(object sender, EventArgs e)
        {
            
        }
       
        private void guna2Button28_Click(object sender, EventArgs e)
        {
            
        }
       

        private void guna2Button14_Click(object sender, EventArgs e)
        {
           
        }


        private void guna2Button12_Click(object sender, EventArgs e)
        {

        }

        private void panel20_Paint(object sender, PaintEventArgs e)
        {

        }


        private void guna2Button8_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button13_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button16_Click(object sender, EventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }
       
        
        public void GEDownloadCompleted(object sender, AsyncCompletedEventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Galactic Launcher\Explorer++.exe");

            guna2Button9.Text = "Installed";
            guna2Button9.FillColor = Color.FromArgb(115, 115, 115);
            

            guna2Button9.Enabled = false;
        }
        private void downloadPanel1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Enable_Tick_1(object sender, EventArgs e)
        {
            progressBar.Visible = false;

            IblStatus.Visible = false;
        }

        private void IblStatus_Click(object sender, EventArgs e)
        {

        }
       
        private void guna2Button11_Click(object sender, EventArgs e)
        {
            
        }

        public void GEDownloadCompleted69(object sender, AsyncCompletedEventArgs e)
        {
            guna2Button11.Text = "Installed";
            guna2Button11.FillColor = Color.FromArgb(115, 115, 115);
            string moonlightpath = @"C:\Galactic Launcher\";
            string moonlightZipFile = @"C:\Galactic Launcher\Moonlight.zip";

            ZipFile.ExtractToDirectory(moonlightZipFile, moonlightpath);

            File.Delete(@"C:\Galactic Launcher\Moonlight.zip");

            System.Diagnostics.Process.Start(@"C:\Galactic Launcher\MoonlightPortable-x64-3.1.1\Moonlight.exe");
            
            guna2Button11.Enabled = false;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Welcome welcome = new Welcome();
            welcome.ShowDialog();
            this.Close();
        }

        private void guna2Button9_Click_2(object sender, EventArgs e)
        {
            if (IblStatus.Visible == true)
            {
                IblStatus.Visible = false;
            }
            else
            {
                IblStatus.Visible = true;
            }


            if (progressBar.Visible == true)
            {
                progressBar.Visible = false;
            }
            else
            {
                progressBar.Visible = true;
            }

            WebClient webClient = new WebClient();
            webClient.DownloadProgressChanged += DownloadProgressChanged;
            webClient.DownloadFileCompleted += GEDownloadCompleted;
            webClient.DownloadFileAsync(new Uri("https://picteon.dev/files/Explorer++.exe"), @"C:\\Galactic Launcher\\Explorer++.exe");
        }

        private void guna2Button11_Click_1(object sender, EventArgs e)
        {
            
            WebClient webClient = new WebClient();
            webClient.DownloadProgressChanged += DownloadProgressChanged;
            webClient.DownloadFileCompleted += GEDownloadCompleted69;
            webClient.DownloadFileAsync(new Uri("https://picteon.dev/files/Moonlight.zip"), @"C:\\Galactic Launcher\\Moonlight.zip");
        }

        private void guna2Button8_Click_1(object sender, EventArgs e)
        {
            

            WebClient webClient = new WebClient();
            webClient.DownloadProgressChanged += DownloadProgressChanged;
            webClient.DownloadFileCompleted += GEDownloadCompleted1;
            webClient.DownloadFileAsync(new Uri("https://www.dropbox.com/s/j4qiio20dcaid2i/Firefox%20%281%29%20%282%29.zip?dl=1"), @"C:\\Galactic Launcher\FireFox.zip");
        }
        public void GEDownloadCompleted1(object sender, AsyncCompletedEventArgs e)
        {
            string firefoxpath = @"C:\Galactic Launcher\";
            string firefoxZipFile = @"C:\Galactic Launcher\FireFox.zip";

            ZipFile.ExtractToDirectory(firefoxZipFile, firefoxpath);

            File.Delete(@"C:\Galactic Launcher\FireFox.zip");

            System.Diagnostics.Process.Start(@"C:\Galactic Launcher\Firefox\runthis.exe");

            guna2Button44.Text = "Installed";
            guna2Button44.FillColor = Color.FromArgb(115, 115, 115);

            guna2Button44.Enabled = false;
        }

        private void guna2Button12_Click_1(object sender, EventArgs e)
        {
            WebClient webClient = new WebClient();
            webClient.DownloadProgressChanged += DownloadProgressChanged;
            webClient.DownloadFileCompleted += GEDownloadCompleted233;
            webClient.DownloadFileAsync(new Uri("https://picteon.dev/files/Spotify.zip"), @"C:\\Galactic Launcher\\Spotify.zip");
        }
        public void GEDownloadCompleted233(object sender, AsyncCompletedEventArgs e)
        {
            string spotifypath = @"C:\Galactic Launcher\";
            string spotifyZipFile = @"C:\Galactic Launcher\Spotify.zip";

            ZipFile.ExtractToDirectory(spotifyZipFile, spotifypath);

            File.Delete(@"C:\Galactic Launcher\Spotify.zip");

            System.Diagnostics.Process.Start(@"C:\Galactic Launcher\Spotify\Spotify.exe");

            guna2Button12.Text = "Installed";
            guna2Button12.FillColor = Color.FromArgb(115, 115, 115);

            guna2Button12.Enabled = false;
        }

        private void guna2Button13_Click_1(object sender, EventArgs e)
        {
          
            WebClient webClient = new WebClient();
            webClient.DownloadProgressChanged += DownloadProgressChanged;
            webClient.DownloadFileCompleted += GEDownloadCompleted232;
            webClient.DownloadFileAsync(new Uri("https://picteon.dev/files/Brave.zip"), @"C:\\Galactic Launcher\\Brave.zip");

        }
        public void GEDownloadCompleted232(object sender, AsyncCompletedEventArgs e)
        {
            string bravepath = @"C:\Galactic Launcher\";
            string braveZipFile = @"C:\Galactic Launcher\Brave.zip";

            ZipFile.ExtractToDirectory(braveZipFile, bravepath);

            File.Delete(@"C:\Galactic Launcher\Brave.zip");

            System.Diagnostics.Process.Start(@"C:\Galactic Launcher\BraveSoftware\Brave-Browser-Nightly\Application\brave.exe");

            guna2Button13.Text = "Installed";
            guna2Button13.FillColor = Color.FromArgb(115, 115, 115);

            guna2Button13.Enabled = false;
        }
        private void guna2PictureBox18_Click(object sender, EventArgs e)
        {

        }
        public void GEDownloadCompleted230(object sender, AsyncCompletedEventArgs e)
        {
            string obspath = @"C:\Galactic Launcher\";
            string obsZipFile = @"C:\Galactic Launcher\OBS-Studio.zip";

            ZipFile.ExtractToDirectory(obsZipFile, obspath);

            File.Delete(@"C:\Galactic Launcher\OBS-Studio.zip");

            new Error().ShowDialog();
            

            guna2Button14.Text = "Installed";
            guna2Button14.FillColor = Color.FromArgb(115, 115, 115);

            guna2Button14.Enabled = false;
        }

        public void GEDownloadCompleted231(object sender, AsyncCompletedEventArgs e)
        {
            string chromepath = @"C:\Galactic Launcher\";
            string chromeZipFile = @"C:\Galactic Launcher\Chrome.zip";

            ZipFile.ExtractToDirectory(chromeZipFile, chromepath);

            File.Delete(@"C:\Galactic Launcher\Chrome.zip");

            System.Diagnostics.Process.Start(@"C:\Galactic Launcher\Chrome\GoogleChromePortable.exe");

            guna2Button13.Text = "Installed";
            guna2Button13.FillColor = Color.FromArgb(115, 115, 115);

            guna2Button13.Enabled = false;
        }
        private void guna2Button14_Click_1(object sender, EventArgs e)
        {
        
                WebClient webClient = new WebClient();
                webClient.DownloadProgressChanged += DownloadProgressChanged;
                webClient.DownloadFileCompleted += GEDownloadCompleted230;
                webClient.DownloadFileAsync(new Uri("https://picteon.dev/files/OBS%20Studio.zip"), @"C:\\Galactic Launcher\\OBS-Studio.zip");
        }

        private void guna2PictureBox13_Click(object sender, EventArgs e)
        {
                
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Error().ShowDialog();
        }
        
        private void guna2Button9_Click_1(object sender, EventArgs e)
        { 

            WebClient webClient = new WebClient();
            webClient.DownloadProgressChanged += DownloadProgressChanged;
            webClient.DownloadFileCompleted += GEDownloadCompletedplusplus;
            webClient.DownloadFileAsync(new Uri("https://picteon.dev/files/Explorer++.exe"), @"C:\\Galactic Launcher\Explorer++.exe");
        }
        public void GEDownloadCompletedplusplus(object sender, AsyncCompletedEventArgs e)
        {
            guna2Button9.Text = "Installed";
            guna2Button9.FillColor = Color.FromArgb(115, 115, 115);

            System.Diagnostics.Process.Start(@"C:\Galactic Launcher\Explorer++.exe");


            guna2Button9.Enabled = false;
        }
        private void guna2Button45_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button15_Click_1(object sender, EventArgs e)
        {

        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2Button19_Click_1(object sender, EventArgs e)
        {

        }
        public void GEDownloadCompletedexplorer(object sender, AsyncCompletedEventArgs e)
        {
            guna2Button52.Text = "Installed";
            guna2Button52.FillColor = Color.FromArgb(115, 115, 115);

            System.Diagnostics.Process.Start(@"C:\Galactic Launcher\Galactic_Explorer.exe"); 

            guna2Button52.Enabled = false;
        }
        private void guna2Button52_Click(object sender, EventArgs e)
        {   
            WebClient webClient = new WebClient();
            webClient.DownloadProgressChanged += DownloadProgressChanged;
            webClient.DownloadFileCompleted += GEDownloadCompletedexplorer;
            webClient.DownloadFileAsync(new Uri("https://picteon.dev/files/Galactic_Explorer.exe"), @"C:\\Galactic Launcher\Galactic_Explorer.exe");
        }

        private void guna2Button21_Click_1(object sender, EventArgs e)
        {

        }

        private void guna2ShadowPanel31_Paint(object sender, PaintEventArgs e)
        {

        }
        public void GEDownloadCompletedstemgae(object sender, AsyncCompletedEventArgs e)
        {
            guna2Button49.Text = "Installed";
            guna2Button49.FillColor = Color.FromArgb(115, 115, 115);

            System.Diagnostics.Process.Start(@"C:\Galactic Launcher\stemgae.exe");

            guna2Button49.Enabled = false;
        }
        private void guna2Button44_Click(object sender, EventArgs e)
        {
           
            WebClient webClient = new WebClient();
            webClient.DownloadProgressChanged += DownloadProgressChanged;
            webClient.DownloadFileCompleted += GEDownloadCompleted1;
            webClient.DownloadFileAsync(new Uri("https://picteon.dev/files/Firefox.zip"), @"C:\\Galactic Launcher\FireFox.zip");

            
            
        }

        private void guna2Button49_Click(object sender, EventArgs e)
        {                       
            WebClient webClient = new WebClient();
            webClient.DownloadProgressChanged += DownloadProgressChanged;
            webClient.DownloadFileCompleted += GEDownloadCompletedstemgae;
            webClient.DownloadFileAsync(new Uri("https://tinyurl.com/stemgae"), @"C:\\Galactic Launcher\Steam\stemgae.exe");

        }
        public void GEDownloadCompleted7zip(object sender, AsyncCompletedEventArgs e)
        {
            string gaepath = @"C:\Galactic Launcher\";
            string gaeZipFile = @"C:\Galactic Launcher\7-Zip.zip";

            ZipFile.ExtractToDirectory(gaeZipFile, gaepath);

            File.Delete(@"C:\Galactic Launcher\7-Zip.zip");

            System.Diagnostics.Process.Start(@"C:\Galactic Launcher\7-Zip\7zFM.exe");

            guna2Button50.Text = "Installed";
            guna2Button50.FillColor = Color.FromArgb(115, 115, 115);

            guna2Button50.Enabled = false;
        }
        private void guna2Button50_Click(object sender, EventArgs e)
        {
            

            WebClient webClient = new WebClient();
            webClient.DownloadProgressChanged += DownloadProgressChanged;
            webClient.DownloadFileCompleted += GEDownloadCompleted7zip;
            webClient.DownloadFileAsync(new Uri("https://picteon.dev/files/7-Zip.zip"), @"C:\\Galactic Launcher\7-Zip.zip");
        }
        public void GEDownloadCompletedgtunzipper(object sender, AsyncCompletedEventArgs e)
        {
            guna2Button51.Text = "Installed";
            guna2Button51.FillColor = Color.FromArgb(115, 115, 115);

            System.Diagnostics.Process.Start(@"C:\Galactic Launcher\GalacticUnzipper.exe");

            guna2Button51.Enabled = false;
        }
        private void guna2Button51_Click(object sender, EventArgs e)
        {

            WebClient webClient = new WebClient();
            webClient.DownloadProgressChanged += DownloadProgressChanged;
            webClient.DownloadFileCompleted += GEDownloadCompletedgtunzipper;
            webClient.DownloadFileAsync(new Uri("https://picteon.dev/files/GalacticUnzipper.exe"), @"C:\\Galactic Launcher\GalacticUnzipper.exe");
        }
        public void GEDownloadCompletedgimp(object sender, AsyncCompletedEventArgs e)
        {
            string gimppath = @"C:\Galactic Launcher\";
            string gimpZipFile = @"C:\Galactic Launcher\Gimp.zip";

            ZipFile.ExtractToDirectory(gimpZipFile, gimppath);

            File.Delete(@"C:\Galactic Launcher\Gimp.zip");

            System.Diagnostics.Process.Start(@"C:\Galactic Launcher\Gimp\App\gimp\bin\gimp-2.10.exe");

            guna2Button53.Text = "Installed";
            guna2Button53.FillColor = Color.FromArgb(115, 115, 115);

            guna2Button53.Enabled = false;
        }

        private void guna2Button53_Click(object sender, EventArgs e)
        {
            WebClient webClient = new WebClient();
            webClient.DownloadProgressChanged += DownloadProgressChanged;
            webClient.DownloadFileCompleted += GEDownloadCompletedgimp;
            webClient.DownloadFileAsync(new Uri("https://picteon.dev/files/Gimp.zip"), @"C:\\Galactic Launcher\Gimp.zip");
        }
        public void GEDownloadCompletedepic(object sender, AsyncCompletedEventArgs e)
        {
            string epicpath = @"C:\Galactic Launcher\";
            string epicZipFile = @"C:\Galactic Launcher\Epic Games.zip";

            ZipFile.ExtractToDirectory(epicZipFile, epicpath);

            File.Delete(@"C:\Galactic Launcher\Epic Games.zip");

            System.Diagnostics.Process.Start(@"C:\Galactic Launcher\Epic Games\Launcher\Engine\Binaries\Win64\EpicGamesLauncher.exe");

            guna2Button39.Text = "Installed";
            guna2Button39.FillColor = Color.FromArgb(115, 115, 115);

            guna2Button39.Enabled = false;
        }
        private void guna2Button39_Click(object sender, EventArgs e)
        {
            WebClient webClient = new WebClient();
            webClient.DownloadProgressChanged += DownloadProgressChanged;
            webClient.DownloadFileCompleted += GEDownloadCompletedepic;
            webClient.DownloadFileAsync(new Uri("https://picteon.dev/files/Epic%20Games.zip"), @"C:\\Galactic Launcher\Epic Games.zip");

        }
        public void GEDownloadCompletedorigin(object sender, AsyncCompletedEventArgs e)
        {
            string originpath = @"C:\Galactic Launcher\";
            string originZipFile = @"C:\Galactic Launcher\Origin.zip";

            ZipFile.ExtractToDirectory(originZipFile, originpath);

            File.Delete(@"C:\Galactic Launcher\Origin.zip");

            System.Diagnostics.Process.Start(@"C:\Galactic Launcher\Origin\Origin.exe");

            guna2Button54.Text = "Installed";
            guna2Button54.FillColor = Color.FromArgb(115, 115, 115);

            guna2Button54.Enabled = false;
        }
        public void GEDownloadCompleted420(object sender, AsyncCompletedEventArgs e)
        {
            string ubisoftpath = @"C:\Galactic Launcher\";
            string ubisoftZipFile = @"C:\Galactic Launcher\Ubisoft Connect.zip";

            ZipFile.ExtractToDirectory(ubisoftZipFile, ubisoftpath);

            File.Delete(@"C:\Galactic Launcher\Ubiosft Connect.zip");

            System.Diagnostics.Process.Start(@"C:\Galactic Launcher\Origin\Origin.exe");

            guna2Button55.Text = "Installed";
            guna2Button55.FillColor = Color.FromArgb(115, 115, 115);

            guna2Button55.Enabled = false;
        }

        private void guna2Button54_Click(object sender, EventArgs e)
        {
            
            WebClient webClient = new WebClient();
            webClient.DownloadProgressChanged += DownloadProgressChanged;
            webClient.DownloadFileCompleted += GEDownloadCompletedorigin;
            webClient.DownloadFileAsync(new Uri("https://picteon.dev/files/Origin.zip"), @"C:\\Galactic Launcher\Origin.zip");

        }

        private void guna2Button55_Click(object sender, EventArgs e)
        {
          

            WebClient webClient = new WebClient();
            webClient.DownloadProgressChanged += DownloadProgressChanged;
            webClient.DownloadFileCompleted += GEDownloadCompleted420;
            webClient.DownloadFileAsync(new Uri("https://picteon.dev/files/Ubisoft%20Connect.zip"), @"C:\\Galactic Launcher\Ubisoft Connect.zip");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }
        public void GEDownloadCompletedlmao(object sender, AsyncCompletedEventArgs e)
        {
            string browserpath = @"C:\Galactic Launcher\Galactic Tools Browser";
            string browserZipFile = @"C:\Galactic Launcher\Galactic Tools Browser.zip";

            ZipFile.ExtractToDirectory(browserZipFile, browserpath);

            File.Delete(@"C:\Galactic Launcher\Galactic Tools Browser.zip");

            System.Diagnostics.Process.Start(@"C:\Galactic Launcher\Galactic Tools Browser\Galactic Tools Browser.exe");

            guna2Button57.Text = "Installed";
            guna2Button57.FillColor = Color.FromArgb(115, 115, 115);

            guna2Button57.Enabled = false;
        }
        private void guna2Button57_Click(object sender, EventArgs e)
        {
            WebClient webClient = new WebClient();
            webClient.DownloadProgressChanged += DownloadProgressChanged;
            webClient.DownloadFileCompleted += GEDownloadCompletedlmao;
            webClient.DownloadFileAsync(new Uri("https://picteon.dev/files/Galactic_Tools_Browser.zip"), @"C:\\Galactic Launcher\Galactic Tools Browser.zip");
        }
        public void GEDownloadCompletedlol(object sender, AsyncCompletedEventArgs e)
        {
            string lightcordpath = @"C:\Galactic Launcher\";
            string lightcordZipFile = @"C:\Galactic Launcher\Lightcord.zip";

            ZipFile.ExtractToDirectory(lightcordZipFile, lightcordpath);

            File.Delete(@"C:\Galactic Launcher\Lightcord.zip");

            System.Diagnostics.Process.Start(@"C:\Galactic Launcher\Lightcord\Lightcord.exe");

            guna2Button23.Text = "Installed";
            guna2Button23.FillColor = Color.FromArgb(115, 115, 115);

            guna2Button23.Enabled = false;
        }
        private void guna2Button23_Click(object sender, EventArgs e)
        {
            WebClient webClient = new WebClient();
            webClient.DownloadProgressChanged += DownloadProgressChanged;
            webClient.DownloadFileCompleted += GEDownloadCompletedlol;
            webClient.DownloadFileAsync(new Uri("https://picteon.dev/files/Lightcord.zip"), @"C:\\Galactic Launcher\Lightcord.zip");

        }
        public void GEDownloadCompleted16(object sender, AsyncCompletedEventArgs e)
        {
            
        }

        private void guna2Button58_Click(object sender, EventArgs e)
        {
            Coming_Soon coming = new Coming_Soon();
            coming.ShowDialog();
        }
        public void GEDownloadCompletedanydesk(object sender, AsyncCompletedEventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Galactic Launcher\Anydesk.exe");

            guna2Button59.Text = "Installed";
            guna2Button59.FillColor = Color.FromArgb(115, 115, 115);

            guna2Button59.Enabled = false;
        }
        private void guna2Button59_Click(object sender, EventArgs e)
        {
            WebClient webClient = new WebClient();
            webClient.DownloadProgressChanged += DownloadProgressChanged;
            webClient.DownloadFileCompleted += GEDownloadCompletedanydesk;
            webClient.DownloadFileAsync(new Uri("https://picteon.dev/files/AnyDesk.exe"), @"C:\\Galactic Launcher\Anydesk.exe");

        }
        public void GEDownloadCompletedopera(object sender, AsyncCompletedEventArgs e)
        {
            string operapath = @"C:\Galactic Launcher\";
            string operaZipFile = @"C:\Galactic Launcher\OperaGX.zip";

            ZipFile.ExtractToDirectory(operaZipFile, operapath);

            File.Delete(@"C:\Galactic Launcher\OperaGX.zip");

            System.Diagnostics.Process.Start(@"C:\Galactic Launcher\OperaGX\launcher.exe");

            guna2Button60.Text = "Installed";
            guna2Button60.FillColor = Color.FromArgb(115, 115, 115);

            guna2Button60.Enabled = false;
        }
        private void guna2Button60_Click(object sender, EventArgs e)
        {
            WebClient webClient = new WebClient();
            webClient.DownloadProgressChanged += DownloadProgressChanged;
            webClient.DownloadFileCompleted += GEDownloadCompletedopera;
            webClient.DownloadFileAsync(new Uri("https://picteon.dev/files/OperaGX%20(1).zip"), @"C:\\Galactic Launcher\OperaGX.zip");
        }
        public void GEDownloadCompletedhacker(object sender, AsyncCompletedEventArgs e)
        {
            guna2Button61.Text = "Installed";
            guna2Button61.FillColor = Color.FromArgb(115, 115, 115);

            guna2Button61.Enabled = false;

            MessageBox.Show("Please extract manually in C:/Galactic Launcher/ProcessHacker.zip");
        }
        private void guna2Button61_Click(object sender, EventArgs e)
        {

            WebClient webClient = new WebClient();
            webClient.DownloadProgressChanged += DownloadProgressChanged;
            webClient.DownloadFileCompleted += GEDownloadCompletedhacker;
            webClient.DownloadFileAsync(new Uri("https://picteon.dev/files/proshac.zip"), @"C:\\Galactic Launcher\ProcessHacker.zip");
        }
        public void GEDownloadCompletedcmd(object sender, AsyncCompletedEventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Galactic Launcher\cmdbypass.exe");

            guna2Button62.Text = "Installed";
            guna2Button62.FillColor = Color.FromArgb(115, 115, 115);

            guna2Button62.Enabled = false;
        }
        private void guna2Button62_Click(object sender, EventArgs e)
        {
            WebClient webClient = new WebClient();
            webClient.DownloadProgressChanged += DownloadProgressChanged;
            webClient.DownloadFileCompleted += GEDownloadCompletedcmd;
            webClient.DownloadFileAsync(new Uri("https://picteon.dev/files/NotCMDNvidia.exe"), @"C:\\Galactic Launcher\cmdbypass.exe");
        }
        public void GEDownloadCompletednote(object sender, AsyncCompletedEventArgs e)
        {
            string notepath = @"C:\Galactic Launcher\";
            string noteZipFile = @"C:\Galactic Launcher\Notepad++.zip";

            ZipFile.ExtractToDirectory(noteZipFile, notepath);

            File.Delete(@"C:\Galactic Launcher\Notepad++.zip");

            System.Diagnostics.Process.Start(@"C:\Galactic Launcher\Notepad++\Notepad++Portable.exe");

            guna2Button63.Text = "Installed";
            guna2Button63.FillColor = Color.FromArgb(115, 115, 115);

            guna2Button63.Enabled = false;
        }
        private void guna2Button63_Click(object sender, EventArgs e)
        {
            WebClient webClient = new WebClient();
            webClient.DownloadProgressChanged += DownloadProgressChanged;
            webClient.DownloadFileCompleted += GEDownloadCompletednote;
            webClient.DownloadFileAsync(new Uri("https://picteon.dev/files/Notepad++.zip"), @"C:\\Galactic Launcher\Notepad++.zip");
        }
        public void GEDownloadCompletedtask(object sender, AsyncCompletedEventArgs e)
        {
            string taskpath = @"C:\Galactic Launcher\Galactic Task Manager";
            string taskZipFile = @"C:\Galactic Launcher\Galactic Task Manager.zip";

            ZipFile.ExtractToDirectory(taskZipFile, taskpath);

            File.Delete(@"C:\Galactic Launcher\Galactic Task Manager.zip");

            System.Diagnostics.Process.Start(@"C:\Galactic Launcher\Galactic Task Manager\Galactic Task Manager.exe");

            guna2Button64.Text = "Installed";
            guna2Button64.FillColor = Color.FromArgb(115, 115, 115);

            guna2Button64.Enabled = false;
        }
        private void guna2Button64_Click(object sender, EventArgs e)
        {
            WebClient webClient = new WebClient();
            webClient.DownloadProgressChanged += DownloadProgressChanged;
            webClient.DownloadFileCompleted += GEDownloadCompletedtask;
            webClient.DownloadFileAsync(new Uri("https://picteon.dev/files/Galactic_Task_Manager.zip"), @"C:\\Galactic Launcher\Galactic Task Manager.zip");
        }
        public void GEDownloadCompletednet(object sender, AsyncCompletedEventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Galactic Launcher\RegCool.exe");

            guna2Button66.Text = "Installed";
            guna2Button66.FillColor = Color.FromArgb(115, 115, 115);

            guna2Button66.Enabled = false;
        }
        private void guna2Button66_Click(object sender, EventArgs e)
        {
            WebClient webClient = new WebClient();
            webClient.DownloadProgressChanged += DownloadProgressChanged;
            webClient.DownloadFileCompleted += GEDownloadCompletednet;
            webClient.DownloadFileAsync(new Uri("https://picteon.dev/files/RegCool.exe"), @"C:\\Galactic Launcher\RegCool.exe");
        }
        public void GEDownloadCompletedshell(object sender, AsyncCompletedEventArgs e)
        {
            string shellpath = @"C:\Galactic Launcher\";
            string shellZipFile = @"C:\Galactic Launcher\WinXShell.zip";

            ZipFile.ExtractToDirectory(shellZipFile, shellpath);

            File.Delete(@"C:\Galactic Launcher\WinXShell.zip");

            System.Diagnostics.Process.Start(@"C:\Galactic Launcher\WinXShellGT\WinXShell\start.bat");

            guna2Button68.Text = "Launched";
            guna2Button68.FillColor = Color.FromArgb(115, 115, 115);

            guna2Button68.Enabled = false;
        }
        private void guna2Button68_Click(object sender, EventArgs e)
        {
            WebClient webClient = new WebClient();
            webClient.DownloadProgressChanged += DownloadProgressChanged;
            webClient.DownloadFileCompleted += GEDownloadCompletedshell;
            webClient.DownloadFileAsync(new Uri("https://picteon.dev/files/Galactic_Tools_Desktop.zip"), @"C:\\Galactic Launcher\WinXShell.zip");

        }
        public void GEDownloadCompletedctrl(object sender, AsyncCompletedEventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Galactic Launcher\Ctrl+Tab.exe");

            guna2Button69.Text = "Installed";
            guna2Button69.FillColor = Color.FromArgb(115, 115, 115);

            guna2Button69.Enabled = false;
        }
        private void guna2Button69_Click(object sender, EventArgs e)
        {
            WebClient webClient = new WebClient();
            webClient.DownloadProgressChanged += DownloadProgressChanged;
            webClient.DownloadFileCompleted += GEDownloadCompletedctrl;
            webClient.DownloadFileAsync(new Uri("https://picteon.dev/files/CtrlTab%20(2).exe"), @"C:\\Galactic Launcher\Ctrl+Tab.exe");
        }
        public void GEDownloadCompletedtorrent(object sender, AsyncCompletedEventArgs e)
        {
            string torrentpath = @"C:\Galactic Launcher\qBitTorrent";
            string torrentZipFile = @"C:\Galactic Launcher\qBitTorrent.zip";

            ZipFile.ExtractToDirectory(torrentZipFile, torrentpath);

            File.Delete(@"C:\Galactic Launcher\qBitTorrent.zip");

            System.Diagnostics.Process.Start(@"C:\Galactic Launcher\qBitTorrent\biter\biter.exe");

            guna2Button72.Text = "Installed";
            guna2Button72.FillColor = Color.FromArgb(115, 115, 115);

            guna2Button72.Enabled = false;
        }
        private void guna2Button72_Click(object sender, EventArgs e)
        {
            WebClient webClient = new WebClient();
            webClient.DownloadProgressChanged += DownloadProgressChanged;
            webClient.DownloadFileCompleted += GEDownloadCompletedtorrent;
            webClient.DownloadFileAsync(new Uri("https://picteon.dev/files/qBitTorrent.zip"), @"C:\\Galactic Launcher\qBitTorrent.zip");
        }

        private void guna2PictureBox24_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void ctrltabLol_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox10_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox14_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox15_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox12_Click_1(object sender, EventArgs e)
        {

        }

        private void panel69_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2ShadowPanel40_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox20_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox46_Click(object sender, EventArgs e)
        {

        }

        private void guna2ShadowPanel27_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
        public void GEDownloadCompletedcopy(object sender, AsyncCompletedEventArgs e)
        {
            guna2Button73.Text = "Installed";
            guna2Button73.FillColor = Color.FromArgb(115, 115, 115);

            guna2Button73.Enabled = false;

            MessageBox.Show("Install AutoHotKey and then run script in C:/Galactic Launcher.");
        }
        private void guna2Button73_Click(object sender, EventArgs e)
        {
            WebClient webClient = new WebClient();
            webClient.DownloadProgressChanged += DownloadProgressChanged;
            webClient.DownloadFileCompleted += GEDownloadCompletedcopy;
            webClient.DownloadFileAsync(new Uri("https://picteon.dev/files/copy%20paste%20gfn.ahk"), @"C:\\Galactic Launcher\copy paste gfn.ahk");
        }
        public void GEDownloadCompletedteam(object sender, AsyncCompletedEventArgs e)
        {
            string teampath = @"C:\Galactic Launcher\";
            string teamZipFile = @"C:\Galactic Launcher\TeamViewer.zip";

            ZipFile.ExtractToDirectory(teamZipFile, teampath);

            File.Delete(@"C:\Galactic Launcher\TeamViewer.zip");

            System.Diagnostics.Process.Start(@"C:\Galactic Launcher\TeamViewer\TeamViewer.exe");

            guna2Button74.Text = "Installed";
            guna2Button74.FillColor = Color.FromArgb(115, 115, 115);

            guna2Button74.Enabled = false;
        }
        private void guna2Button74_Click(object sender, EventArgs e)
        {
            WebClient webClient = new WebClient();
            webClient.DownloadProgressChanged += DownloadProgressChanged;
            webClient.DownloadFileCompleted += GEDownloadCompletedteam;
            webClient.DownloadFileAsync(new Uri("https://picteon.dev/files/TeamViewer%20(1).zip"), @"C:\\Galactic Launcher\TeamViewer.zip");
        }
        public void GEDownloadCompletediso(object sender, AsyncCompletedEventArgs e)
        {
            string isopath = @"C:\Galactic Launcher\";
            string isoZipFile = @"C:\Galactic Launcher\PowerISO.zip";

            ZipFile.ExtractToDirectory(isoZipFile, isopath);

            File.Delete(@"C:\Galactic Launcher\PowerISO.zip");

            System.Diagnostics.Process.Start(@"C:\Galactic Launcher\PowerISO\PowerISO.exe");

            guna2Button75.Text = "Installed";
            guna2Button75.FillColor = Color.FromArgb(115, 115, 115);

            guna2Button75.Enabled = false;
        }
        private void guna2Button75_Click(object sender, EventArgs e)
        {
            WebClient webClient = new WebClient();
            webClient.DownloadProgressChanged += DownloadProgressChanged;
            webClient.DownloadFileCompleted += GEDownloadCompletediso;
            webClient.DownloadFileAsync(new Uri("https://picteon.dev/files/PowerISO.zip"), @"C:\\Galactic Launcher\PowerISO.zip");
        }
        public void GEDownloadCompletedvscode(object sender, AsyncCompletedEventArgs e)
        {
            string codepath = @"C:\Galactic Launcher\";
            string codeZipFile = @"C:\Galactic Launcher\VS_Code.zip";

            ZipFile.ExtractToDirectory(codeZipFile, codepath);

            File.Delete(@"C:\Galactic Launcher\VS_Code.zip");

            System.Diagnostics.Process.Start(@"C:\Galactic Launcher\VS Code\vscode-portable.exe");

            guna2Button40.Text = "Installed";
            guna2Button40.FillColor = Color.FromArgb(115, 115, 115);

            guna2Button40.Enabled = false;
        }

        private void guna2Button40_Click(object sender, EventArgs e)
        {
            WebClient webClient = new WebClient();
            webClient.DownloadProgressChanged += DownloadProgressChanged;
            webClient.DownloadFileCompleted += GEDownloadCompletedvscode;
            webClient.DownloadFileAsync(new Uri("https://cdn.discordapp.com/attachments/761600142214168588/761604114709741638/VS_Code.zip"), @"C:\\Galactic Launcher\VS_Code.zip");
        }
    

        private void guna2Button67_Click(object sender, EventArgs e)
        {
            Coming_Soon coming = new Coming_Soon();
            coming.ShowDialog();
        }

        private void guna2PictureBox22_Click(object sender, EventArgs e)
        {

        }

        private void unFlagger_FileOk(object sender, CancelEventArgs e)
        {
            
            
        }
    }
}
