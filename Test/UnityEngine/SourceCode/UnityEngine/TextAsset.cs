namespace UnityEngine
{
    using System;
    using System.Runtime.CompilerServices;

    public class TextAsset : Object
    {
        public override string ToString()
        {
            return this.text;
        }

        public byte[] bytes {  get; }

        public string text {  get; }
    }
}

