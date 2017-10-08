namespace UnityEngine
{
    using System;
    using System.Runtime.CompilerServices;

    public sealed class Ping
    {
        private IntPtr pingWrapper;

        
        public extern Ping(string address);
        
        public extern void DestroyPing();
        ~Ping()
        {
            this.DestroyPing();
        }

        public string ip {  get; }

        public bool isDone {  get; }

        public int time {  get; }
    }
}

