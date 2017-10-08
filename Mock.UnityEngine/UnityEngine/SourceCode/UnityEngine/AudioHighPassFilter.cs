namespace UnityEngine
{
    using System;
    using System.Runtime.CompilerServices;

    public sealed class AudioHighPassFilter : Behaviour
    {
        public float cutoffFrequency {  get;  set; }

        public float highpassResonaceQ
        {
            get
            {
                return this.highpassResonanceQ;
            }
            set
            {
            }
        }

        public float highpassResonanceQ {  get;  set; }
    }
}

