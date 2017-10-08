namespace UnityEngine
{
    using System;
    using System.Runtime.CompilerServices;

    public sealed class SpringJoint : Joint
    {
        public float damper {  get;  set; }

        public float maxDistance {  get;  set; }

        public float minDistance {  get;  set; }

        public float spring {  get;  set; }

        public float tolerance {  get;  set; }
    }
}

