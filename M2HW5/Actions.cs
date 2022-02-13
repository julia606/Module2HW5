// <copyright file="Actions.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace M2HW5
{
    using System;

    /// <summary>
    /// Class with methods.
    /// </summary>
    public static class Actions
    {
        /// <summary>
        /// First method.
        /// </summary>
        /// <returns>Object with log info.</returns>
        public static bool FirstMethod()
        {
            return true;
        }

        /// <summary>
        /// Second method.
        /// </summary>
        /// <returns>Object with log info.</returns>
        public static BussinesExeption SecondMethod()
        {
            return new BussinesExeption("Skipped logic in method");
        }

        /// <summary>
        /// Second method.
        /// </summary>
        /// <param name="log">Logger.</param>
        public static void ThirdMethod()
        {
            throw new Exception("I broke a logic");
        }
    }
}
