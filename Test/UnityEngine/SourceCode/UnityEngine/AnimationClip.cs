//namespace UnityEngine
//{
//    using System;
//    using System.Runtime.CompilerServices;
//    using System.Runtime.InteropServices;
//
//    public sealed class AnimationClip : Motion
//    {
//        public AnimationClip()
//        {
//            Internal_CreateAnimationClip(this);
//        }
//
//        public void AddEvent(AnimationEvent evt)
//        {
//            this.AddEventInternal(evt);
//        }
//
//        
//        internal extern void AddEventInternal(object evt);
//        public void ClearCurves()
//        {
//            INTERNAL_CALL_ClearCurves(this);
//        }
//
//        public void EnsureQuaternionContinuity()
//        {
//            INTERNAL_CALL_EnsureQuaternionContinuity(this);
//        }
//
//        
//        internal extern Array GetEventsInternal();
//        
//        private static extern void INTERNAL_CALL_ClearCurves(AnimationClip self);
//        
//        private static extern void INTERNAL_CALL_EnsureQuaternionContinuity(AnimationClip self);
//        
//        private static extern void Internal_CreateAnimationClip([Writable] AnimationClip self);
//        
//        private extern void INTERNAL_get_localBounds(out Bounds value);
//        
//        private extern void INTERNAL_set_localBounds(ref Bounds value);
//        
//        public extern void SampleAnimation(GameObject go, float time);
//        
//        public extern void SetCurve(string relativePath, Type type, string propertyName, AnimationCurve curve);
//        
//        internal extern void SetEventsInternal(Array value);
//
//        public AnimationEvent[] events
//        {
//            get
//            {
//                return (AnimationEvent[]) this.GetEventsInternal();
//            }
//            set
//            {
//                this.SetEventsInternal(value);
//            }
//        }
//
//        public float frameRate {  get;  set; }
//
//        public bool humanMotion {  get; }
//
//        public bool legacy {  get;  set; }
//
//        public float length {  get; }
//
//        public Bounds localBounds
//        {
//            get
//            {
//                Bounds bounds;
//                this.INTERNAL_get_localBounds(out bounds);
//                return bounds;
//            }
//            set
//            {
//                this.INTERNAL_set_localBounds(ref value);
//            }
//        }
//
//        internal float startTime {  get; }
//
//        internal float stopTime {  get; }
//
//        public WrapMode wrapMode {  get;  set; }
//    }
//}
//
