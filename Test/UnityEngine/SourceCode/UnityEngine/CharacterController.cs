namespace UnityEngine
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    public sealed class CharacterController : Collider
    {
        
        private static extern CollisionFlags INTERNAL_CALL_Move(CharacterController self, ref Vector3 motion);
        
        private static extern bool INTERNAL_CALL_SimpleMove(CharacterController self, ref Vector3 speed);
        
        private extern void INTERNAL_get_center(out Vector3 value);
        
        private extern void INTERNAL_get_velocity(out Vector3 value);
        
        private extern void INTERNAL_set_center(ref Vector3 value);
        public CollisionFlags Move(Vector3 motion)
        {
            return INTERNAL_CALL_Move(this, ref motion);
        }

        public bool SimpleMove(Vector3 speed)
        {
            return INTERNAL_CALL_SimpleMove(this, ref speed);
        }

        public Vector3 center
        {
            get
            {
                Vector3 vector;
                this.INTERNAL_get_center(out vector);
                return vector;
            }
            set
            {
                this.INTERNAL_set_center(ref value);
            }
        }

        public CollisionFlags collisionFlags {  get; }

        public bool detectCollisions {  get;  set; }

        public float height {  get;  set; }

        public bool isGrounded {  get; }

        public float radius {  get;  set; }

        public float skinWidth {  get;  set; }

        public float slopeLimit {  get;  set; }

        public float stepOffset {  get;  set; }

        public Vector3 velocity
        {
            get
            {
                Vector3 vector;
                this.INTERNAL_get_velocity(out vector);
                return vector;
            }
        }
    }
}

