namespace UnityEngine
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using UnityEngine.Rendering;

    public sealed class LightProbes : Object
    {
            

        public SphericalHarmonicsL2[] bakedProbes {  get;  set; }

        public int cellCount {  get; }

        [Obsolete("coefficients property has been deprecated. Please use bakedProbes instead.", true)]
        public float[] coefficients
        {
            get
            {
                return new float[0];
            }
            set
            {
            }
        }

        public int count {  get; }

        public Vector3[] positions {  get; }
    }
}

