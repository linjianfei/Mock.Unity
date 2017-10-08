//namespace UnityEngine
//{
//    using System;
//    using System.Runtime.CompilerServices;
//    using System.Runtime.InteropServices;
//
//    public sealed class NavMesh
//    {
//        public const int AllAreas = -1;
//
//        
//        public static extern void AddOffMeshLinks();
//        public static bool CalculatePath(Vector3 sourcePosition, Vector3 targetPosition, int areaMask, NavMeshPath path)
//        {
//            path.ClearCorners();
//            return CalculatePathInternal(sourcePosition, targetPosition, areaMask, path);
//        }
//
//        internal static bool CalculatePathInternal(Vector3 sourcePosition, Vector3 targetPosition, int areaMask, NavMeshPath path)
//        {
//            return INTERNAL_CALL_CalculatePathInternal(ref sourcePosition, ref targetPosition, areaMask, path);
//        }
//
//        public static NavMeshTriangulation CalculateTriangulation()
//        {
//            return (NavMeshTriangulation) TriangulateInternal();
//        }
//
//        public static bool FindClosestEdge(Vector3 sourcePosition, out NavMeshHit hit, int areaMask)
//        {
//            return INTERNAL_CALL_FindClosestEdge(ref sourcePosition, out hit, areaMask);
//        }
//
//        
//        public static extern float GetAreaCost(int areaIndex);
//        
//        public static extern int GetAreaFromName(string areaName);
//        
//        internal static extern float GetAvoidancePredictionTime();
//        
//        public static extern float GetLayerCost(int layer);
//        
//        public static extern int GetNavMeshLayerFromName(string layerName);
//        
//        internal static extern int GetPathfindingIterationsPerFrame();
//        
//        private static extern bool INTERNAL_CALL_CalculatePathInternal(ref Vector3 sourcePosition, ref Vector3 targetPosition, int areaMask, NavMeshPath path);
//        
//        private static extern bool INTERNAL_CALL_FindClosestEdge(ref Vector3 sourcePosition, out NavMeshHit hit, int areaMask);
//        
//        private static extern bool INTERNAL_CALL_Raycast(ref Vector3 sourcePosition, ref Vector3 targetPosition, out NavMeshHit hit, int areaMask);
//        
//        private static extern bool INTERNAL_CALL_SamplePosition(ref Vector3 sourcePosition, out NavMeshHit hit, float maxDistance, int areaMask);
//        public static bool Raycast(Vector3 sourcePosition, Vector3 targetPosition, out NavMeshHit hit, int areaMask)
//        {
//            return INTERNAL_CALL_Raycast(ref sourcePosition, ref targetPosition, out hit, areaMask);
//        }
//
//        
//        public static extern void RestoreNavMesh();
//        public static bool SamplePosition(Vector3 sourcePosition, out NavMeshHit hit, float maxDistance, int areaMask)
//        {
//            return INTERNAL_CALL_SamplePosition(ref sourcePosition, out hit, maxDistance, areaMask);
//        }
//
//        
//        public static extern void SetAreaCost(int areaIndex, float cost);
//        
//        internal static extern void SetAvoidancePredictionTime(float t);
//        
//        public static extern void SetLayerCost(int layer, float cost);
//        
//        internal static extern void SetPathfindingIterationsPerFrame(int iter);
//        
//        public static extern void Triangulate(out Vector3[] vertices, out int[] indices);
//        
//        internal static extern object TriangulateInternal();
//
//        public static float avoidancePredictionTime
//        {
//            get
//            {
//                return GetAvoidancePredictionTime();
//            }
//            set
//            {
//                SetAvoidancePredictionTime(value);
//            }
//        }
//
//        public static int pathfindingIterationsPerFrame
//        {
//            get
//            {
//                return GetPathfindingIterationsPerFrame();
//            }
//            set
//            {
//                SetPathfindingIterationsPerFrame(value);
//            }
//        }
//    }
//}
//
