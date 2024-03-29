﻿//namespace UnityEngine
//{
//    using System;
//    using System.Runtime.CompilerServices;
//
//    public sealed class DynamicGI
//    {
//        
//        private static extern void INTERNAL_CALL_SetEmissive(Renderer renderer, ref Color color);
//        
//        private static extern void INTERNAL_CALL_UpdateMaterialsForTerrain(Terrain terrain, ref Rect uvBounds);
//        public static void SetEmissive(Renderer renderer, Color color)
//        {
//            INTERNAL_CALL_SetEmissive(renderer, ref color);
//        }
//
//        
//        public static extern void UpdateEnvironment();
//        public static void UpdateMaterials(Renderer renderer)
//        {
//            UpdateMaterialsForRenderer(renderer);
//        }
//
//        public static void UpdateMaterials(Terrain terrain)
//        {
//            if (terrain == null)
//            {
//                throw new ArgumentNullException("terrain");
//            }
//            if (terrain.terrainData == null)
//            {
//                throw new ArgumentException("Invalid terrainData.");
//            }
//            UpdateMaterialsForTerrain(terrain, new Rect(0f, 0f, 1f, 1f));
//        }
//
//        public static void UpdateMaterials(Terrain terrain, int x, int y, int width, int height)
//        {
//            if (terrain == null)
//            {
//                throw new ArgumentNullException("terrain");
//            }
//            if (terrain.terrainData == null)
//            {
//                throw new ArgumentException("Invalid terrainData.");
//            }
//            float alphamapWidth = terrain.terrainData.alphamapWidth;
//            float alphamapHeight = terrain.terrainData.alphamapHeight;
//            UpdateMaterialsForTerrain(terrain, new Rect(((float) x) / alphamapWidth, ((float) y) / alphamapHeight, ((float) width) / alphamapWidth, ((float) height) / alphamapHeight));
//        }
//
//        
//        internal static extern void UpdateMaterialsForRenderer(Renderer renderer);
//        internal static void UpdateMaterialsForTerrain(Terrain terrain, Rect uvBounds)
//        {
//            INTERNAL_CALL_UpdateMaterialsForTerrain(terrain, ref uvBounds);
//        }
//
//        public static float indirectScale {  get;  set; }
//
//        public static bool synchronousMode {  get;  set; }
//
//        public static float updateThreshold {  get;  set; }
//    }
//}
//
