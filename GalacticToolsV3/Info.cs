using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
using NvAPIWrapper;
using Microsoft.VisualBasic.Devices;
using System.Diagnostics;

namespace GalacticToolsV3
{ 
    public partial class Info : Form
    {
        private Stopwatch stopWatch;
        public Info()
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

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Info_Load(object sender, EventArgs e)  
        {
            #region getting processor name
            RegistryKey processor_name = Registry.LocalMachine.OpenSubKey(@"Hardware\Description\System\CentralProcessor\0", RegistryKeyPermissionCheck.ReadSubTree);   //This registry entry contains entry for processor info.

            if (processor_name != null)
            {
                if (processor_name.GetValue("ProcessorNameString") != null)
                {
                    string among;
                    among = ((string)processor_name.GetValue("ProcessorNameString"));
                    label6.Text = among;
                }
            }
            #endregion

            #region getting gpu
            ManagementObjectSearcher searcher
     = new ManagementObjectSearcher("SELECT * FROM Win32_DisplayConfiguration");

            string graphicsCard = string.Empty;
            foreach (ManagementObject mo in searcher.Get())
            {
                foreach (PropertyData property in mo.Properties)
                {
                    if (property.Name == "Description")
                    {
                        label10.Text = property.Value.ToString();
                    }
                }
            }
            #endregion

            #region getting ram
            ComputerInfo CI = new ComputerInfo();
            ulong mem = ulong.Parse(CI.TotalPhysicalMemory.ToString());
            label9.Text = (mem / (1024 * 1024) + " MB").ToString();
            #endregion

            timer1.Start();
            label4.Text = DateTime.Now.ToLongDateString();

            label5.Text = DateTime.Now.ToLongTimeString();

            timer2.Start();

            stopWatch = new Stopwatch();
            stopWatch.Start();

            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label5.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
                
        }

        private void guna2PictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.timeboi.Text = string.Format("{0:hh\\:mm\\:ss}", stopWatch.Elapsed);
        }

        private void timeboi_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button13_Click(object sender, EventArgs e)
        {
            this.Hide();
            Games games = new Games();
            games.ShowDialog();
            this.Close();
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            Coming_Soon coming = new Coming_Soon();
            coming.ShowDialog();
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void guna2Button14_Click(object sender, EventArgs e)
        {
            this.Hide();
            Welcome welcome = new Welcome();
            welcome.ShowDialog();
            this.Close();
        }

        private void guna2Button12_Click(object sender, EventArgs e)
        {
            this.Hide();
            Apps apps = new Apps();
            apps.ShowDialog();
            this.Close();
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Launchers launchers = new Launchers();
            launchers.ShowDialog();
            this.Close();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            Coming_Soon coming = new Coming_Soon();
            coming.ShowDialog();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            UnFlagger unFlagger = new UnFlagger();
            unFlagger.ShowDialog();
        }

        private void guna2CircleButton3_Click(object sender, EventArgs e)
        {

        }

        private void guna2CircleButton4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Settings settings = new Settings();
            settings.ShowDialog();
            this.Close();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void circularProgressBar1_Click(object sender, EventArgs e)
        {

        }

        private void timeboi_Click_1(object sender, EventArgs e)
        {

        }

        private void timer3_Tick_1(object sender, EventArgs e)
        {
            guna2CircleProgressBar1.Value = (int)(CPU.NextValue());
            label17.Text = "Processor Percentage: " + guna2CircleProgressBar1.Value.ToString() + "%";
        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {
            
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
