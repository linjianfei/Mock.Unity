namespace UnityEngine
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    public sealed class Compass
    {
        
        private extern void INTERNAL_get_rawVector(out Vector3 value);

        public bool enabled {  get;  set; }

        public float headingAccuracy {  get; }

        public float magneticHeading {  get; }

        public Vector3 rawVector
        {
            get
            {
                Vector3 vector;
                this.INTERNAL_get_rawVector(out vector);
                return vector;
            }
        }

        public double timestamp {  get; }

        public float trueHeading {  get; }
    }
}

