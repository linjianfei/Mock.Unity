namespace UnityEngine
{
    using System;
    using System.Runtime.CompilerServices;

    public sealed class OffMeshLink : Component
    {
        
        public extern void UpdatePositions();

        public bool activated {  get;  set; }

        public int area {  get;  set; }

        public bool autoUpdatePositions {  get;  set; }

        public bool biDirectional {  get;  set; }

        public float costOverride {  get;  set; }

        public Transform endTransform {  get;  set; }

        [Obsolete("Use area instead.")]
        public int navMeshLayer {  get;  set; }

        public bool occupied {  get; }

        public Transform startTransform {  get;  set; }
    }
}

