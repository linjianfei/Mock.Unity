//namespace UnityEngine
//{
//    using System;
//    using System.Runtime.CompilerServices;
//    using System.Runtime.InteropServices;
//
//    public sealed class SpringJoint2D : AnchoredJoint2D
//    {
//        public Vector2 GetReactionForce(float timeStep)
//        {
//            Vector2 vector;
//            SpringJoint2D_CUSTOM_INTERNAL_GetReactionForce(this, timeStep, out vector);
//            return vector;
//        }
//
//        public float GetReactionTorque(float timeStep)
//        {
//            return INTERNAL_CALL_GetReactionTorque(this, timeStep);
//        }
//
//        
//        private static extern float INTERNAL_CALL_GetReactionTorque(SpringJoint2D self, float timeStep);
//        
//        private static extern void SpringJoint2D_CUSTOM_INTERNAL_GetReactionForce(SpringJoint2D joint, float timeStep, out Vector2 value);
//
//        public float dampingRatio {  get;  set; }
//
//        public float distance {  get;  set; }
//
//        public float frequency {  get;  set; }
//    }
//}
//
