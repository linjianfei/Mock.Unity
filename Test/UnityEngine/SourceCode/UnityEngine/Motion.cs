namespace UnityEngine
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    public class Motion : Object
    {
        
        private extern void INTERNAL_get_averageSpeed(out Vector3 value);
        
        public extern bool ValidateIfRetargetable(bool val);

        public float apparentSpeed {  get; }

        public float averageAngularSpeed {  get; }

        public float averageDuration {  get; }

        public Vector3 averageSpeed
        {
            get
            {
                Vector3 vector;
                this.INTERNAL_get_averageSpeed(out vector);
                return vector;
            }
        }

        [Obsolete("isAnimatorMotion is not supported anymore. Use !legacy instead.", true)]
        public bool isAnimatorMotion {  get; }

        public bool isHumanMotion {  get; }

        public bool isLooping {  get; }

        public bool legacy {  get; }
    }
}

