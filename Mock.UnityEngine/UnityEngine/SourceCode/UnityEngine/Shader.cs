namespace UnityEngine
{
    using System;
    using System.Runtime.CompilerServices;

    public sealed class Shader : Object
    {
        
        public static extern void DisableKeyword(string keyword);
        
        public static extern void EnableKeyword(string keyword);
        
        public static extern Shader Find(string name);
        
        internal static extern Shader FindBuiltin(string name);
        
        private static extern void INTERNAL_CALL_SetGlobalColor(int nameID, ref Color color);
        
        private static extern void INTERNAL_CALL_SetGlobalMatrix(int nameID, ref Matrix4x4 mat);
        
        public static extern bool IsKeywordEnabled(string keyword);
        
        public static extern int PropertyToID(string name);
        
        public static extern void SetGlobalBuffer(string propertyName, ComputeBuffer buffer);
        public static void SetGlobalColor(int nameID, Color color)
        {
            INTERNAL_CALL_SetGlobalColor(nameID, ref color);
        }

        public static void SetGlobalColor(string propertyName, Color color)
        {
            SetGlobalColor(PropertyToID(propertyName), color);
        }

        
        public static extern void SetGlobalFloat(int nameID, float value);
        public static void SetGlobalFloat(string propertyName, float value)
        {
            SetGlobalFloat(PropertyToID(propertyName), value);
        }

        public static void SetGlobalInt(int nameID, int value)
        {
            SetGlobalFloat(nameID, (float) value);
        }

        public static void SetGlobalInt(string propertyName, int value)
        {
            SetGlobalFloat(propertyName, (float) value);
        }

        public static void SetGlobalMatrix(int nameID, Matrix4x4 mat)
        {
            INTERNAL_CALL_SetGlobalMatrix(nameID, ref mat);
        }

        public static void SetGlobalMatrix(string propertyName, Matrix4x4 mat)
        {
            SetGlobalMatrix(PropertyToID(propertyName), mat);
        }

        
        public static extern void SetGlobalTexGenMode(string propertyName, TexGenMode mode);
        
        public static extern void SetGlobalTexture(int nameID, Texture tex);
        public static void SetGlobalTexture(string propertyName, Texture tex)
        {
            SetGlobalTexture(PropertyToID(propertyName), tex);
        }

        
        public static extern void SetGlobalTextureMatrixName(string propertyName, string matrixName);
        public static void SetGlobalVector(int nameID, Vector4 vec)
        {
            SetGlobalColor(nameID, vec);
        }

        public static void SetGlobalVector(string propertyName, Vector4 vec)
        {
            SetGlobalColor(propertyName, vec);
        }

        
        public static extern void WarmupAllShaders();

        internal string customEditor {  get; }

        internal DisableBatchingType disableBatching {  get; }

        public static int globalMaximumLOD {  get;  set; }

        public bool isSupported {  get; }

        public int maximumLOD {  get;  set; }

        public int renderQueue {  get; }
    }
}

