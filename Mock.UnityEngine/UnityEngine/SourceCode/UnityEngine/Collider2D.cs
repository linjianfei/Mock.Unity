namespace UnityEngine
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using UnityEngine.Internal;

    public class Collider2D : Behaviour
    {
        
        private static extern bool INTERNAL_CALL_OverlapPoint(Collider2D self, ref Vector2 point);
        
        private extern void INTERNAL_get_bounds(out Bounds value);
        
        private extern void INTERNAL_get_offset(out Vector2 value);
        
        private extern void INTERNAL_set_offset(ref Vector2 value);
        
        public extern bool IsTouching(Collider2D collider);
        [ExcludeFromDocs]
        public bool IsTouchingLayers()
        {
            int layerMask = -1;
            return this.IsTouchingLayers(layerMask);
        }

        
        public extern bool IsTouchingLayers([DefaultValue("Physics2D.AllLayers")] int layerMask);
        public bool OverlapPoint(Vector2 point)
        {
            return INTERNAL_CALL_OverlapPoint(this, ref point);
        }


        public Bounds bounds
        {
            get
            {
                Bounds bounds;
                this.INTERNAL_get_bounds(out bounds);
                return bounds;
            }
        }

        internal ColliderErrorState2D errorState {  get; }

        public bool isTrigger {  get;  set; }

        public Vector2 offset
        {
            get
            {
                Vector2 vector;
                this.INTERNAL_get_offset(out vector);
                return vector;
            }
            set
            {
                this.INTERNAL_set_offset(ref value);
            }
        }

        public int shapeCount {  get; }


        public bool usedByEffector {  get;  set; }
    }
}

