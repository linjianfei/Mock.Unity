namespace UnityEngine
{
    using System;
    using System.Runtime.CompilerServices;

    public sealed class AudioEchoFilter : Behaviour
    {
        public float decayRatio {  get;  set; }

        public float delay {  get;  set; }

        public float dryMix {  get;  set; }

        public float wetMix {  get;  set; }
    }
}

