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
            this.components = new System.ComponentModel.Container();
            this.btnCompileFile = new System.Windows.Forms.Button();
            this.listFolders = new System.Windows.Forms.ListBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.cmdOpenFolder = new System.Windows.Forms.Button();
            this.listFolderFiles = new System.Windows.Forms.ListBox();
            this.btnRemoveFolder = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.lblPlus = new System.Windows.Forms.Label();
            this.lblMinus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCompileFile
            // 
            this.btnCompileFile.BackColor = System.Drawing.Color.White;
            this.btnCompileFile.Enabled = false;
            this.btnCompileFile.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCompileFile.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCompileFile.Location = new System.Drawing.Point(423, 143);
            this.btnCompileFile.Name = "btnCompileFile";
            this.btnCompileFile.Size = new System.Drawing.Size(103, 23);
            this.btnCompileFile.TabIndex = 0;
            this.btnCompileFile.Text = "&Compile";
            this.btnCompileFile.UseVisualStyleBackColor = true;
            this.btnCompileFile.Visible = false;
            this.btnCompileFile.Click += new System.EventHandler(this.button1_Click);
            // 
            // listFolders
            // 
            this.listFolders.FormattingEnabled = true;
            this.listFolders.Location = new System.Drawing.Point(12, 12);
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
            this.cmdOpenFolder.Location = new System.Drawing.Point(424, 201);
            this.cmdOpenFolder.Name = "cmdOpenFolder";
            this.cmdOpenFolder.Size = new System.Drawing.Size(102, 23);
            this.cmdOpenFolder.TabIndex = 3;
            this.cmdOpenFolder.Text = "Open a folder..";
            this.cmdOpenFolder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdOpenFolder.UseVisualStyleBackColor = true;
            this.cmdOpenFolder.Visible = false;
            this.cmdOpenFolder.Click += new System.EventHandler(this.cmdOpenFolder_Click);
            // 
            // listFolderFiles
            // 
            this.listFolderFiles.FormattingEnabled = true;
            this.listFolderFiles.Location = new System.Drawing.Point(245, 12);
            this.listFolderFiles.Name = "listFolderFiles";
            this.listFolderFiles.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listFolderFiles.Size = new System.Drawing.Size(161, 212);
            this.listFolderFiles.TabIndex = 4;
            this.listFolderFiles.SelectedIndexChanged += new System.EventHandler(this.listFolderFiles_SelectedIndexChanged_1);
            // 
            // btnRemoveFolder
            // 
            this.btnRemoveFolder.Location = new System.Drawing.Point(423, 172);
            this.btnRemoveFolder.Name = "btnRemoveFolder";
            this.btnRemoveFolder.Size = new System.Drawing.Size(103, 23);
            this.btnRemoveFolder.TabIndex = 5;
            this.btnRemoveFolder.Text = "Remove Folder";
            this.btnRemoveFolder.UseVisualStyleBackColor = true;
            this.btnRemoveFolder.Visible = false;
            this.btnRemoveFolder.Click += new System.EventHandler(this.btnRemoveFolder_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // lblPlus
            // 
            this.lblPlus.AutoSize = true;
            this.lblPlus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.lblPlus.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlus.ForeColor = System.Drawing.Color.White;
            this.lblPlus.Location = new System.Drawing.Point(413, 12);
            this.lblPlus.Margin = new System.Windows.Forms.Padding(0);
            this.lblPlus.MinimumSize = new System.Drawing.Size(60, 0);
            this.lblPlus.Name = "lblPlus";
            this.lblPlus.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.lblPlus.Size = new System.Drawing.Size(60, 60);
            this.lblPlus.TabIndex = 6;
            this.lblPlus.Text = "+";
            this.lblPlus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPlus.Click += new System.EventHandler(this.lblPlus_Click);
            this.lblPlus.MouseEnter += new System.EventHandler(this.plusHover);
            this.lblPlus.MouseLeave += new System.EventHandler(this.plusOut);
            this.lblPlus.MouseHover += new System.EventHandler(this.plusHover);
            // 
            // lblMinus
            // 
            this.lblMinus.AutoSize = true;
            this.lblMinus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.lblMinus.Font = new System.Drawing.Font("Verdana", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinus.ForeColor = System.Drawing.Color.White;
            this.lblMinus.Location = new System.Drawing.Point(413, 81);
            this.lblMinus.Margin = new System.Windows.Forms.Padding(0);
            this.lblMinus.MinimumSize = new System.Drawing.Size(60, 0);
            this.lblMinus.Name = "lblMinus";
            this.lblMinus.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.lblMinus.Size = new System.Drawing.Size(60, 59);
            this.lblMinus.TabIndex = 7;
            this.lblMinus.Text = "-";
            this.lblMinus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMinus.Click += new System.EventHandler(this.lblMinus_Click);
            this.lblMinus.MouseEnter += new System.EventHandler(this.minusHover);
            this.lblMinus.MouseLeave += new System.EventHandler(this.minusOut);
            this.lblMinus.MouseHover += new System.EventHandler(this.minusHover);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(482, 236);
            this.Controls.Add(this.lblMinus);
            this.Controls.Add(this.lblPlus);
            this.Controls.Add(this.btnRemoveFolder);
            this.Controls.Add(this.listFolderFiles);
            this.Controls.Add(this.cmdOpenFolder);
            this.Controls.Add(this.listFolders);
            this.Controls.Add(this.btnCompileFile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Typescript Compiler UI";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCompileFile;
        private System.Windows.Forms.ListBox listFolders;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button cmdOpenFolder;
        private System.Windows.Forms.ListBox listFolderFiles;
        private System.Windows.Forms.Button btnRemoveFolder;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Label lblPlus;
        private System.Windows.Forms.Label lblMinus;
    }
}

