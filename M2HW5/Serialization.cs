// <copyright file="Serialization.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace M2HW5
{
    using System.IO;
    using System.Text.Json;

    /// <summary>
    /// Class for serialization.
    /// </summary>
    internal static class Serialization
    {
        /// <summary>
        /// Creating and writing to file.
        /// </summary>
        public static void SampleOfSerialization()
        {
            var options = new JsonSerializerOptions
            {
               WriteIndented = true,
            };
            using (FileStream fs = new FileStream(@"C:\Users\ulkap\source\repos\julia606\Module2HW5\user.json", FileMode.OpenOrCreate))
            {
                LoggerConfig loggerConfig = new LoggerConfig()
                {
                    TimeFormat = "MM/dd/yyyy HH:mm:ss",
                    DirectoryPath = @"C:\Users\ulkap\source\repos\julia606\Module2HW5\AllFiles",
                    FileName = "HH.mm.ss dd MMMM yyyy.txt",
                    FileExtension = ".txt",
                };
                JsonSerializer.SerializeAsync<LoggerConfig>(fs, loggerConfig, options);
            }
        }
    }
}
