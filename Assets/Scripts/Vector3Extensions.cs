using UnityEngine;

namespace PerigonGames
{
    public static class Vector3Extensions
    {
        /*
        Explanation of what it does: resets vector
        Category: Vector3
        Sample Input: object.Transform.position
        Expected Output: vector reset to Vector3.zero
        */
        public static void ResetToZero(this ref Vector3 v)
        {
            v = Vector3.zero;
        }
    }
}
