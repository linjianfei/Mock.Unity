//namespace UnityEngine
//{
//    using System;
//    using System.Runtime.CompilerServices;
//    using System.Runtime.InteropServices;
//    using UnityEngine.Rendering;
//
//    public sealed class RenderSettings : Object
//    {
//        
//        internal static extern Object GetRenderSettings();
//        
//        private static extern void INTERNAL_get_ambientEquatorColor(out Color value);
//        
//        private static extern void INTERNAL_get_ambientGroundColor(out Color value);
//        
//        private static extern void INTERNAL_get_ambientLight(out Color value);
//        
//        private static extern void INTERNAL_get_ambientProbe(out SphericalHarmonicsL2 value);
//        
//        private static extern void INTERNAL_get_ambientSkyColor(out Color value);
//        
//        private static extern void INTERNAL_get_fogColor(out Color value);
//        
//        private static extern void INTERNAL_set_ambientEquatorColor(ref Color value);
//        
//        private static extern void INTERNAL_set_ambientGroundColor(ref Color value);
//        
//        private static extern void INTERNAL_set_ambientLight(ref Color value);
//        
//        private static extern void INTERNAL_set_ambientProbe(ref SphericalHarmonicsL2 value);
//        
//        private static extern void INTERNAL_set_ambientSkyColor(ref Color value);
//        
//        private static extern void INTERNAL_set_fogColor(ref Color value);
//        
//        internal static extern void Reset();
//
//        public static Color ambientEquatorColor
//        {
//            get
//            {
//                Color color;
//                INTERNAL_get_ambientEquatorColor(out color);
//                return color;
//            }
//            set
//            {
//                INTERNAL_set_ambientEquatorColor(ref value);
//            }
//        }
//
//        public static Color ambientGroundColor
//        {
//            get
//            {
//                Color color;
//                INTERNAL_get_ambientGroundColor(out color);
//                return color;
//            }
//            set
//            {
//                INTERNAL_set_ambientGroundColor(ref value);
//            }
//        }
//
//        public static float ambientIntensity {  get;  set; }
//
//        public static Color ambientLight
//        {
//            get
//            {
//                Color color;
//                INTERNAL_get_ambientLight(out color);
//                return color;
//            }
//            set
//            {
//                INTERNAL_set_ambientLight(ref value);
//            }
//        }
//
//        public static AmbientMode ambientMode {  get;  set; }
//
//        public static SphericalHarmonicsL2 ambientProbe
//        {
//            get
//            {
//                SphericalHarmonicsL2 sl;
//                INTERNAL_get_ambientProbe(out sl);
//                return sl;
//            }
//            set
//            {
//                INTERNAL_set_ambientProbe(ref value);
//            }
//        }
//
//        [Obsolete("Use RenderSettings.ambientIntensity instead (UnityUpgradable) -> ambientIntensity", false)]
//        public static float ambientSkyboxAmount
//        {
//            get
//            {
//                return ambientIntensity;
//            }
//            set
//            {
//                ambientIntensity = value;
//            }
//        }
//
//        public static Color ambientSkyColor
//        {
//            get
//            {
//                Color color;
//                INTERNAL_get_ambientSkyColor(out color);
//                return color;
//            }
//            set
//            {
//                INTERNAL_set_ambientSkyColor(ref value);
//            }
//        }
//
//        public static Cubemap customReflection {  get;  set; }
//
//        public static DefaultReflectionMode defaultReflectionMode {  get;  set; }
//
//        public static int defaultReflectionResolution {  get;  set; }
//
//        public static float flareFadeSpeed {  get;  set; }
//
//        public static float flareStrength {  get;  set; }
//
//        public static bool fog {  get;  set; }
//
//        public static Color fogColor
//        {
//            get
//            {
//                Color color;
//                INTERNAL_get_fogColor(out color);
//                return color;
//            }
//            set
//            {
//                INTERNAL_set_fogColor(ref value);
//            }
//        }
//
//        public static float fogDensity {  get;  set; }
//
//        public static float fogEndDistance {  get;  set; }
//
//        public static FogMode fogMode {  get;  set; }
//
//        public static float fogStartDistance {  get;  set; }
//
//        public static float haloStrength {  get;  set; }
//
//        public static int reflectionBounces {  get;  set; }
//
//        public static float reflectionIntensity {  get;  set; }
//
//        public static Material skybox {  get;  set; }
//    }
//}
//
