namespace UnityEngine
{
    using System;
    using System.Runtime.CompilerServices;

    public sealed class Tree : Component
    {
        public ScriptableObject data {  get;  set; }

        public bool hasSpeedTreeWind {  get; }
    }
}

