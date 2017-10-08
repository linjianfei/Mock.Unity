//namespace UnityEngine
//{
//    using System;
//    using System.Runtime.CompilerServices;
//    using System.Runtime.InteropServices;
//
//    public sealed class HingeJoint2D : AnchoredJoint2D
//    {
//        public float GetMotorTorque(float timeStep)
//        {
//            return INTERNAL_CALL_GetMotorTorque(this, timeStep);
//        }
//
//        public Vector2 GetReactionForce(float timeStep)
//        {
//            Vector2 vector;
//            HingeJoint2D_CUSTOM_INTERNAL_GetReactionForce(this, timeStep, out vector);
//            return vector;
//        }
//
//        public float GetReactionTorque(float timeStep)
//        {
//            return INTERNAL_CALL_GetReactionTorque(this, timeStep);
//        }
//
//        
//        private static extern void HingeJoint2D_CUSTOM_INTERNAL_GetReactionForce(HingeJoint2D joint, float timeStep, out Vector2 value);
//        
//        private static extern float INTERNAL_CALL_GetMotorTorque(HingeJoint2D self, float timeStep);
//        
//        private static extern float INTERNAL_CALL_GetReactionTorque(HingeJoint2D self, float timeStep);
//        
//        private extern void INTERNAL_get_limits(out JointAngleLimits2D value);
//        
//        private extern void INTERNAL_get_motor(out JointMotor2D value);
//        
//        private extern void INTERNAL_set_limits(ref JointAngleLimits2D value);
//        
//        private extern void INTERNAL_set_motor(ref JointMotor2D value);
//
//        public float jointAngle {  get; }
//
//        public float jointSpeed {  get; }
//
//        public JointAngleLimits2D limits
//        {
//            get
//            {
//                JointAngleLimits2D limitsd;
//                this.INTERNAL_get_limits(out limitsd);
//                return limitsd;
//            }
//            set
//            {
//                this.INTERNAL_set_limits(ref value);
//            }
//        }
//
//        public JointLimitState2D limitState {  get; }
//
//        public JointMotor2D motor
//        {
//            get
//            {
//                JointMotor2D motord;
//                this.INTERNAL_get_motor(out motord);
//                return motord;
//            }
//            set
//            {
//                this.INTERNAL_set_motor(ref value);
//            }
//        }
//
//        public float referenceAngle {  get; }
//
//        public bool useLimits {  get;  set; }
//
//        public bool useMotor {  get;  set; }
//    }
//}

