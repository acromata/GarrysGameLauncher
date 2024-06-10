using System;
using System.Diagnostics;
using IWshRuntimeLibrary;
using System.Net;
using System.ComponentModel;
using System.IO.Compression;
using Newtonsoft.Json;


namespace GarrysGameLauncher
{
    public partial class GGLauncher : Form
    {
        // AppData stuff
        private string appDataPath;
        private string launcherDataPath;

        // Current Version
        private string currentGameVersion = "1.0.4";

        // Garry's Game File
        string downloadURL = "https://github.com/acromata/GarrysGame/releases/download/v1.0.5-beta.1/GarrysGame.zip";
        string gamePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

        // Has clicked launch
        bool hasClickedLaunch;

        public GGLauncher()
        {
            InitializeComponent();

            // Get app data folder
            appDataPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "GarrysGameLauncher");
            // Get launcher data json
            launcherDataPath = Path.Combine(appDataPath, "LauncherData.json");

            // Create folder if it doesn't exist already
            if (!System.IO.File.Exists(launcherDataPath))
            {
                System.IO.File.Create(launcherDataPath);
            }
            else
            {
                // Get current version from JSON
                string jsonString = System.IO.File.ReadAllText(launcherDataPath);

                // Deserialize JSON
                var versionData = JsonConvert.DeserializeObject<dynamic>(jsonString);

                if(versionData != null)
                {
                    currentGameVersion = versionData.Version;
                }
            }

            // Set version text
            VersionText.Text = ("v" + currentGameVersion);
        }

        protected override void OnResizeBegin(EventArgs e)
        {
            SuspendLayout();
            base.OnResizeBegin(e);
        }
        protected override void OnResizeEnd(EventArgs e)
        {
            ResumeLayout();
            base.OnResizeEnd(e);
        }

        private void LaunchButton_Click(object sender, EventArgs e)
        {
            if (!hasClickedLaunch)
            {
                // Make it so you can't download twice
                hasClickedLaunch = true;

                // Check for updates
                string[] versionComponents = currentGameVersion.Split('.');

                int major = int.Parse(versionComponents[0]);
                int minor = int.Parse(versionComponents[1]);
                int patch = int.Parse(versionComponents[2]);

                bool hasCheckedMajor = false;
                bool hasCheckedMinor = false;
                bool hasCheckedPatch = false;

                string URLToCheck;

                // Visibility
                ProgessLabel.Visible = true;
                ProgessLabel.Text = "Checking for updates...";


                Debug.WriteLine("Checking for updates...");
                while (true)
                {
                    // Set download URL
                    URLToCheck = $"https://github.com/acromata/GarrysGame/releases/download/v{major}.{minor}.{patch}-beta.1/GarrysGame.zip";
                    Debug.WriteLine("URL to check:" + URLToCheck);

                    if (IsValidUrl(URLToCheck))
                    {
                        downloadURL = URLToCheck;
                        Debug.WriteLine("Valid URL:" + downloadURL);

                        if (!hasCheckedMajor)
                        {
                            major++;
                            Debug.WriteLine("Major checked: " + major);
                        }
                        else if (!hasCheckedMinor)
                        {
                            minor++;
                            Debug.WriteLine("Minor checked: " + minor);
                        }
                        else if (!hasCheckedPatch)
                        {
                            patch++;
                            Debug.WriteLine("Patch checked: " + patch);
                        }
                        else
                        {
                            break;
                        }

                    }
                    else
                    {
                        if (!hasCheckedMajor)
                        {
                            hasCheckedMajor = true;
                            Debug.WriteLine("Major found: " + major);
                        }
                        else if (!hasCheckedMinor)
                        {
                            hasCheckedMinor = true;
                            Debug.WriteLine("Minor found: " + minor);
                        }
                        else
                        {
                            // Latest version is found
                            hasCheckedPatch = true;
                            Debug.WriteLine($"Version is: v{major}.{minor}.{patch}-beta.1");

                            break;
                        }
                    }
                }

                // Check if update is needed
                if(currentGameVersion == $"{major}.{minor}.{patch}" && System.IO.File.Exists(Path.Combine(gamePath, "GarrysGame")))
                {
                    Debug.WriteLine("On latest version, launching");

                    try
                    {
                        Process.Start(Path.Combine(gamePath, "GarrysGame/GarrysGameClient.exe"));
                        hasClickedLaunch = false;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occured while launching game: {ex.Message}");
                        hasClickedLaunch = false;
                    }
                }
                else
                {
                    Debug.WriteLine("Update or install required");

                    if(System.IO.File.Exists(Path.Combine(gamePath, "GarrysGame")))
                    {
                        // Delete old version
                        System.IO.File.Delete(Path.Combine(gamePath, "GarrysGame"));
                    }

                    // Update current version
                    currentGameVersion = $"{major}.{minor}.{patch}";

                    // Gets web client
                    WebClient client = new WebClient();

                    // Call increase progress bar
                    client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(IncreaseProgressPar);

                    // Call when download is finished
                    client.DownloadFileCompleted += new AsyncCompletedEventHandler(DownloadCompleted);

                    // Visibility
                    DownloadProgressBar.Visible = true;
                    ProgessLabel.Text = "Downloading files...";

                    // Attempt to download file
                    try
                    {
                        client.DownloadFileAsync(new Uri(downloadURL), Path.Combine(gamePath, "GarrysGame.zip"));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred during download: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        // Visibility
                        ProgessLabel.Visible = false;
                        DownloadProgressBar.Visible = false;

                        hasClickedLaunch = false;
                    }
                }
            }
        }

