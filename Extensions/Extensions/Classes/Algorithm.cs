﻿using System;
using System.Linq;
using System.Collections.Generic;

namespace Extensions
{
    /// <summary>
    /// Class that encapsulate some algorithms.
    /// </summary>
    public static class Algorithm
    {
        /// <summary>
        /// Generate the instance of IEnumerable of certain size and generated values.
        /// </summary>
        /// <typeparam name="T">The type of value in the collection.</typeparam>
        /// <param name="count">The amount of element that should be generated.</param>
        /// <param name="generator">The generator that produce value for filling.</param>
        /// <returns>The instance of IEnumerable filled with generated values of certain size.</returns>
        public static IEnumerable<T> GenerateN<T>(int count, Func<T> generator)
        {
            T[] array = new T[count];
            for (int i = 0; i < count; ++i)
            {
                array[i] = generator();
            }
            return array.AsEnumerable<T>();
        }
        /// <summary>
        /// Swap the values of two variables.
        /// </summary>
        /// <typeparam name="T">The type of variables.</typeparam>
        /// <param name="item1">The first variable.</param>
        /// <param name="item2">The second variable.</param>
        public static void Swap<T>(ref T item1, ref T item2)
        {
            T temp = item1;
            item1 = item2;
            item2 = temp;
        }
    }
}
