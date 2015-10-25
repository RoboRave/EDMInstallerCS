namespace TestInstaller
{
    partial class MainWindow
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
            this.InstallButton = new System.Windows.Forms.Button();
            this.ForgeInstall = new System.Windows.Forms.CheckBox();
            this.EDMInstall = new System.Windows.Forms.CheckBox();
            this.FileLocation = new System.Windows.Forms.TextBox();
            this.FindButton = new System.Windows.Forms.Button();
            this.FolderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // InstallButton
            // 
            this.InstallButton.Location = new System.Drawing.Point(14, 84);
            this.InstallButton.Name = "InstallButton";
            this.InstallButton.Size = new System.Drawing.Size(75, 23);
            this.InstallButton.TabIndex = 0;
            this.InstallButton.Text = "Install";
            this.InstallButton.UseVisualStyleBackColor = true;
            this.InstallButton.Click += new System.EventHandler(this.InstallButton_Click);
            // 
            // ForgeInstall
            // 
            this.ForgeInstall.AutoSize = true;
            this.ForgeInstall.Location = new System.Drawing.Point(14, 38);
            this.ForgeInstall.Name = "ForgeInstall";
            this.ForgeInstall.Size = new System.Drawing.Size(162, 17);
            this.ForgeInstall.TabIndex = 1;
            this.ForgeInstall.Text = "MinecraftForge Version 1291";
            this.ForgeInstall.UseVisualStyleBackColor = true;
            this.ForgeInstall.CheckedChanged += new System.EventHandler(this.ForgeInstall_CheckedChanged);
            // 
            // EDMInstall
            // 
            this.EDMInstall.AutoSize = true;
            this.EDMInstall.Location = new System.Drawing.Point(14, 61);
            this.EDMInstall.Name = "EDMInstall";
            this.EDMInstall.Size = new System.Drawing.Size(189, 17);
            this.EDMInstall.TabIndex = 2;
            this.EDMInstall.Text = "Extra Diamonds Mod Version 4.1.0";
            this.EDMInstall.UseVisualStyleBackColor = true;
            this.EDMInstall.CheckedChanged += new System.EventHandler(this.EDMInstall_CheckedChanged);
            // 
            // FileLocation
            // 
            this.FileLocation.Location = new System.Drawing.Point(12, 12);
            this.FileLocation.Name = "FileLocation";
            this.FileLocation.Size = new System.Drawing.Size(229, 20);
            this.FileLocation.TabIndex = 3;
            // 
            // FindButton
            // 
            this.FindButton.Location = new System.Drawing.Point(247, 12);
            this.FindButton.Name = "FindButton";
            this.FindButton.Size = new System.Drawing.Size(27, 23);
            this.FindButton.TabIndex = 4;
            this.FindButton.Text = "...";
            this.FindButton.UseVisualStyleBackColor = true;
            this.FindButton.Click += new System.EventHandler(this.FindButton_Click);
            // 
            // FolderBrowser
            // 
            this.FolderBrowser.HelpRequest += new System.EventHandler(this.FolderBrowser_HelpRequest);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 121);
            this.Controls.Add(this.FindButton);
            this.Controls.Add(this.FileLocation);
            this.Controls.Add(this.EDMInstall);
            this.Controls.Add(this.ForgeInstall);
            this.Controls.Add(this.InstallButton);
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.Text = "EDM Installer For Minecraft 1.7.10";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button InstallButton;
        private System.Windows.Forms.CheckBox ForgeInstall;
        private System.Windows.Forms.CheckBox EDMInstall;
        private System.Windows.Forms.TextBox FileLocation;
        private System.Windows.Forms.Button FindButton;
        private System.Windows.Forms.FolderBrowserDialog FolderBrowser;
    }
}

