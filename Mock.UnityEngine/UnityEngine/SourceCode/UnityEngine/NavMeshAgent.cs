//namespace UnityEngine
//{
//    using System;
//    using System.Runtime.CompilerServices;
//    using System.Runtime.InteropServices;
//
//    public sealed class NavMeshAgent : Behaviour
//    {
//        
//        public extern void ActivateCurrentOffMeshLink(bool activated);
//        public bool CalculatePath(Vector3 targetPosition, NavMeshPath path)
//        {
//            path.ClearCorners();
//            return this.CalculatePathInternal(targetPosition, path);
//        }
//
//        private bool CalculatePathInternal(Vector3 targetPosition, NavMeshPath path)
//        {
//            return INTERNAL_CALL_CalculatePathInternal(this, ref targetPosition, path);
//        }
//
//        
//        public extern void CompleteOffMeshLink();
//        
//        internal extern void CopyPathTo(NavMeshPath path);
//        
//        public extern bool FindClosestEdge(out NavMeshHit hit);
//        
//        public extern float GetAreaCost(int areaIndex);
//        
//        internal extern OffMeshLinkData GetCurrentOffMeshLinkDataInternal();
//        
//        public extern float GetLayerCost(int layer);
//        
//        internal extern OffMeshLinkData GetNextOffMeshLinkDataInternal();
//        
//        private static extern bool INTERNAL_CALL_CalculatePathInternal(NavMeshAgent self, ref Vector3 targetPosition, NavMeshPath path);
//        
//        private static extern void INTERNAL_CALL_Move(NavMeshAgent self, ref Vector3 offset);
//        
//        private static extern bool INTERNAL_CALL_Raycast(NavMeshAgent self, ref Vector3 targetPosition, out NavMeshHit hit);
//        
//        private static extern bool INTERNAL_CALL_SetDestination(NavMeshAgent self, ref Vector3 target);
//        
//        private static extern bool INTERNAL_CALL_Warp(NavMeshAgent self, ref Vector3 newPosition);
//        
//        private extern void INTERNAL_get_desiredVelocity(out Vector3 value);
//        
//        private extern void INTERNAL_get_destination(out Vector3 value);
//        
//        private extern void INTERNAL_get_nextPosition(out Vector3 value);
//        
//        private extern void INTERNAL_get_pathEndPosition(out Vector3 value);
//        
//        private extern void INTERNAL_get_steeringTarget(out Vector3 value);
//        
//        private extern void INTERNAL_get_velocity(out Vector3 value);
//        
//        private extern void INTERNAL_set_destination(ref Vector3 value);
//        
//        private extern void INTERNAL_set_nextPosition(ref Vector3 value);
//        
//        private extern void INTERNAL_set_velocity(ref Vector3 value);
//        public void Move(Vector3 offset)
//        {
//            INTERNAL_CALL_Move(this, ref offset);
//        }
//
//        public bool Raycast(Vector3 targetPosition, out NavMeshHit hit)
//        {
//            return INTERNAL_CALL_Raycast(this, ref targetPosition, out hit);
//        }
//
//        
//        public extern void ResetPath();
//        
//        public extern void Resume();
//        
//        public extern bool SamplePathPosition(int areaMask, float maxDistance, out NavMeshHit hit);
//        
//        public extern void SetAreaCost(int areaIndex, float areaCost);
//        public bool SetDestination(Vector3 target)
//        {
//            return INTERNAL_CALL_SetDestination(this, ref target);
//        }
//
//        
//        public extern void SetLayerCost(int layer, float cost);
//        
//        public extern bool SetPath(NavMeshPath path);
//        public void Stop()
//        {
//            this.StopInternal();
//        }
//
//        [Obsolete("Use Stop() instead")]
//        public void Stop(bool stopUpdates)
//        {
//            this.StopInternal();
//        }
//
//        
//        internal extern void StopInternal();
//        public bool Warp(Vector3 newPosition)
//        {
//            return INTERNAL_CALL_Warp(this, ref newPosition);
//        }
//
//        public float acceleration {  get;  set; }
//
//        public float angularSpeed {  get;  set; }
//
//        public int areaMask {  get;  set; }
//
//        public bool autoBraking {  get;  set; }
//
//        public bool autoRepath {  get;  set; }
//
//        public bool autoTraverseOffMeshLink {  get;  set; }
//
//        public int avoidancePriority {  get;  set; }
//
//        public float baseOffset {  get;  set; }
//
//        public OffMeshLinkData currentOffMeshLinkData
//        {
//            get
//            {
//                return this.GetCurrentOffMeshLinkDataInternal();
//            }
//        }
//
//        public Vector3 desiredVelocity
//        {
//            get
//            {
//                Vector3 vector;
//                this.INTERNAL_get_desiredVelocity(out vector);
//                return vector;
//            }
//        }
//
//        public Vector3 destination
//        {
//            get
//            {
//                Vector3 vector;
//                this.INTERNAL_get_destination(out vector);
//                return vector;
//            }
//            set
//            {
//                this.INTERNAL_set_destination(ref value);
//            }
//        }
//
//        public bool hasPath {  get; }
//
//        public float height {  get;  set; }
//
//        public bool isOnNavMesh {  get; }
//
//        public bool isOnOffMeshLink {  get; }
//
//        public bool isPathStale {  get; }
//
//        public OffMeshLinkData nextOffMeshLinkData
//        {
//            get
//            {
//                return this.GetNextOffMeshLinkDataInternal();
//            }
//        }
//
//        public Vector3 nextPosition
//        {
//            get
//            {
//                Vector3 vector;
//                this.INTERNAL_get_nextPosition(out vector);
//                return vector;
//            }
//            set
//            {
//                this.INTERNAL_set_nextPosition(ref value);
//            }
//        }
//
//        public ObstacleAvoidanceType obstacleAvoidanceType {  get;  set; }
//
//        public NavMeshPath path
//        {
//            get
//            {
//                NavMeshPath path = new NavMeshPath();
//                this.CopyPathTo(path);
//                return path;
//            }
//            set
//            {
//                if (value == null)
//                {
//                    throw new NullReferenceException();
//                }
//                this.SetPath(value);
//            }
//        }
//
//        public Vector3 pathEndPosition
//        {
//            get
//            {
//                Vector3 vector;
//                this.INTERNAL_get_pathEndPosition(out vector);
//                return vector;
//            }
//        }
//
//        public bool pathPending {  get; }
//
//        public NavMeshPathStatus pathStatus {  get; }
//
//        public float radius {  get;  set; }
//
//        public float remainingDistance {  get; }
//
//        public float speed {  get;  set; }
//
//        public Vector3 steeringTarget
//        {
//            get
//            {
//                Vector3 vector;
//                this.INTERNAL_get_steeringTarget(out vector);
//                return vector;
//            }
//        }
//
//        public float stoppingDistance {  get;  set; }
//
//        public bool updatePosition {  get;  set; }
//
//        public bool updateRotation {  get;  set; }
//
//        public Vector3 velocity
//        {
//            get
//            {
//                Vector3 vector;
//                this.INTERNAL_get_velocity(out vector);
//                return vector;
//            }
//            set
//            {
//                this.INTERNAL_set_velocity(ref value);
//            }
//        }
//
//        [Obsolete("Use areaMask instead.")]
//        public int walkableMask {  get;  set; }
//    }
//}
//
