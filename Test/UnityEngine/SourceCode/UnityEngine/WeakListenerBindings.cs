namespace UnityEngine
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    internal sealed class WeakListenerBindings
    {
        
        public static extern void InvokeCallbacks(object inst, GCHandle gchandle, object[] parameters);
    }
}

