using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace tsCompiler
{
    public partial class Form1 : Form
    {
        static private string saveFileName = "folders.txt";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadFolders();
        }

        //Load folders from file into the system
        public void loadFolders()
        {
            string[] folders = System.IO.File.ReadAllLines(@saveFileName);
            for (int i = 0; i < folders.Length; i++)
            {
                listFolders.Items.Add(folders[i]);
            }
        }

        //Save folders from the system into the file
        public void saveFolders()
        {
            string[] folders = new string[listFolders.Items.Count];
            for (int i = 0; i < listFolders.Items.Count; i++)
            {
                folders[i] = listFolders.Items[i].ToString();
            }

            System.IO.File.WriteAllLines(@saveFileName, folders);
        }


        //Compile button
        private void button1_Click(object sender, EventArgs e)
        {
            if (listFolderFiles.SelectedItems.Count > 0)
            {
                string returnString = compile(listFolders.SelectedItem.ToString(), listFolderFiles.SelectedItem.ToString());
                if (returnString.Trim() == "")
                {
                    //everything went fine!
                }
                else
                {
                    string br = (char)13 + "";
                    MessageBox.Show("Errors were found: " + br + returnString);
                }
            }
        }

        //Compile function
        public string compile(string folder, string file)
        {
            return runCmd("tsc " + file, folder);
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
            saveFolders();
        }
        
        //Select a folder
        private void listFolders_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Clear the list and add the new files
            listFolderFiles.Items.Clear();
            btnCompileFile.Enabled = false;

            if (listFolders.SelectedItems.Count > 0)
            {
                string folder = listFolders.SelectedItem.ToString();    // The folder selected
                string[] files = Directory.GetFiles(@folder);           // The files inside it
                
                for (int i = 0; i < files.Length; i++)
                {                 
                    string filename = files[i];
                    filename = filename.Replace(folder + "\\", "");

                    if (filename.ToUpper().EndsWith(".TS"))
                    {
                        // Add to the list
                        listFolderFiles.Items.Add(filename);
                    }
                }
            }
        }

        //Remove a folder
        private void btnRemoveFolder_Click(object sender, EventArgs e)
        {
            if(listFolders.SelectedItems.Count > 0)
            {                
                listFolders.Items.RemoveAt(listFolders.SelectedIndex);
            }
            saveFolders();
        }

        //Select a file
        private void listFolderFiles_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if(listFolderFiles.SelectedItems.Count>0)
            {
                btnCompileFile.Enabled = true;
            }
            else
            {
                btnCompileFile.Enabled = false;
            }
        }
    }
}
