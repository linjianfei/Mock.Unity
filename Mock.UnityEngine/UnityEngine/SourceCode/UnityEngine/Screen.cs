namespace UnityEngine
{
    using System;
    using System.Runtime.CompilerServices;
    using UnityEngine.Internal;

    public sealed class Screen
    {
        [ExcludeFromDocs]
        public static void SetResolution(int width, int height, bool fullscreen)
        {
            int preferredRefreshRate = 0;
            SetResolution(width, height, fullscreen, preferredRefreshRate);
        }

        public static extern void SetResolution(int width, int height, bool fullscreen, int preferredRefreshRate);

        public static bool autorotateToLandscapeLeft {  get;  set; }

        public static bool autorotateToLandscapeRight {  get;  set; }

        public static bool autorotateToPortrait {  get;  set; }

        public static bool autorotateToPortraitUpsideDown {  get;  set; }

        public static Resolution currentResolution {  get; }

        public static float dpi {  get; }

        public static bool fullScreen {  get;  set; }

              public static int height {  get; }

        public static bool lockCursor
        {
            get
            {
                return (CursorLockMode.None == Cursor.lockState);
            }
            set
            {
                if (value)
                {
                    Cursor.visible = false;
                    Cursor.lockState = CursorLockMode.Locked;
                }
                else
                {
                    Cursor.lockState = CursorLockMode.None;
                    Cursor.visible = true;
                }
            }
        }

        public static ScreenOrientation orientation {  get;  set; }

        public static Resolution[] resolutions {  get; }

        public static bool showCursor { get; set; }

        public static int sleepTimeout {  get;  set; }

        public static int width {  get; }
    }
}

