using UnityEngine;

namespace PerigonGames
{
    public static class TransformExtensions
    {
        /*
            Explanation of what it does: resets position
            Category: Transform
            Sample Input: object.Transform
            Expected Output: Position reset to Vector3.zero
         */
        public static void ResetPosition(this Transform t)
        {
            t.position = Vector3.zero;
        }
        
        /*
            Explanation of what it does: resets local positon
            Category: Transform
            Sample Input: object.Transform
            Expected Output: Local position reset to Vector3.zero
         */
        public static void ResetLocalPosition(this Transform t)
        {
            t.localPosition = Vector3.zero;
        }

        /*
            Method Signature: public static void ResetScale (Transform t)
            Explanation of what it does: resets scale 
            Category: Transform (Maybe GameObject?)
            Sample Input: object.Transform
            Expected Output: Scale reset to Vector3.one
         */
        public static void ResetScale(this Transform t)
        {
            t.localScale = Vector3.one;
        }

        /*
            Explanation of what it does: resets Rotation
            Category: Transform
            Sample Input: object.Transform
            Expected Output: Rotation reset to Vector3.zero
         */
        public static void ResetRotation(this Transform t)
        {
            t.eulerAngles = Vector3.zero;
        }
        
        /*
            Explanation of what it does: resets local rotation
            Category: Transform
            Sample Input: object.Transform
            Expected Output: Local rotation reset to Vector3.zero
         */
        public static void ResetLocalRotation(this Transform t)
        {
            t.localEulerAngles = Vector3.zero;
        }

        /*
            Explanation of what it does: resets position, rotation, and scale of a transform
            Category: Transform
            Sample Input: object.Transform
            Expected Output: Rotation, Position, Scale should be reset
         */
        public static void ResetTransform(this Transform t)
        {
            t.ResetPosition();
            t.ResetScale();
            t.ResetRotation();
        }
        
        /*
            Explanation of what it does: resets local position, local rotation, and scale of a transform
            Category: Transform
            Sample Input: object.Transform
            Expected Output: Local rotation, Local position, Scale should be reset
         */
        public static void ResetLocalTransform(this Transform t)
        {
            t.ResetPosition();
            t.ResetScale();
            t.ResetRotation();
        }
    }
}