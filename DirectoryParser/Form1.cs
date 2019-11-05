using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace DirectoryParser
{
    public partial class Form1 : Form
    {
        private static string searchString = @"['!#%&*{}\:<>?\/|""]";
        private Regex regEx = new Regex(searchString, RegexOptions.IgnoreCase | RegexOptions.ExplicitCapture);

        public Form1()
        {
            InitializeComponent();
        }

        private void btnDirStart_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {

                    textDirStart.Text = fbd.SelectedPath;

                }
            }
        }

        private void btnStartSearch_Click(object sender, EventArgs e)
        {
            textOutput.Text = "";
            FindFilesInDirectory(textDirStart.Text);
            var directories = Directory.GetDirectories(textDirStart.Text, "*.*", SearchOption.AllDirectories);
            
            
            foreach (var directory in directories)
            {
                var _directory = directory.Replace(Directory.GetDirectoryRoot(directory), "");

                var match = regEx.Match(_directory);
                if (match.Success)
                {
                    textOutput.AppendText("DirectoryMatch: ");
                    textOutput.AppendText(directory);
                    textOutput.AppendText(Environment.NewLine);
                }

                FindFilesInDirectory(directory);
            }

        }

        private void FindFilesInDirectory(string directory)
        {
            var filesInCurrentDirectory = Directory.GetFiles(directory,"*.*");
            foreach (var file in filesInCurrentDirectory)
            {
                var _file = file.Replace(Directory.GetDirectoryRoot(file), "");
                var fileMatch = regEx.Match(_file);

                if (fileMatch.Success)
                {
                    textOutput.AppendText("FileName Match: ");
                    textOutput.AppendText(file);
                    textOutput.AppendText(Environment.NewLine);
                }
            }
        }
    }
}
