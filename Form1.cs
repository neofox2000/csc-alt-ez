using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.Win32;

namespace CSC_Alt_EZ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region Control Events
        
        private void LocateExeButton_Click(object sender, EventArgs e)
        {
            if (OpenFileD.ShowDialog() == DialogResult.OK)
            {
                ExeTextBox.Text = OpenFileD.FileName;
                OutputFolderTextBox.Text = Path.GetDirectoryName(ExeTextBox.Text);
            }
        }
        private void OutputFolderButton_Click(object sender, EventArgs e)
        {
            if (FolderBrowserD.ShowDialog() == DialogResult.OK)
            {
                OutputFolderTextBox.Text = FolderBrowserD.SelectedPath;
            }
        }
        
        private void MakeFilesButton_Click(object sender, EventArgs e)
        {
            // verify platform
            if (!RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                MessageBox.Show("This function only works on Windows right now!");
                return;
            }

            //Validate exe
            if (!File.Exists(ExeTextBox.Text) || !ExeTextBox.Text.EndsWith(".exe"))
            {
                MessageBox.Show("Invalid exe file.");
                return;
            }

            //Validate output folder
            if (!Directory.Exists(OutputFolderTextBox.Text))
            {
                MessageBox.Show("Invalid output folder.");
                return;
            }

            using RegistryKey key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\LucidSight, Inc\CSC-Alpha");
            if (key == null)
            {
                MessageBox.Show("Could not find the game registry entries - you may have too stronk security, or game is not installed!");
                return;
            }

            //Setup the registry file and write to output folder
            string[] outputLines = new string[] {
                "Windows Registry Editor Version 5.00",
                string.Empty,
                "[HKEY_CURRENT_USER\\Software\\LucidSight, Inc\\CSC-Alpha]",
                MakeRegistryHex(key, "user_h2087973204"),
                MakeRegistryHex(key, "password_h1569157018")
            };
            File.WriteAllLines($"{OutputFolderTextBox.Text}\\creds.reg", outputLines);

            //Setup the batch file and write to output folder
            outputLines = new string[]
            {
                $"reg import \"{OutputFolderTextBox.Text}\\creds.reg\"",
                $"start \"\" \"{ExeTextBox.Text}\""
            };
            File.WriteAllLines($"{OutputFolderTextBox.Text}\\Start CSC Alt.bat", outputLines);

            MessageBox.Show("Job's done!");
        }

        #endregion

        private string MakeRegistryHex(RegistryKey key, string rkName)
        {
            var data = key.GetValue(rkName) as byte[];
            var strdata = BitConverter.ToString(data);
            return $"\"{rkName}\" = hex:{strdata.Replace("-", ",")}";
        }
    }
}