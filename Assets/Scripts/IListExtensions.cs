using System.Collections.Generic;
using Random = System.Random;

namespace PerigonGames
{
    public static class IListExtensions
    {
        /*
            Method Signature: public bool isNullOrEmpty(IList<T>) 
            Explanation of what it does: returns true if List/Array is either null or empty (similiar to string.isNullOrEmpty()
            Category: List/Array
            Sample Input: null
            Expected Output: true
         */
        public static bool IsNullOrEmpty<T>(this IList<T> list)
        {
            return list == null || list.Count == 0;
        }
        
        /*
            Method Signature: public void ShuffleFisherYates(this IList<T>, int) 
            Explanation of what it does: Shuffles elements in list in Fisher-Yates style randomly with given seed if provided
            Category: List/Array
            Sample Input: [1,2,3]
            Expected Output: [3,1,2]
         */
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

