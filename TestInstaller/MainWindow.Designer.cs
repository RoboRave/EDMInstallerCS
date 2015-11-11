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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.InstallButton = new System.Windows.Forms.Button();
            this.ForgeInstall = new System.Windows.Forms.CheckBox();
            this.ModInstall = new System.Windows.Forms.CheckBox();
            this.FileLocation = new System.Windows.Forms.TextBox();
            this.FindButton = new System.Windows.Forms.Button();
            this.FolderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.VersionSelector = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // InstallButton
            // 
            this.InstallButton.Location = new System.Drawing.Point(20, 135);
            this.InstallButton.Name = "InstallButton";
            this.InstallButton.Size = new System.Drawing.Size(75, 20);
            this.InstallButton.TabIndex = 0;
            this.InstallButton.Text = "Install";
            this.InstallButton.UseVisualStyleBackColor = true;
            this.InstallButton.Click += new System.EventHandler(this.InstallButton_Click);
            // 
            // ForgeInstall
            // 
            this.ForgeInstall.Location = new System.Drawing.Point(20, 85);
            this.ForgeInstall.Name = "ForgeInstall";
            this.ForgeInstall.Size = new System.Drawing.Size(230, 20);
            this.ForgeInstall.TabIndex = 1;
            this.ForgeInstall.Text = "MinecraftForge";
            this.ForgeInstall.UseVisualStyleBackColor = true;
            this.ForgeInstall.CheckedChanged += new System.EventHandler(this.ForgeInstall_CheckedChanged);
            // 
            // ModInstall
            // 
            this.ModInstall.Location = new System.Drawing.Point(20, 110);
            this.ModInstall.Name = "ModInstall";
            this.ModInstall.Size = new System.Drawing.Size(230, 20);
            this.ModInstall.TabIndex = 2;
            this.ModInstall.Text = "Default";
            this.ModInstall.UseVisualStyleBackColor = true;
            this.ModInstall.CheckedChanged += new System.EventHandler(this.ModInstall_CheckedChanged);
            // 
            // FileLocation
            // 
            this.FileLocation.Location = new System.Drawing.Point(20, 60);
            this.FileLocation.Name = "FileLocation";
            this.FileLocation.Size = new System.Drawing.Size(230, 20);
            this.FileLocation.TabIndex = 3;
            // 
            // FindButton
            // 
            this.FindButton.Location = new System.Drawing.Point(255, 60);
            this.FindButton.Name = "FindButton";
            this.FindButton.Size = new System.Drawing.Size(25, 20);
            this.FindButton.TabIndex = 4;
            this.FindButton.Text = "...";
            this.FindButton.UseVisualStyleBackColor = true;
            this.FindButton.Click += new System.EventHandler(this.FindButton_Click);
            // 
            // FolderBrowser
            // 
            this.FolderBrowser.HelpRequest += new System.EventHandler(this.FolderBrowser_HelpRequest);
            // 
            // VersionSelector
            // 
            this.VersionSelector.FormattingEnabled = true;
            this.VersionSelector.Items.AddRange(new object[] {
            "1.8",
            "1.7.10",
            "1.7.2"});
            this.VersionSelector.Location = new System.Drawing.Point(20, 20);
            this.VersionSelector.Name = "VersionSelector";
            this.VersionSelector.Size = new System.Drawing.Size(230, 21);
            this.VersionSelector.TabIndex = 5;
            this.VersionSelector.Text = "Minecraft version";
            this.VersionSelector.SelectedIndexChanged += new System.EventHandler(this.VersionSelector_SelectedIndexChanged);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 161);
            this.Controls.Add(this.VersionSelector);
            this.Controls.Add(this.FindButton);
            this.Controls.Add(this.FileLocation);
            this.Controls.Add(this.ModInstall);
            this.Controls.Add(this.ForgeInstall);
            this.Controls.Add(this.InstallButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.Text = "Mod Installer For Minecraft";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button InstallButton;
        private System.Windows.Forms.CheckBox ForgeInstall;
        private System.Windows.Forms.CheckBox ModInstall;
        private System.Windows.Forms.TextBox FileLocation;
        private System.Windows.Forms.Button FindButton;
        private System.Windows.Forms.FolderBrowserDialog FolderBrowser;
        private System.Windows.Forms.ComboBox VersionSelector;
    }
}

