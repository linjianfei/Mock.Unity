namespace UnityEngine
{
    using System;
    using System.Runtime.CompilerServices;

    public sealed class AreaEffector2D : Effector2D
    {
        public float angularDrag {  get;  set; }

        public float drag {  get;  set; }

        public float forceAngle {  get;  set; }

        [Obsolete("AreaEffector2D.forceDirection has been deprecated. Use AreaEffector2D.forceAngle instead (UnityUpgradable) -> forceAngle", true)]
        public float forceDirection
        {
            get
            {
                return this.forceAngle;
            }
            set
            {
                this.forceAngle = value;
            }
        }

        public float forceMagnitude {  get;  set; }

        public EffectorSelection2D forceTarget {  get;  set; }

        public float forceVariation {  get;  set; }

        public bool useGlobalAngle {  get;  set; }
    }
}

