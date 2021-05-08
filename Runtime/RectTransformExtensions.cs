using UnityEngine;

namespace PerigonGames
{
    public static class RectTransformExtensions
    {
        public static void SetLeft(this RectTransform rt, float left)
        {
            rt.offsetMin = new Vector2(left, rt.offsetMin.y);
        }
 
        public static void SetRight(this RectTransform rt, float right)
        {
            rt.offsetMax = new Vector2(-right, rt.offsetMax.y);
        }
 
        public static void SetTop(this RectTransform rt, float top)
        {
            rt.offsetMax = new Vector2(rt.offsetMax.x, -top);
        }
 
        public static void SetBottom(this RectTransform rt, float bottom)
        {
            rt.offsetMin = new Vector2(rt.offsetMin.x, bottom);
        }

        public static void SetMinXAnchor(this RectTransform rt, float anchor)
        {
            rt.anchorMin = new Vector2(anchor, rt.anchorMin.y);
        }
        
        public static void SetMaxXAnchor(this RectTransform rt, float anchor)
        {
            rt.anchorMax = new Vector2(anchor, rt.anchorMax.y);
        }
        
        public static void SetMinYAnchor(this RectTransform rt, float anchor)
        {
            rt.anchorMin = new Vector2(rt.anchorMin.x, anchor);
        }
        
        public static void SetMaxYAnchor(this RectTransform rt, float anchor)
        {
            rt.anchorMax = new Vector2(rt.anchorMax.x, anchor);
        }
    }
}