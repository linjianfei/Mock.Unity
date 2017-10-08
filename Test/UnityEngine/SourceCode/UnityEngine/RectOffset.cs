namespace UnityEngine
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    [Serializable, StructLayout(LayoutKind.Sequential)]
    public sealed class RectOffset
    {
        [NonSerialized]
        internal IntPtr m_Ptr;
        public RectOffset()
        {
        }

     

        public RectOffset(int left, int right, int top, int bottom)
        {
            this.left = left;
            this.right = right;
            this.top = top;
            this.bottom = bottom;
        }


        public override string ToString()
        {
            object[] args = new object[] { this.left, this.right, this.top, this.bottom };
            return UnityString.Format("RectOffset (l:{0} r:{1} t:{2} b:{3})", args);
        }

        
        public int left {  get;  set; }
        public int right {  get;  set; }
        public int top {  get;  set; }
        public int bottom {  get;  set; }
        public int horizontal {  get; }
        public int vertical {  get; }
        public Rect Add(Rect rect)
        {
            return rect;
        }

        
        public Rect Remove(Rect rect)
        {
            return rect;
        }

        
    }
}

