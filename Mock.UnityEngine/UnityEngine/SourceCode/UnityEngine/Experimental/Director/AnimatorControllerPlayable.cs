//namespace UnityEngine.Experimental.Director
//{
//    using System;
//    using System.Collections.Generic;
//    using System.Runtime.CompilerServices;
//    using UnityEngine;
//    using UnityEngine.Internal;
//
//    public sealed class AnimatorControllerPlayable : AnimationPlayable, IAnimatorControllerPlayable
//    {
//        public AnimatorControllerPlayable(RuntimeAnimatorController controller) : base(false)
//        {
//            base.m_Ptr = IntPtr.Zero;
//            this.InstantiateEnginePlayable(controller);
//        }
//
//        public override int AddInput(AnimationPlayable source)
//        {
//            Debug.LogError("AnimationClipPlayable doesn't support adding inputs");
//            return -1;
//        }
//
//        [ExcludeFromDocs]
//        public void CrossFade(int stateNameHash, float transitionDuration)
//        {
//            float negativeInfinity = float.NegativeInfinity;
//            int layer = -1;
//            this.CrossFade(stateNameHash, transitionDuration, layer, negativeInfinity);
//        }
//
//        [ExcludeFromDocs]
//        public void CrossFade(string stateName, float transitionDuration)
//        {
//            float negativeInfinity = float.NegativeInfinity;
//            int layer = -1;
//            this.CrossFade(stateName, transitionDuration, layer, negativeInfinity);
//        }
//
//        [ExcludeFromDocs]
//        public void CrossFade(int stateNameHash, float transitionDuration, int layer)
//        {
//            float negativeInfinity = float.NegativeInfinity;
//            this.CrossFade(stateNameHash, transitionDuration, layer, negativeInfinity);
//        }
//
//        [ExcludeFromDocs]
//        public void CrossFade(string stateName, float transitionDuration, int layer)
//        {
//            float negativeInfinity = float.NegativeInfinity;
//            this.CrossFade(stateName, transitionDuration, layer, negativeInfinity);
//        }
//
//        
//        public extern void CrossFade(int stateNameHash, float transitionDuration, [DefaultValue("-1")] int layer, [DefaultValue("float.NegativeInfinity")] float normalizedTime);
//        public void CrossFade(string stateName, float transitionDuration, [DefaultValue("-1")] int layer, [DefaultValue("float.NegativeInfinity")] float normalizedTime)
//        {
//            this.CrossFade(StringToHash(stateName), transitionDuration, layer, normalizedTime);
//        }
//
//        [ExcludeFromDocs]
//        public void CrossFadeInFixedTime(int stateNameHash, float transitionDuration)
//        {
//            float fixedTime = 0f;
//            int layer = -1;
//            this.CrossFadeInFixedTime(stateNameHash, transitionDuration, layer, fixedTime);
//        }
//
//        [ExcludeFromDocs]
//        public void CrossFadeInFixedTime(string stateName, float transitionDuration)
//        {
//            float fixedTime = 0f;
//            int layer = -1;
//            this.CrossFadeInFixedTime(stateName, transitionDuration, layer, fixedTime);
//        }
//
//        [ExcludeFromDocs]
//        public void CrossFadeInFixedTime(int stateNameHash, float transitionDuration, int layer)
//        {
//            float fixedTime = 0f;
//            this.CrossFadeInFixedTime(stateNameHash, transitionDuration, layer, fixedTime);
//        }
//
//        [ExcludeFromDocs]
//        public void CrossFadeInFixedTime(string stateName, float transitionDuration, int layer)
//        {
//            float fixedTime = 0f;
//            this.CrossFadeInFixedTime(stateName, transitionDuration, layer, fixedTime);
//        }
//
//        
//        public extern void CrossFadeInFixedTime(int stateNameHash, float transitionDuration, [DefaultValue("-1")] int layer, [DefaultValue("0.0f")] float fixedTime);
//        public void CrossFadeInFixedTime(string stateName, float transitionDuration, [DefaultValue("-1")] int layer, [DefaultValue("0.0f")] float fixedTime)
//        {
//            this.CrossFadeInFixedTime(StringToHash(stateName), transitionDuration, layer, fixedTime);
//        }
//
//        
//        public extern AnimatorTransitionInfo GetAnimatorTransitionInfo(int layerIndex);
//        public bool GetBool(int id)
//        {
//            return this.GetBoolID(id);
//        }
//
//        public bool GetBool(string name)
//        {
//            return this.GetBoolString(name);
//        }
//
//        
//        private extern bool GetBoolID(int id);
//        
//        private extern bool GetBoolString(string name);
//        
//        public extern AnimatorClipInfo[] GetCurrentAnimatorClipInfo(int layerIndex);
//        
//        public extern AnimatorStateInfo GetCurrentAnimatorStateInfo(int layerIndex);
//        public float GetFloat(int id)
//        {
//            return this.GetFloatID(id);
//        }
//
//        public float GetFloat(string name)
//        {
//            return this.GetFloatString(name);
//        }
//
//        
//        private extern float GetFloatID(int id);
//        
//        private extern float GetFloatString(string name);
//        public int GetInteger(int id)
//        {
//            return this.GetIntegerID(id);
//        }
//
//        public int GetInteger(string name)
//        {
//            return this.GetIntegerString(name);
//        }
//
//        
//        private extern int GetIntegerID(int id);
//        
//        private extern int GetIntegerString(string name);
//        
//        public extern int GetLayerIndex(string layerName);
//        
//        public extern string GetLayerName(int layerIndex);
//        
//        public extern float GetLayerWeight(int layerIndex);
//        
//        public extern AnimatorClipInfo[] GetNextAnimatorClipInfo(int layerIndex);
//        
//        public extern AnimatorStateInfo GetNextAnimatorStateInfo(int layerIndex);
//        public AnimatorControllerParameter GetParameter(int index)
//        {
//            AnimatorControllerParameter[] parameters = this.parameters;
//            if ((index < 0) && (index >= this.parameters.Length))
//            {
//                throw new IndexOutOfRangeException("index");
//            }
//            return parameters[index];
//        }
//
//        
//        public extern bool HasState(int layerIndex, int stateID);
//        
//        private extern void InstantiateEnginePlayable(RuntimeAnimatorController controller);
//        
//        public extern bool IsInTransition(int layerIndex);
//        public bool IsParameterControlledByCurve(int id)
//        {
//            return this.IsParameterControlledByCurveID(id);
//        }
//
//        public bool IsParameterControlledByCurve(string name)
//        {
//            return this.IsParameterControlledByCurveString(name);
//        }
//
//        
//        private extern bool IsParameterControlledByCurveID(int id);
//        
//        private extern bool IsParameterControlledByCurveString(string name);
//        [ExcludeFromDocs]
//        public void Play(int stateNameHash)
//        {
//            float negativeInfinity = float.NegativeInfinity;
//            int layer = -1;
//            this.Play(stateNameHash, layer, negativeInfinity);
//        }
//
//        [ExcludeFromDocs]
//        public void Play(string stateName)
//        {
//            float negativeInfinity = float.NegativeInfinity;
//            int layer = -1;
//            this.Play(stateName, layer, negativeInfinity);
//        }
//
//        [ExcludeFromDocs]
//        public void Play(int stateNameHash, int layer)
//        {
//            float negativeInfinity = float.NegativeInfinity;
//            this.Play(stateNameHash, layer, negativeInfinity);
//        }
//
//        [ExcludeFromDocs]
//        public void Play(string stateName, int layer)
//        {
//            float negativeInfinity = float.NegativeInfinity;
//            this.Play(stateName, layer, negativeInfinity);
//        }
//
//        
//        public extern void Play(int stateNameHash, [DefaultValue("-1")] int layer, [DefaultValue("float.NegativeInfinity")] float normalizedTime);
//        public void Play(string stateName, [DefaultValue("-1")] int layer, [DefaultValue("float.NegativeInfinity")] float normalizedTime)
//        {
//            this.Play(StringToHash(stateName), layer, normalizedTime);
//        }
//
//        [ExcludeFromDocs]
//        public void PlayInFixedTime(int stateNameHash)
//        {
//            float negativeInfinity = float.NegativeInfinity;
//            int layer = -1;
//            this.PlayInFixedTime(stateNameHash, layer, negativeInfinity);
//        }
//
//        [ExcludeFromDocs]
//        public void PlayInFixedTime(string stateName)
//        {
//            float negativeInfinity = float.NegativeInfinity;
//            int layer = -1;
//            this.PlayInFixedTime(stateName, layer, negativeInfinity);
//        }
//
//        [ExcludeFromDocs]
//        public void PlayInFixedTime(int stateNameHash, int layer)
//        {
//            float negativeInfinity = float.NegativeInfinity;
//            this.PlayInFixedTime(stateNameHash, layer, negativeInfinity);
//        }
//
//        [ExcludeFromDocs]
//        public void PlayInFixedTime(string stateName, int layer)
//        {
//            float negativeInfinity = float.NegativeInfinity;
//            this.PlayInFixedTime(stateName, layer, negativeInfinity);
//        }
//
//        
//        public extern void PlayInFixedTime(int stateNameHash, [DefaultValue("-1")] int layer, [DefaultValue("float.NegativeInfinity")] float fixedTime);
//        public void PlayInFixedTime(string stateName, [DefaultValue("-1")] int layer, [DefaultValue("float.NegativeInfinity")] float fixedTime)
//        {
//            this.PlayInFixedTime(StringToHash(stateName), layer, fixedTime);
//        }
//
//        public override bool RemoveAllInputs()
//        {
//            Debug.LogError("AnimationClipPlayable doesn't support removing inputs");
//            return false;
//        }
//
//        public override bool RemoveInput(int index)
//        {
//            Debug.LogError("AnimationClipPlayable doesn't support removing inputs");
//            return false;
//        }
//
//        public override bool RemoveInput(AnimationPlayable playable)
//        {
//            Debug.LogError("AnimationClipPlayable doesn't support removing inputs");
//            return false;
//        }
//
//        public void ResetTrigger(int id)
//        {
//            this.ResetTriggerID(id);
//        }
//
//        public void ResetTrigger(string name)
//        {
//            this.ResetTriggerString(name);
//        }
//
//        
//        private extern void ResetTriggerID(int id);
//        
//        private extern void ResetTriggerString(string name);
//        
//        internal extern string ResolveHash(int hash);
//        public void SetBool(int id, bool value)
//        {
//            this.SetBoolID(id, value);
//        }
//
//        public void SetBool(string name, bool value)
//        {
//            this.SetBoolString(name, value);
//        }
//
//        
//        private extern void SetBoolID(int id, bool value);
//        
//        private extern void SetBoolString(string name, bool value);
//        public void SetFloat(int id, float value)
//        {
//            this.SetFloatID(id, value);
//        }
//
//        public void SetFloat(string name, float value)
//        {
//            this.SetFloatString(name, value);
//        }
//
//        
//        private extern void SetFloatID(int id, float value);
//        
//        private extern void SetFloatString(string name, float value);
//        public override bool SetInput(AnimationPlayable source, int index)
//        {
//            Debug.LogError("AnimationClipPlayable doesn't support setting inputs");
//            return false;
//        }
//
//        public override bool SetInputs(IEnumerable<AnimationPlayable> sources)
//        {
//            Debug.LogError("AnimationClipPlayable doesn't support setting inputs");
//            return false;
//        }
//
//        public void SetInteger(int id, int value)
//        {
//            this.SetIntegerID(id, value);
//        }
//
//        public void SetInteger(string name, int value)
//        {
//            this.SetIntegerString(name, value);
//        }
//
//        
//        private extern void SetIntegerID(int id, int value);
//        
//        private extern void SetIntegerString(string name, int value);
//        
//        public extern void SetLayerWeight(int layerIndex, float weight);
//        public void SetTrigger(int id)
//        {
//            this.SetTriggerID(id);
//        }
//
//        public void SetTrigger(string name)
//        {
//            this.SetTriggerString(name);
//        }
//
//        
//        private extern void SetTriggerID(int id);
//        
//        private extern void SetTriggerString(string name);
//        
//        private static extern int StringToHash(string name);
//
//        public RuntimeAnimatorController animatorController {  get; }
//
//        public int layerCount {  get; }
//
//        public int parameterCount {  get; }
//
//        private AnimatorControllerParameter[] parameters {  get; }
//    }
//}
//
