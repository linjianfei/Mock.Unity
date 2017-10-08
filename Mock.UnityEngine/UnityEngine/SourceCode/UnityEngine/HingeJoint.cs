namespace UnityEngine
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    public sealed class HingeJoint : Joint
    {
        
        private extern void INTERNAL_get_limits(out JointLimits value);
        
        private extern void INTERNAL_get_motor(out JointMotor value);
        
        private extern void INTERNAL_get_spring(out JointSpring value);
        
        private extern void INTERNAL_set_limits(ref JointLimits value);
        
        private extern void INTERNAL_set_motor(ref JointMotor value);
        
        private extern void INTERNAL_set_spring(ref JointSpring value);

        public float angle {  get; }

        public JointLimits limits
        {
            get
            {
                JointLimits limits;
                this.INTERNAL_get_limits(out limits);
                return limits;
            }
            set
            {
                this.INTERNAL_set_limits(ref value);
            }
        }

        public JointMotor motor
        {
            get
            {
                JointMotor motor;
                this.INTERNAL_get_motor(out motor);
                return motor;
            }
            set
            {
                this.INTERNAL_set_motor(ref value);
            }
        }

        public JointSpring spring
        {
            get
            {
                JointSpring spring;
                this.INTERNAL_get_spring(out spring);
                return spring;
            }
            set
            {
                this.INTERNAL_set_spring(ref value);
            }
        }

        public bool useLimits {  get;  set; }

        public bool useMotor {  get;  set; }

        public bool useSpring {  get;  set; }

        public float velocity {  get; }
    }
}

