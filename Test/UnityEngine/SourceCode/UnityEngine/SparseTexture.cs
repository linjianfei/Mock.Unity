namespace UnityEngine
{
    using System;
    using System.Runtime.CompilerServices;

    public sealed class SparseTexture : Texture
    {
        public SparseTexture(int width, int height, TextureFormat format, int mipCount)
        {
            Internal_Create(this, width, height, format, mipCount, false);
        }

        public SparseTexture(int width, int height, TextureFormat format, int mipCount, bool linear)
        {
            Internal_Create(this, width, height, format, mipCount, linear);
        }

        
        private static extern void Internal_Create([Writable] SparseTexture mono, int width, int height, TextureFormat format, int mipCount, bool linear);
        
        public extern void UnloadTile(int tileX, int tileY, int miplevel);
        
        public extern void UpdateTile(int tileX, int tileY, int miplevel, Color32[] data);
        
        public extern void UpdateTileRaw(int tileX, int tileY, int miplevel, byte[] data);

        public bool isCreated {  get; }

        public int tileHeight {  get; }

        public int tileWidth {  get; }
    }
}

