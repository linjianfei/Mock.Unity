namespace UnityEngine
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    public sealed class LensFlare : Behaviour
    {
        
        private extern void INTERNAL_get_color(out Color value);
        
        private extern void INTERNAL_set_color(ref Color value);

        public float brightness {  get;  set; }

        public Color color
        {
            get
            {
                Color color;
                this.INTERNAL_get_color(out color);
                return color;
            }
            set
            {
                this.INTERNAL_set_color(ref value);
            }
        }

        public float fadeSpeed {  get;  set; }

        public Flare flare {  get;  set; }
    }
}

