﻿//namespace UnityEngine
//{
//    using System;
//    using System.Runtime.CompilerServices;
//    using System.Runtime.InteropServices;
//
//    public class AnchoredJoint2D : Joint2D
//    {
//        private extern void INTERNAL_get_anchor(out Vector2 value);
//        private extern void INTERNAL_get_connectedAnchor(out Vector2 value);
//        private extern void INTERNAL_set_anchor(ref Vector2 value);
//        private extern void INTERNAL_set_connectedAnchor(ref Vector2 value);
//
//        public Vector2 anchor
//        {
//            get
//            {
//                Vector2 vector;
//                this.INTERNAL_get_anchor(out vector);
//                return vector;
//            }
//            set
//            {
//                this.INTERNAL_set_anchor(ref value);
//            }
//        }
//
//        public Vector2 connectedAnchor
//        {
//            get
//            {
//                Vector2 vector;
//                this.INTERNAL_get_connectedAnchor(out vector);
//                return vector;
//            }
//            set
//            {
//                this.INTERNAL_set_connectedAnchor(ref value);
//            }
//        }
//    }
//}

