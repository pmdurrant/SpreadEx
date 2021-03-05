// ***********************************************************************
// Assembly         : SpreadEx
// Author           : pdurrant
// Created          : 03-04-2021
//
// Last Modified By : pdurrant
// Last Modified On : 03-05-2021
// ***********************************************************************
// <copyright file="Program.cs" company="SpreadEx">
//     Copyright (c) . All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using SpreadEx.Shapes;

namespace SpreadEx
{
    /// <summary>
    /// Class Program.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        static void Main(string[] args)
        {

            List<Widgets> items = new List<Widgets>();
            items.Add(new Rectangle(10, 10, 30, 40));
            items.Add(new Circle(1, 1, 300));
            items.Add(new Ellipse(100, 150, 300, 200));
            items.Add(new Square(15, 30, 35));
            items.Add(new Textbox(5, 6, 200, 100, "sample text"));

            ConsoleKeyInfo key;
            Console.WriteLine("Press P to Print, Esc to exit");

            do
            {
                key = Console.ReadKey();
                if (key.Key.ToString() == "P" || key.Key.ToString() == "p")
                {
                    Console.WriteLine("");
                    Console.WriteLine("----------------------------------------------------------------");
                    Console.WriteLine("Requested Drawing");
                    Console.WriteLine("----------------------------------------------------------------");

                    items.ForEach(item =>
                    {
                        Console.WriteLine(item.ToString());
                    });
                    Console.WriteLine("----------------------------------------------------------------");
                }
            } while (key.Key != ConsoleKey.Escape);
          }
    }
}
