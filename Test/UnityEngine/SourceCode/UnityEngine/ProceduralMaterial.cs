//namespace UnityEngine
//{
//    using System;
//    using System.Runtime.CompilerServices;
//
//    public sealed class ProceduralMaterial : Material
//    {
//        internal ProceduralMaterial() : base((Material) null)
//        {
//        }
//
//        
//        public extern void CacheProceduralProperty(string inputName, bool value);
//        
//        public extern void ClearCache();
//        
//        public extern ProceduralTexture GetGeneratedTexture(string textureName);
//        
//        public extern Texture[] GetGeneratedTextures();
//        
//        public extern bool GetProceduralBoolean(string inputName);
//        
//        public extern Color GetProceduralColor(string inputName);
//        
//        public extern int GetProceduralEnum(string inputName);
//        
//        public extern float GetProceduralFloat(string inputName);
//        
//        public extern ProceduralPropertyDescription[] GetProceduralPropertyDescriptions();
//        
//        public extern Texture2D GetProceduralTexture(string inputName);
//        
//        public extern Vector4 GetProceduralVector(string inputName);
//        
//        public extern bool HasProceduralProperty(string inputName);
//        
//        private static extern void INTERNAL_CALL_SetProceduralColor(ProceduralMaterial self, string inputName, ref Color value);
//        
//        private static extern void INTERNAL_CALL_SetProceduralVector(ProceduralMaterial self, string inputName, ref Vector4 value);
//        
//        public extern bool IsProceduralPropertyCached(string inputName);
//        
//        public extern bool IsProceduralPropertyVisible(string inputName);
//        
//        public extern void RebuildTextures();
//        
//        public extern void RebuildTexturesImmediately();
//        
//        public extern void SetProceduralBoolean(string inputName, bool value);
//        public void SetProceduralColor(string inputName, Color value)
//        {
//            INTERNAL_CALL_SetProceduralColor(this, inputName, ref value);
//        }
//
//        
//        public extern void SetProceduralEnum(string inputName, int value);
//        
//        public extern void SetProceduralFloat(string inputName, float value);
//        
//        public extern void SetProceduralTexture(string inputName, Texture2D value);
//        public void SetProceduralVector(string inputName, Vector4 value)
//        {
//            INTERNAL_CALL_SetProceduralVector(this, inputName, ref value);
//        }
//
//        
//        public static extern void StopRebuilds();
//
//        public int animationUpdateRate {  get;  set; }
//
//        public ProceduralCacheSize cacheSize {  get;  set; }
//
//        public bool isCachedDataAvailable {  get; }
//
//        public bool isLoadTimeGenerated {  get;  set; }
//
//        public bool isProcessing {  get; }
//
//        public bool isReadable {  get;  set; }
//
//        public static bool isSupported {  get; }
//
//        public ProceduralLoadingBehavior loadingBehavior {  get; }
//
//        public string preset {  get;  set; }
//
//        public static ProceduralProcessorUsage substanceProcessorUsage {  get;  set; }
//    }
//}
//
