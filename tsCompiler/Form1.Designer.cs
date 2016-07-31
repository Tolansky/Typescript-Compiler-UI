namespace tsCompiler
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCompileFile = new System.Windows.Forms.Button();
            this.listFolders = new System.Windows.Forms.ListBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.cmdOpenFolder = new System.Windows.Forms.Button();
            this.listFolderFiles = new System.Windows.Forms.ListBox();
            this.btnRemoveFolder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCompileFile
            // 
            this.btnCompileFile.Enabled = false;
            this.btnCompileFile.Location = new System.Drawing.Point(408, 39);
            this.btnCompileFile.Name = "btnCompileFile";
            this.btnCompileFile.Size = new System.Drawing.Size(103, 23);
            this.btnCompileFile.TabIndex = 0;
            this.btnCompileFile.Text = "&Compile";
            this.btnCompileFile.UseVisualStyleBackColor = true;
            this.btnCompileFile.Click += new System.EventHandler(this.button1_Click);
            // 
            // listFolders
            // 
            this.listFolders.FormattingEnabled = true;
            this.listFolders.Location = new System.Drawing.Point(8, 39);
            this.listFolders.Name = "listFolders";
            this.listFolders.Size = new System.Drawing.Size(227, 212);
            this.listFolders.TabIndex = 1;
            this.listFolders.SelectedIndexChanged += new System.EventHandler(this.listFolders_SelectedIndexChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // cmdOpenFolder
            // 
            this.cmdOpenFolder.Location = new System.Drawing.Point(8, 10);
            this.cmdOpenFolder.Name = "cmdOpenFolder";
            this.cmdOpenFolder.Size = new System.Drawing.Size(170, 23);
            this.cmdOpenFolder.TabIndex = 3;
            this.cmdOpenFolder.Text = "open a folder";
            this.cmdOpenFolder.UseVisualStyleBackColor = true;
            this.cmdOpenFolder.Click += new System.EventHandler(this.cmdOpenFolder_Click);
            // 
            // listFolderFiles
            // 
            this.listFolderFiles.FormattingEnabled = true;
            this.listFolderFiles.Location = new System.Drawing.Point(241, 39);
            this.listFolderFiles.Name = "listFolderFiles";
            this.listFolderFiles.Size = new System.Drawing.Size(161, 212);
            this.listFolderFiles.TabIndex = 4;
            this.listFolderFiles.SelectedIndexChanged += new System.EventHandler(this.listFolderFiles_SelectedIndexChanged_1);
            // 
            // btnRemoveFolder
            // 
            this.btnRemoveFolder.Location = new System.Drawing.Point(408, 98);
            this.btnRemoveFolder.Name = "btnRemoveFolder";
            this.btnRemoveFolder.Size = new System.Drawing.Size(103, 23);
            this.btnRemoveFolder.TabIndex = 5;
            this.btnRemoveFolder.Text = "Remove Folder";
            this.btnRemoveFolder.UseVisualStyleBackColor = true;
            this.btnRemoveFolder.Click += new System.EventHandler(this.btnRemoveFolder_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 263);
            this.Controls.Add(this.btnRemoveFolder);
            this.Controls.Add(this.listFolderFiles);
            this.Controls.Add(this.cmdOpenFolder);
            this.Controls.Add(this.listFolders);
            this.Controls.Add(this.btnCompileFile);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCompileFile;
        private System.Windows.Forms.ListBox listFolders;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button cmdOpenFolder;
        private System.Windows.Forms.ListBox listFolderFiles;
        private System.Windows.Forms.Button btnRemoveFolder;
    }
}

