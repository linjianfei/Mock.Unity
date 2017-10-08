namespace UnityEngine
{
    using System;
    using System.Runtime.CompilerServices;
    using UnityEngine.Internal;

    public sealed class Texture3D : Texture
    {
        public Texture3D(int width, int height, int depth, TextureFormat format, bool mipmap)
        {
        }

        [ExcludeFromDocs]
        public void Apply()
        {
            bool updateMipmaps = true;
            this.Apply(updateMipmaps);
        }


        public  void Apply([DefaultValue("true")] bool updateMipmaps)
        {
            
        }
        [ExcludeFromDocs]
        public Color[] GetPixels()
        {
            int miplevel = 0;
            return this.GetPixels(miplevel);
        }


        public  Color[] GetPixels([DefaultValue("0")] int miplevel)
        {
            return null;
        }
        [ExcludeFromDocs]
        public Color32[] GetPixels32()
        {
            int miplevel = 0;
            return this.GetPixels32(miplevel);
        }


        public  Color32[] GetPixels32([DefaultValue("0")] int miplevel)
        {
            return null;
        }
        
        [ExcludeFromDocs]
        public void SetPixels(Color[] colors)
        {
            int miplevel = 0;
            this.SetPixels(colors, miplevel);
        }


        public  void SetPixels(Color[] colors, [DefaultValue("0")] int miplevel)
        {
            
        }
        [ExcludeFromDocs]
        public void SetPixels32(Color32[] colors)
        {
            int miplevel = 0;
            this.SetPixels32(colors, miplevel);
        }


        public  void SetPixels32(Color32[] colors, [DefaultValue("0")] int miplevel)
        {
            
        }

        public int depth {  get; }

        public TextureFormat format {  get; }
    }
}

