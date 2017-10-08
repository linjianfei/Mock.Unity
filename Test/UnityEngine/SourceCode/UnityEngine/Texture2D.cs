namespace UnityEngine
{
    using System;
    using System.Runtime.CompilerServices;
    using UnityEngine.Internal;

    public sealed class Texture2D : Texture
    {
        public Texture2D(int width, int height)
        {
        }

        public Texture2D(int width, int height, TextureFormat format, bool mipmap)
        {
        }

        public Texture2D(int width, int height, TextureFormat format, bool mipmap, bool linear)
        {
        }

        internal Texture2D(int width, int height, TextureFormat format, bool mipmap, bool linear, IntPtr nativeTex)
        {
        }

        [ExcludeFromDocs]
        public void Apply()
        {
            bool makeNoLongerReadable = false;
            bool updateMipmaps = true;
            this.Apply(updateMipmaps, makeNoLongerReadable);
        }

        [ExcludeFromDocs]
        public void Apply(bool updateMipmaps)
        {
            bool makeNoLongerReadable = false;
            this.Apply(updateMipmaps, makeNoLongerReadable);
        }


        public  void Apply([DefaultValue("true")] bool updateMipmaps,
            [DefaultValue("false")] bool makeNoLongerReadable)
        {
            
        }
        public void Compress(bool highQuality)
        {
        }

        public static Texture2D CreateExternalTexture(int width, int height, TextureFormat format, bool mipmap, bool linear, IntPtr nativeTex)
        {
            return new Texture2D(width, height, format, mipmap, linear, nativeTex);
        }

        public byte[] EncodeToJPG()
        {
            return this.EncodeToJPG(0x4b);
        }


        public  byte[] EncodeToJPG(int quality)
        {
            return null;
        }

        public  byte[] EncodeToPNG()
        {
            return null;
        }

        public  Color GetPixel(int x, int y)
        {
            return Color.black;
            
        }

        public  Color GetPixelBilinear(float u, float v)
        {
            return Color.black;
            
        }
        [ExcludeFromDocs]
        public Color[] GetPixels()
        {
            int miplevel = 0;
            return this.GetPixels(miplevel);
        }

        public Color[] GetPixels([DefaultValue("0")] int miplevel)
        {
            int blockWidth = this.width >> miplevel;
            if (blockWidth < 1)
            {
                blockWidth = 1;
            }
            int blockHeight = this.height >> miplevel;
            if (blockHeight < 1)
            {
                blockHeight = 1;
            }
            return this.GetPixels(0, 0, blockWidth, blockHeight, miplevel);
        }

        [ExcludeFromDocs]
        public Color[] GetPixels(int x, int y, int blockWidth, int blockHeight)
        {
            int miplevel = 0;
            return this.GetPixels(x, y, blockWidth, blockHeight, miplevel);
        }


        public  Color[] GetPixels(int x, int y, int blockWidth, int blockHeight, [DefaultValue("0")] int miplevel)
        {
            return null;
        }
        [ExcludeFromDocs]
        public Color32[] GetPixels32()
        {
            int miplevel = 0;
            return this.GetPixels32(miplevel);
        }

        
        public extern Color32[] GetPixels32([DefaultValue("0")] int miplevel);
        
     
        [ExcludeFromDocs]
        public Rect[] PackTextures(Texture2D[] textures, int padding)
        {
            return null;
        }

        [ExcludeFromDocs]
        public Rect[] PackTextures(Texture2D[] textures, int padding, int maximumAtlasSize)
        {
            return null;
        }


        [ExcludeFromDocs]
        public void ReadPixels(Rect source, int destX, int destY)
        {
            bool recalculateMipMaps = true;
        }

        public void ReadPixels(Rect source, int destX, int destY, [DefaultValue("true")] bool recalculateMipMaps)
        {
        }

        public bool Resize(int width, int height)
        {
            return true;
        }

        
        public void SetPixel(int x, int y, Color color)
        {
        }

        [ExcludeFromDocs]
        public void SetPixels(Color[] colors)
        {
            int miplevel = 0;
            this.SetPixels(colors, miplevel);
        }

        public void SetPixels(Color[] colors, [DefaultValue("0")] int miplevel)
        {
            int blockWidth = this.width >> miplevel;
            if (blockWidth < 1)
            {
                blockWidth = 1;
            }
            int blockHeight = this.height >> miplevel;
            if (blockHeight < 1)
            {
                blockHeight = 1;
            }
        }

        [ExcludeFromDocs]
        public void SetPixels(int x, int y, int blockWidth, int blockHeight, Color[] colors)
        {
            int miplevel = 0;
        }

        
        [ExcludeFromDocs]
        public void SetPixels32(Color32[] colors)
        {
            int miplevel = 0;
            this.SetPixels32(colors, miplevel);
        }

        public void SetPixels32(Color32[] colors, [DefaultValue("0")] int miplevel)
        {
        }

        [ExcludeFromDocs]
        public void SetPixels32(int x, int y, int blockWidth, int blockHeight, Color32[] colors)
        {
            int miplevel = 0;
            this.SetPixels32(x, y, blockWidth, blockHeight, colors, miplevel);
        }

        public void SetPixels32(int x, int y, int blockWidth, int blockHeight, Color32[] colors, [DefaultValue("0")] int miplevel)
        {
        }

        

        public bool alphaIsTransparency {  get;  set; }

        public static Texture2D blackTexture {  get; }

        public TextureFormat format {  get; }

        public int mipmapCount {  get; }

        public static Texture2D whiteTexture {  get; }
    }
}

