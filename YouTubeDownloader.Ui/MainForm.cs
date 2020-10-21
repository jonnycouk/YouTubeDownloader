using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using MediaToolkit;
using MediaToolkit.Model;
using VideoLibrary;

namespace YouTubeDownloader.Ui
{
    public partial class MainForm : Form
    {
        private string _downloadLocation = "";
        private string _lastDownload = "";

        public MainForm()
        {
            InitializeComponent();
            btnOpenFolder.Click += (obj, args) => Open(_downloadLocation);
            btnGitHub.Click += (obj, args) => Open("https://github.com/jonnycouk/YouTubeDownloader");
            btnDownloadVideo.Click += (obj, args) => DownloadVideo();
        }

        private void DownloadVideo()
        {
            if (!string.IsNullOrEmpty(txtUrl.Text))
            {
                CheckDownloadLocation();

                string link = txtUrl.Text.Trim();
                var youTube = YouTube.Default;
                var video = youTube.GetVideo(link);

                File.WriteAllBytes($"{_downloadLocation}\\{video.FullName}", video.GetBytes());

                _lastDownload = $"{_downloadLocation}\\{video.FullName}";

                if (chkOpenFolderAfterDownload.Checked)
                    Open(_downloadLocation);

                if (chkPlayAfterDownload.Checked)
                    Open(_lastDownload);

                if (chkExtractAudioAfterDownload.Checked)
                {
                    var inputFile = new MediaFile { Filename = $"{_downloadLocation}\\{video.FullName}" };
                    var outputFile = new MediaFile { Filename = $"{_downloadLocation}\\{video.FullName}.mp3" };

                    using (var engine = new Engine())
                    {
                        engine.GetMetadata(inputFile);
                        engine.Convert(inputFile, outputFile);
                    }

                }
            }
        }

        private void CheckDownloadLocation()
        {
            string location = txtDownloadLocation.Text.Trim();

            if (!string.IsNullOrEmpty(location))
            {
                if (!Directory.Exists(location))
                    Directory.CreateDirectory(location);
            }

            _downloadLocation = location;
        }

        private void Open(string path)
        {
            try
            {
                Process openProcess = new Process { StartInfo = new ProcessStartInfo(path) };
                openProcess.Start();
            }
            catch (Exception)
            {
            }
        }



        private void MainForm_Load(object sender, EventArgs e)
        {
            CheckDownloadLocation();
        }

    }
}
