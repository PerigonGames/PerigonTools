using System.Collections;
using System.Collections.Generic;

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
    }
}

