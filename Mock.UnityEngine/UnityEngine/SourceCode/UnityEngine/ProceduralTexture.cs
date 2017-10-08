namespace UnityEngine
{
    using System;
    using System.Runtime.CompilerServices;

    public sealed class ProceduralTexture : Texture
    {
        
        public extern Color32[] GetPixels32(int x, int y, int blockWidth, int blockHeight);
        
        
        public extern ProceduralOutputType GetProceduralOutputType();
        
        internal extern bool HasBeenGenerated();

        public TextureFormat format {  get; }

        public bool hasAlpha {  get; }
    }
}

