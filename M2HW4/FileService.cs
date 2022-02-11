// <copyright file="FileService.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace M2HW5
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text;

    /// <summary>
    /// Class for work wth files.
    /// </summary>
    internal class FileService : ICreateFile
    {
        /// <summary>
        /// Checking files.
        /// </summary>
        public void CheckYourFiles()
        {
            string[] fileEntries = Directory.GetFiles(@"C:\Users\ulkap\source\repos\julia606\Module2HW5\AllFiles");
            if (fileEntries.Length > 3)
            {
                File.Delete(fileEntries[0]);
            }
        }

        /// <summary>
        /// Creating and writing to file.
        /// </summary>
        /// <param name="logs">List of logs.</param>
        public void CreateFile(List<Log> logs)
        {
            string path = $"{DateTime.Now.ToString("HH.mm.ss dd MMMM yyyy")}.txt";
            FileInfo fi = new FileInfo(@$"C:\Users\ulkap\source\repos\julia606\Module2HW5\AllFiles\{path}");
            byte[] info;
            if (fi.Exists)
            {
                fi.Delete();
            }

            using (FileStream fs = fi.Create())
            {
                DateTime.Now.ToString("dddd, dd MMMM yyyy HH:mm:ss");

                foreach (var log in logs)
                {
                  info = new UTF8Encoding(true).GetBytes(log.ToString());
                  fs.Write(info, 0, info.Length);
                }

                this.CheckYourFiles();
            }
        }
    }
}
