﻿namespace UnityEngine
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    public sealed class Display
    {
        private static Display _mainDisplay = displays[0];
        public static Display[] displays = new Display[] { new Display() };
        internal IntPtr nativeDisplay;

        public static  event DisplaysUpdatedDelegate onDisplaysUpdated;

        internal Display()
        {
            this.nativeDisplay = new IntPtr(0);
        }

        internal Display(IntPtr nativeDisplay)
        {
            this.nativeDisplay = nativeDisplay;
        }

        public void Activate()
        {
            ActivateDisplayImpl(this.nativeDisplay, 0, 0, 60);
        }

        public void Activate(int width, int height, int refreshRate)
        {
            ActivateDisplayImpl(this.nativeDisplay, width, height, refreshRate);
        }

        
        private static extern void ActivateDisplayImpl(IntPtr nativeDisplay, int width, int height, int refreshRate);
        private static void FireDisplaysUpdated()
        {
            if (onDisplaysUpdated != null)
            {
                onDisplaysUpdated();
            }
        }

        
        private static extern void GetRenderingBuffersImpl(IntPtr nativeDisplay, out RenderBuffer color, out RenderBuffer depth);
        
        private static extern void GetRenderingExtImpl(IntPtr nativeDisplay, out int w, out int h);
        
        private static extern void GetSystemExtImpl(IntPtr nativeDisplay, out int w, out int h);
        public static bool MultiDisplayLicense()
        {
            return MultiDisplayLicenseImpl();
        }

        
        private static extern bool MultiDisplayLicenseImpl();
        private static void RecreateDisplayList(IntPtr[] nativeDisplay)
        {
            displays = new Display[nativeDisplay.Length];
            for (int i = 0; i < nativeDisplay.Length; i++)
            {
                displays[i] = new Display(nativeDisplay[i]);
            }
            _mainDisplay = displays[0];
        }

        public static Vector3 RelativeMouseAt(Vector3 inputMouseCoordinates)
        {
            Vector3 vector;
            int rx = 0;
            int ry = 0;
            int x = (int) inputMouseCoordinates.x;
            int y = (int) inputMouseCoordinates.y;
            vector.z = RelativeMouseAtImpl(x, y, out rx, out ry);
            vector.x = rx;
            vector.y = ry;
            return vector;
        }

        
        private static extern int RelativeMouseAtImpl(int x, int y, out int rx, out int ry);
        public void SetParams(int width, int height, int x, int y)
        {
            SetParamsImpl(this.nativeDisplay, width, height, x, y);
        }

        
        private static extern void SetParamsImpl(IntPtr nativeDisplay, int width, int height, int x, int y);
        public void SetRenderingResolution(int w, int h)
        {
            SetRenderingResolutionImpl(this.nativeDisplay, w, h);
        }

        
        private static extern void SetRenderingResolutionImpl(IntPtr nativeDisplay, int w, int h);

        public RenderBuffer colorBuffer
        {
            get
            {
                RenderBuffer buffer;
                RenderBuffer buffer2;
                GetRenderingBuffersImpl(this.nativeDisplay, out buffer, out buffer2);
                return buffer;
            }
        }

        public RenderBuffer depthBuffer
        {
            get
            {
                RenderBuffer buffer;
                RenderBuffer buffer2;
                GetRenderingBuffersImpl(this.nativeDisplay, out buffer, out buffer2);
                return buffer2;
            }
        }

        public static Display main
        {
            get
            {
                return _mainDisplay;
            }
        }

        public int renderingHeight
        {
            get
            {
                int w = 0;
                int h = 0;
                GetRenderingExtImpl(this.nativeDisplay, out w, out h);
                return h;
            }
        }

        public int renderingWidth
        {
            get
            {
                int w = 0;
                int h = 0;
                GetRenderingExtImpl(this.nativeDisplay, out w, out h);
                return w;
            }
        }

        public int systemHeight
        {
            get
            {
                int w = 0;
                int h = 0;
                GetSystemExtImpl(this.nativeDisplay, out w, out h);
                return h;
            }
        }

        public int systemWidth
        {
            get
            {
                int w = 0;
                int h = 0;
                GetSystemExtImpl(this.nativeDisplay, out w, out h);
                return w;
            }
        }

        public delegate void DisplaysUpdatedDelegate();
    }
}

