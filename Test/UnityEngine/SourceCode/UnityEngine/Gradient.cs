namespace UnityEngine
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential)]
    public sealed class Gradient
    {
        internal IntPtr m_Ptr;
        public Gradient()
        {
            this.Init();
        }

        
        private extern void Init();
        
        private extern void Cleanup();
        ~Gradient()
        {
            this.Cleanup();
        }

        
        public extern Color Evaluate(float time);
        public GradientColorKey[] colorKeys {  get;  set; }
        public GradientAlphaKey[] alphaKeys {  get;  set; }
        internal Color constantColor
        {
            get
            {
                Color color;
                this.INTERNAL_get_constantColor(out color);
                return color;
            }
            set
            {
                this.INTERNAL_set_constantColor(ref value);
            }
        }
        
        private extern void INTERNAL_get_constantColor(out Color value);
        
        private extern void INTERNAL_set_constantColor(ref Color value);
        
        public extern void SetKeys(GradientColorKey[] colorKeys, GradientAlphaKey[] alphaKeys);
    }
}

