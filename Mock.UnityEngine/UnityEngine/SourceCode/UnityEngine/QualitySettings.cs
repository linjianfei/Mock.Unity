namespace UnityEngine
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using UnityEngine.Internal;

    public sealed class QualitySettings : Object
    {
        [ExcludeFromDocs]
        public static void DecreaseLevel()
        {
            bool applyExpensiveChanges = false;
            DecreaseLevel(applyExpensiveChanges);
        }

        
        public static extern void DecreaseLevel([DefaultValue("false")] bool applyExpensiveChanges);
        
        public static extern int GetQualityLevel();
        [ExcludeFromDocs]
        public static void IncreaseLevel()
        {
            bool applyExpensiveChanges = false;
            IncreaseLevel(applyExpensiveChanges);
        }

        
        public static extern void IncreaseLevel([DefaultValue("false")] bool applyExpensiveChanges);
        
        private static extern void INTERNAL_get_shadowCascade4Split(out Vector3 value);
        
        private static extern void INTERNAL_set_shadowCascade4Split(ref Vector3 value);
        [ExcludeFromDocs]
        public static void SetQualityLevel(int index)
        {
            bool applyExpensiveChanges = true;
            SetQualityLevel(index, applyExpensiveChanges);
        }

        
        public static extern void SetQualityLevel(int index, [DefaultValue("true")] bool applyExpensiveChanges);

        public static ColorSpace activeColorSpace {  get; }

        public static AnisotropicFiltering anisotropicFiltering {  get;  set; }

        public static int antiAliasing {  get;  set; }

        public static bool billboardsFaceCameraPosition {  get;  set; }

        public static BlendWeights blendWeights {  get;  set; }

        [Obsolete("Use GetQualityLevel and SetQualityLevel")]
        public static QualityLevel currentLevel {  get;  set; }

        public static ColorSpace desiredColorSpace {  get; }

        public static float lodBias {  get;  set; }

        public static int masterTextureLimit {  get;  set; }

        public static int maximumLODLevel {  get;  set; }

        public static int maxQueuedFrames {  get;  set; }

        public static string[] names {  get; }

        public static int particleRaycastBudget {  get;  set; }

        public static int pixelLightCount {  get;  set; }

        public static bool realtimeReflectionProbes {  get;  set; }

        public static float shadowCascade2Split {  get;  set; }

        public static Vector3 shadowCascade4Split
        {
            get
            {
                Vector3 vector;
                INTERNAL_get_shadowCascade4Split(out vector);
                return vector;
            }
            set
            {
                INTERNAL_set_shadowCascade4Split(ref value);
            }
        }

        public static int shadowCascades {  get;  set; }

        public static float shadowDistance {  get;  set; }

        public static float shadowNearPlaneOffset {  get;  set; }

        public static ShadowProjection shadowProjection {  get;  set; }

        public static bool softVegetation {  get;  set; }

        public static int vSyncCount {  get;  set; }
    }
}

