namespace UnityEngine
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    public sealed class TextMesh : Component
    {
        
        private extern void INTERNAL_get_color(out Color value);
        
        private extern void INTERNAL_set_color(ref Color value);

        public TextAlignment alignment {  get;  set; }

        public TextAnchor anchor {  get;  set; }

        public float characterSize {  get;  set; }

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

        public float offsetZ {  get;  set; }

        public bool richText {  get;  set; }

        public float tabSize {  get;  set; }

        public string text {  get;  set; }
    }
}

