namespace UnityEngine
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using UnityEngine.Rendering;

    public sealed class Light : Behaviour
    {
        
        public extern void AddCommandBuffer(LightEvent evt, CommandBuffer buffer);
        
        public extern CommandBuffer[] GetCommandBuffers(LightEvent evt);
        
        public static extern Light[] GetLights(LightType type, int layer);
        
        private extern void INTERNAL_get_areaSize(out Vector2 value);
        
        private extern void INTERNAL_get_color(out Color value);
        
        private extern void INTERNAL_set_areaSize(ref Vector2 value);
        
        private extern void INTERNAL_set_color(ref Color value);
        
        public extern void RemoveAllCommandBuffers();
        
        public extern void RemoveCommandBuffer(LightEvent evt, CommandBuffer buffer);
        
        public extern void RemoveCommandBuffers(LightEvent evt);

        public bool alreadyLightmapped {  get;  set; }

        public Vector2 areaSize
        {
            get
            {
                Vector2 vector;
                this.INTERNAL_get_areaSize(out vector);
                return vector;
            }
            set
            {
                this.INTERNAL_set_areaSize(ref value);
            }
        }

        [Obsolete("light.attenuate was removed; all lights always attenuate now", true)]
        public bool attenuate
        {
            get
            {
                return true;
            }
            set
            {
            }
        }

        public float bounceIntensity {  get;  set; }

        public Color color
        {
            get
            {
                Color color;
                this.INTERNAL_get_color(out color);
                return color;
            }
            set
            {
                this.INTERNAL_set_color(ref value);
            }
        }

        public int commandBufferCount {  get; }

        public Texture cookie {  get;  set; }

        public float cookieSize {  get;  set; }

        public int cullingMask {  get;  set; }

        public Flare flare {  get;  set; }

        public float intensity {  get;  set; }

        [Obsolete("Use QualitySettings.pixelLightCount instead.")]
        public static int pixelLightCount {  get;  set; }

        public float range {  get;  set; }

        public LightRenderMode renderMode {  get;  set; }

        public float shadowBias {  get;  set; }

        [Obsolete("light.shadowConstantBias was removed, use light.shadowBias", true)]
        public float shadowConstantBias
        {
            get
            {
                return 0f;
            }
            set
            {
            }
        }

        public float shadowNormalBias {  get;  set; }

        [Obsolete("light.shadowObjectSizeBias was removed, use light.shadowBias", true)]
        public float shadowObjectSizeBias
        {
            get
            {
                return 0f;
            }
            set
            {
            }
        }

        public LightShadows shadows {  get;  set; }

        [Obsolete("Shadow softness is removed in Unity 5.0+")]
        public float shadowSoftness {  get;  set; }

        [Obsolete("Shadow softness is removed in Unity 5.0+")]
        public float shadowSoftnessFade {  get;  set; }

        public float shadowStrength {  get;  set; }

        public float spotAngle {  get;  set; }

        public LightType type {  get;  set; }
    }
}

