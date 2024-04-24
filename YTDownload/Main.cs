﻿using Google.Apis.Services;
using Google.Apis.YouTube.v3;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YoutubeExplode;

namespace YTDownload
{
    public partial class Main : Form
    {
        private bool isDragging = false;
        private Point lastCursor;
        private Point lastForm;

        private YouTubeService youtubeService;

        public Main()
        {
            InitializeComponent();         
        }

        private YouTubeService YouTubeService
        {
            get
            {
                if (youtubeService == null)
                {
                    youtubeService = new YouTubeService(new BaseClientService.Initializer()
                    {
                        // Place your API Key here
                        ApiKey = "your_API_Key",

                        // Place your Application Name here
                        ApplicationName = "you_application_name"
                    });
                }
                return youtubeService;
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            // Close the form
            this.Close();
        }

        private void buttonMinimize_Click(object sender, EventArgs e)
        {
            // Minimize the window
            WindowState = FormWindowState.Minimized;
        }

        private void panelNav_MouseDown(object sender, MouseEventArgs e)
        {
            isDragging = true;
            lastCursor = Cursor.Position;
            lastForm = this.Location;
        }

        private void panelNav_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                int deltaX = Cursor.Position.X - lastCursor.X;
                int deltaY = Cursor.Position.Y - lastCursor.Y;
                this.Location = new Point(lastForm.X + deltaX, lastForm.Y + deltaY);
            }
        }

