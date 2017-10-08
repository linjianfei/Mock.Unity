//namespace UnityEngine
//{
//    using System;
//    using System.Runtime.CompilerServices;
//    using UnityEngine.Internal;
//
//    public sealed class AnimationState : TrackedReference
//    {
//        [ExcludeFromDocs]
//        public void AddMixingTransform(Transform mix)
//        {
//            bool recursive = true;
//            this.AddMixingTransform(mix, recursive);
//        }
//
//        
//        public extern void AddMixingTransform(Transform mix, [DefaultValue("true")] bool recursive);
//        
//        public extern void RemoveMixingTransform(Transform mix);
//
//        public AnimationBlendMode blendMode {  get;  set; }
//
//        public AnimationClip clip {  get; }
//
//        public bool enabled {  get;  set; }
//
//        public int layer {  get;  set; }
//
//        public float length {  get; }
//
//        public string name {  get;  set; }
//
//        public float normalizedSpeed {  get;  set; }
//
//        public float normalizedTime {  get;  set; }
//
//        public float speed {  get;  set; }
//
//        public float time {  get;  set; }
//
//        public float weight {  get;  set; }
//
//        public WrapMode wrapMode {  get;  set; }
//    }
//}
//
