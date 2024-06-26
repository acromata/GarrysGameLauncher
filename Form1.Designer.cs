﻿namespace GarrysGameLauncher
{
    partial class GGLauncher
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GGLauncher));
            LogoImage = new PictureBox();
            LaunchButton = new Button();
            toolTip1 = new ToolTip(components);
            DownloadProgressBar = new ProgressBar();
            ProgessLabel = new Label();
            VersionText = new Label();
            MenuButton = new Label();
            SettingsPanel = new Panel();
            VerifyGameFilesTxt = new Label();
            OpenGameFilesTxt = new Label();
            AddDesktopShortcutTxt = new Label();
            ((System.ComponentModel.ISupportInitialize)LogoImage).BeginInit();
            SettingsPanel.SuspendLayout();
            SuspendLayout();
            // 
            // LogoImage
            // 
            LogoImage.BackColor = Color.Transparent;
            LogoImage.BackgroundImageLayout = ImageLayout.Zoom;
            LogoImage.Dock = DockStyle.Top;
            LogoImage.Image = (Image)resources.GetObject("LogoImage.Image");
            LogoImage.Location = new Point(0, 0);
            LogoImage.Margin = new Padding(0);
            LogoImage.Name = "LogoImage";
            LogoImage.Size = new Size(1048, 450);
            LogoImage.SizeMode = PictureBoxSizeMode.Zoom;
            LogoImage.TabIndex = 0;
            LogoImage.TabStop = false;
            // 
            // LaunchButton
            // 
            LaunchButton.Anchor = AnchorStyles.Bottom;
            LaunchButton.Location = new Point(338, 453);
            LaunchButton.Name = "LaunchButton";
            LaunchButton.Size = new Size(330, 84);
            LaunchButton.TabIndex = 1;
            LaunchButton.Text = "Launch";
            LaunchButton.UseVisualStyleBackColor = true;
            LaunchButton.Click += LaunchButton_Click;
            // 
            // DownloadProgressBar
            // 
            DownloadProgressBar.Anchor = AnchorStyles.Bottom;
            DownloadProgressBar.Location = new Point(338, 546);
            DownloadProgressBar.Name = "DownloadProgressBar";
            DownloadProgressBar.Size = new Size(330, 23);
            DownloadProgressBar.TabIndex = 3;
            DownloadProgressBar.Visible = false;
            // 
            // ProgessLabel
            // 
            ProgessLabel.Anchor = AnchorStyles.Bottom;
            ProgessLabel.AutoSize = true;
            ProgessLabel.BackColor = Color.Transparent;
            ProgessLabel.Font = new Font("Segoe UI", 8F);
            ProgessLabel.ForeColor = SystemColors.ControlLight;
            ProgessLabel.Location = new Point(339, 570);
            ProgessLabel.Name = "ProgessLabel";
            ProgessLabel.Size = new Size(38, 13);
            ProgessLabel.TabIndex = 4;
            ProgessLabel.Text = "label1";
            ProgessLabel.Visible = false;
            // 
            // VersionText
            // 
            VersionText.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            VersionText.AutoSize = true;
            VersionText.BackColor = Color.Transparent;
            VersionText.Font = new Font("Segoe UI", 12F);
            VersionText.ForeColor = SystemColors.ControlLightLight;
            VersionText.Location = new Point(617, 286);
            VersionText.Name = "VersionText";
            VersionText.Size = new Size(51, 21);
            VersionText.TabIndex = 5;
            VersionText.Text = "v1.0.0";
            // 
            // MenuButton
            // 
            MenuButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            MenuButton.AutoSize = true;
            MenuButton.BackColor = Color.Transparent;
            MenuButton.Font = new Font("Segoe UI", 32F);
            MenuButton.ForeColor = SystemColors.ControlLightLight;
            MenuButton.Location = new Point(996, 0);
            MenuButton.Name = "MenuButton";
            MenuButton.Size = new Size(52, 59);
            MenuButton.TabIndex = 6;
            MenuButton.Text = "...";
            MenuButton.Click += MenuButton_Click;
            // 
            // SettingsPanel
            // 
            SettingsPanel.BackColor = Color.Transparent;
            SettingsPanel.Controls.Add(VerifyGameFilesTxt);
            SettingsPanel.Controls.Add(OpenGameFilesTxt);
            SettingsPanel.Controls.Add(AddDesktopShortcutTxt);
            SettingsPanel.Location = new Point(883, 62);
            SettingsPanel.Name = "SettingsPanel";
            SettingsPanel.Size = new Size(154, 100);
            SettingsPanel.TabIndex = 7;
            SettingsPanel.Visible = false;
            // 
            // VerifyGameFilesTxt
            // 
            VerifyGameFilesTxt.AutoSize = true;
            VerifyGameFilesTxt.BackColor = Color.WhiteSmoke;
            VerifyGameFilesTxt.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            VerifyGameFilesTxt.Location = new Point(1, 56);
            VerifyGameFilesTxt.Name = "VerifyGameFilesTxt";
            VerifyGameFilesTxt.Size = new Size(152, 19);
            VerifyGameFilesTxt.TabIndex = 5;
            VerifyGameFilesTxt.Text = "Verify Game Files       ";
            VerifyGameFilesTxt.Click += VerifyGameFilesTxt_Click;
            // 
            // OpenGameFilesTxt
            // 
            OpenGameFilesTxt.AutoSize = true;
            OpenGameFilesTxt.BackColor = Color.WhiteSmoke;
            OpenGameFilesTxt.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            OpenGameFilesTxt.Location = new Point(1, 28);
            OpenGameFilesTxt.Name = "OpenGameFilesTxt";
            OpenGameFilesTxt.Size = new Size(153, 19);
            OpenGameFilesTxt.TabIndex = 4;
            OpenGameFilesTxt.Text = "Open Game Files        ";
            OpenGameFilesTxt.Click += OpenGameFilesTxt_Click;
            // 
            // AddDesktopShortcutTxt
            // 
            AddDesktopShortcutTxt.AutoSize = true;
            AddDesktopShortcutTxt.BackColor = Color.WhiteSmoke;
            AddDesktopShortcutTxt.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            AddDesktopShortcutTxt.Location = new Point(-1, 0);
            AddDesktopShortcutTxt.Name = "AddDesktopShortcutTxt";
            AddDesktopShortcutTxt.Size = new Size(156, 19);
            AddDesktopShortcutTxt.TabIndex = 3;
            AddDesktopShortcutTxt.Text = "Add Desktop Shortcut";
            AddDesktopShortcutTxt.Click += AddDesktopShortcutTxt_Click;
            // 
            // GGLauncher
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1048, 588);
            Controls.Add(SettingsPanel);
            Controls.Add(MenuButton);
            Controls.Add(VersionText);
            Controls.Add(ProgessLabel);
            Controls.Add(DownloadProgressBar);
            Controls.Add(LaunchButton);
            Controls.Add(LogoImage);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "GGLauncher";
            Text = "Garry's Game Launcher";
            ((System.ComponentModel.ISupportInitialize)LogoImage).EndInit();
            SettingsPanel.ResumeLayout(false);
            SettingsPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox LogoImage;
        private Button LaunchButton;
        private ToolTip toolTip1;
        private ProgressBar DownloadProgressBar;
        private Label ProgessLabel;
        private Label VersionText;
        private Label MenuButton;
        private Panel SettingsPanel;
        private Label AddDesktopShortcutTxt;
        private Label OpenGameFilesTxt;
        private Label VerifyGameFilesTxt;
    }
}
