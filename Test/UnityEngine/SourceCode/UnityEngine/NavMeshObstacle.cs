//namespace UnityEngine
//{
//    using System;
//    using System.Runtime.CompilerServices;
//    using System.Runtime.InteropServices;
//
//    public sealed class NavMeshObstacle : Behaviour
//    {
//        
//        internal extern void FitExtents();
//        
//        private extern void INTERNAL_get_center(out Vector3 value);
//        
//        private extern void INTERNAL_get_size(out Vector3 value);
//        
//        private extern void INTERNAL_get_velocity(out Vector3 value);
//        
//        private extern void INTERNAL_set_center(ref Vector3 value);
//        
//        private extern void INTERNAL_set_size(ref Vector3 value);
//        
//        private extern void INTERNAL_set_velocity(ref Vector3 value);
//
//        public bool carveOnlyStationary {  get;  set; }
//
//        public bool carving {  get;  set; }
//
//        public float carvingMoveThreshold {  get;  set; }
//
//        public float carvingTimeToStationary {  get;  set; }
//
//        public Vector3 center
//        {
//            get
//            {
//                Vector3 vector;
//                this.INTERNAL_get_center(out vector);
//                return vector;
//            }
//            set
//            {
//                this.INTERNAL_set_center(ref value);
//            }
//        }
//
//        public float height {  get;  set; }
//
//        public float radius {  get;  set; }
//
//        public NavMeshObstacleShape shape {  get;  set; }
//
//        public Vector3 size
//        {
//            get
//            {
//                Vector3 vector;
//                this.INTERNAL_get_size(out vector);
//                return vector;
//            }
//            set
//            {
//                this.INTERNAL_set_size(ref value);
//            }
//        }
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
//    }
//}
//
