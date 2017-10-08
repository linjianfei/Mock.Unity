//namespace UnityEngine
//{
//    using System;
//    using System.Runtime.CompilerServices;
//    using System.Runtime.InteropServices;
//
//    public sealed class WheelCollider : Collider
//    {
//        
//        public extern void ConfigureVehicleSubsteps(float speedThreshold, int stepsBelowThreshold, int stepsAboveThreshold);
//        
//        public extern bool GetGroundHit(out WheelHit hit);
//        
//        public extern void GetWorldPose(out Vector3 pos, out Quaternion quat);
//        
//        private extern void INTERNAL_get_center(out Vector3 value);
//        
//        private extern void INTERNAL_get_forwardFriction(out WheelFrictionCurve value);
//        
//        private extern void INTERNAL_get_sidewaysFriction(out WheelFrictionCurve value);
//        
//        private extern void INTERNAL_get_suspensionSpring(out JointSpring value);
//        
//        private extern void INTERNAL_set_center(ref Vector3 value);
//        
//        private extern void INTERNAL_set_forwardFriction(ref WheelFrictionCurve value);
//        
//        private extern void INTERNAL_set_sidewaysFriction(ref WheelFrictionCurve value);
//        
//        private extern void INTERNAL_set_suspensionSpring(ref JointSpring value);
//
//        public float brakeTorque {  get;  set; }
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
//        public float forceAppPointDistance {  get;  set; }
//
//        public WheelFrictionCurve forwardFriction
//        {
//            get
//            {
//                WheelFrictionCurve curve;
//                this.INTERNAL_get_forwardFriction(out curve);
//                return curve;
//            }
//            set
//            {
//                this.INTERNAL_set_forwardFriction(ref value);
//            }
//        }
//
//        public bool isGrounded {  get; }
//
//        public float mass {  get;  set; }
//
//        public float motorTorque {  get;  set; }
//
//        public float radius {  get;  set; }
//
//        public float rpm {  get; }
//
//        public WheelFrictionCurve sidewaysFriction
//        {
//            get
//            {
//                WheelFrictionCurve curve;
//                this.INTERNAL_get_sidewaysFriction(out curve);
//                return curve;
//            }
//            set
//            {
//                this.INTERNAL_set_sidewaysFriction(ref value);
//            }
//        }
//
//        public float sprungMass {  get; }
//
//        public float steerAngle {  get;  set; }
//
//        public float suspensionDistance {  get;  set; }
//
//        public JointSpring suspensionSpring
//        {
//            get
//            {
//                JointSpring spring;
//                this.INTERNAL_get_suspensionSpring(out spring);
//                return spring;
//            }
//            set
//            {
//                this.INTERNAL_set_suspensionSpring(ref value);
//            }
//        }
//
//        public float wheelDampingRate {  get;  set; }
//    }
//}
//
