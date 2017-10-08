namespace UnityEngine
{
    using System;
    using System.Runtime.CompilerServices;

    public sealed class EdgeCollider2D : Collider2D
    {
        
        public extern void Reset();

        public int edgeCount {  get; }

        public int pointCount {  get; }

        public Vector2[] points {  get;  set; }
    }
}

