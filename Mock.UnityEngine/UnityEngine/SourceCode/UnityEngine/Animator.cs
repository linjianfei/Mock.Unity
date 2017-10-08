//namespace UnityEngine
//{
//    using System;
//    using System.Runtime.CompilerServices;
//    using System.Runtime.InteropServices;
//    using UnityEngine.Experimental.Director;
//    using UnityEngine.Internal;
//
//    public sealed class Animator : DirectorPlayer, IAnimatorControllerPlayable
//    {
//        
//        public extern void ApplyBuiltinRootMotion();
//        private void CheckIfInIKPass()
//        {
//            if (this.logWarnings && !this.CheckIfInIKPassInternal())
//            {
//                Debug.LogWarning("Setting and getting IK Goals, Lookat and BoneLocalRotation should only be done in OnAnimatorIK or OnStateIK");
//            }
//        }
//
//        
//        private extern bool CheckIfInIKPassInternal();
//        internal static T[] ConvertStateMachineBehaviour<T>(ScriptableObject[] rawObjects) where T: StateMachineBehaviour
//        {
//            if (rawObjects == null)
//            {
//                return null;
//            }
//            T[] localArray = new T[rawObjects.Length];
//            for (int i = 0; i < localArray.Length; i++)
//            {
//                localArray[i] = (T) rawObjects[i];
//            }
//            return localArray;
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
//        internal extern void EvaluateController();
//        [Obsolete("ForceStateNormalizedTime is deprecated. Please use Play or CrossFade instead.")]
//        public void ForceStateNormalizedTime(float normalizedTime)
//        {
//            this.Play(0, 0, normalizedTime);
//        }
//
//        
//        public extern AnimatorTransitionInfo GetAnimatorTransitionInfo(int layerIndex);
//        public T GetBehaviour<T>() where T: StateMachineBehaviour
//        {
//            return (this.GetBehaviour(typeof(T)) as T);
//        }
//
//        
//        internal extern ScriptableObject GetBehaviour(Type type);
//        public T[] GetBehaviours<T>() where T: StateMachineBehaviour
//        {
//            return ConvertStateMachineBehaviour<T>(this.GetBehaviours(typeof(T)));
//        }
//
//        
//        internal extern ScriptableObject[] GetBehaviours(Type type);
//        
//        public extern Transform GetBoneTransform(HumanBodyBones humanBoneId);
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
//        
//        internal extern string GetCurrentStateName(int layerIndex);
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
//        
//        internal extern float GetHintWeightPositionInternal(AvatarIKHint hint);
//        public Vector3 GetIKHintPosition(AvatarIKHint hint)
//        {
//            this.CheckIfInIKPass();
//            return this.GetIKHintPositionInternal(hint);
//        }
//
//        
//        internal extern Vector3 GetIKHintPositionInternal(AvatarIKHint hint);
//        public float GetIKHintPositionWeight(AvatarIKHint hint)
//        {
//            this.CheckIfInIKPass();
//            return this.GetHintWeightPositionInternal(hint);
//        }
//
//        public Vector3 GetIKPosition(AvatarIKGoal goal)
//        {
//            this.CheckIfInIKPass();
//            return this.GetIKPositionInternal(goal);
//        }
//
//        
//        internal extern Vector3 GetIKPositionInternal(AvatarIKGoal goal);
//        public float GetIKPositionWeight(AvatarIKGoal goal)
//        {
//            this.CheckIfInIKPass();
//            return this.GetIKPositionWeightInternal(goal);
//        }
//
//        
//        internal extern float GetIKPositionWeightInternal(AvatarIKGoal goal);
//        public Quaternion GetIKRotation(AvatarIKGoal goal)
//        {
//            this.CheckIfInIKPass();
//            return this.GetIKRotationInternal(goal);
//        }
//
//        
//        internal extern Quaternion GetIKRotationInternal(AvatarIKGoal goal);
//        public float GetIKRotationWeight(AvatarIKGoal goal)
//        {
//            this.CheckIfInIKPass();
//            return this.GetIKRotationWeightInternal(goal);
//        }
//
//        
//        internal extern float GetIKRotationWeightInternal(AvatarIKGoal goal);
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
//        
//        internal extern string GetNextStateName(int layerIndex);
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
//        [Obsolete("GetQuaternion is deprecated.")]
//        public Quaternion GetQuaternion(int id)
//        {
//            return Quaternion.identity;
//        }
//
//        [Obsolete("GetQuaternion is deprecated.")]
//        public Quaternion GetQuaternion(string name)
//        {
//            return Quaternion.identity;
//        }
//
//        
//        internal extern string GetStats();
//        [Obsolete("GetVector is deprecated.")]
//        public Vector3 GetVector(int id)
//        {
//            return Vector3.zero;
//        }
//
//        [Obsolete("GetVector is deprecated.")]
//        public Vector3 GetVector(string name)
//        {
//            return Vector3.zero;
//        }
//
//        
//        public extern bool HasState(int layerIndex, int stateID);
//        
//        private static extern void INTERNAL_CALL_MatchTarget(Animator self, ref Vector3 matchPosition, ref Quaternion matchRotation, AvatarTarget targetBodyPart, ref MatchTargetWeightMask weightMask, float startNormalizedTime, float targetNormalizedTime);
//        
//        private static extern void INTERNAL_CALL_SetBoneLocalRotationInternal(Animator self, HumanBodyBones humanBoneId, ref Quaternion rotation);
//        
//        private static extern void INTERNAL_CALL_SetIKHintPositionInternal(Animator self, AvatarIKHint hint, ref Vector3 hintPosition);
//        
//        private static extern void INTERNAL_CALL_SetIKPositionInternal(Animator self, AvatarIKGoal goal, ref Vector3 goalPosition);
//        
//        private static extern void INTERNAL_CALL_SetIKRotationInternal(Animator self, AvatarIKGoal goal, ref Quaternion goalRotation);
//        
//        private static extern void INTERNAL_CALL_SetLookAtPositionInternal(Animator self, ref Vector3 lookAtPosition);
//        
//        private extern void INTERNAL_get_angularVelocity(out Vector3 value);
//        
//        private extern void INTERNAL_get_bodyPosition(out Vector3 value);
//        
//        private extern void INTERNAL_get_bodyRotation(out Quaternion value);
//        
//        private extern void INTERNAL_get_deltaPosition(out Vector3 value);
//        
//        private extern void INTERNAL_get_deltaRotation(out Quaternion value);
//        
//        private extern void INTERNAL_get_pivotPosition(out Vector3 value);
//        
//        private extern void INTERNAL_get_rootPosition(out Vector3 value);
//        
//        private extern void INTERNAL_get_rootRotation(out Quaternion value);
//        
//        private extern void INTERNAL_get_targetPosition(out Vector3 value);
//        
//        private extern void INTERNAL_get_targetRotation(out Quaternion value);
//        
//        private extern void INTERNAL_get_velocity(out Vector3 value);
//        
//        private extern void INTERNAL_set_bodyPosition(ref Vector3 value);
//        
//        private extern void INTERNAL_set_bodyRotation(ref Quaternion value);
//        
//        private extern void INTERNAL_set_rootPosition(ref Vector3 value);
//        
//        private extern void INTERNAL_set_rootRotation(ref Quaternion value);
//        [ExcludeFromDocs]
//        public void InterruptMatchTarget()
//        {
//            bool completeMatch = true;
//            this.InterruptMatchTarget(completeMatch);
//        }
//
//        
//        public extern void InterruptMatchTarget([DefaultValue("true")] bool completeMatch);
//        
//        internal extern bool IsBoneTransform(Transform transform);
//        
//        public extern bool IsControlled(Transform transform);
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
//        public void MatchTarget(Vector3 matchPosition, Quaternion matchRotation, AvatarTarget targetBodyPart, MatchTargetWeightMask weightMask, float startNormalizedTime)
//        {
//            float targetNormalizedTime = 1f;
//            INTERNAL_CALL_MatchTarget(this, ref matchPosition, ref matchRotation, targetBodyPart, ref weightMask, startNormalizedTime, targetNormalizedTime);
//        }
//
//        public void MatchTarget(Vector3 matchPosition, Quaternion matchRotation, AvatarTarget targetBodyPart, MatchTargetWeightMask weightMask, float startNormalizedTime, [DefaultValue("1")] float targetNormalizedTime)
//        {
//            INTERNAL_CALL_MatchTarget(this, ref matchPosition, ref matchRotation, targetBodyPart, ref weightMask, startNormalizedTime, targetNormalizedTime);
//        }
//
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
//        
//        public extern void Rebind();
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
//        public void SetBoneLocalRotation(HumanBodyBones humanBoneId, Quaternion rotation)
//        {
//            this.CheckIfInIKPass();
//            this.SetBoneLocalRotationInternal(humanBoneId, rotation);
//        }
//
//        internal void SetBoneLocalRotationInternal(HumanBodyBones humanBoneId, Quaternion rotation)
//        {
//            INTERNAL_CALL_SetBoneLocalRotationInternal(this, humanBoneId, ref rotation);
//        }
//
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
//        public void SetFloat(int id, float value, float dampTime, float deltaTime)
//        {
//            this.SetFloatIDDamp(id, value, dampTime, deltaTime);
//        }
//
//        public void SetFloat(string name, float value, float dampTime, float deltaTime)
//        {
//            this.SetFloatStringDamp(name, value, dampTime, deltaTime);
//        }
//
//        
//        private extern void SetFloatID(int id, float value);
//        
//        private extern void SetFloatIDDamp(int id, float value, float dampTime, float deltaTime);
//        
//        private extern void SetFloatString(string name, float value);
//        
//        private extern void SetFloatStringDamp(string name, float value, float dampTime, float deltaTime);
//        public void SetIKHintPosition(AvatarIKHint hint, Vector3 hintPosition)
//        {
//            this.CheckIfInIKPass();
//            this.SetIKHintPositionInternal(hint, hintPosition);
//        }
//
//        internal void SetIKHintPositionInternal(AvatarIKHint hint, Vector3 hintPosition)
//        {
//            INTERNAL_CALL_SetIKHintPositionInternal(this, hint, ref hintPosition);
//        }
//
//        public void SetIKHintPositionWeight(AvatarIKHint hint, float value)
//        {
//            this.CheckIfInIKPass();
//            this.SetIKHintPositionWeightInternal(hint, value);
//        }
//
//        
//        internal extern void SetIKHintPositionWeightInternal(AvatarIKHint hint, float value);
//        public void SetIKPosition(AvatarIKGoal goal, Vector3 goalPosition)
//        {
//            this.CheckIfInIKPass();
//            this.SetIKPositionInternal(goal, goalPosition);
//        }
//
//        internal void SetIKPositionInternal(AvatarIKGoal goal, Vector3 goalPosition)
//        {
//            INTERNAL_CALL_SetIKPositionInternal(this, goal, ref goalPosition);
//        }
//
//        public void SetIKPositionWeight(AvatarIKGoal goal, float value)
//        {
//            this.CheckIfInIKPass();
//            this.SetIKPositionWeightInternal(goal, value);
//        }
//
//        
//        internal extern void SetIKPositionWeightInternal(AvatarIKGoal goal, float value);
//        public void SetIKRotation(AvatarIKGoal goal, Quaternion goalRotation)
//        {
//            this.CheckIfInIKPass();
//            this.SetIKRotationInternal(goal, goalRotation);
//        }
//
//        internal void SetIKRotationInternal(AvatarIKGoal goal, Quaternion goalRotation)
//        {
//            INTERNAL_CALL_SetIKRotationInternal(this, goal, ref goalRotation);
//        }
//
//        public void SetIKRotationWeight(AvatarIKGoal goal, float value)
//        {
//            this.CheckIfInIKPass();
//            this.SetIKRotationWeightInternal(goal, value);
//        }
//
//        
//        internal extern void SetIKRotationWeightInternal(AvatarIKGoal goal, float value);
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
//        public void SetLookAtPosition(Vector3 lookAtPosition)
//        {
//            this.CheckIfInIKPass();
//            this.SetLookAtPositionInternal(lookAtPosition);
//        }
//
//        internal void SetLookAtPositionInternal(Vector3 lookAtPosition)
//        {
//            INTERNAL_CALL_SetLookAtPositionInternal(this, ref lookAtPosition);
//        }
//
//        [ExcludeFromDocs]
//        public void SetLookAtWeight(float weight)
//        {
//            float clampWeight = 0.5f;
//            float eyesWeight = 0f;
//            float headWeight = 1f;
//            float bodyWeight = 0f;
//            this.SetLookAtWeight(weight, bodyWeight, headWeight, eyesWeight, clampWeight);
//        }
//
//        [ExcludeFromDocs]
//        public void SetLookAtWeight(float weight, float bodyWeight)
//        {
//            float clampWeight = 0.5f;
//            float eyesWeight = 0f;
//            float headWeight = 1f;
//            this.SetLookAtWeight(weight, bodyWeight, headWeight, eyesWeight, clampWeight);
//        }
//
//        [ExcludeFromDocs]
//        public void SetLookAtWeight(float weight, float bodyWeight, float headWeight)
//        {
//            float clampWeight = 0.5f;
//            float eyesWeight = 0f;
//            this.SetLookAtWeight(weight, bodyWeight, headWeight, eyesWeight, clampWeight);
//        }
//
//        [ExcludeFromDocs]
//        public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight)
//        {
//            float clampWeight = 0.5f;
//            this.SetLookAtWeight(weight, bodyWeight, headWeight, eyesWeight, clampWeight);
//        }
//
//        public void SetLookAtWeight(float weight, [DefaultValue("0.00f")] float bodyWeight, [DefaultValue("1.00f")] float headWeight, [DefaultValue("0.00f")] float eyesWeight, [DefaultValue("0.50f")] float clampWeight)
//        {
//            this.CheckIfInIKPass();
//            this.SetLookAtWeightInternal(weight, bodyWeight, headWeight, eyesWeight, clampWeight);
//        }
//
//        [ExcludeFromDocs]
//        internal void SetLookAtWeightInternal(float weight)
//        {
//            float clampWeight = 0.5f;
//            float eyesWeight = 0f;
//            float headWeight = 1f;
//            float bodyWeight = 0f;
//            this.SetLookAtWeightInternal(weight, bodyWeight, headWeight, eyesWeight, clampWeight);
//        }
//
//        [ExcludeFromDocs]
//        internal void SetLookAtWeightInternal(float weight, float bodyWeight)
//        {
//            float clampWeight = 0.5f;
//            float eyesWeight = 0f;
//            float headWeight = 1f;
//            this.SetLookAtWeightInternal(weight, bodyWeight, headWeight, eyesWeight, clampWeight);
//        }
//
//        [ExcludeFromDocs]
//        internal void SetLookAtWeightInternal(float weight, float bodyWeight, float headWeight)
//        {
//            float clampWeight = 0.5f;
//            float eyesWeight = 0f;
//            this.SetLookAtWeightInternal(weight, bodyWeight, headWeight, eyesWeight, clampWeight);
//        }
//
//        [ExcludeFromDocs]
//        internal void SetLookAtWeightInternal(float weight, float bodyWeight, float headWeight, float eyesWeight)
//        {
//            float clampWeight = 0.5f;
//            this.SetLookAtWeightInternal(weight, bodyWeight, headWeight, eyesWeight, clampWeight);
//        }
//
//        
//        internal extern void SetLookAtWeightInternal(float weight, [DefaultValue("0.00f")] float bodyWeight, [DefaultValue("1.00f")] float headWeight, [DefaultValue("0.00f")] float eyesWeight, [DefaultValue("0.50f")] float clampWeight);
//        [Obsolete("SetQuaternion is deprecated.")]
//        public void SetQuaternion(int id, Quaternion value)
//        {
//        }
//
//        [Obsolete("SetQuaternion is deprecated.")]
//        public void SetQuaternion(string name, Quaternion value)
//        {
//        }
//
//        
//        public extern void SetTarget(AvatarTarget targetIndex, float targetNormalizedTime);
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
//        [Obsolete("SetVector is deprecated.")]
//        public void SetVector(int id, Vector3 value)
//        {
//        }
//
//        [Obsolete("SetVector is deprecated.")]
//        public void SetVector(string name, Vector3 value)
//        {
//        }
//
//        
//        public extern void StartPlayback();
//        
//        public extern void StartRecording(int frameCount);
//        
//        public extern void StopPlayback();
//        
//        public extern void StopRecording();
//        
//        public static extern int StringToHash(string name);
//        
//        public extern void Update(float deltaTime);
//        
//        internal extern void WriteDefaultPose();
//
//        internal bool allowConstantClipSamplingOptimization {  get;  set; }
//
//        public Vector3 angularVelocity
//        {
//            get
//            {
//                Vector3 vector;
//                this.INTERNAL_get_angularVelocity(out vector);
//                return vector;
//            }
//        }
//
//        [Obsolete("Use Animator.updateMode instead")]
//        public bool animatePhysics
//        {
//            get
//            {
//                return (this.updateMode == AnimatorUpdateMode.AnimatePhysics);
//            }
//            set
//            {
//                this.updateMode = !value ? AnimatorUpdateMode.Normal : AnimatorUpdateMode.AnimatePhysics;
//            }
//        }
//
//        public bool applyRootMotion {  get;  set; }
//
//        public Avatar avatar {  get;  set; }
//
//        internal Transform avatarRoot {  get; }
//
//        public Vector3 bodyPosition
//        {
//            get
//            {
//                Vector3 vector;
//                this.INTERNAL_get_bodyPosition(out vector);
//                return vector;
//            }
//            set
//            {
//                this.INTERNAL_set_bodyPosition(ref value);
//            }
//        }
//
//        public Quaternion bodyRotation
//        {
//            get
//            {
//                Quaternion quaternion;
//                this.INTERNAL_get_bodyRotation(out quaternion);
//                return quaternion;
//            }
//            set
//            {
//                this.INTERNAL_set_bodyRotation(ref value);
//            }
//        }
//
//        public AnimatorCullingMode cullingMode {  get;  set; }
//
//        public Vector3 deltaPosition
//        {
//            get
//            {
//                Vector3 vector;
//                this.INTERNAL_get_deltaPosition(out vector);
//                return vector;
//            }
//        }
//
//        public Quaternion deltaRotation
//        {
//            get
//            {
//                Quaternion quaternion;
//                this.INTERNAL_get_deltaRotation(out quaternion);
//                return quaternion;
//            }
//        }
//
//        public float feetPivotActive {  get;  set; }
//
//        public bool fireEvents {  get;  set; }
//
//        public float gravityWeight {  get; }
//
//        public bool hasRootMotion {  get; }
//
//        public bool hasTransformHierarchy {  get; }
//
//        public float humanScale {  get; }
//
//        public bool isHuman {  get; }
//
//        public bool isInitialized {  get; }
//
//        public bool isMatchingTarget {  get; }
//
//        public bool isOptimizable {  get; }
//
//        internal bool isRootPositionOrRotationControlledByCurves {  get; }
//
//        public int layerCount {  get; }
//
//        public bool layersAffectMassCenter {  get;  set; }
//
//        public float leftFeetBottomHeight {  get; }
//
//        public bool linearVelocityBlending {  get;  set; }
//
//        public bool logWarnings {  get;  set; }
//
//        public int parameterCount {  get; }
//
//        public AnimatorControllerParameter[] parameters {  get; }
//
//        public Vector3 pivotPosition
//        {
//            get
//            {
//                Vector3 vector;
//                this.INTERNAL_get_pivotPosition(out vector);
//                return vector;
//            }
//        }
//
//        public float pivotWeight {  get; }
//
//        public float playbackTime {  get;  set; }
//
//        public AnimatorRecorderMode recorderMode {  get; }
//
//        public float recorderStartTime {  get;  set; }
//
//        public float recorderStopTime {  get;  set; }
//
//        public float rightFeetBottomHeight {  get; }
//
//        public Vector3 rootPosition
//        {
//            get
//            {
//                Vector3 vector;
//                this.INTERNAL_get_rootPosition(out vector);
//                return vector;
//            }
//            set
//            {
//                this.INTERNAL_set_rootPosition(ref value);
//            }
//        }
//
//        public Quaternion rootRotation
//        {
//            get
//            {
//                Quaternion quaternion;
//                this.INTERNAL_get_rootRotation(out quaternion);
//                return quaternion;
//            }
//            set
//            {
//                this.INTERNAL_set_rootRotation(ref value);
//            }
//        }
//
//        public RuntimeAnimatorController runtimeAnimatorController {  get;  set; }
//
//        public float speed {  get;  set; }
//
//        public bool stabilizeFeet {  get;  set; }
//
//        internal bool supportsOnAnimatorMove {  get; }
//
//        public Vector3 targetPosition
//        {
//            get
//            {
//                Vector3 vector;
//                this.INTERNAL_get_targetPosition(out vector);
//                return vector;
//            }
//        }
//
//        public Quaternion targetRotation
//        {
//            get
//            {
//                Quaternion quaternion;
//                this.INTERNAL_get_targetRotation(out quaternion);
//                return quaternion;
//            }
//        }
//
//        public AnimatorUpdateMode updateMode {  get;  set; }
//
//        public Vector3 velocity
//        {
//            get
//            {
//                Vector3 vector;
//                this.INTERNAL_get_velocity(out vector);
//                return vector;
//            }
//        }
//    }
//}
//
