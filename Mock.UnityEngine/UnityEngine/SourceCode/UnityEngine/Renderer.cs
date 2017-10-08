//namespace UnityEngine
//{
//    using System;
//    using System.Collections.Generic;
//    using System.Runtime.CompilerServices;
//    using System.Runtime.InteropServices;
//    using UnityEngine.Rendering;
//
//    public class Renderer : Component
//    {
//        public void GetClosestReflectionProbes(List<ReflectionProbeBlendInfo> result)
//        {
//            this.GetClosestReflectionProbesInternal(result);
//        }
//
//        
//        private extern void GetClosestReflectionProbesInternal(object result);
//        
//        public extern void GetPropertyBlock(MaterialPropertyBlock dest);
//        
//        private extern void INTERNAL_get_bounds(out Bounds value);
//        
//        private extern void INTERNAL_get_lightmapScaleOffset(out Vector4 value);
//        
//        private extern void INTERNAL_get_localToWorldMatrix(out Matrix4x4 value);
//        
//        private extern void INTERNAL_get_realtimeLightmapScaleOffset(out Vector4 value);
//        
//        private extern void INTERNAL_get_worldToLocalMatrix(out Matrix4x4 value);
//        
//        private extern void INTERNAL_set_lightmapScaleOffset(ref Vector4 value);
//        
//        private extern void INTERNAL_set_realtimeLightmapScaleOffset(ref Vector4 value);
//        
//        internal extern void RenderNow(int material);
//        
//        public extern void SetPropertyBlock(MaterialPropertyBlock properties);
//        
//        internal extern void SetSubsetIndex(int index, int subSetIndexForMaterial);
//
//        public Bounds bounds
//        {
//            get
//            {
//                Bounds bounds;
//                this.INTERNAL_get_bounds(out bounds);
//                return bounds;
//            }
//        }
//
//        public bool castShadows {  get;  set; }
//
//        public bool enabled {  get;  set; }
//
//        public bool isPartOfStaticBatch {  get; }
//
//        public bool isVisible {  get; }
//
//        public int lightmapIndex {  get;  set; }
//
//        public Vector4 lightmapScaleOffset
//        {
//            get
//            {
//                Vector4 vector;
//                this.INTERNAL_get_lightmapScaleOffset(out vector);
//                return vector;
//            }
//            set
//            {
//                this.INTERNAL_set_lightmapScaleOffset(ref value);
//            }
//        }
//
//        public Vector4 lightmapTilingOffset
//        {
//            get
//            {
//                return Vector4.zero;
//            }
//            set
//            {
//            }
//        }
//
//        [Obsolete("Use probeAnchor instead (UnityUpgradable) -> probeAnchor", true)]
//        public Transform lightProbeAnchor
//        {
//            get
//            {
//                return this.probeAnchor;
//            }
//            set
//            {
//                this.probeAnchor = value;
//            }
//        }
//
//        public Matrix4x4 localToWorldMatrix
//        {
//            get
//            {
//                Matrix4x4 matrixx;
//                this.INTERNAL_get_localToWorldMatrix(out matrixx);
//                return matrixx;
//            }
//        }
//
//        public Material material {  get;  set; }
//
//        public Material[] materials {  get;  set; }
//
//        public Transform probeAnchor {  get;  set; }
//
//        public int realtimeLightmapIndex {  get;  set; }
//
//        public Vector4 realtimeLightmapScaleOffset
//        {
//            get
//            {
//                Vector4 vector;
//                this.INTERNAL_get_realtimeLightmapScaleOffset(out vector);
//                return vector;
//            }
//            set
//            {
//                this.INTERNAL_set_realtimeLightmapScaleOffset(ref value);
//            }
//        }
//
//        public bool receiveShadows {  get;  set; }
//
//        public ReflectionProbeUsage reflectionProbeUsage {  get;  set; }
//
//        public ShadowCastingMode shadowCastingMode {  get;  set; }
//
//        public Material sharedMaterial {  get;  set; }
//
//        public Material[] sharedMaterials {  get;  set; }
//
//        public int sortingLayerID {  get;  set; }
//
//        public string sortingLayerName {  get;  set; }
//
//        public int sortingOrder {  get;  set; }
//
//        internal int staticBatchIndex {  get; }
//
//        internal Transform staticBatchRootTransform {  get;  set; }
//
//        public bool useLightProbes {  get;  set; }
//
//        public Matrix4x4 worldToLocalMatrix
//        {
//            get
//            {
//                Matrix4x4 matrixx;
//                this.INTERNAL_get_worldToLocalMatrix(out matrixx);
//                return matrixx;
//            }
//        }
//    }
//}
//
