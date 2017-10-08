namespace UnityEngine
{
    using System;
    using System.Runtime.CompilerServices;

    public sealed class PointEffector2D : Effector2D
    {
        public float angularDrag {  get;  set; }

        public float distanceScale {  get;  set; }

        public float drag {  get;  set; }

        public float forceMagnitude {  get;  set; }

        public EffectorForceMode2D forceMode {  get;  set; }

        public EffectorSelection2D forceSource {  get;  set; }

        public EffectorSelection2D forceTarget {  get;  set; }

        public float forceVariation {  get;  set; }
    }
}

