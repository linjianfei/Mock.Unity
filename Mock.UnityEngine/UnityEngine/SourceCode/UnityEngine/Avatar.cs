//namespace UnityEngine
//{
//    using System;
//    using System.Runtime.CompilerServices;
//
//    public sealed class Avatar : Object
//    {
//        private Avatar()
//        {
//        }
//
//        
//        internal extern float GetAxisLength(int humanId);
//        
//        internal extern Vector3 GetLimitSign(int humanId);
//        
//        internal extern Quaternion GetPostRotation(int humanId);
//        
//        internal extern Quaternion GetPreRotation(int humanId);
//        internal Quaternion GetZYPostQ(int humanId, Quaternion parentQ, Quaternion q)
//        {
//            return INTERNAL_CALL_GetZYPostQ(this, humanId, ref parentQ, ref q);
//        }
//
//        internal Quaternion GetZYRoll(int humanId, Vector3 uvw)
//        {
//            return INTERNAL_CALL_GetZYRoll(this, humanId, ref uvw);
//        }
//
//        
//        private static extern Quaternion INTERNAL_CALL_GetZYPostQ(Avatar self, int humanId, ref Quaternion parentQ, ref Quaternion q);
//        
//        private static extern Quaternion INTERNAL_CALL_GetZYRoll(Avatar self, int humanId, ref Vector3 uvw);
//        
//        internal extern void SetMuscleMinMax(int muscleId, float min, float max);
//        
//        internal extern void SetParameter(int parameterId, float value);
//
//        public bool isHuman {  get; }
//
//        public bool isValid {  get; }
//    }
//}
//
