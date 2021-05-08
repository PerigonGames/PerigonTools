using UnityEngine;

namespace PerigonGames
{
    public static class TransformExtensions
    {
        /// <summary>
        /// Resets Position to (0, 0, 0)
        /// </summary>
        /// <param name="t">transform</param>
        public static void ResetPosition(this Transform t)
        {
            t.position = Vector3.zero;
        }

        /// <summary>
        /// Resets local position to (0, 0, 0)
        /// </summary>
        /// <param name="t">transform</param>
        public static void ResetLocalPosition(this Transform t)
        {
            t.localPosition = Vector3.zero;
        }

        /// <summary>
        /// Reset Scale to (0, 0, 0)
        /// </summary>
        /// <param name="t">Transform</param>
        public static void ResetScale(this Transform t)
        {
            t.localScale = Vector3.one;
        }

        /// <summary>
        /// Resets Rotation to (0, 0, 0)
        /// </summary>
        /// <param name="t">Transform</param>
        public static void ResetRotation(this Transform t)
        {
            t.eulerAngles = Vector3.zero;
        }

        /// <summary>
        /// Resets Local Rotation to (0, 0, 0)
        /// </summary>
        /// <param name="t">Transform</param>
        public static void ResetLocalRotation(this Transform t)
        {
            t.localEulerAngles = Vector3.zero;
        }

        /// <summary>
        /// Reset rotation, Position and Scale to (0, 0, 0)
        /// </summary>
        /// <param name="t">Transform</param>
        public static void Reset(this Transform t)
        {
            t.ResetPosition();
            t.ResetScale();
            t.ResetRotation();
        }

        /// <summary>
        /// Resets Local Position, Scale and Rotation to (0, 0, 0)
        /// </summary>
        /// <param name="t">Transform</param>
        public static void ResetLocal(this Transform t)
        {
            t.ResetLocalPosition();
            t.ResetScale();
            t.ResetLocalRotation();
        }
    }
}