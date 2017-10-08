namespace UnityEngine
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    public sealed class OcclusionArea : Component
    {
        
        private extern void INTERNAL_get_center(out Vector3 value);
        
        private extern void INTERNAL_get_size(out Vector3 value);
        
        private extern void INTERNAL_set_center(ref Vector3 value);
        
        private extern void INTERNAL_set_size(ref Vector3 value);

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

        public Vector3 size
        {
            get
            {
                Vector3 vector;
                this.INTERNAL_get_size(out vector);
                return vector;
            }
            set
            {
                this.INTERNAL_set_size(ref value);
            }
        }
    }
}