        private void panelNav_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }

        private string GetVideoIdFromUrl(string url)
        {
            var uri = new Uri(url);
            var query = uri.Query;
            var queryParams = query.TrimStart('?').Split('&')
                                  .Select(part => part.Split('='))
                                  .ToDictionary(split => split[0], split => split.Length > 1 ? split[1] : "");

            if (queryParams.ContainsKey("v"))
            {
                return queryParams["v"];
            }
            else
            {
                throw new ArgumentException("Invalid YouTube URL: missing video ID");
            }
        }

        private async void buttonSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxURL.Text))
            {
                MessageBox.Show("Please enter a video ID or URL");
                return;
            }

            string videoId = GetVideoIdFromUrl(textBoxURL.Text);

            try
            {
                var videosListRequest = YouTubeService.Videos.List("snippet");
                videosListRequest.Id = videoId;
                var videosListResponse = await videosListRequest.ExecuteAsync();

                if (videosListResponse.Items.Count == 0)
                {
                    MessageBox.Show("Video not found");
                    return;
                }

                var videoItem = videosListResponse.Items[0];

                // Access video title
                string videoTitle = videoItem.Snippet.Title;
                richTextBoxTitle.Text = videoTitle;

                // Access video thumbnail URL
                string thumbnailUrl = videoItem.Snippet.Thumbnails.Default__.Url;

                // Display video thumbnail in PictureBox
                pictureBoxThumbnail.Load(thumbnailUrl);

                // Populate comboBoxQuality with available quality options
                PopulateQualityComboBox(videoId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error searching video: " + ex.Message);
            }
        }

        private async void PopulateQualityComboBox(string videoId)
        {
            var youtube = new YoutubeClient();
            var streamManifest = await youtube.Videos.Streams.GetManifestAsync(videoId);

            // Extract available quality options from both muxed and video-only streams
            var muxedQualityOptions = streamManifest.GetMuxedStreams()
                .Select(s => s.VideoQuality.ToString())
                .Distinct();
            var videoOnlyQualityOptions = streamManifest.GetVideoOnlyStreams()
                .Select(s => s.VideoQuality.ToString())
                .Distinct();

            // Combine and order quality options from both sets of streams
            var qualityOptions = muxedQualityOptions.Concat(videoOnlyQualityOptions)
                .Distinct()
                .OrderByDescending(q => ParseQuality(q)) // Order by quality (highest to lowest)
                .ToList();

            // Clear comboBoxQuality.Items and add the quality options
            comboBoxQuality.Items.Clear();
            comboBoxQuality.Items.AddRange(qualityOptions.ToArray());

            // Set default selection
            comboBoxQuality.SelectedIndex = 0;
        }

        // Helper method to parse quality string into a comparable format
        private int ParseQuality(string quality)
        {
            // Assuming the format is "Heightp" e.g., "1080p", "720p", "480p", etc.
            string heightStr = quality.TrimEnd('p');
            int height;
            if (int.TryParse(heightStr, out height))
            {
                return height;
            }
            else
            {
                // If parsing fails, return a default value
                return 0;
            }
        }

        private async void buttonDLVideo_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxURL.Text))
            {
                MessageBox.Show("Please enter a video ID or URL");
                return;
            }

            string videoId = null;
            try
            {
                // Try to parse the input as a video ID
                videoId = GetVideoIdFromUrl(textBoxURL.Text);
            }
            catch (ArgumentException)
            {
                // If parsing as a video ID fails, assume it's a URL and extract the video ID
                videoId = textBoxURL.Text;
            }

            // Get the download location from the textBoxFileLocation
            string savePath = textBoxFileLocation.Text;

            if (string.IsNullOrEmpty(savePath))
            {
                // If the download location is not set, prompt the user to choose it
                MessageBox.Show("Please choose a download location");
                return;
            }

            try
            {
                // Download the video using the selected or default location
                string selectedQuality = comboBoxQuality.SelectedItem?.ToString();
                await DownloadVideo(videoId, savePath, selectedQuality);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error downloading video: " + ex.Message);
            }
        }

        private async Task DownloadVideo(string videoId, string savePath, string selectedQuality)
        {
            var youtube = new YoutubeClient();
            var streamManifest = await youtube.Videos.Streams.GetManifestAsync(videoId);

            // Get all available muxed streams
            var muxedStreams = streamManifest.GetMuxedStreams();

            // Find the closest quality to the selected quality
            var selectedStream = muxedStreams
                .OrderByDescending(s => ParseQualityToInt(s.VideoQuality.ToString()))
                .FirstOrDefault(s => ParseQualityToInt(s.VideoQuality.ToString()) >= ParseQualityToInt(selectedQuality));

            if (selectedStream != null)
            {
                // Download the video with the selected quality
                string filePath = Path.Combine(savePath, $"{videoId}.mp4");
                var progress = new Progress<double>(p =>
                {
                    // Update progress spinner value
                    progressBar1.Value = (int)(p * 100); // Convert progress to percentage
                });

                await youtube.Videos.Streams.DownloadAsync(selectedStream, filePath, progress);

                MessageBox.Show("Video downloaded successfully!");
            }
            else
            {
                MessageBox.Show($"No available {selectedQuality} streams for this video.");
            }
        }

        // Helper method to parse quality string into a comparable format
        private int ParseQualityToInt(string quality)
        {
            // Assuming the format is "Heightp" e.g., "1080p", "720p", "480p", etc.
            string heightStr = quality.TrimEnd('p');
            int height;
            if (int.TryParse(heightStr, out height))
            {
                return height;
            }
            else
            {
                // If parsing fails, return a default value
                return 0;
            }
        }

        private async void buttonDLMp3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxURL.Text))
            {
                MessageBox.Show("Please enter a video ID or URL");
                return;
            }

            string videoId = null;
            try
            {
                // Try to parse the input as a video ID
                videoId = GetVideoIdFromUrl(textBoxURL.Text);
            }
            catch (ArgumentException)
            {
                // If parsing as a video ID fails, assume it's a URL and extract the video ID
                videoId = textBoxURL.Text;
            }

            // Get the default download location
            string defaultDownloadLocation = LoadDefaultDownloadLocationFromSettings();

            try
            {
                await DownloadAudio(videoId, defaultDownloadLocation);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error downloading audio: " + ex.Message);
            }
        }

        private async Task DownloadAudio(string videoId, string savePath)
        {
            var youtube = new YoutubeClient();
            var streamManifest = await youtube.Videos.Streams.GetManifestAsync(videoId);
            var audioStreamInfo = streamManifest.GetAudioOnlyStreams().OrderByDescending(s => s.Bitrate).FirstOrDefault();

            if (audioStreamInfo != null)
            {
                // Download the audio to the default download location
                string filePath = Path.Combine(savePath, $"{videoId}.mp3");
                var progress = new Progress<double>(p =>
                {
                    // Update progress spinner value
                    progressBar1.Value = (int)(p * 100); // Convert progress to percentage
                });

                await youtube.Videos.Streams.DownloadAsync(audioStreamInfo, filePath, progress);

                MessageBox.Show("Audio downloaded successfully!");
            }
            else
            {
                MessageBox.Show("No available audio streams for this video.");
            }
        }

        private void buttonDFLocation_Click(object sender, EventArgs e)
        {
            // Open a folder browser dialog to choose the download location
            using (var folderDialog = new FolderBrowserDialog())
            {
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    // Set the chosen location to the textBoxFileLocation
                    textBoxFileLocation.Text = folderDialog.SelectedPath;

                    // Update the default download location setting to the newly selected location
                    SaveDefaultDownloadLocationToSettings(folderDialog.SelectedPath);
                }
            }
        }

        private void SaveDefaultDownloadLocationToSettings(string selectedPath)
        {
           
            Properties.Settings.Default.DefaultDownloadLocation = selectedPath;
            Properties.Settings.Default.Save();
           
        }


        private void LoadDefaultDownloadLocation()
        {
          
            string defaultDownloadLocation = LoadDefaultDownloadLocationFromSettings();

            // Display the default download location in the textBoxFileLocation
            textBoxFileLocation.Text = defaultDownloadLocation;
        }

        private string LoadDefaultDownloadLocationFromSettings()
        {
            // Retrieve the default download location from application settings
            string defaultDownloadLocation = Properties.Settings.Default.DefaultDownloadLocation;

            // If the saved location is not null or empty, return it
            if (!string.IsNullOrEmpty(defaultDownloadLocation))
            {
                return defaultDownloadLocation;
            }
            else
            {
                // If the saved location is null or empty, return a default location
                return @"C:\Users\Public\Downloads"; // Default location if settings not found
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            LoadDefaultDownloadLocation();
        }

        private void buttonGitHub_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/seizue/YTDownload?tab=readme-ov-file");
        }
    }
}
