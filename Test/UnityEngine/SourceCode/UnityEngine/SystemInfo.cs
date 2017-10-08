namespace UnityEngine
{
    using System;
    using System.Runtime.CompilerServices;
    using UnityEngine.Rendering;

    public sealed class SystemInfo
    {
        
        public static extern bool SupportsRenderTextureFormat(RenderTextureFormat format);
        
        public static extern bool SupportsTextureFormat(TextureFormat format);

        public static string deviceModel {  get; }

        public static string deviceName {  get; }

        public static DeviceType deviceType {  get; }

        public static string deviceUniqueIdentifier {  get; }

        public static int graphicsDeviceID {  get; }

        public static string graphicsDeviceName {  get; }

        public static GraphicsDeviceType graphicsDeviceType {  get; }

        public static string graphicsDeviceVendor {  get; }

        public static int graphicsDeviceVendorID {  get; }

        public static string graphicsDeviceVersion {  get; }

        public static int graphicsMemorySize {  get; }

        public static bool graphicsMultiThreaded {  get; }

        [Obsolete("graphicsPixelFillrate is no longer supported in Unity 5.0+.")]
        public static int graphicsPixelFillrate
        {
            get
            {
                return -1;
            }
        }

        public static int graphicsShaderLevel {  get; }

        public static int maxTextureSize {  get; }

        public static NPOTSupport npotSupport {  get; }

        public static string operatingSystem {  get; }

        public static int processorCount {  get; }

        public static string processorType {  get; }

        public static int supportedRenderTargetCount {  get; }

        public static bool supports3DTextures {  get; }

        public static bool supportsAccelerometer {  get; }

        public static bool supportsComputeShaders {  get; }

        public static bool supportsGyroscope {  get; }

        public static bool supportsImageEffects {  get; }

        public static bool supportsInstancing {  get; }

        public static bool supportsLocationService {  get; }

        public static bool supportsRenderTextures {  get; }

        public static bool supportsRenderToCubemap {  get; }

        public static bool supportsShadows {  get; }

        public static bool supportsSparseTextures {  get; }

        public static int supportsStencil {  get; }

        [Obsolete("Vertex program support is required in Unity 5.0+")]
        public static bool supportsVertexPrograms
        {
            get
            {
                return true;
            }
        }

        public static bool supportsVibration {  get; }

        public static int systemMemorySize {  get; }
    }
}

