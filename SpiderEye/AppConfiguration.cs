﻿namespace SpiderEye
{
    /// <summary>
    /// Application configuration.
    /// </summary>
    public class AppConfiguration
    {
        /// <summary>
        /// Default configuration instance.
        /// </summary>
        public static readonly AppConfiguration Default = new AppConfiguration();

        /// <summary>
        /// Gets or sets the initial window title.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the initial window width.
        /// </summary>
        public int Width { get; set; }

        /// <summary>
        /// Gets or sets the initial window height.
        /// </summary>
        public int Height { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the window can be resized or not.
        /// </summary>
        public bool CanResize { get; set; }

        /// <summary>
        /// Gets or sets the start page file path. Default is "index.html".
        /// </summary>
        public string StartPageUrl { get; set; }

        /// <summary>
        /// Gets or sets the host url.
        /// </summary>
        public string Host { get; set; }

        /// <summary>
        /// Gets or sets the folder path where the embedded files are. Default is "App".
        /// </summary>
        public string ContentFolder { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppConfiguration"/> class.
        /// </summary>
        public AppConfiguration()
        {
            Title = "Main Window";
            Width = 900;
            Height = 600;
            CanResize = true;
            StartPageUrl = "index.html";
            ContentFolder = "App";
            Host = null;
        }
    }
}
