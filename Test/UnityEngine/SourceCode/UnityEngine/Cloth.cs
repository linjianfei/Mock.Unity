//namespace UnityEngine
//{
//    using System;
//    using System.Runtime.CompilerServices;
//    using System.Runtime.InteropServices;
//    using UnityEngine.Internal;
//
//    public sealed class Cloth : Component
//    {
//        public void ClearTransformMotion()
//        {
//            INTERNAL_CALL_ClearTransformMotion(this);
//        }
//
//        
//        private static extern void INTERNAL_CALL_ClearTransformMotion(Cloth self);
//        
//        private extern void INTERNAL_get_externalAcceleration(out Vector3 value);
//        
//        private extern void INTERNAL_get_randomAcceleration(out Vector3 value);
//        
//        private extern void INTERNAL_set_externalAcceleration(ref Vector3 value);
//        
//        private extern void INTERNAL_set_randomAcceleration(ref Vector3 value);
//        [ExcludeFromDocs]
//        public void SetEnabledFading(bool enabled)
//        {
//            float interpolationTime = 0.5f;
//            this.SetEnabledFading(enabled, interpolationTime);
//        }
//
//        
//        public extern void SetEnabledFading(bool enabled, [DefaultValue("0.5f")] float interpolationTime);
//
//        public float bendingStiffness {  get;  set; }
//
//        public CapsuleCollider[] capsuleColliders {  get;  set; }
//
//        public ClothSkinningCoefficient[] coefficients {  get;  set; }
//
//        public float collisionMassScale {  get;  set; }
//
//        public float damping {  get;  set; }
//
//        public bool enabled {  get;  set; }
//
//        public Vector3 externalAcceleration
//        {
//            get
//            {
//                Vector3 vector;
//                this.INTERNAL_get_externalAcceleration(out vector);
//                return vector;
//            }
//            set
//            {
//                this.INTERNAL_set_externalAcceleration(ref value);
//            }
//        }
//
//        public float friction {  get;  set; }
//
//        public Vector3[] normals {  get; }
//
//        public Vector3 randomAcceleration
//        {
//            get
//            {
//                Vector3 vector;
//                this.INTERNAL_get_randomAcceleration(out vector);
//                return vector;
//            }
//            set
//            {
//                this.INTERNAL_set_randomAcceleration(ref value);
//            }
//        }
//
//        [Obsolete("Deprecated. Cloth.selfCollisions is no longer supported since Unity 5.0.", true)]
//        public bool selfCollision {  get;  set; }
//
//        public float sleepThreshold {  get;  set; }
//
//        public bool solverFrequency {  get;  set; }
//
//        public ClothSphereColliderPair[] sphereColliders {  get;  set; }
//
//        public float stretchingStiffness {  get;  set; }
//
//        public float useContinuousCollision {  get;  set; }
//
//        public bool useGravity {  get;  set; }
//
//        public float useVirtualParticles {  get;  set; }
//
//        public Vector3[] vertices {  get; }
//
//        public float worldAccelerationScale {  get;  set; }
//
//        public float worldVelocityScale {  get;  set; }
//    }
//}
//
