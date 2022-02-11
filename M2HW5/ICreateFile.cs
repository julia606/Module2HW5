// <copyright file="ICreateFile.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace M2HW5
{
    using System.Collections.Generic;

    /// <summary>
    /// Interface for creating file.
    /// </summary>
    internal interface ICreateFile
    {
        /// <summary>
        /// Function for creating and writing to file.
        /// </summary>
        /// <param name="logs">List with logs.</param>
        void CreateFile(List<Log> logs);
    }
}
