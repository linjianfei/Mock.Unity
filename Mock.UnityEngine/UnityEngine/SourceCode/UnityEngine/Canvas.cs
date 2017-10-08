namespace UnityEngine
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    public sealed class Canvas : Behaviour
    {
        public static  event WillRenderCanvases willRenderCanvases;

        public static void ForceUpdateCanvases()
        {
            SendWillRenderCanvases();
        }

        
        public static extern Material GetDefaultCanvasMaterial();
        
        public static extern Material GetDefaultCanvasTextMaterial();
        
        private extern void INTERNAL_get_pixelRect(out Rect value);
        private static void SendWillRenderCanvases()
        {
            if (willRenderCanvases != null)
            {
                willRenderCanvases();
            }
        }

        public int cachedSortingLayerValue {  get; }

        public bool isRootCanvas {  get; }

        public bool overridePixelPerfect {  get;  set; }

        public bool overrideSorting {  get;  set; }

        public bool pixelPerfect {  get;  set; }

        public Rect pixelRect
        {
            get
            {
                Rect rect;
                this.INTERNAL_get_pixelRect(out rect);
                return rect;
            }
        }

        public float planeDistance {  get;  set; }

        public float referencePixelsPerUnit {  get;  set; }

        public RenderMode renderMode {  get;  set; }

        public int renderOrder {  get; }

        public float scaleFactor {  get;  set; }

        public int sortingLayerID {  get;  set; }

        public string sortingLayerName {  get;  set; }

        public int sortingOrder {  get;  set; }

        public Camera worldCamera {  get;  set; }

        public delegate void WillRenderCanvases();
    }
}

