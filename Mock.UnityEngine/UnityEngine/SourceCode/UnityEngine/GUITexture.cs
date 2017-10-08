namespace UnityEngine
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    public sealed class GUITexture : GUIElement
    {
        
        private extern void INTERNAL_get_color(out Color value);
        
        private extern void INTERNAL_get_pixelInset(out Rect value);
        
        private extern void INTERNAL_set_color(ref Color value);
        
        private extern void INTERNAL_set_pixelInset(ref Rect value);

        public RectOffset border {  get;  set; }

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

        public Rect pixelInset
        {
            get
            {
                Rect rect;
                this.INTERNAL_get_pixelInset(out rect);
                return rect;
            }
            set
            {
                this.INTERNAL_set_pixelInset(ref value);
            }
        }

        public Texture texture {  get;  set; }
    }
}

