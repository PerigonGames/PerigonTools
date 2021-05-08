using System.Collections.Generic;
using Random = System.Random;

namespace PerigonGames
{
    public static class IListExtensions
    {
        /// <summary>
        /// Checks if List is null or empty
        /// </summary>
        /// <param name="list">list</param>
        /// <typeparam name="T">generic type</typeparam>
        /// <returns>whether or not it's empty or null</returns>
        public static bool IsNullOrEmpty<T>(this IList<T> list)
        {
            return list == null || list.Count == 0;
        }

        /// <summary>
        /// Returns a null value if index out of vounds
        /// </summary>
        /// <param name="list">list</param>
        /// <param name="index">index</param>
        /// <typeparam name="T">generic type</typeparam>
        /// <returns>value or null</returns>
        public static T NullableGetElementAt<T>(this IList<T> list, int index)
        {
            if (index >= list.Count || list.IsNullOrEmpty())
            {
                return default(T);
            }
            else
            {
                return list[index];
            }
        }

        /// <summary>
        /// Shuffles IList using Fisher Yates Algorithm
        /// </summary>
        /// <param name="list">list</param>
        /// <param name="seed">seed</param>
        /// <typeparam name="T">Generic Type</typeparam>
        public static void ShuffleFisherYates<T>(this IList<T> list, int seed = -1)
        {
            if (list.IsNullOrEmpty())
            {
                return;
            }

            Random random = seed > -1 ? new Random(seed) : new Random();
            
            int count = list.Count;

            for (int i = 0; i < (count - 1); i++)
            {
                int index = i + random.Next(count - i);
                T element = list[index];
                list[index] = list[i];
                list[i] = element;
            }
        }
    }
}