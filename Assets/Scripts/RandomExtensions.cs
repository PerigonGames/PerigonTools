using System;
using System.Collections.Generic;

namespace PerigonGames
{    
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
            element = list[0];
            return false;
        }
    }
}
