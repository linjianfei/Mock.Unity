﻿namespace UnityEngine
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using UnityEngine.Internal;

    public sealed class Sprite : Object
    {
        [ExcludeFromDocs]
        public static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot)
        {
            Vector4 zero = Vector4.zero;
            SpriteMeshType tight = SpriteMeshType.Tight;
            uint extrude = 0;
            float pixelsPerUnit = 100f;
            return INTERNAL_CALL_Create(texture, ref rect, ref pivot, pixelsPerUnit, extrude, tight, ref zero);
        }

        [ExcludeFromDocs]
        public static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit)
        {
            Vector4 zero = Vector4.zero;
            SpriteMeshType tight = SpriteMeshType.Tight;
            uint extrude = 0;
            return INTERNAL_CALL_Create(texture, ref rect, ref pivot, pixelsPerUnit, extrude, tight, ref zero);
        }

        [ExcludeFromDocs]
        public static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit, uint extrude)
        {
            Vector4 zero = Vector4.zero;
            SpriteMeshType tight = SpriteMeshType.Tight;
            return INTERNAL_CALL_Create(texture, ref rect, ref pivot, pixelsPerUnit, extrude, tight, ref zero);
        }

        [ExcludeFromDocs]
        public static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit, uint extrude, SpriteMeshType meshType)
        {
            Vector4 zero = Vector4.zero;
            return INTERNAL_CALL_Create(texture, ref rect, ref pivot, pixelsPerUnit, extrude, meshType, ref zero);
        }

        public static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot, [DefaultValue("100.0f")] float pixelsPerUnit, [DefaultValue("0")] uint extrude, [DefaultValue("SpriteMeshType.Tight")] SpriteMeshType meshType, [DefaultValue("Vector4.zero")] Vector4 border)
        {
            return INTERNAL_CALL_Create(texture, ref rect, ref pivot, pixelsPerUnit, extrude, meshType, ref border);
        }

        
        private static extern Sprite INTERNAL_CALL_Create(Texture2D texture, ref Rect rect, ref Vector2 pivot, float pixelsPerUnit, uint extrude, SpriteMeshType meshType, ref Vector4 border);
        
        private extern void INTERNAL_get_border(out Vector4 value);
        
        private extern void INTERNAL_get_bounds(out Bounds value);
        
        private extern void INTERNAL_get_rect(out Rect value);
        
        private extern void INTERNAL_get_textureRect(out Rect value);
        
        private static extern void Internal_GetPivot(Sprite sprite, out Vector2 output);
        
        private static extern void Internal_GetTextureRectOffset(Sprite sprite, out Vector2 output);
        
        public extern void OverrideGeometry(Vector2[] vertices, ushort[] triangles);

        public Texture2D associatedAlphaSplitTexture {  get; }

        public Vector4 border
        {
            get
            {
                Vector4 vector;
                this.INTERNAL_get_border(out vector);
                return vector;
            }
        }

        public Bounds bounds
        {
            get
            {
                Bounds bounds;
                this.INTERNAL_get_bounds(out bounds);
                return bounds;
            }
        }

        public bool packed {  get; }

        public SpritePackingMode packingMode {  get; }

        public SpritePackingRotation packingRotation {  get; }

        public Vector2 pivot
        {
            get
            {
                Vector2 vector;
                Internal_GetPivot(this, out vector);
                return vector;
            }
        }

        public float pixelsPerUnit {  get; }

        public Rect rect
        {
            get
            {
                Rect rect;
                this.INTERNAL_get_rect(out rect);
                return rect;
            }
        }

        public Texture2D texture {  get; }

        public Rect textureRect
        {
            get
            {
                Rect rect;
                this.INTERNAL_get_textureRect(out rect);
                return rect;
            }
        }

        public Vector2 textureRectOffset
        {
            get
            {
                Vector2 vector;
                Internal_GetTextureRectOffset(this, out vector);
                return vector;
            }
        }

        public ushort[] triangles {  get; }

        public Vector2[] uv {  get; }

        public Vector2[] vertices {  get; }
    }
}

