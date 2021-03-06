﻿namespace YouTubeDownloader.Ui
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.btnDownloadVideo = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDownloadLocation = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnOpenFolder = new System.Windows.Forms.Button();
            this.chkPlayAfterDownload = new System.Windows.Forms.CheckBox();
            this.chkOpenFolderAfterDownload = new System.Windows.Forms.CheckBox();
            this.btnGitHub = new System.Windows.Forms.Button();
            this.chkExtractAudioAfterDownload = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 135);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "YouTube URL";
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(44, 160);
            this.txtUrl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(497, 26);
            this.txtUrl.TabIndex = 0;
            // 
            // btnDownloadVideo
            // 
            this.btnDownloadVideo.Image = ((System.Drawing.Image)(resources.GetObject("btnDownloadVideo.Image")));
            this.btnDownloadVideo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDownloadVideo.Location = new System.Drawing.Point(577, 216);
            this.btnDownloadVideo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDownloadVideo.Name = "btnDownloadVideo";
            this.btnDownloadVideo.Size = new System.Drawing.Size(183, 46);
            this.btnDownloadVideo.TabIndex = 1;
            this.btnDownloadVideo.Text = "Download Media";
            this.btnDownloadVideo.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, -7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(215, 112);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(204, 73);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 37);
            this.label2.TabIndex = 4;
            this.label2.Text = "downloader";
            // 
            // txtDownloadLocation
            // 
            this.txtDownloadLocation.Location = new System.Drawing.Point(44, 237);
            this.txtDownloadLocation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDownloadLocation.Name = "txtDownloadLocation";
            this.txtDownloadLocation.Size = new System.Drawing.Size(497, 26);
            this.txtDownloadLocation.TabIndex = 6;
            this.txtDownloadLocation.Text = "D:\\Temp\\YouTube";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 212);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Download to";
            // 
            // btnOpenFolder
            // 
            this.btnOpenFolder.Image = ((System.Drawing.Image)(resources.GetObject("btnOpenFolder.Image")));
            this.btnOpenFolder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOpenFolder.Location = new System.Drawing.Point(577, 160);
            this.btnOpenFolder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnOpenFolder.Name = "btnOpenFolder";
            this.btnOpenFolder.Size = new System.Drawing.Size(183, 46);
            this.btnOpenFolder.TabIndex = 7;
            this.btnOpenFolder.Text = "Download Folder";
            this.btnOpenFolder.UseVisualStyleBackColor = true;
            // 
            // chkPlayAfterDownload
            // 
            this.chkPlayAfterDownload.AutoSize = true;
            this.chkPlayAfterDownload.Location = new System.Drawing.Point(44, 306);
            this.chkPlayAfterDownload.Name = "chkPlayAfterDownload";
            this.chkPlayAfterDownload.Size = new System.Drawing.Size(207, 24);
            this.chkPlayAfterDownload.TabIndex = 8;
            this.chkPlayAfterDownload.Text = "Play video after download";
            this.chkPlayAfterDownload.UseVisualStyleBackColor = true;
            // 
            // chkOpenFolderAfterDownload
            // 
            this.chkOpenFolderAfterDownload.AutoSize = true;
            this.chkOpenFolderAfterDownload.Checked = true;
            this.chkOpenFolderAfterDownload.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkOpenFolderAfterDownload.Location = new System.Drawing.Point(44, 276);
            this.chkOpenFolderAfterDownload.Name = "chkOpenFolderAfterDownload";
            this.chkOpenFolderAfterDownload.Size = new System.Drawing.Size(292, 24);
            this.chkOpenFolderAfterDownload.TabIndex = 9;
            this.chkOpenFolderAfterDownload.Text = "Open download folder after download";
            this.chkOpenFolderAfterDownload.UseVisualStyleBackColor = true;
            // 
            // btnGitHub
            // 
            this.btnGitHub.Image = ((System.Drawing.Image)(resources.GetObject("btnGitHub.Image")));
            this.btnGitHub.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGitHub.Location = new System.Drawing.Point(577, 314);
            this.btnGitHub.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGitHub.Name = "btnGitHub";
            this.btnGitHub.Size = new System.Drawing.Size(183, 46);
            this.btnGitHub.TabIndex = 10;
            this.btnGitHub.Text = "Download Source";
            this.btnGitHub.UseVisualStyleBackColor = true;
            // 
            // chkExtractAudioAfterDownload
            // 
            this.chkExtractAudioAfterDownload.AutoSize = true;
            this.chkExtractAudioAfterDownload.Location = new System.Drawing.Point(44, 336);
            this.chkExtractAudioAfterDownload.Name = "chkExtractAudioAfterDownload";
            this.chkExtractAudioAfterDownload.Size = new System.Drawing.Size(271, 24);
            this.chkExtractAudioAfterDownload.TabIndex = 12;
            this.chkExtractAudioAfterDownload.Text = "Extract audio after video download";
            this.chkExtractAudioAfterDownload.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(794, 377);
            this.Controls.Add(this.chkExtractAudioAfterDownload);
            this.Controls.Add(this.btnGitHub);
            this.Controls.Add(this.chkOpenFolderAfterDownload);
            this.Controls.Add(this.chkPlayAfterDownload);
            this.Controls.Add(this.btnOpenFolder);
            this.Controls.Add(this.txtDownloadLocation);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnDownloadVideo);
            this.Controls.Add(this.txtUrl);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "YouTube Downloader";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.Button btnDownloadVideo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDownloadLocation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnOpenFolder;
        private System.Windows.Forms.CheckBox chkPlayAfterDownload;
        private System.Windows.Forms.CheckBox chkOpenFolderAfterDownload;
        private System.Windows.Forms.Button btnGitHub;
        private System.Windows.Forms.CheckBox chkExtractAudioAfterDownload;
    }
}

