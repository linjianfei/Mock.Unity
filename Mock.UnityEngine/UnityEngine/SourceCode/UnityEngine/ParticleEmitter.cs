//namespace UnityEngine
//{
//    using System;
//    using System.Runtime.CompilerServices;
//    using System.Runtime.InteropServices;
//
//    public class ParticleEmitter : Component
//    {
//        internal ParticleEmitter()
//        {
//        }
//
//        public void ClearParticles()
//        {
//            INTERNAL_CALL_ClearParticles(this);
//        }
//
//        public void Emit()
//        {
//            this.Emit2((int) Random.Range(this.minEmission, this.maxEmission));
//        }
//
//        public void Emit(int count)
//        {
//            this.Emit2(count);
//        }
//
//        public void Emit(Vector3 pos, Vector3 velocity, float size, float energy, Color color)
//        {
//            InternalEmitParticleArguments args = new InternalEmitParticleArguments {
//                pos = pos,
//                velocity = velocity,
//                size = size,
//                energy = energy,
//                color = color,
//                rotation = 0f,
//                angularVelocity = 0f
//            };
//            this.Emit3(ref args);
//        }
//
//        public void Emit(Vector3 pos, Vector3 velocity, float size, float energy, Color color, float rotation, float angularVelocity)
//        {
//            InternalEmitParticleArguments args = new InternalEmitParticleArguments {
//                pos = pos,
//                velocity = velocity,
//                size = size,
//                energy = energy,
//                color = color,
//                rotation = rotation,
//                angularVelocity = angularVelocity
//            };
//            this.Emit3(ref args);
//        }
//
//        
//        private extern void Emit2(int count);
//        
//        private extern void Emit3(ref InternalEmitParticleArguments args);
//        
//        private static extern void INTERNAL_CALL_ClearParticles(ParticleEmitter self);
//        
//        private extern void INTERNAL_get_localVelocity(out Vector3 value);
//        
//        private extern void INTERNAL_get_rndVelocity(out Vector3 value);
//        
//        private extern void INTERNAL_get_worldVelocity(out Vector3 value);
//        
//        private extern void INTERNAL_set_localVelocity(ref Vector3 value);
//        
//        private extern void INTERNAL_set_rndVelocity(ref Vector3 value);
//        
//        private extern void INTERNAL_set_worldVelocity(ref Vector3 value);
//        
//        public extern void Simulate(float deltaTime);
//
//        public float angularVelocity {  get;  set; }
//
//        public bool emit {  get;  set; }
//
//        public float emitterVelocityScale {  get;  set; }
//
//        public bool enabled {  get;  set; }
//
//        public Vector3 localVelocity
//        {
//            get
//            {
//                Vector3 vector;
//                this.INTERNAL_get_localVelocity(out vector);
//                return vector;
//            }
//            set
//            {
//                this.INTERNAL_set_localVelocity(ref value);
//            }
//        }
//
//        public float maxEmission {  get;  set; }
//
//        public float maxEnergy {  get;  set; }
//
//        public float maxSize {  get;  set; }
//
//        public float minEmission {  get;  set; }
//
//        public float minEnergy {  get;  set; }
//
//        public float minSize {  get;  set; }
//
//        public int particleCount {  get; }
//
//        public Particle[] particles {  get;  set; }
//
//        public float rndAngularVelocity {  get;  set; }
//
//        public bool rndRotation {  get;  set; }
//
//        public Vector3 rndVelocity
//        {
//            get
//            {
//                Vector3 vector;
//                this.INTERNAL_get_rndVelocity(out vector);
//                return vector;
//            }
//            set
//            {
//                this.INTERNAL_set_rndVelocity(ref value);
//            }
//        }
//
//        public bool useWorldSpace {  get;  set; }
//
//        public Vector3 worldVelocity
//        {
//            get
//            {
//                Vector3 vector;
//                this.INTERNAL_get_worldVelocity(out vector);
//                return vector;
//            }
//            set
//            {
//                this.INTERNAL_set_worldVelocity(ref value);
//            }
//        }
//    }
//}
//
