//namespace UnityEngine
//{
//    using System;
//    using System.Runtime.CompilerServices;
//    using System.Runtime.InteropServices;
//
//    public sealed class WheelJoint2D : AnchoredJoint2D
//    {
//        public float GetMotorTorque(float timeStep)
//        {
//            return INTERNAL_CALL_GetMotorTorque(this, timeStep);
//        }
//
//        
//        private static extern float INTERNAL_CALL_GetMotorTorque(WheelJoint2D self, float timeStep);
//        
//        private extern void INTERNAL_get_motor(out JointMotor2D value);
//        
//        private extern void INTERNAL_get_suspension(out JointSuspension2D value);
//        
//        private extern void INTERNAL_set_motor(ref JointMotor2D value);
//        
//        private extern void INTERNAL_set_suspension(ref JointSuspension2D value);
//
//        public float jointSpeed {  get; }
//
//        public float jointTranslation {  get; }
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
//        public JointSuspension2D suspension
//        {
//            get
//            {
//                JointSuspension2D suspensiond;
//                this.INTERNAL_get_suspension(out suspensiond);
//                return suspensiond;
//            }
//            set
//            {
//                this.INTERNAL_set_suspension(ref value);
//            }
//        }
//
//        public bool useMotor {  get;  set; }
//    }
//}
//
