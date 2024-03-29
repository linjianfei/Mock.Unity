﻿//namespace UnityEngine
//{
//    using System;
//    using System.Collections;
//    using System.Reflection;
//    using System.Runtime.CompilerServices;
//    using System.Runtime.InteropServices;
//    using UnityEngine.Internal;
//
//    public sealed class Animation : Behaviour, IEnumerable
//    {
//        public void AddClip(AnimationClip clip, string newName)
//        {
//            this.AddClip(clip, newName, -2147483648, 0x7fffffff);
//        }
//
//        [ExcludeFromDocs]
//        public void AddClip(AnimationClip clip, string newName, int firstFrame, int lastFrame)
//        {
//            bool addLoopFrame = false;
//            this.AddClip(clip, newName, firstFrame, lastFrame, addLoopFrame);
//        }
//
//        
//        public extern void AddClip(AnimationClip clip, string newName, int firstFrame, int lastFrame, [DefaultValue("false")] bool addLoopFrame);
//        [ExcludeFromDocs]
//        public void Blend(string animation)
//        {
//            float fadeLength = 0.3f;
//            float targetWeight = 1f;
//            this.Blend(animation, targetWeight, fadeLength);
//        }
//
//        [ExcludeFromDocs]
//        public void Blend(string animation, float targetWeight)
//        {
//            float fadeLength = 0.3f;
//            this.Blend(animation, targetWeight, fadeLength);
//        }
//
//        
//        public extern void Blend(string animation, [DefaultValue("1.0F")] float targetWeight, [DefaultValue("0.3F")] float fadeLength);
//        [ExcludeFromDocs]
//        public void CrossFade(string animation)
//        {
//            PlayMode stopSameLayer = PlayMode.StopSameLayer;
//            float fadeLength = 0.3f;
//            this.CrossFade(animation, fadeLength, stopSameLayer);
//        }
//
//        [ExcludeFromDocs]
//        public void CrossFade(string animation, float fadeLength)
//        {
//            PlayMode stopSameLayer = PlayMode.StopSameLayer;
//            this.CrossFade(animation, fadeLength, stopSameLayer);
//        }
//
//        
//        public extern void CrossFade(string animation, [DefaultValue("0.3F")] float fadeLength, [DefaultValue("PlayMode.StopSameLayer")] PlayMode mode);
//        [ExcludeFromDocs]
//        public AnimationState CrossFadeQueued(string animation)
//        {
//            PlayMode stopSameLayer = PlayMode.StopSameLayer;
//            QueueMode completeOthers = QueueMode.CompleteOthers;
//            float fadeLength = 0.3f;
//            return this.CrossFadeQueued(animation, fadeLength, completeOthers, stopSameLayer);
//        }
//
//        [ExcludeFromDocs]
//        public AnimationState CrossFadeQueued(string animation, float fadeLength)
//        {
//            PlayMode stopSameLayer = PlayMode.StopSameLayer;
//            QueueMode completeOthers = QueueMode.CompleteOthers;
//            return this.CrossFadeQueued(animation, fadeLength, completeOthers, stopSameLayer);
//        }
//
//        [ExcludeFromDocs]
//        public AnimationState CrossFadeQueued(string animation, float fadeLength, QueueMode queue)
//        {
//            PlayMode stopSameLayer = PlayMode.StopSameLayer;
//            return this.CrossFadeQueued(animation, fadeLength, queue, stopSameLayer);
//        }
//
//        
//        public extern AnimationState CrossFadeQueued(string animation, [DefaultValue("0.3F")] float fadeLength, [DefaultValue("QueueMode.CompleteOthers")] QueueMode queue, [DefaultValue("PlayMode.StopSameLayer")] PlayMode mode);
//        public AnimationClip GetClip(string name)
//        {
//            AnimationState state = this.GetState(name);
//            if (state != null)
//            {
//                return state.clip;
//            }
//            return null;
//        }
//
//        
//        public extern int GetClipCount();
//        public IEnumerator GetEnumerator()
//        {
//            return new Enumerator(this);
//        }
//
//        
//        internal extern AnimationState GetState(string name);
//        
//        internal extern AnimationState GetStateAtIndex(int index);
//        
//        internal extern int GetStateCount();
//        
//        private static extern void INTERNAL_CALL_Rewind(Animation self);
//        
//        private static extern void INTERNAL_CALL_Sample(Animation self);
//        
//        private static extern void INTERNAL_CALL_Stop(Animation self);
//        
//        private static extern void INTERNAL_CALL_SyncLayer(Animation self, int layer);
//        
//        private extern void INTERNAL_get_localBounds(out Bounds value);
//        
//        private extern void Internal_RewindByName(string name);
//        
//        private extern void INTERNAL_set_localBounds(ref Bounds value);
//        
//        private extern void Internal_StopByName(string name);
//        
//        public extern bool IsPlaying(string name);
//        [ExcludeFromDocs]
//        public bool Play()
//        {
//            PlayMode stopSameLayer = PlayMode.StopSameLayer;
//            return this.Play(stopSameLayer);
//        }
//
//        [ExcludeFromDocs]
//        public bool Play(string animation)
//        {
//            PlayMode stopSameLayer = PlayMode.StopSameLayer;
//            return this.Play(animation, stopSameLayer);
//        }
//
//        [Obsolete("use PlayMode instead of AnimationPlayMode.")]
//        public bool Play(AnimationPlayMode mode)
//        {
//            return this.PlayDefaultAnimation((PlayMode) mode);
//        }
//
//        public bool Play([DefaultValue("PlayMode.StopSameLayer")] PlayMode mode)
//        {
//            return this.PlayDefaultAnimation(mode);
//        }
//
//        [Obsolete("use PlayMode instead of AnimationPlayMode.")]
//        public bool Play(string animation, AnimationPlayMode mode)
//        {
//            return this.Play(animation, (PlayMode) mode);
//        }
//
//        
//        public extern bool Play(string animation, [DefaultValue("PlayMode.StopSameLayer")] PlayMode mode);
//        
//        private extern bool PlayDefaultAnimation(PlayMode mode);
//        [ExcludeFromDocs]
//        public AnimationState PlayQueued(string animation)
//        {
//            PlayMode stopSameLayer = PlayMode.StopSameLayer;
//            QueueMode completeOthers = QueueMode.CompleteOthers;
//            return this.PlayQueued(animation, completeOthers, stopSameLayer);
//        }
//
//        [ExcludeFromDocs]
//        public AnimationState PlayQueued(string animation, QueueMode queue)
//        {
//            PlayMode stopSameLayer = PlayMode.StopSameLayer;
//            return this.PlayQueued(animation, queue, stopSameLayer);
//        }
//
//        
//        public extern AnimationState PlayQueued(string animation, [DefaultValue("QueueMode.CompleteOthers")] QueueMode queue, [DefaultValue("PlayMode.StopSameLayer")] PlayMode mode);
//        public void RemoveClip(string clipName)
//        {
//            this.RemoveClip2(clipName);
//        }
//
//        
//        public extern void RemoveClip(AnimationClip clip);
//        
//        private extern void RemoveClip2(string clipName);
//        public void Rewind()
//        {
//            INTERNAL_CALL_Rewind(this);
//        }
//
//        public void Rewind(string name)
//        {
//            this.Internal_RewindByName(name);
//        }
//
//        public void Sample()
//        {
//            INTERNAL_CALL_Sample(this);
//        }
//
//        public void Stop()
//        {
//            INTERNAL_CALL_Stop(this);
//        }
//
//        public void Stop(string name)
//        {
//            this.Internal_StopByName(name);
//        }
//
//        public void SyncLayer(int layer)
//        {
//            INTERNAL_CALL_SyncLayer(this, layer);
//        }
//
//        [Obsolete("Use cullingType instead")]
//        public bool animateOnlyIfVisible {  get;  set; }
//
//        public bool animatePhysics {  get;  set; }
//
//        public AnimationClip clip {  get;  set; }
//
//        public AnimationCullingType cullingType {  get;  set; }
//
//        public bool isPlaying {  get; }
//
//        public AnimationState this[string name]
//        {
//            get
//            {
//                return this.GetState(name);
//            }
//        }
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
//        public bool playAutomatically {  get;  set; }
//
//        public WrapMode wrapMode {  get;  set; }
//
//        private sealed class Enumerator : IEnumerator
//        {
//            private int m_CurrentIndex = -1;
//            private Animation m_Outer;
//
//            internal Enumerator(Animation outer)
//            {
//                this.m_Outer = outer;
//            }
//
//            public bool MoveNext()
//            {
//                int stateCount = this.m_Outer.GetStateCount();
//                this.m_CurrentIndex++;
//                return (this.m_CurrentIndex < stateCount);
//            }
//
//            public void Reset()
//            {
//                this.m_CurrentIndex = -1;
//            }
//
//            public object Current
//            {
//                get
//                {
//                    return this.m_Outer.GetStateAtIndex(this.m_CurrentIndex);
//                }
//            }
//        }
//    }
//}
//
