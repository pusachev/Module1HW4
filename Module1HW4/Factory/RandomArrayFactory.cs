// <copyright file="RandomArrayFactory.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>
namespace Module1HW4.Factory
{
    using System;

    /// <summary>
    /// Random Array Factory with prefilled elements.
    /// </summary>
    public class RandomArrayFactory
    {
        /// <summary>
        /// Create and returned array with prefilled element by provied size
        /// </summary>
        /// <param name="size">array size.</param>
        /// <returns>Array with random int elements.</returns>
        public static int[] Create(int size)
        {
            int[] array = new int[size];

            Random rand = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(1, 27);
            }

            return array;
        }
    }
}