namespace UnityEngine
{
    using System;
    using System.Runtime.CompilerServices;

    public sealed class MeshFilter : Component
    {
        public Mesh mesh {  get;  set; }

        public Mesh sharedMesh {  get;  set; }
    }
}

