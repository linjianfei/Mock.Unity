namespace UnityEngine
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    public class Collider : Component
    {
        public Vector3 ClosestPointOnBounds(Vector3 position)
        {
            return INTERNAL_CALL_ClosestPointOnBounds(this, ref position);
        }

        
        private static extern Vector3 INTERNAL_CALL_ClosestPointOnBounds(Collider self, ref Vector3 position);
        
        private static extern bool INTERNAL_CALL_Internal_Raycast(Collider col, ref Ray ray, out RaycastHit hitInfo, float maxDistance);
        
        private extern void INTERNAL_get_bounds(out Bounds value);
        private static bool Internal_Raycast(Collider col, Ray ray, out RaycastHit hitInfo, float maxDistance)
        {
            return INTERNAL_CALL_Internal_Raycast(col, ref ray, out hitInfo, maxDistance);
        }

        public bool Raycast(Ray ray, out RaycastHit hitInfo, float maxDistance)
        {
            return Internal_Raycast(this, ray, out hitInfo, maxDistance);
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

        public float contactOffset {  get;  set; }

        public bool enabled {  get;  set; }

        public bool isTrigger {  get;  set; }

    }
}

