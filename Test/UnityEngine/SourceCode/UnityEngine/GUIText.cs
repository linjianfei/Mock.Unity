namespace UnityEngine
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    public sealed class GUIText : GUIElement
    {
        
        private static extern void INTERNAL_CALL_Internal_SetPixelOffset(GUIText self, ref Vector2 p);
        
        private extern void INTERNAL_get_color(out Color value);
        
        private extern void Internal_GetPixelOffset(out Vector2 output);
        
        private extern void INTERNAL_set_color(ref Color value);
        private void Internal_SetPixelOffset(Vector2 p)
        {
            INTERNAL_CALL_Internal_SetPixelOffset(this, ref p);
        }

        public TextAlignment alignment {  get;  set; }

        public TextAnchor anchor {  get;  set; }

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

        public Font font {  get;  set; }

        public int fontSize {  get;  set; }

        public FontStyle fontStyle {  get;  set; }

        public float lineSpacing {  get;  set; }

        public Material material {  get;  set; }

        public Vector2 pixelOffset
        {
            get
            {
                Vector2 vector;
                this.Internal_GetPixelOffset(out vector);
                return vector;
            }
            set
            {
                this.Internal_SetPixelOffset(value);
            }
        }

        public bool richText {  get;  set; }

        public float tabSize {  get;  set; }

        public string text {  get;  set; }
    }
}

