//namespace UnityEngine
//{
//    using System;
//    using System.Runtime.CompilerServices;
//    using System.Runtime.InteropServices;
//
//    public sealed class DistanceJoint2D : AnchoredJoint2D
//    {
//        
//        private static extern void DistanceJoint2D_CUSTOM_INTERNAL_GetReactionForce(DistanceJoint2D joint, float timeStep, out Vector2 value);
//        public Vector2 GetReactionForce(float timeStep)
//        {
//            Vector2 vector;
//            DistanceJoint2D_CUSTOM_INTERNAL_GetReactionForce(this, timeStep, out vector);
//            return vector;
//        }
//
//        public float GetReactionTorque(float timeStep)
//        {
//            return INTERNAL_CALL_GetReactionTorque(this, timeStep);
//        }
//
//        
//        private static extern float INTERNAL_CALL_GetReactionTorque(DistanceJoint2D self, float timeStep);
//
//        public float distance {  get;  set; }
//
//        public bool maxDistanceOnly {  get;  set; }
//    }
//}
//
