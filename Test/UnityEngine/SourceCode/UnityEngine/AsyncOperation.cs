namespace UnityEngine
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential)]
    public class AsyncOperation : YieldInstruction
    {
        internal IntPtr m_Ptr;
        
        private extern void InternalDestroy();
        ~AsyncOperation()
        {
            this.InternalDestroy();
        }

        public bool isDone {  get; }
        public float progress {  get; }
        public int priority {  get;  set; }
        public bool allowSceneActivation {  get;  set; }
    }
}

