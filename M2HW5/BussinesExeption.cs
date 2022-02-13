// <copyright file="BussinesExeption.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace M2HW5
{
    using System;

    /// <summary>
    /// Class my custom exeption.
    /// </summary>
    public class BussinesExeption : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BussinesExeption"/> class.
        /// </summary>
        /// <param name="message">Message for exeption.</param>
        public BussinesExeption(string message)
            : base(message)
        {
        }
    }
}