        // Increase the progress bar depending on the download
        private void IncreaseProgressPar(object sender, DownloadProgressChangedEventArgs e)
        {
            DownloadProgressBar.Value = e.ProgressPercentage;
        }

        // Call when download is finished
        private async void DownloadCompleted(object sender, AsyncCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                MessageBox.Show($"An error occurred during download: {e.Error.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (e.Cancelled)
            {
                MessageBox.Show("Download was cancelled.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string zipFilePath = Path.Combine(gamePath, "GarrysGame.zip");
                string extractedFolderPath = Path.Combine(gamePath, "GarrysGame");

                // Extract
                try
                {
                    DownloadProgressBar.Value = 99;
                    ProgessLabel.Text = "Extracting files...";
                    await Task.Run(() => ZipFile.ExtractToDirectory(zipFilePath, extractedFolderPath));

                    // Visibility
                    ProgessLabel.Visible = false;
                    DownloadProgressBar.Visible = false;

                    // Delete Zip Path
                    System.IO.File.Delete(zipFilePath);

                    // Save new version
                    var versionData = new { Version = currentGameVersion };
                    // Serialize version to JSON
                    string jsonString = JsonConvert.SerializeObject(versionData, Formatting.Indented);
                    // Write data to json file
                    System.IO.File.WriteAllText(launcherDataPath, jsonString);

                    try
                    {
                        Process.Start(Path.Combine(extractedFolderPath, "GarrysGameClient.exe"));
                        hasClickedLaunch = false;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occured while launching game: {ex.Message}");
                    }
                }
                catch (Exception ex)
                {
                    // Visibility
                    ProgessLabel.Visible = false;
                    DownloadProgressBar.Visible = false;
                    MessageBox.Show($"An error occured while extracting files: {ex.Message}");
                }
            }
        }

        private bool IsValidUrl(string url)
        {
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.Method = "GET";
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                using (var stream = response.GetResponseStream())
                using (var reader = new System.IO.StreamReader(stream))
                {
                    //string htmlContent = reader.ReadToEnd();
                    //if (Regex.IsMatch(htmlContent, @"<body[^>]*>.*</body>", RegexOptions.IgnoreCase))
                    //{
                    //    // If it has a body, it's not a download link
                    //    return false;
                    //}
                    //else
                    //{
                    //    return true;
                    //}

                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        private void DesktopShortcutButton_Click(object sender, EventArgs e)
        {
            // Get desktop path
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            // Where the shortcut will be created, as well as the shortcut name
            string shortcutPath = System.IO.Path.Combine(desktopPath, "Garry's Game.lnk");

            // Get windows shell command line
            WshShell shell = new WshShell();

            // Create shortcut
            IWshShortcut shortcut = (IWshShortcut)shell.CreateShortcut(shortcutPath);
            shortcut.Description = "My Application Description"; // Shortcut Description
            shortcut.TargetPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "GarrysGameLauncher.exe"); // The application the shortcut will open
            shortcut.Save(); // Saves shortcut
        }
    }
}
