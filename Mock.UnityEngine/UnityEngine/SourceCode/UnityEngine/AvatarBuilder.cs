//namespace UnityEngine
//{
//    using System;
//    using System.Runtime.CompilerServices;
//
//    public sealed class AvatarBuilder
//    {
//        
//        public static extern Avatar BuildGenericAvatar(GameObject go, string rootMotionTransformName);
//        public static Avatar BuildHumanAvatar(GameObject go, HumanDescription monoHumanDescription)
//        {
//            if (go == null)
//            {
//                throw new NullReferenceException();
//            }
//            return BuildHumanAvatarMono(go, monoHumanDescription);
//        }
//
//        private static Avatar BuildHumanAvatarMono(GameObject go, HumanDescription monoHumanDescription)
//        {
//            return INTERNAL_CALL_BuildHumanAvatarMono(go, ref monoHumanDescription);
//        }
//
//        
//        private static extern Avatar INTERNAL_CALL_BuildHumanAvatarMono(GameObject go, ref HumanDescription monoHumanDescription);
//    }
//}
//
