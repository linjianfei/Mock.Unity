//namespace UnityEngine
//{
//    using System;
//    using System.Runtime.CompilerServices;
//
//    public sealed class ParticleRenderer : Renderer
//    {
//        [Obsolete("animatedTextureCount has been replaced by uvAnimationXTile and uvAnimationYTile.")]
//        public int animatedTextureCount
//        {
//            get
//            {
//                return this.uvAnimationXTile;
//            }
//            set
//            {
//                this.uvAnimationXTile = value;
//            }
//        }
//
//        public float cameraVelocityScale {  get;  set; }
//
//        [Obsolete("This function has been removed.", true)]
//        public AnimationCurve heightCurve
//        {
//            get
//            {
//                return null;
//            }
//            set
//            {
//            }
//        }
//
//        public float lengthScale {  get;  set; }
//
//        public float maxParticleSize {  get;  set; }
//
//        public float maxPartileSize
//        {
//            get
//            {
//                return this.maxParticleSize;
//            }
//            set
//            {
//                this.maxParticleSize = value;
//            }
//        }
//
//        public ParticleRenderMode particleRenderMode {  get;  set; }
//
//        [Obsolete("This function has been removed.", true)]
//        public AnimationCurve rotationCurve
//        {
//            get
//            {
//                return null;
//            }
//            set
//            {
//            }
//        }
//
//        public float uvAnimationCycles {  get;  set; }
//
//        public int uvAnimationXTile {  get;  set; }
//
//        public int uvAnimationYTile {  get;  set; }
//
//        public Rect[] uvTiles {  get;  set; }
//
//        public float velocityScale {  get;  set; }
//
//        [Obsolete("This function has been removed.", true)]
//        public AnimationCurve widthCurve
//        {
//            get
//            {
//                return null;
//            }
//            set
//            {
//            }
//        }
//    }
//}
//
