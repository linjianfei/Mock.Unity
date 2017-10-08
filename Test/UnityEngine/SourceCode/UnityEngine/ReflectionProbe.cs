namespace UnityEngine
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using UnityEngine.Internal;
    using UnityEngine.Rendering;

    public sealed class ReflectionProbe : Behaviour
    {
        
        public static extern bool BlendCubemap(Texture src, Texture dst, float blend, RenderTexture target);
        
        private extern void INTERNAL_get_backgroundColor(out Color value);
        
        private extern void INTERNAL_get_bounds(out Bounds value);
        
        private extern void INTERNAL_get_center(out Vector3 value);
        
        private extern void INTERNAL_get_size(out Vector3 value);
        
        private extern void INTERNAL_set_backgroundColor(ref Color value);
        
        private extern void INTERNAL_set_center(ref Vector3 value);
        
        private extern void INTERNAL_set_size(ref Vector3 value);
        
        public extern bool IsFinishedRendering(int renderId);
        [ExcludeFromDocs]
        public int RenderProbe()
        {
            RenderTexture targetTexture = null;
            return this.RenderProbe(targetTexture);
        }

        
        public extern int RenderProbe([DefaultValue("null")] RenderTexture targetTexture);

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

        public Texture bakedTexture {  get;  set; }

        public float blendDistance {  get;  set; }

        public Bounds bounds
        {
            get
            {
                Bounds bounds;
                this.INTERNAL_get_bounds(out bounds);
                return bounds;
            }
        }

        public bool boxProjection {  get;  set; }

        public Vector3 center
        {
            get
            {
                Vector3 vector;
                this.INTERNAL_get_center(out vector);
                return vector;
            }
            set
            {
                this.INTERNAL_set_center(ref value);
            }
        }

        public ReflectionProbeClearFlags clearFlags {  get;  set; }

        public int cullingMask {  get;  set; }

        public Texture customBakedTexture {  get;  set; }

        public float farClipPlane {  get;  set; }

        public bool hdr {  get;  set; }

        public int importance {  get;  set; }

        public float intensity {  get;  set; }

        public ReflectionProbeMode mode {  get;  set; }

        public float nearClipPlane {  get;  set; }

        public ReflectionProbeRefreshMode refreshMode {  get;  set; }

        public int resolution {  get;  set; }

        public float shadowDistance {  get;  set; }

        public Vector3 size
        {
            get
            {
                Vector3 vector;
                this.INTERNAL_get_size(out vector);
                return vector;
            }
            set
            {
                this.INTERNAL_set_size(ref value);
            }
        }

        public Texture texture {  get; }

        public ReflectionProbeTimeSlicingMode timeSlicingMode {  get;  set; }

        public ReflectionProbeType type {  get;  set; }
    }
}

