namespace UnityEngine
{
    using System;
    using System.Runtime.CompilerServices;

    public sealed class SurfaceEffector2D : Effector2D
    {
        public float forceScale {  get;  set; }

        public float speed {  get;  set; }

        public float speedVariation {  get;  set; }

        public bool useBounce {  get;  set; }

        public bool useContactForce {  get;  set; }

        public bool useFriction {  get;  set; }
    }
}

