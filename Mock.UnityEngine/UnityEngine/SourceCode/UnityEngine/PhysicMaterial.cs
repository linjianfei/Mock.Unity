//namespace UnityEngine
//{
//    using System;
//    using System.Runtime.CompilerServices;
//
//    public sealed class PhysicMaterial : Object
//    {
//        public PhysicMaterial()
//        {
//            Internal_CreateDynamicsMaterial(this, null);
//        }
//
//        public PhysicMaterial(string name)
//        {
//            Internal_CreateDynamicsMaterial(this, name);
//        }
//
//        
//        private static extern void Internal_CreateDynamicsMaterial([Writable] PhysicMaterial mat, string name);
//
//        public PhysicMaterialCombine bounceCombine {  get;  set; }
//
//        public float bounciness {  get;  set; }
//
//        [Obsolete("Use PhysicMaterial.bounciness instead", true)]
//        public float bouncyness
//        {
//            get
//            {
//                return this.bounciness;
//            }
//            set
//            {
//                this.bounciness = value;
//            }
//        }
//
//        public float dynamicFriction {  get;  set; }
//
//        [Obsolete("Anisotropic friction is no longer supported since Unity 5.0.", true)]
//        public float dynamicFriction2 {  get;  set; }
//
//        public PhysicMaterialCombine frictionCombine {  get;  set; }
//
//        [Obsolete("Anisotropic friction is no longer supported since Unity 5.0.", true)]
//        public Vector3 frictionDirection
//        {
//            get
//            {
//                return Vector3.zero;
//            }
//            set
//            {
//            }
//        }
//
//        [Obsolete("Anisotropic friction is no longer supported since Unity 5.0.", true)]
//        public Vector3 frictionDirection2
//        {
//            get
//            {
//                return Vector3.zero;
//            }
//            set
//            {
//            }
//        }
//
//        public float staticFriction {  get;  set; }
//
//        [Obsolete("Anisotropic friction is no longer supported since Unity 5.0.", true)]
//        public float staticFriction2 {  get;  set; }
//    }
//}
//
