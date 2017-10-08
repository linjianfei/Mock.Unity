//namespace UnityEngine
//{
//    using System;
//    using System.Runtime.CompilerServices;
//    using System.Runtime.InteropServices;
//
//    public sealed class SliderJoint2D : AnchoredJoint2D
//    {
//        public float GetMotorForce(float timeStep)
//        {
//            return INTERNAL_CALL_GetMotorForce(this, timeStep);
//        }
//
//        
//        private static extern float INTERNAL_CALL_GetMotorForce(SliderJoint2D self, float timeStep);
//        
//        private extern void INTERNAL_get_limits(out JointTranslationLimits2D value);
//        
//        private extern void INTERNAL_get_motor(out JointMotor2D value);
//        
//        private extern void INTERNAL_set_limits(ref JointTranslationLimits2D value);
//        
//        private extern void INTERNAL_set_motor(ref JointMotor2D value);
//
//        public float angle {  get;  set; }
//
//        public float jointSpeed {  get; }
//
//        public float jointTranslation {  get; }
//
//        public JointTranslationLimits2D limits
//        {
//            get
//            {
//                JointTranslationLimits2D limitsd;
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
//
