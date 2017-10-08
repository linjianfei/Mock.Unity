namespace UnityEngine
{
    using System;
    using System.Runtime.CompilerServices;

    public sealed class AudioChorusFilter : Behaviour
    {
        public float delay {  get;  set; }

        public float depth {  get;  set; }

        public float dryMix {  get;  set; }

        [Obsolete("feedback is deprecated, this property does nothing.")]
        public float feedback {  get;  set; }

        public float rate {  get;  set; }

        public float wetMix1 {  get;  set; }

        public float wetMix2 {  get;  set; }

        public float wetMix3 {  get;  set; }
    }
}

