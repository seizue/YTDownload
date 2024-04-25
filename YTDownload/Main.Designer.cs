namespace YTDownload
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.panelNav = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonMinimize = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.textBoxURL = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxQuality = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.richTextBoxTitle = new System.Windows.Forms.RichTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonDLMp3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonDLVideo = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.textBoxFileLocation = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonDFLocation = new System.Windows.Forms.Button();
            this.buttonGitHub = new System.Windows.Forms.Button();
            this.pictureBoxThumbnail = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonCancelDL = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panelNav.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxThumbnail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelNav
            // 
            this.panelNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.panelNav.Controls.Add(this.label3);
            this.panelNav.Controls.Add(this.pictureBox1);
            this.panelNav.Controls.Add(this.buttonMinimize);
            this.panelNav.Controls.Add(this.buttonClose);
            this.panelNav.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelNav.Location = new System.Drawing.Point(0, 0);
            this.panelNav.Name = "panelNav";
            this.panelNav.Size = new System.Drawing.Size(829, 35);
            this.panelNav.TabIndex = 0;
            this.panelNav.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelNav_MouseDown);
            this.panelNav.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelNav_MouseMove);
            this.panelNav.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelNav_MouseUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkGray;
            this.label3.Location = new System.Drawing.Point(53, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 18);
            this.label3.TabIndex = 13;
            this.label3.Text = "YTDownload";
            // 
            // buttonMinimize
            // 
            this.buttonMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMinimize.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.buttonMinimize.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(36)))), ((int)(((byte)(31)))));
            this.buttonMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMinimize.Location = new System.Drawing.Point(755, 10);
            this.buttonMinimize.Name = "buttonMinimize";
            this.buttonMinimize.Size = new System.Drawing.Size(14, 14);
            this.buttonMinimize.TabIndex = 6;
            this.buttonMinimize.UseVisualStyleBackColor = false;
            this.buttonMinimize.Click += new System.EventHandler(this.buttonMinimize_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.BackColor = System.Drawing.Color.IndianRed;
            this.buttonClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Location = new System.Drawing.Point(787, 10);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(14, 14);
            this.buttonClose.TabIndex = 4;
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // textBoxURL
            // 
            this.textBoxURL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.textBoxURL.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxURL.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxURL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBoxURL.Location = new System.Drawing.Point(139, 95);
            this.textBoxURL.Name = "textBoxURL";
            this.textBoxURL.Size = new System.Drawing.Size(486, 20);
            this.textBoxURL.TabIndex = 1;
            this.textBoxURL.TextChanged += new System.EventHandler(this.textBoxURL_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(136, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Paste URL or Video ID";
            // 
            // comboBoxQuality
            // 
            this.comboBoxQuality.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.comboBoxQuality.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxQuality.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxQuality.ForeColor = System.Drawing.Color.Silver;
            this.comboBoxQuality.Location = new System.Drawing.Point(139, 167);
            this.comboBoxQuality.Name = "comboBoxQuality";
            this.comboBoxQuality.Size = new System.Drawing.Size(121, 21);
            this.comboBoxQuality.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(136, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "Choose Quality";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.richTextBoxTitle);
            this.panel1.Controls.Add(this.pictureBoxThumbnail);
            this.panel1.Location = new System.Drawing.Point(139, 218);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(543, 124);
            this.panel1.TabIndex = 10;
            // 
            // richTextBoxTitle
            // 
            this.richTextBoxTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.richTextBoxTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxTitle.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxTitle.ForeColor = System.Drawing.Color.DarkGray;
            this.richTextBoxTitle.Location = new System.Drawing.Point(0, 0);
            this.richTextBoxTitle.Name = "richTextBoxTitle";
            this.richTextBoxTitle.ReadOnly = true;
            this.richTextBoxTitle.Size = new System.Drawing.Size(372, 124);
            this.richTextBoxTitle.TabIndex = 11;
            this.richTextBoxTitle.Text = "";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.panel2.Controls.Add(this.buttonCancelDL);
            this.panel2.Controls.Add(this.buttonDLMp3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.buttonGitHub);
            this.panel2.Controls.Add(this.buttonDLVideo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 428);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(829, 84);
            this.panel2.TabIndex = 11;
            // 
            // buttonDLMp3
            // 
            this.buttonDLMp3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDLMp3.BackColor = System.Drawing.Color.Sienna;
            this.buttonDLMp3.FlatAppearance.BorderColor = System.Drawing.Color.SaddleBrown;
            this.buttonDLMp3.FlatAppearance.BorderSize = 2;
            this.buttonDLMp3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDLMp3.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDLMp3.ForeColor = System.Drawing.Color.White;
            this.buttonDLMp3.Location = new System.Drawing.Point(482, 26);
            this.buttonDLMp3.Name = "buttonDLMp3";
            this.buttonDLMp3.Size = new System.Drawing.Size(150, 29);
            this.buttonDLMp3.TabIndex = 15;
            this.buttonDLMp3.Text = "Download MP3";
            this.buttonDLMp3.UseVisualStyleBackColor = false;
            this.buttonDLMp3.Click += new System.EventHandler(this.buttonDLMp3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkGray;
            this.label4.Location = new System.Drawing.Point(405, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 18);
            this.label4.TabIndex = 14;
            // 
            // buttonDLVideo
            // 
            this.buttonDLVideo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDLVideo.BackColor = System.Drawing.Color.IndianRed;
            this.buttonDLVideo.FlatAppearance.BorderColor = System.Drawing.Color.LightCoral;
            this.buttonDLVideo.FlatAppearance.BorderSize = 2;
            this.buttonDLVideo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDLVideo.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDLVideo.ForeColor = System.Drawing.Color.White;
            this.buttonDLVideo.Location = new System.Drawing.Point(651, 26);
            this.buttonDLVideo.Name = "buttonDLVideo";
            this.buttonDLVideo.Size = new System.Drawing.Size(150, 29);
            this.buttonDLVideo.TabIndex = 5;
            this.buttonDLVideo.Text = "Download Video";
            this.buttonDLVideo.UseVisualStyleBackColor = false;
            this.buttonDLVideo.Click += new System.EventHandler(this.buttonDLVideo_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.progressBar1.Location = new System.Drawing.Point(0, 418);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(829, 10);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 12;
            // 
            // textBoxFileLocation
            // 
            this.textBoxFileLocation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.textBoxFileLocation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxFileLocation.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFileLocation.ForeColor = System.Drawing.Color.DarkGray;
            this.textBoxFileLocation.Location = new System.Drawing.Point(299, 167);
            this.textBoxFileLocation.Name = "textBoxFileLocation";
            this.textBoxFileLocation.Size = new System.Drawing.Size(342, 19);
            this.textBoxFileLocation.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Silver;
            this.label5.Location = new System.Drawing.Point(296, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 18);
            this.label5.TabIndex = 15;
            this.label5.Text = "Choose Download Location";
            // 
            // buttonClear
            // 
            this.buttonClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClear.BackColor = System.Drawing.Color.Transparent;
            this.buttonClear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonClear.FlatAppearance.BorderSize = 0;
            this.buttonClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.buttonClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.buttonClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClear.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClear.ForeColor = System.Drawing.Color.DarkGray;
            this.buttonClear.Image = global::YTDownload.Properties.Resources.broom_24px;
            this.buttonClear.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonClear.Location = new System.Drawing.Point(556, 59);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(126, 24);
            this.buttonClear.TabIndex = 17;
            this.buttonClear.Text = "Clear Search Box";
            this.buttonClear.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSearch.BackColor = System.Drawing.Color.IndianRed;
            this.buttonSearch.FlatAppearance.BorderColor = System.Drawing.Color.LightCoral;
            this.buttonSearch.FlatAppearance.BorderSize = 2;
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearch.Image = global::YTDownload.Properties.Resources.search_14px;
            this.buttonSearch.Location = new System.Drawing.Point(631, 95);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(51, 20);
            this.buttonSearch.TabIndex = 16;
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonDFLocation
            // 
            this.buttonDFLocation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDFLocation.BackColor = System.Drawing.Color.Transparent;
            this.buttonDFLocation.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonDFLocation.FlatAppearance.BorderSize = 0;
            this.buttonDFLocation.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.buttonDFLocation.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.buttonDFLocation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDFLocation.Image = global::YTDownload.Properties.Resources.folder_24px;
            this.buttonDFLocation.Location = new System.Drawing.Point(647, 164);
            this.buttonDFLocation.Name = "buttonDFLocation";
            this.buttonDFLocation.Size = new System.Drawing.Size(35, 24);
            this.buttonDFLocation.TabIndex = 13;
            this.buttonDFLocation.UseVisualStyleBackColor = false;
            this.buttonDFLocation.Click += new System.EventHandler(this.buttonDFLocation_Click);
            // 
            // buttonGitHub
            // 
            this.buttonGitHub.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonGitHub.BackColor = System.Drawing.Color.Transparent;
            this.buttonGitHub.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(36)))), ((int)(((byte)(31)))));
            this.buttonGitHub.FlatAppearance.BorderSize = 0;
            this.buttonGitHub.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonGitHub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGitHub.ForeColor = System.Drawing.Color.Gray;
            this.buttonGitHub.Image = global::YTDownload.Properties.Resources.github_24px;
            this.buttonGitHub.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonGitHub.Location = new System.Drawing.Point(23, 26);
            this.buttonGitHub.Name = "buttonGitHub";
            this.buttonGitHub.Size = new System.Drawing.Size(119, 27);
            this.buttonGitHub.TabIndex = 7;
            this.buttonGitHub.Text = "Open Source! ";
            this.buttonGitHub.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonGitHub.UseVisualStyleBackColor = false;
            this.buttonGitHub.Click += new System.EventHandler(this.buttonGitHub_Click);
            // 
            // pictureBoxThumbnail
            // 
            this.pictureBoxThumbnail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.pictureBoxThumbnail.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBoxThumbnail.Location = new System.Drawing.Point(372, 0);
            this.pictureBoxThumbnail.Name = "pictureBoxThumbnail";
            this.pictureBoxThumbnail.Size = new System.Drawing.Size(171, 124);
            this.pictureBoxThumbnail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxThumbnail.TabIndex = 3;
            this.pictureBoxThumbnail.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::YTDownload.Properties.Resources.YouTube_24px;
            this.pictureBox1.Location = new System.Drawing.Point(23, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // buttonCancelDL
            // 
            this.buttonCancelDL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancelDL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.buttonCancelDL.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.buttonCancelDL.FlatAppearance.BorderSize = 2;
            this.buttonCancelDL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancelDL.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelDL.ForeColor = System.Drawing.Color.White;
            this.buttonCancelDL.Location = new System.Drawing.Point(297, 26);
            this.buttonCancelDL.Name = "buttonCancelDL";
            this.buttonCancelDL.Size = new System.Drawing.Size(150, 29);
            this.buttonCancelDL.TabIndex = 16;
            this.buttonCancelDL.Text = "Cancel Download";
            this.buttonCancelDL.UseVisualStyleBackColor = false;
            this.buttonCancelDL.Click += new System.EventHandler(this.buttonCancelDL_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gray;
            this.panel3.Location = new System.Drawing.Point(463, 458);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1, 19);
            this.panel3.TabIndex = 17;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(829, 512);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxFileLocation);
            this.Controls.Add(this.buttonDFLocation);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxQuality);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxURL);
            this.Controls.Add(this.panelNav);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Opacity = 0.98D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Main_Load);
            this.panelNav.ResumeLayout(false);
            this.panelNav.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxThumbnail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelNav;
        private System.Windows.Forms.Button buttonMinimize;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.TextBox textBoxURL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxQuality;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox richTextBoxTitle;
        private System.Windows.Forms.PictureBox pictureBoxThumbnail;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonDLVideo;
        private System.Windows.Forms.Button buttonGitHub;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonDLMp3;
        private System.Windows.Forms.Button buttonDFLocation;
        private System.Windows.Forms.TextBox textBoxFileLocation;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonCancelDL;
        private System.Windows.Forms.Panel panel3;
    }
}

