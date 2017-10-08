namespace UnityEngine
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential)]
    public sealed class Coroutine : YieldInstruction
    {
        internal IntPtr m_Ptr;
        private Coroutine()
        {
        }

        
        private extern void ReleaseCoroutine();
        ~Coroutine()
        {
            this.ReleaseCoroutine();
        }
    }
}

