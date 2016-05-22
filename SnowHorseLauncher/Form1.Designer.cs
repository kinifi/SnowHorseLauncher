namespace SnowHorseLauncher
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.NewsBrowser = new System.Windows.Forms.WebBrowser();
            this.noInternetIcon = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.snowHorsePictureBox = new System.Windows.Forms.PictureBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.MerchBrowser = new System.Windows.Forms.WebBrowser();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.DevTasksBrowser = new System.Windows.Forms.WebBrowser();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.noInternetIcon)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.snowHorsePictureBox)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(-1, -1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(20, 10);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1009, 730);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tabPage1.Controls.Add(this.NewsBrowser);
            this.tabPage1.Controls.Add(this.noInternetIcon);
            this.tabPage1.Location = new System.Drawing.Point(4, 41);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1001, 685);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "News";
            // 
            // NewsBrowser
            // 
            this.NewsBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NewsBrowser.Location = new System.Drawing.Point(3, 3);
            this.NewsBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.NewsBrowser.Name = "NewsBrowser";
            this.NewsBrowser.Size = new System.Drawing.Size(995, 679);
            this.NewsBrowser.TabIndex = 0;
            this.NewsBrowser.Url = new System.Uri("http://snowhorsegame.tumblr.com/", System.UriKind.Absolute);
            this.NewsBrowser.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser2_DocumentCompleted);
            // 
            // noInternetIcon
            // 
            this.noInternetIcon.Image = global::SnowHorseLauncher.Properties.Resources.no_conection_512;
            this.noInternetIcon.Location = new System.Drawing.Point(238, 78);
            this.noInternetIcon.Name = "noInternetIcon";
            this.noInternetIcon.Size = new System.Drawing.Size(510, 510);
            this.noInternetIcon.TabIndex = 1;
            this.noInternetIcon.TabStop = false;
            this.noInternetIcon.Visible = false;
            this.noInternetIcon.WaitOnLoad = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.snowHorsePictureBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 41);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(998, 685);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "SNOW HORSE";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(351, 564);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(310, 75);
            this.button1.TabIndex = 1;
            this.button1.Text = "PLAY";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // snowHorsePictureBox
            // 
            this.snowHorsePictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.snowHorsePictureBox.Image = global::SnowHorseLauncher.Properties.Resources._12194886_416496711884875_4603880809263483227_o;
            this.snowHorsePictureBox.Location = new System.Drawing.Point(3, 3);
            this.snowHorsePictureBox.Name = "snowHorsePictureBox";
            this.snowHorsePictureBox.Size = new System.Drawing.Size(992, 679);
            this.snowHorsePictureBox.TabIndex = 0;
            this.snowHorsePictureBox.TabStop = false;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.MerchBrowser);
            this.tabPage4.Location = new System.Drawing.Point(4, 41);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(998, 685);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Merch";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // MerchBrowser
            // 
            this.MerchBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MerchBrowser.Location = new System.Drawing.Point(3, 3);
            this.MerchBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.MerchBrowser.Name = "MerchBrowser";
            this.MerchBrowser.Size = new System.Drawing.Size(992, 679);
            this.MerchBrowser.TabIndex = 0;
            this.MerchBrowser.Url = new System.Uri("http://snowhorse.storenvy.com/", System.UriKind.Absolute);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.DevTasksBrowser);
            this.tabPage3.Location = new System.Drawing.Point(4, 41);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(998, 685);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Dev Tasks";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // DevTasksBrowser
            // 
            this.DevTasksBrowser.AllowNavigation = false;
            this.DevTasksBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DevTasksBrowser.Location = new System.Drawing.Point(-4, 0);
            this.DevTasksBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.DevTasksBrowser.Name = "DevTasksBrowser";
            this.DevTasksBrowser.Size = new System.Drawing.Size(1009, 689);
            this.DevTasksBrowser.TabIndex = 0;
            this.DevTasksBrowser.Url = new System.Uri("https://trello.com/b/ydaxlA6O/snow-horse", System.UriKind.Absolute);
            this.DevTasksBrowser.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted_1);
            // 
            // MainWindow
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "MainWindow";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Horse Launcher";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.noInternetIcon)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.snowHorsePictureBox)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.WebBrowser DevTasksBrowser;
        private System.Windows.Forms.WebBrowser NewsBrowser;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.WebBrowser MerchBrowser;
        private System.Windows.Forms.PictureBox snowHorsePictureBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox noInternetIcon;
    }
}

