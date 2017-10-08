namespace UnityEngine
{
    using System;
    using System.Runtime.CompilerServices;
    using UnityEngine.Internal;

    public sealed class PolygonCollider2D : Collider2D
    {
        [ExcludeFromDocs]
        public void CreatePrimitive(int sides)
        {
            Vector2 zero = Vector2.zero;
            Vector2 one = Vector2.one;
            INTERNAL_CALL_CreatePrimitive(this, sides, ref one, ref zero);
        }

        [ExcludeFromDocs]
        public void CreatePrimitive(int sides, Vector2 scale)
        {
            Vector2 zero = Vector2.zero;
            INTERNAL_CALL_CreatePrimitive(this, sides, ref scale, ref zero);
        }

        public void CreatePrimitive(int sides, [DefaultValue("Vector2.one")] Vector2 scale, [DefaultValue("Vector2.zero")] Vector2 offset)
        {
            INTERNAL_CALL_CreatePrimitive(this, sides, ref scale, ref offset);
        }

        
        public extern Vector2[] GetPath(int index);
        
        public extern int GetTotalPointCount();
        
        private static extern void INTERNAL_CALL_CreatePrimitive(PolygonCollider2D self, int sides, ref Vector2 scale, ref Vector2 offset);
        
        public extern void SetPath(int index, Vector2[] points);

        public int pathCount {  get;  set; }

        public Vector2[] points {  get;  set; }
    }
}

