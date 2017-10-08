namespace UnityEngine
{
    using System;
    using System.Runtime.CompilerServices;
    using UnityEngine.Internal;

    public sealed class Handheld
    {
        
        public static extern void ClearShaderCache();
        
        public static extern int GetActivityIndicatorStyle();
        
        private static extern bool INTERNAL_CALL_PlayFullScreenMovie(string path, ref Color bgColor, FullScreenMovieControlMode controlMode, FullScreenMovieScalingMode scalingMode);
        [ExcludeFromDocs]
        public static bool PlayFullScreenMovie(string path)
        {
            FullScreenMovieScalingMode aspectFit = FullScreenMovieScalingMode.AspectFit;
            FullScreenMovieControlMode full = FullScreenMovieControlMode.Full;
            Color black = Color.black;
            return INTERNAL_CALL_PlayFullScreenMovie(path, ref black, full, aspectFit);
        }

        [ExcludeFromDocs]
        public static bool PlayFullScreenMovie(string path, Color bgColor)
        {
            FullScreenMovieScalingMode aspectFit = FullScreenMovieScalingMode.AspectFit;
            FullScreenMovieControlMode full = FullScreenMovieControlMode.Full;
            return INTERNAL_CALL_PlayFullScreenMovie(path, ref bgColor, full, aspectFit);
        }

        [ExcludeFromDocs]
        public static bool PlayFullScreenMovie(string path, Color bgColor, FullScreenMovieControlMode controlMode)
        {
            FullScreenMovieScalingMode aspectFit = FullScreenMovieScalingMode.AspectFit;
            return INTERNAL_CALL_PlayFullScreenMovie(path, ref bgColor, controlMode, aspectFit);
        }

        public static bool PlayFullScreenMovie(string path, [DefaultValue("Color.black")] Color bgColor, [DefaultValue("FullScreenMovieControlMode.Full")] FullScreenMovieControlMode controlMode, [DefaultValue("FullScreenMovieScalingMode.AspectFit")] FullScreenMovieScalingMode scalingMode)
        {
            return INTERNAL_CALL_PlayFullScreenMovie(path, ref bgColor, controlMode, scalingMode);
        }

        public static void SetActivityIndicatorStyle(AndroidActivityIndicatorStyle style)
        {
            SetActivityIndicatorStyleImpl((int) style);
        }

  

        
        internal static extern void SetActivityIndicatorStyleImpl(int style);
        
        public static extern void StartActivityIndicator();
        
        public static extern void StopActivityIndicator();
        
        public static extern void Vibrate();

        [Obsolete("Property Handheld.use32BitDisplayBuffer has been deprecated. Modifying it has no effect, use PlayerSettings instead.")]
        public static bool use32BitDisplayBuffer {  get;  set; }
    }
}

