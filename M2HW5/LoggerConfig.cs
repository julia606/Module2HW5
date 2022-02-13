// <copyright file="LoggerConfig.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>
namespace M2HW5
{
    using System;

    /// <summary>
    /// Logger configuration.
    /// </summary>
    [Serializable]
    internal class LoggerConfig
    {
        /// <summary>
        /// Gets or sets the message of log.
        /// </summary>
        public string TimeFormat { get; set; }

        /// <summary>
        /// Gets or sets the message of log.
        /// </summary>
        public string DirectoryPath { get; set; }

        /// <summary>
        /// Gets or sets the message of log.
        /// </summary>
        public string FileName { get; set; }

        /// <summary>
        /// Gets or sets the message of log.
        /// </summary>
        public string FileExtension { get; set; }
    }
}
