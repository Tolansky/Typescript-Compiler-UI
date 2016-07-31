using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

            MessageBox.Show(runCmd("dir"));
            
        }


        public string runCmd(string cmd)
        {
            //Create process
            var pProcess = new System.Diagnostics.Process
            {
                StartInfo =
                {
                    FileName = "cmd.exe",
                    Arguments = "/C "+cmd,
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    WorkingDirectory = "C:\\"
                }
            };
            pProcess.Start();
            string results = pProcess.StandardOutput.ReadToEnd();

            pProcess.Close();

            //Console.WriteLine("done");
            return results;
        }
    }
}
