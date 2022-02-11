// <copyright file="Starter.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace M2HW5
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Starts all work.
    /// </summary>
    internal class Starter
    {
        /// <summary>
        /// Starting looking for logs.
        /// </summary>
        /// <param name="log">Logger.</param>
        public static void Run()
        {
            List<Log> logs = new List<Log>();
            Random random = new Random();
            for (int i = 0; i < 100; i++)
            {
                int operation = random.Next(1, 4);
                switch (operation)
                {
                    case 1:
                        if (Actions.FirstMethod())
                        {
                            Log log1 = new Log(Type.Info, "Start method : FirstMethod", DateTime.Now);
                            logs.Add(log1);
                            Console.WriteLine(log1.ToString());
                        }

                        break;
                    case 2:
                        var result = Actions.SecondMethod();
                        Log log2 = new Log(Type.Warning, $"Action got this custom Exception : {result.Message}", DateTime.Now);
                        logs.Add(log2);
                        Console.WriteLine(log2.ToString());

                        break;
                    case 3:
                        try
                        {
                            Actions.ThirdMethod();
                        }
                        catch (Exception ex)
                        {
                            Log log3 = new Log(Type.Error, $"Action failed by reason : {ex.Message}", DateTime.Now);
                            logs.Add(log3);
                            Console.WriteLine(log3.ToString());
                        }

                        break;
                }
            }

            new FileService().CreateFile(logs);
        }
    }
}
