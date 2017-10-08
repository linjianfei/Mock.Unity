//namespace UnityEngine
//{
//    using System;
//    using System.Runtime.CompilerServices;
//    using UnityEngine.Internal;
//
//    public sealed class WebCamTexture : Texture
//    {
//        public WebCamTexture()
//        {
//            Internal_CreateWebCamTexture(this, string.Empty, 0, 0, 0);
//        }
//
//        public WebCamTexture(string deviceName)
//        {
//            Internal_CreateWebCamTexture(this, deviceName, 0, 0, 0);
//        }
//
//        public WebCamTexture(int requestedWidth, int requestedHeight)
//        {
//            Internal_CreateWebCamTexture(this, string.Empty, requestedWidth, requestedHeight, 0);
//        }
//
//        public WebCamTexture(int requestedWidth, int requestedHeight, int requestedFPS)
//        {
//            Internal_CreateWebCamTexture(this, string.Empty, requestedWidth, requestedHeight, requestedFPS);
//        }
//
//        public WebCamTexture(string deviceName, int requestedWidth, int requestedHeight)
//        {
//            Internal_CreateWebCamTexture(this, deviceName, requestedWidth, requestedHeight, 0);
//        }
//
//        public WebCamTexture(string deviceName, int requestedWidth, int requestedHeight, int requestedFPS)
//        {
//            Internal_CreateWebCamTexture(this, deviceName, requestedWidth, requestedHeight, requestedFPS);
//        }
//
//        
//        public extern Color GetPixel(int x, int y);
//        public Color[] GetPixels()
//        {
//            return this.GetPixels(0, 0, this.width, this.height);
//        }
//
//        
//        public extern Color[] GetPixels(int x, int y, int blockWidth, int blockHeight);
//        [ExcludeFromDocs]
//        public Color32[] GetPixels32()
//        {
//            Color32[] colors = null;
//            return this.GetPixels32(colors);
//        }
//
//        
//        public extern Color32[] GetPixels32([DefaultValue("null")] Color32[] colors);
//        
//        private static extern void INTERNAL_CALL_Pause(WebCamTexture self);
//        
//        private static extern void INTERNAL_CALL_Play(WebCamTexture self);
//        
//        private static extern void INTERNAL_CALL_Stop(WebCamTexture self);
//        
//        private static extern void Internal_CreateWebCamTexture([Writable] WebCamTexture self, string scriptingDevice, int requestedWidth, int requestedHeight, int maxFramerate);
//        
//        public extern void MarkNonReadable();
//        public void Pause()
//        {
//            INTERNAL_CALL_Pause(this);
//        }
//
//        public void Play()
//        {
//            INTERNAL_CALL_Play(this);
//        }
//
//        public void Stop()
//        {
//            INTERNAL_CALL_Stop(this);
//        }
//
//        public string deviceName {  get;  set; }
//
//        public static WebCamDevice[] devices {  get; }
//
//        public bool didUpdateThisFrame {  get; }
//
//        public bool isPlaying {  get; }
//
//        [Obsolete("since Unity 5.0 iOS WebCamTexture always goes through CVTextureCache and is read to memory on-demand")]
//        public bool isReadable {  get; }
//
//        public float requestedFPS {  get;  set; }
//
//        public int requestedHeight {  get;  set; }
//
//        public int requestedWidth {  get;  set; }
//
//        public int videoRotationAngle {  get; }
//
//        public bool videoVerticallyMirrored {  get; }
//    }
//}
//
