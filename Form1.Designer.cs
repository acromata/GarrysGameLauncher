namespace GarrysGameLauncher
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
            DesktopShortcutButton = new PictureBox();
            toolTip1 = new ToolTip(components);
            DownloadProgressBar = new ProgressBar();
            ProgessLabel = new Label();
            VersionText = new Label();
            ((System.ComponentModel.ISupportInitialize)LogoImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DesktopShortcutButton).BeginInit();
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
            // DesktopShortcutButton
            // 
            DesktopShortcutButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            DesktopShortcutButton.BackColor = Color.Transparent;
            DesktopShortcutButton.BackgroundImageLayout = ImageLayout.Zoom;
            DesktopShortcutButton.Image = (Image)resources.GetObject("DesktopShortcutButton.Image");
            DesktopShortcutButton.Location = new Point(34, 486);
            DesktopShortcutButton.Name = "DesktopShortcutButton";
            DesktopShortcutButton.Size = new Size(43, 46);
            DesktopShortcutButton.SizeMode = PictureBoxSizeMode.Zoom;
            DesktopShortcutButton.TabIndex = 2;
            DesktopShortcutButton.TabStop = false;
            toolTip1.SetToolTip(DesktopShortcutButton, "Create Desktop Shortcut");
            DesktopShortcutButton.Click += DesktopShortcutButton_Click;
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
            VersionText.Location = new Point(986, 560);
            VersionText.Name = "VersionText";
            VersionText.Size = new Size(51, 21);
            VersionText.TabIndex = 5;
            VersionText.Text = "v1.0.0";
            // 
            // GGLauncher
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1048, 588);
            Controls.Add(VersionText);
            Controls.Add(ProgessLabel);
            Controls.Add(DownloadProgressBar);
            Controls.Add(DesktopShortcutButton);
            Controls.Add(LaunchButton);
            Controls.Add(LogoImage);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "GGLauncher";
            Text = "Garry's Game Launcher";
            ((System.ComponentModel.ISupportInitialize)LogoImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)DesktopShortcutButton).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox LogoImage;
        private Button LaunchButton;
        private PictureBox DesktopShortcutButton;
        private ToolTip toolTip1;
        private ProgressBar DownloadProgressBar;
        private Label ProgessLabel;
        private Label VersionText;
    }
}
