namespace UnityEngine
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    public sealed class CapsuleCollider : Collider
    {
        
        private extern void INTERNAL_get_center(out Vector3 value);
        
        private extern void INTERNAL_set_center(ref Vector3 value);

        public Vector3 center
        {
            get
            {
                Vector3 vector;
                this.INTERNAL_get_center(out vector);
                return vector;
            }
            set
            {
                this.INTERNAL_set_center(ref value);
            }
        }

        public int direction {  get;  set; }

        public float height {  get;  set; }

        public float radius {  get;  set; }
    }
}

