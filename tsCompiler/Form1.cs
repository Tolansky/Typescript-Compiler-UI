using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tsCompiler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string returnString = runCmd("tsc " + listFolderFiles.SelectedItem.ToString(), listFolders.SelectedItem.ToString());
            if(returnString.Trim() == "")
            {
                //everything went fine!
            }
            else
            {
                string br = (char)13 + "";
                MessageBox.Show("Errors were found: " + br + returnString);
            }
            
            
        }


        /// <summary>
        /// Run a command and return the results in a string
        /// </summary>
        /// <param name="cmd">Command to run</param>
        /// <param name="workingDirectory">Working directory</param>
        /// <returns></returns>
        public string runCmd(string cmd, string workingDirectory = @"c:\")
        {
            //Create process
            var pProcess = new System.Diagnostics.Process
            {
                StartInfo =
                {
                    FileName = "cmd.exe",
                    Arguments = "/C " + cmd,
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    WorkingDirectory = workingDirectory,
                    WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden
                }                
            };
            
            pProcess.Start();
            string results = pProcess.StandardOutput.ReadToEnd();
            pProcess.Close();
            
            return results;
        }


        //Open a folder
        private void cmdOpenFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();

            DialogResult result = fbd.ShowDialog();

            if (!string.IsNullOrWhiteSpace(fbd.SelectedPath))
            {
                string[] files = Directory.GetFiles(fbd.SelectedPath);            
                listFolders.Items.Add(fbd.SelectedPath);
            }
        }

        //
        private void listFolderFiles_SelectedIndexChanged(object sender, EventArgs e)
        {            
            string filename = listFolderFiles.SelectedItem.ToString();
        }


        //Select a folder
        private void listFolders_SelectedIndexChanged(object sender, EventArgs e)
        {
            string folder = listFolders.SelectedItem.ToString();    // The folder selected
            string[] files = Directory.GetFiles(@folder);           // The files inside it

            //Clear the list and add the new files
            listFolderFiles.Items.Clear();
            for (int i = 0; i < files.Length;i++)
            {
                // filename
                string filename = files[i];
                filename = filename.Replace(folder + "\\", "");

                if(filename.ToUpper().EndsWith(".TS"))
                {
                    // Add to the list
                    listFolderFiles.Items.Add(filename);
                }
            }
            
        }
    }
}
