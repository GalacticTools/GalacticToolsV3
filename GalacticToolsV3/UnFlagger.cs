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
using System.Diagnostics;
using System.Threading;

namespace GalacticToolsV3
{
    public partial class UnFlagger : Form
    {
        public UnFlagger()
        {
            InitializeComponent();
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

        private void guna2Button9_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "exe files (*.exe)|*.exe";
            openFileDialog1.InitialDirectory = @"C:\Program Files (x86)\Steam";
            openFileDialog1.Title = "Please select a file";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if (File.Exists(@"C:\\Galactic Launcher\\UnFlaggedFiles\\" + browseTextBox.Text + ".exe"))
                    {
                        File.Copy(openFileDialog1.FileName, @"C:\\Galactic Launcher\\UnFlaggedFiles\\" + browseTextBox.Text + 1 + ".exe");
                        Thread.Sleep(1000);
                        Process.Start(@"C:\\Galactic Launcher\\UnFlaggedFiles\\" + browseTextBox.Text + 1 + ".exe");
                    }
                    else
                    {
                        File.Copy(openFileDialog1.FileName, @"C:\\Galactic Launcher\\UnFlaggedFiles\\" + browseTextBox.Text + ".exe");
                        Thread.Sleep(1000);
                        Process.Start(@"C:\\Galactic Launcher\\UnFlaggedFiles\\" + browseTextBox.Text + ".exe");
                    }
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
                this.Close();
            }

        }

        private void UnFlagger_Load(object sender, EventArgs e)
        {

        }
    }
}    
