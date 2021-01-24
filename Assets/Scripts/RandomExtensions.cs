using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;

namespace PerigonGames
{
    public enum ShuffleStyle
    {
        FisherYates,
        PlaceHolder
    }

    public static class RandomExtensions
    {
        /*
         * Method Signature: public bool CoinFlip()
            Explanation of what it does: Returns true or false randomly at 50/50 rate
            Sample Input: None
            Expected Output: True or False
         */
        public static bool CoinFlip(this Random random)
        {
            return random.Next() % 2 == 0;
        }

        
        /*
            Method Signature: public static bool NextTryGetElement(IList<T>, out T) 
            Explanation of what it does: If able to retrieve a random element from the list/array, return it 
            Sample Input: [1,2,3,4,5]
            Expected Output: Random element between 1 -> 5
         */
        public static bool NextTryGetElement<T>(this Random random, IList<T> list, out T element)
        {
            if (list.IsNullOrEmpty() || random == null)
            {
                element = default;
                return false;
            }

            element = list[random.Next(0, list.Count)];
            return true;
        }

        public static void Shuffle<T>(this IList<T> list, ShuffleStyle style = ShuffleStyle.FisherYates)
        {
            if (list.IsNullOrEmpty())
            {
                return;
            }

            switch (style)
            {
                case ShuffleStyle.FisherYates:
                    FisherYatesShuffle(ref list);
                    break;
                case ShuffleStyle.PlaceHolder:
                    Debug.Log("PlaceHolder Shuffle");
                    break;
                default:
                    return;
            }
        }

        private static void FisherYatesShuffle<T>(ref IList<T> list)
        {
            int count = list.Count;

            for (int i = 0; i < (count - 1); i++)
            {
                int index = i + new Random().Next(count - i);
                T element = list[index];
                list[index] = list[i];
                list[i] = element;
            }
        }
    }
}
