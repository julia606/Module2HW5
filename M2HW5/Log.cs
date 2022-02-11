// <copyright file="Log.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace M2HW5
{
    using System;

    /// <summary>
    /// Types of message.
    /// </summary>
    public enum Type
    {
        /// <summary>Info log</summary>
        Info,

        /// <summary>Warning log</summary>
        Warning,

        /// <summary>Error log</summary>
        Error,
    }

    /// <summary>
    /// Class for log.
    /// </summary>
    public class Log
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Log"/> class.
        /// </summary>
        /// <param name="type">Type.</param>
        /// <param name="message">Message.</param>
        /// <param name="date">Date.</param>
        public Log(Type type, string message, DateTime date)
        {
            this.Type = type;
            this.DateTime = date;
            this.Message = message;
        }

        /// <summary>
        /// Gets the type of log.
        /// </summary>
        public Type Type { get; private set; }

        /// <summary>
        /// Gets a value indicating whether gets or sets the status of log.
        /// </summary>
        public bool Status { get; private set; }

        /// <summary>
        /// Gets the message of log.
        /// </summary>
        public string Message { get; private set; }

        /// <summary>
        /// Gets the time of log.
        /// </summary>
        public DateTime DateTime { get; private set; }

        /// <summary>
        /// Overriding ToString().
        /// </summary>
        /// <returns>String.</returns>
        public override string ToString()
        {
            return $" {this.DateTime}: {this.Type} : {this.Message}\n";
        }
    }
}
