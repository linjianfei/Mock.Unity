namespace UnityEngine
{
    using System;
    using System.Runtime.CompilerServices;

    public class Effector2D : Behaviour
    {
        public int colliderMask {  get;  set; }

        internal bool designedForNonTrigger {  get; }

        internal bool designedForTrigger {  get; }

        internal bool requiresCollider {  get; }

        public bool useColliderMask {  get;  set; }
    }
}

