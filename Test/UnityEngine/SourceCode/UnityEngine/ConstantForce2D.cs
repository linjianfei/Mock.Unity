namespace UnityEngine
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    public sealed class ConstantForce2D 
    {
        
        private extern void INTERNAL_get_force(out Vector2 value);
        
        private extern void INTERNAL_get_relativeForce(out Vector2 value);
        
        private extern void INTERNAL_set_force(ref Vector2 value);
        
        private extern void INTERNAL_set_relativeForce(ref Vector2 value);

        public Vector2 force
        {
            get
            {
                Vector2 vector;
                this.INTERNAL_get_force(out vector);
                return vector;
            }
            set
            {
                this.INTERNAL_set_force(ref value);
            }
        }

        public Vector2 relativeForce
        {
            get
            {
                Vector2 vector;
                this.INTERNAL_get_relativeForce(out vector);
                return vector;
            }
            set
            {
                this.INTERNAL_set_relativeForce(ref value);
            }
        }

        public float torque {  get;  set; }
    }
}

