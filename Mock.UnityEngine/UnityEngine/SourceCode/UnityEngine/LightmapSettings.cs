namespace UnityEngine
{
    using System;
    using System.Runtime.CompilerServices;

    public sealed class LightmapSettings : Object
    {
        
        internal static extern void Reset();

        [Obsolete("bakedColorSpace is no longer valid. Use QualitySettings.desiredColorSpace.", false)]
        public static ColorSpace bakedColorSpace
        {
            get
            {
                return QualitySettings.desiredColorSpace;
            }
            set
            {
            }
        }

        public static LightmapData[] lightmaps {  get;  set; }

        public static LightmapsMode lightmapsMode {  get;  set; }

        [Obsolete("Use lightmapsMode property")]
        public static LightmapsModeLegacy lightmapsModeLegacy {  get;  set; }

        public static LightProbes lightProbes {  get;  set; }
    }
}

