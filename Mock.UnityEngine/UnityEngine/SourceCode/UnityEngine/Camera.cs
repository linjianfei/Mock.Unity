﻿namespace UnityEngine
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using UnityEngine.Internal;
    using UnityEngine.Rendering;

    public sealed class Camera : Behaviour
    {
        public static CameraCallback onPostRender;
        public static CameraCallback onPreCull;
        public static CameraCallback onPreRender;

        
        public extern void AddCommandBuffer(CameraEvent evt, CommandBuffer buffer);
        public Matrix4x4 CalculateObliqueMatrix(Vector4 clipPlane)
        {
            return INTERNAL_CALL_CalculateObliqueMatrix(this, ref clipPlane);
        }

        
        public extern void CopyFrom(Camera other);
         private static void FireOnPostRender(Camera cam)
        {
            if (onPostRender != null)
            {
                onPostRender(cam);
            }
        }

        private static void FireOnPreCull(Camera cam)
        {
            if (onPreCull != null)
            {
                onPreCull(cam);
            }
        }

        private static void FireOnPreRender(Camera cam)
        {
            if (onPreRender != null)
            {
                onPreRender(cam);
            }
        }

        
        public static extern int GetAllCameras(Camera[] cameras);
        
        public extern CommandBuffer[] GetCommandBuffers(CameraEvent evt);
        
        internal extern string[] GetHDRWarnings();
        public float GetScreenHeight()
        {
            return 0f;
        }

        public float GetScreenWidth()
        {
            return 0f;
        }

        
        private static extern Matrix4x4 INTERNAL_CALL_CalculateObliqueMatrix(Camera self, ref Vector4 clipPlane);
        
        private static extern GameObject INTERNAL_CALL_RaycastTry(Camera self, ref Ray ray, float distance, int layerMask, QueryTriggerInteraction queryTriggerInteraction);
        
        private static extern GameObject INTERNAL_CALL_RaycastTry2D(Camera self, ref Ray ray, float distance, int layerMask);
        
        private static extern void INTERNAL_CALL_ResetAspect(Camera self);
        
        private static extern void INTERNAL_CALL_ResetProjectionMatrix(Camera self);
        
        private static extern void INTERNAL_CALL_ResetReplacementShader(Camera self);
        
        private static extern void INTERNAL_CALL_ResetWorldToCameraMatrix(Camera self);
        
        private static extern Ray INTERNAL_CALL_ScreenPointToRay(Camera self, ref Vector3 position);
        
        private static extern Vector3 INTERNAL_CALL_ScreenToViewportPoint(Camera self, ref Vector3 position);
        
        private static extern Vector3 INTERNAL_CALL_ScreenToWorldPoint(Camera self, ref Vector3 position);
        
        private static extern Ray INTERNAL_CALL_ViewportPointToRay(Camera self, ref Vector3 position);
        
        private static extern Vector3 INTERNAL_CALL_ViewportToScreenPoint(Camera self, ref Vector3 position);
        
        private static extern Vector3 INTERNAL_CALL_ViewportToWorldPoint(Camera self, ref Vector3 position);
        
        private static extern Vector3 INTERNAL_CALL_WorldToScreenPoint(Camera self, ref Vector3 position);
        
        private static extern Vector3 INTERNAL_CALL_WorldToViewportPoint(Camera self, ref Vector3 position);
        
        private extern void INTERNAL_get_backgroundColor(out Color value);
        
        private extern void INTERNAL_get_cameraToWorldMatrix(out Matrix4x4 value);
        
        private extern void INTERNAL_get_pixelRect(out Rect value);
        
        private extern void INTERNAL_get_projectionMatrix(out Matrix4x4 value);
        
        private extern void INTERNAL_get_rect(out Rect value);
        
        private extern void INTERNAL_get_velocity(out Vector3 value);
        
        private extern void INTERNAL_get_worldToCameraMatrix(out Matrix4x4 value);
        
        private extern bool Internal_RenderToCubemapRT(RenderTexture cubemap, int faceMask);
        
        private extern bool Internal_RenderToCubemapTexture(Cubemap cubemap, int faceMask);
        
        private extern void INTERNAL_set_backgroundColor(ref Color value);
        
        private extern void INTERNAL_set_pixelRect(ref Rect value);
        
        private extern void INTERNAL_set_projectionMatrix(ref Matrix4x4 value);
        
        private extern void INTERNAL_set_rect(ref Rect value);
        
        private extern void INTERNAL_set_worldToCameraMatrix(ref Matrix4x4 value);
        
        internal extern bool IsFiltered(GameObject go);
        internal void OnlyUsedForTesting1()
        {
        }

        internal void OnlyUsedForTesting2()
        {
        }

        [ExcludeFromDocs]
        internal GameObject RaycastTry(Ray ray, float distance, int layerMask)
        {
            QueryTriggerInteraction useGlobal = QueryTriggerInteraction.UseGlobal;
            return INTERNAL_CALL_RaycastTry(this, ref ray, distance, layerMask, useGlobal);
        }

        internal GameObject RaycastTry(Ray ray, float distance, int layerMask, [DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction)
        {
            return INTERNAL_CALL_RaycastTry(this, ref ray, distance, layerMask, queryTriggerInteraction);
        }

        internal GameObject RaycastTry2D(Ray ray, float distance, int layerMask)
        {
            return INTERNAL_CALL_RaycastTry2D(this, ref ray, distance, layerMask);
        }

        
        public extern void RemoveAllCommandBuffers();
        
        public extern void RemoveCommandBuffer(CameraEvent evt, CommandBuffer buffer);
        
        public extern void RemoveCommandBuffers(CameraEvent evt);
        
        public extern void Render();
        
        public extern void RenderDontRestore();
        [ExcludeFromDocs]
        public bool RenderToCubemap(Cubemap cubemap)
        {
            int faceMask = 0x3f;
            return this.RenderToCubemap(cubemap, faceMask);
        }

        [ExcludeFromDocs]
        public bool RenderToCubemap(RenderTexture cubemap)
        {
            int faceMask = 0x3f;
            return this.RenderToCubemap(cubemap, faceMask);
        }

        public bool RenderToCubemap(Cubemap cubemap, [DefaultValue("63")] int faceMask)
        {
            return this.Internal_RenderToCubemapTexture(cubemap, faceMask);
        }

        public bool RenderToCubemap(RenderTexture cubemap, [DefaultValue("63")] int faceMask)
        {
            return this.Internal_RenderToCubemapRT(cubemap, faceMask);
        }

        
        public extern void RenderWithShader(Shader shader, string replacementTag);
        public void ResetAspect()
        {
            INTERNAL_CALL_ResetAspect(this);
        }

        public void ResetProjectionMatrix()
        {
            INTERNAL_CALL_ResetProjectionMatrix(this);
        }

        public void ResetReplacementShader()
        {
            INTERNAL_CALL_ResetReplacementShader(this);
        }

        public void ResetWorldToCameraMatrix()
        {
            INTERNAL_CALL_ResetWorldToCameraMatrix(this);
        }

        public Ray ScreenPointToRay(Vector3 position)
        {
            return INTERNAL_CALL_ScreenPointToRay(this, ref position);
        }

        public Vector3 ScreenToViewportPoint(Vector3 position)
        {
            return INTERNAL_CALL_ScreenToViewportPoint(this, ref position);
        }

        public Vector3 ScreenToWorldPoint(Vector3 position)
        {
            return INTERNAL_CALL_ScreenToWorldPoint(this, ref position);
        }

        
        public extern void SetReplacementShader(Shader shader, string replacementTag);
        public void SetTargetBuffers(RenderBuffer colorBuffer, RenderBuffer depthBuffer)
        {
            this.SetTargetBuffersImpl(out colorBuffer, out depthBuffer);
        }

        public void SetTargetBuffers(RenderBuffer[] colorBuffer, RenderBuffer depthBuffer)
        {
            this.SetTargetBuffersMRTImpl(colorBuffer, out depthBuffer);
        }

        
        private extern void SetTargetBuffersImpl(out RenderBuffer color, out RenderBuffer depth);
        
        private extern void SetTargetBuffersMRTImpl(RenderBuffer[] color, out RenderBuffer depth);
        
        public static extern void SetupCurrent(Camera cur);
        public Ray ViewportPointToRay(Vector3 position)
        {
            return INTERNAL_CALL_ViewportPointToRay(this, ref position);
        }

        public Vector3 ViewportToScreenPoint(Vector3 position)
        {
            return INTERNAL_CALL_ViewportToScreenPoint(this, ref position);
        }

        public Vector3 ViewportToWorldPoint(Vector3 position)
        {
            return INTERNAL_CALL_ViewportToWorldPoint(this, ref position);
        }

        public Vector3 WorldToScreenPoint(Vector3 position)
        {
            return INTERNAL_CALL_WorldToScreenPoint(this, ref position);
        }

        public Vector3 WorldToViewportPoint(Vector3 position)
        {
            return INTERNAL_CALL_WorldToViewportPoint(this, ref position);
        }

        public RenderingPath actualRenderingPath {  get; }

        public static Camera[] allCameras {  get; }

        public static int allCamerasCount {  get; }

        public float aspect {  get;  set; }

        public Color backgroundColor
        {
            get
            {
                Color color;
                this.INTERNAL_get_backgroundColor(out color);
                return color;
            }
            set
            {
                this.INTERNAL_set_backgroundColor(ref value);
            }
        }

        public Matrix4x4 cameraToWorldMatrix
        {
            get
            {
                Matrix4x4 matrixx;
                this.INTERNAL_get_cameraToWorldMatrix(out matrixx);
                return matrixx;
            }
        }

        public CameraType cameraType {  get;  set; }

        public CameraClearFlags clearFlags {  get;  set; }

        public bool clearStencilAfterLightingPass {  get;  set; }

        public int commandBufferCount {  get; }

        public int cullingMask {  get;  set; }

        public static Camera current {  get; }

        public float depth {  get;  set; }

        public DepthTextureMode depthTextureMode {  get;  set; }

        public int eventMask {  get;  set; }

        [Obsolete("use Camera.farClipPlane instead.")]
        public float far
        {
            get
            {
                return this.farClipPlane;
            }
            set
            {
                this.farClipPlane = value;
            }
        }

        public float farClipPlane {  get;  set; }

        public float fieldOfView {  get;  set; }

        [Obsolete("use Camera.fieldOfView instead.")]
        public float fov
        {
            get
            {
                return this.fieldOfView;
            }
            set
            {
                this.fieldOfView = value;
            }
        }

        public bool hdr {  get;  set; }

        public bool isOrthoGraphic
        {
            get
            {
                return false;
            }
            set
            {
            }
        }

        public float[] layerCullDistances {  get;  set; }

        public bool layerCullSpherical {  get;  set; }

        public static Camera main {  get; }

        public static Camera mainCamera
        {
            get
            {
                return null;
            }
        }

        [Obsolete("use Camera.nearClipPlane instead.")]
        public float near
        {
            get
            {
                return this.nearClipPlane;
            }
            set
            {
                this.nearClipPlane = value;
            }
        }

        public float nearClipPlane {  get;  set; }

        public OpaqueSortMode opaqueSortMode {  get;  set; }

        public bool orthographic {  get;  set; }

        public float orthographicSize {  get;  set; }

        public int pixelHeight {  get; }

        public Rect pixelRect
        {
            get
            {
                Rect rect;
                this.INTERNAL_get_pixelRect(out rect);
                return rect;
            }
            set
            {
                this.INTERNAL_set_pixelRect(ref value);
            }
        }

        public int pixelWidth {  get; }

        internal static int PreviewCullingLayer {  get; }

        public Matrix4x4 projectionMatrix
        {
            get
            {
                Matrix4x4 matrixx;
                this.INTERNAL_get_projectionMatrix(out matrixx);
                return matrixx;
            }
            set
            {
                this.INTERNAL_set_projectionMatrix(ref value);
            }
        }

        public Rect rect
        {
            get
            {
                Rect rect;
                this.INTERNAL_get_rect(out rect);
                return rect;
            }
            set
            {
                this.INTERNAL_set_rect(ref value);
            }
        }

        public RenderingPath renderingPath {  get;  set; }

        public float stereoConvergence {  get;  set; }

        public bool stereoEnabled {  get; }

        public bool stereoMirrorMode {  get;  set; }

        public float stereoSeparation {  get;  set; }

        public int targetDisplay {  get;  set; }

        public RenderTexture targetTexture {  get;  set; }

        public TransparencySortMode transparencySortMode {  get;  set; }

        public bool useOcclusionCulling {  get;  set; }

        public Vector3 velocity
        {
            get
            {
                Vector3 vector;
                this.INTERNAL_get_velocity(out vector);
                return vector;
            }
        }

        public Matrix4x4 worldToCameraMatrix
        {
            get
            {
                Matrix4x4 matrixx;
                this.INTERNAL_get_worldToCameraMatrix(out matrixx);
                return matrixx;
            }
            set
            {
                this.INTERNAL_set_worldToCameraMatrix(ref value);
            }
        }

        public delegate void CameraCallback(Camera cam);
    }
}

