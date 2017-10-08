namespace UnityEngine
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    public class Joint : Component
    {
        
        private extern void INTERNAL_get_anchor(out Vector3 value);
        
        private extern void INTERNAL_get_axis(out Vector3 value);
        
        private extern void INTERNAL_get_connectedAnchor(out Vector3 value);
        
        private extern void INTERNAL_set_anchor(ref Vector3 value);
        
        private extern void INTERNAL_set_axis(ref Vector3 value);
        
        private extern void INTERNAL_set_connectedAnchor(ref Vector3 value);

        public Vector3 anchor
        {
            get
            {
                Vector3 vector;
                this.INTERNAL_get_anchor(out vector);
                return vector;
            }
            set
            {
                this.INTERNAL_set_anchor(ref value);
            }
        }

        public bool autoConfigureConnectedAnchor {  get;  set; }

        public Vector3 axis
        {
            get
            {
                Vector3 vector;
                this.INTERNAL_get_axis(out vector);
                return vector;
            }
            set
            {
                this.INTERNAL_set_axis(ref value);
            }
        }

        public float breakForce {  get;  set; }

        public float breakTorque {  get;  set; }

        public Vector3 connectedAnchor
        {
            get
            {
                Vector3 vector;
                this.INTERNAL_get_connectedAnchor(out vector);
                return vector;
            }
            set
            {
                this.INTERNAL_set_connectedAnchor(ref value);
            }
        }


        public bool enableCollision {  get;  set; }

        public bool enablePreprocessing {  get;  set; }
    }
}

