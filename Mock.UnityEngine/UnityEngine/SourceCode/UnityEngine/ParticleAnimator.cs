﻿//namespace UnityEngine
//{
//    using System;
//    using System.Runtime.CompilerServices;
//    using System.Runtime.InteropServices;
//
//    public sealed class ParticleAnimator : Component
//    {
//        
//        private extern void INTERNAL_get_force(out Vector3 value);
//        
//        private extern void INTERNAL_get_localRotationAxis(out Vector3 value);
//        
//        private extern void INTERNAL_get_rndForce(out Vector3 value);
//        
//        private extern void INTERNAL_get_worldRotationAxis(out Vector3 value);
//        
//        private extern void INTERNAL_set_force(ref Vector3 value);
//        
//        private extern void INTERNAL_set_localRotationAxis(ref Vector3 value);
//        
//        private extern void INTERNAL_set_rndForce(ref Vector3 value);
//        
//        private extern void INTERNAL_set_worldRotationAxis(ref Vector3 value);
//
//        public bool autodestruct {  get;  set; }
//
//        public Color[] colorAnimation {  get;  set; }
//
//        public float damping {  get;  set; }
//
//        public bool doesAnimateColor {  get;  set; }
//
//        public Vector3 force
//        {
//            get
//            {
//                Vector3 vector;
//                this.INTERNAL_get_force(out vector);
//                return vector;
//            }
//            set
//            {
//                this.INTERNAL_set_force(ref value);
//            }
//        }
//
//        public Vector3 localRotationAxis
//        {
//            get
//            {
//                Vector3 vector;
//                this.INTERNAL_get_localRotationAxis(out vector);
//                return vector;
//            }
//            set
//            {
//                this.INTERNAL_set_localRotationAxis(ref value);
//            }
//        }
//
//        public Vector3 rndForce
//        {
//            get
//            {
//                Vector3 vector;
//                this.INTERNAL_get_rndForce(out vector);
//                return vector;
//            }
//            set
//            {
//                this.INTERNAL_set_rndForce(ref value);
//            }
//        }
//
//        public float sizeGrow {  get;  set; }
//
//        public Vector3 worldRotationAxis
//        {
//            get
//            {
//                Vector3 vector;
//                this.INTERNAL_get_worldRotationAxis(out vector);
//                return vector;
//            }
//            set
//            {
//                this.INTERNAL_set_worldRotationAxis(ref value);
//            }
//        }
//    }
//}
//
