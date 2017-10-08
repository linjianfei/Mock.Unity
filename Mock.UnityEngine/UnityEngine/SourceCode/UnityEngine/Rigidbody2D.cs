//namespace UnityEngine
//{
//    using System;
//    using System.Runtime.CompilerServices;
//    using System.Runtime.InteropServices;
//    using UnityEngine.Internal;
//
//    public sealed class Rigidbody2D : Component
//    {
//        [ExcludeFromDocs]
//        public void AddForce(Vector2 force)
//        {
//            ForceMode2D mode = ForceMode2D.Force;
//            INTERNAL_CALL_AddForce(this, ref force, mode);
//        }
//
//        public void AddForce(Vector2 force, [DefaultValue("ForceMode2D.Force")] ForceMode2D mode)
//        {
//            INTERNAL_CALL_AddForce(this, ref force, mode);
//        }
//
//        [ExcludeFromDocs]
//        public void AddForceAtPosition(Vector2 force, Vector2 position)
//        {
//            ForceMode2D mode = ForceMode2D.Force;
//            INTERNAL_CALL_AddForceAtPosition(this, ref force, ref position, mode);
//        }
//
//        public void AddForceAtPosition(Vector2 force, Vector2 position, [DefaultValue("ForceMode2D.Force")] ForceMode2D mode)
//        {
//            INTERNAL_CALL_AddForceAtPosition(this, ref force, ref position, mode);
//        }
//
//        [ExcludeFromDocs]
//        public void AddRelativeForce(Vector2 relativeForce)
//        {
//            ForceMode2D force = ForceMode2D.Force;
//            INTERNAL_CALL_AddRelativeForce(this, ref relativeForce, force);
//        }
//
//        public void AddRelativeForce(Vector2 relativeForce, [DefaultValue("ForceMode2D.Force")] ForceMode2D mode)
//        {
//            INTERNAL_CALL_AddRelativeForce(this, ref relativeForce, mode);
//        }
//
//        [ExcludeFromDocs]
//        public void AddTorque(float torque)
//        {
//            ForceMode2D force = ForceMode2D.Force;
//            this.AddTorque(torque, force);
//        }
//
//        
//        public extern void AddTorque(float torque, [DefaultValue("ForceMode2D.Force")] ForceMode2D mode);
//        public Vector2 GetPoint(Vector2 point)
//        {
//            Vector2 vector;
//            Rigidbody2D_CUSTOM_INTERNAL_GetPoint(this, point, out vector);
//            return vector;
//        }
//
//        public Vector2 GetPointVelocity(Vector2 point)
//        {
//            Vector2 vector;
//            Rigidbody2D_CUSTOM_INTERNAL_GetPointVelocity(this, point, out vector);
//            return vector;
//        }
//
//        public Vector2 GetRelativePoint(Vector2 relativePoint)
//        {
//            Vector2 vector;
//            Rigidbody2D_CUSTOM_INTERNAL_GetRelativePoint(this, relativePoint, out vector);
//            return vector;
//        }
//
//        public Vector2 GetRelativePointVelocity(Vector2 relativePoint)
//        {
//            Vector2 vector;
//            Rigidbody2D_CUSTOM_INTERNAL_GetRelativePointVelocity(this, relativePoint, out vector);
//            return vector;
//        }
//
//        public Vector2 GetRelativeVector(Vector2 relativeVector)
//        {
//            Vector2 vector;
//            Rigidbody2D_CUSTOM_INTERNAL_GetRelativeVector(this, relativeVector, out vector);
//            return vector;
//        }
//
//        public Vector2 GetVector(Vector2 vector)
//        {
//            Vector2 vector2;
//            Rigidbody2D_CUSTOM_INTERNAL_GetVector(this, vector, out vector2);
//            return vector2;
//        }
//
//        
//        private static extern void INTERNAL_CALL_AddForce(Rigidbody2D self, ref Vector2 force, ForceMode2D mode);
//        
//        private static extern void INTERNAL_CALL_AddForceAtPosition(Rigidbody2D self, ref Vector2 force, ref Vector2 position, ForceMode2D mode);
//        
//        private static extern void INTERNAL_CALL_AddRelativeForce(Rigidbody2D self, ref Vector2 relativeForce, ForceMode2D mode);
//        
//        private static extern void INTERNAL_CALL_MovePosition(Rigidbody2D self, ref Vector2 position);
//        
//        private static extern void INTERNAL_CALL_MoveRotation(Rigidbody2D self, float angle);
//        
//        private static extern void INTERNAL_CALL_Rigidbody2D_CUSTOM_INTERNAL_GetPoint(Rigidbody2D rigidbody, ref Vector2 point, out Vector2 value);
//        
//        private static extern void INTERNAL_CALL_Rigidbody2D_CUSTOM_INTERNAL_GetPointVelocity(Rigidbody2D rigidbody, ref Vector2 point, out Vector2 value);
//        
//        private static extern void INTERNAL_CALL_Rigidbody2D_CUSTOM_INTERNAL_GetRelativePoint(Rigidbody2D rigidbody, ref Vector2 relativePoint, out Vector2 value);
//        
//        private static extern void INTERNAL_CALL_Rigidbody2D_CUSTOM_INTERNAL_GetRelativePointVelocity(Rigidbody2D rigidbody, ref Vector2 relativePoint, out Vector2 value);
//        
//        private static extern void INTERNAL_CALL_Rigidbody2D_CUSTOM_INTERNAL_GetRelativeVector(Rigidbody2D rigidbody, ref Vector2 relativeVector, out Vector2 value);
//        
//        private static extern void INTERNAL_CALL_Rigidbody2D_CUSTOM_INTERNAL_GetVector(Rigidbody2D rigidbody, ref Vector2 vector, out Vector2 value);
//        
//        private extern void INTERNAL_get_centerOfMass(out Vector2 value);
//        
//        private extern void INTERNAL_get_position(out Vector2 value);
//        
//        private extern void INTERNAL_get_velocity(out Vector2 value);
//        
//        private extern void INTERNAL_get_worldCenterOfMass(out Vector2 value);
//        
//        private extern void INTERNAL_set_centerOfMass(ref Vector2 value);
//        
//        private extern void INTERNAL_set_position(ref Vector2 value);
//        
//        private extern void INTERNAL_set_velocity(ref Vector2 value);
//        
//        public extern bool IsAwake();
//        
//        public extern bool IsSleeping();
//        
//        public extern bool IsTouching(Collider2D collider);
//        [ExcludeFromDocs]
//        public bool IsTouchingLayers()
//        {
//            int layerMask = -1;
//            return this.IsTouchingLayers(layerMask);
//        }
//
//        
//        public extern bool IsTouchingLayers([DefaultValue("Physics2D.AllLayers")] int layerMask);
//        public void MovePosition(Vector2 position)
//        {
//            INTERNAL_CALL_MovePosition(this, ref position);
//        }
//
//        public void MoveRotation(float angle)
//        {
//            INTERNAL_CALL_MoveRotation(this, angle);
//        }
//
//        private static void Rigidbody2D_CUSTOM_INTERNAL_GetPoint(Rigidbody2D rigidbody, Vector2 point, out Vector2 value)
//        {
//            INTERNAL_CALL_Rigidbody2D_CUSTOM_INTERNAL_GetPoint(rigidbody, ref point, out value);
//        }
//
//        private static void Rigidbody2D_CUSTOM_INTERNAL_GetPointVelocity(Rigidbody2D rigidbody, Vector2 point, out Vector2 value)
//        {
//            INTERNAL_CALL_Rigidbody2D_CUSTOM_INTERNAL_GetPointVelocity(rigidbody, ref point, out value);
//        }
//
//        private static void Rigidbody2D_CUSTOM_INTERNAL_GetRelativePoint(Rigidbody2D rigidbody, Vector2 relativePoint, out Vector2 value)
//        {
//            INTERNAL_CALL_Rigidbody2D_CUSTOM_INTERNAL_GetRelativePoint(rigidbody, ref relativePoint, out value);
//        }
//
//        private static void Rigidbody2D_CUSTOM_INTERNAL_GetRelativePointVelocity(Rigidbody2D rigidbody, Vector2 relativePoint, out Vector2 value)
//        {
//            INTERNAL_CALL_Rigidbody2D_CUSTOM_INTERNAL_GetRelativePointVelocity(rigidbody, ref relativePoint, out value);
//        }
//
//        private static void Rigidbody2D_CUSTOM_INTERNAL_GetRelativeVector(Rigidbody2D rigidbody, Vector2 relativeVector, out Vector2 value)
//        {
//            INTERNAL_CALL_Rigidbody2D_CUSTOM_INTERNAL_GetRelativeVector(rigidbody, ref relativeVector, out value);
//        }
//
//        private static void Rigidbody2D_CUSTOM_INTERNAL_GetVector(Rigidbody2D rigidbody, Vector2 vector, out Vector2 value)
//        {
//            INTERNAL_CALL_Rigidbody2D_CUSTOM_INTERNAL_GetVector(rigidbody, ref vector, out value);
//        }
//
//        
//        public extern void Sleep();
//        
//        public extern void WakeUp();
//
//        public float angularDrag {  get;  set; }
//
//        public float angularVelocity {  get;  set; }
//
//        public Vector2 centerOfMass
//        {
//            get
//            {
//                Vector2 vector;
//                this.INTERNAL_get_centerOfMass(out vector);
//                return vector;
//            }
//            set
//            {
//                this.INTERNAL_set_centerOfMass(ref value);
//            }
//        }
//
//        public CollisionDetectionMode2D collisionDetectionMode {  get;  set; }
//
//        public RigidbodyConstraints2D constraints {  get;  set; }
//
//        public float drag {  get;  set; }
//
//        [Obsolete("The fixedAngle is no longer supported. Use constraints instead.")]
//        public bool fixedAngle {  get;  set; }
//
//        public bool freezeRotation {  get;  set; }
//
//        public float gravityScale {  get;  set; }
//
//        public float inertia {  get;  set; }
//
//        public RigidbodyInterpolation2D interpolation {  get;  set; }
//
//        public bool isKinematic {  get;  set; }
//
//        public float mass {  get;  set; }
//
//        public Vector2 position
//        {
//            get
//            {
//                Vector2 vector;
//                this.INTERNAL_get_position(out vector);
//                return vector;
//            }
//            set
//            {
//                this.INTERNAL_set_position(ref value);
//            }
//        }
//
//        public float rotation {  get;  set; }
//
//        public bool simulated {  get;  set; }
//
//        public RigidbodySleepMode2D sleepMode {  get;  set; }
//
//        public Vector2 velocity
//        {
//            get
//            {
//                Vector2 vector;
//                this.INTERNAL_get_velocity(out vector);
//                return vector;
//            }
//            set
//            {
//                this.INTERNAL_set_velocity(ref value);
//            }
//        }
//
//        public Vector2 worldCenterOfMass
//        {
//            get
//            {
//                Vector2 vector;
//                this.INTERNAL_get_worldCenterOfMass(out vector);
//                return vector;
//            }
//        }
//    }
//}
//
