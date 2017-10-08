namespace UnityEngine
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    public class Texture : Object
    {
        
        public extern int GetNativeTextureID();
        
        public extern IntPtr GetNativeTexturePtr();
        
        private extern void INTERNAL_get_texelSize(out Vector2 value);
        
        private static extern int Internal_GetHeight(Texture mono);
        
        private static extern int Internal_GetWidth(Texture mono);
        
        public static extern void SetGlobalAnisotropicFilteringLimits(int forcedMin, int globalMax);

        public int anisoLevel {  get;  set; }

        public static AnisotropicFiltering anisotropicFiltering {  get;  set; }

        public FilterMode filterMode {  get;  set; }

        public virtual int height
        {
            get
            {
                return Internal_GetHeight(this);
            }
            set
            {
                throw new Exception("not implemented");
            }
        }

        public static int masterTextureLimit {  get;  set; }

        public float mipMapBias {  get;  set; }

        public Vector2 texelSize
        {
            get
            {
                Vector2 vector;
                this.INTERNAL_get_texelSize(out vector);
                return vector;
            }
        }

        public virtual int width
        {
            get
            {
                return Internal_GetWidth(this);
            }
            set
            {
                throw new Exception("not implemented");
            }
        }

        public TextureWrapMode wrapMode {  get;  set; }
    }
}

