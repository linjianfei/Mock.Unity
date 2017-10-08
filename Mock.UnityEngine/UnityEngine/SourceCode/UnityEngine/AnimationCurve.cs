//namespace UnityEngine
//{
//    using System;
//    using System.Reflection;
//    using System.Runtime.CompilerServices;
//    using System.Runtime.InteropServices;
//
//    [StructLayout(LayoutKind.Sequential)]
//    public sealed class AnimationCurve
//    {
//        internal IntPtr m_Ptr;
//        public AnimationCurve(params Keyframe[] keys)
//        {
//            this.Init(keys);
//        }
//
//        public AnimationCurve()
//        {
//            this.Init(null);
//        }
//
//        
//        private extern void Cleanup();
//        ~AnimationCurve()
//        {
//            this.Cleanup();
//        }
//
//        
//        public extern float Evaluate(float time);
//        public Keyframe[] keys
//        {
//            get
//            {
//                return this.GetKeys();
//            }
//            set
//            {
//                this.SetKeys(value);
//            }
//        }
//        
//        public extern int AddKey(float time, float value);
//        public int AddKey(Keyframe key)
//        {
//            return this.AddKey_Internal(key);
//        }
//
//        private int AddKey_Internal(Keyframe key)
//        {
//            return INTERNAL_CALL_AddKey_Internal(this, ref key);
//        }
//
//        
//        private static extern int INTERNAL_CALL_AddKey_Internal(AnimationCurve self, ref Keyframe key);
//        public int MoveKey(int index, Keyframe key)
//        {
//            return INTERNAL_CALL_MoveKey(this, index, ref key);
//        }
//
//        
//        private static extern int INTERNAL_CALL_MoveKey(AnimationCurve self, int index, ref Keyframe key);
//        
//        public extern void RemoveKey(int index);
//        public Keyframe this[int index]
//        {
//            get
//            {
//                return this.GetKey_Internal(index);
//            }
//        }
//        public int length {  get; }
//        
//        private extern void SetKeys(Keyframe[] keys);
//        
//        private extern Keyframe GetKey_Internal(int index);
//        
//        private extern Keyframe[] GetKeys();
//        
//        public extern void SmoothTangents(int index, float weight);
//        public static AnimationCurve Linear(float timeStart, float valueStart, float timeEnd, float valueEnd)
//        {
//            float outTangent = (valueEnd - valueStart) / (timeEnd - timeStart);
//            Keyframe[] keys = new Keyframe[] { new Keyframe(timeStart, valueStart, 0f, outTangent), new Keyframe(timeEnd, valueEnd, outTangent, 0f) };
//            return new AnimationCurve(keys);
//        }
//
//        public static AnimationCurve EaseInOut(float timeStart, float valueStart, float timeEnd, float valueEnd)
//        {
//            Keyframe[] keys = new Keyframe[] { new Keyframe(timeStart, valueStart, 0f, 0f), new Keyframe(timeEnd, valueEnd, 0f, 0f) };
//            return new AnimationCurve(keys);
//        }
//
//        public WrapMode preWrapMode {  get;  set; }
//        public WrapMode postWrapMode {  get;  set; }
//        
//        private extern void Init(Keyframe[] keys);
//    }
//}
//
