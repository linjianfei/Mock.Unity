﻿//namespace UnityEngine
//{
//    using System;
//    using System.Runtime.InteropServices;
//
//    [StructLayout(LayoutKind.Sequential)]
//    public struct AnimatorStateInfo
//    {
//        private int m_Name;
//        private int m_Path;
//        private int m_FullPath;
//        private float m_NormalizedTime;
//        private float m_Length;
//        private float m_Speed;
//        private float m_SpeedMultiplier;
//        private int m_Tag;
//        private int m_Loop;
//        public bool IsName(string name)
//        {
//            int num = Animator.StringToHash(name);
//            return (((num == this.m_FullPath) || (num == this.m_Name)) || (num == this.m_Path));
//        }
//
//        public int fullPathHash
//        {
//            get
//            {
//                return this.m_FullPath;
//            }
//        }
//        [Obsolete("Use AnimatorStateInfo.fullPathHash instead.")]
//        public int nameHash
//        {
//            get
//            {
//                return this.m_Path;
//            }
//        }
//        public int shortNameHash
//        {
//            get
//            {
//                return this.m_Name;
//            }
//        }
//        public float normalizedTime
//        {
//            get
//            {
//                return this.m_NormalizedTime;
//            }
//        }
//        public float length
//        {
//            get
//            {
//                return this.m_Length;
//            }
//        }
//        public float speed
//        {
//            get
//            {
//                return this.m_Speed;
//            }
//        }
//        public float speedMultiplier
//        {
//            get
//            {
//                return this.m_SpeedMultiplier;
//            }
//        }
//        public int tagHash
//        {
//            get
//            {
//                return this.m_Tag;
//            }
//        }
//        public bool IsTag(string tag)
//        {
//            return (Animator.StringToHash(tag) == this.m_Tag);
//        }
//
//        public bool loop
//        {
//            get
//            {
//                return (this.m_Loop != 0);
//            }
//        }
//    }
//}
//
