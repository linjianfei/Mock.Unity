//namespace UnityEngine
//{
//    using System;
//    using System.Collections.Generic;
//    using System.Runtime.CompilerServices;
//    using System.Runtime.InteropServices;
//    using UnityEngine.Rendering;
//
//    public sealed class Terrain : Behaviour
//    {
//        public void AddTreeInstance(TreeInstance instance)
//        {
//            INTERNAL_CALL_AddTreeInstance(this, ref instance);
//        }
//
//        
//        public extern void ApplyDelayedHeightmapModification();
//        
//        public static extern GameObject CreateTerrainGameObject(TerrainData assignTerrain);
//        
//        public extern void Flush();
//        public void GetClosestReflectionProbes(List<ReflectionProbeBlendInfo> result)
//        {
//            this.GetClosestReflectionProbesInternal(result);
//        }
//
//        
//        private extern void GetClosestReflectionProbesInternal(object result);
//        
//        public extern Vector3 GetPosition();
//        
//        private static extern void INTERNAL_CALL_AddTreeInstance(Terrain self, ref TreeInstance instance);
//        
//        private static extern void INTERNAL_CALL_RemoveTrees(Terrain self, ref Vector2 position, float radius, int prototypeIndex);
//        
//        private static extern float INTERNAL_CALL_SampleHeight(Terrain self, ref Vector3 worldPosition);
//        
//        private extern void INTERNAL_get_legacySpecular(out Color value);
//        
//        private extern void INTERNAL_get_lightmapScaleOffset(out Vector4 value);
//        
//        private extern void INTERNAL_get_realtimeLightmapScaleOffset(out Vector4 value);
//        
//        private extern void INTERNAL_set_legacySpecular(ref Color value);
//        
//        private extern void INTERNAL_set_lightmapScaleOffset(ref Vector4 value);
//        
//        private extern void INTERNAL_set_realtimeLightmapScaleOffset(ref Vector4 value);
//        internal void RemoveTrees(Vector2 position, float radius, int prototypeIndex)
//        {
//            INTERNAL_CALL_RemoveTrees(this, ref position, radius, prototypeIndex);
//        }
//
//        public float SampleHeight(Vector3 worldPosition)
//        {
//            return INTERNAL_CALL_SampleHeight(this, ref worldPosition);
//        }
//
//        
//        public extern void SetNeighbors(Terrain left, Terrain top, Terrain right, Terrain bottom);
//
//        public static Terrain activeTerrain {  get; }
//
//        public static Terrain[] activeTerrains {  get; }
//
//        public bool bakeLightProbesForTrees {  get;  set; }
//
//        public float basemapDistance {  get;  set; }
//
//        public bool castShadows {  get;  set; }
//
//        public bool collectDetailPatches {  get;  set; }
//
//        public float detailObjectDensity {  get;  set; }
//
//        public float detailObjectDistance {  get;  set; }
//
//        public bool drawHeightmap {  get;  set; }
//
//        public bool drawTreesAndFoliage {  get;  set; }
//
//        public TerrainRenderFlags editorRenderFlags {  get;  set; }
//
//        public int heightmapMaximumLOD {  get;  set; }
//
//        public float heightmapPixelError {  get;  set; }
//
//        public float legacyShininess {  get;  set; }
//
//        public Color legacySpecular
//        {
//            get
//            {
//                Color color;
//                this.INTERNAL_get_legacySpecular(out color);
//                return color;
//            }
//            set
//            {
//                this.INTERNAL_set_legacySpecular(ref value);
//            }
//        }
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
//        public Material materialTemplate {  get;  set; }
//
//        public MaterialType materialType {  get;  set; }
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
//        public ReflectionProbeUsage reflectionProbeUsage {  get;  set; }
//
//        [Obsolete("use basemapDistance", true)]
//        public float splatmapDistance
//        {
//            get
//            {
//                return this.basemapDistance;
//            }
//            set
//            {
//                this.basemapDistance = value;
//            }
//        }
//
//        public TerrainData terrainData {  get;  set; }
//
//        public float treeBillboardDistance {  get;  set; }
//
//        public float treeCrossFadeLength {  get;  set; }
//
//        public float treeDistance {  get;  set; }
//
//        public int treeMaximumFullLODCount {  get;  set; }
//
//        public enum MaterialType
//        {
//            BuiltInStandard,
//            BuiltInLegacyDiffuse,
//            BuiltInLegacySpecular,
//            Custom
//        }
//    }
//}
//
