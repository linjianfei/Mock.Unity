//namespace UnityEngine
//{
//    using System;
//    using System.Runtime.CompilerServices;
//
//    public sealed class MovieTexture : Texture
//    {
//        
//        private static extern void INTERNAL_CALL_Pause(MovieTexture self);
//        
//        private static extern void INTERNAL_CALL_Play(MovieTexture self);
//        
//        private static extern void INTERNAL_CALL_Stop(MovieTexture self);
//        public void Pause()
//        {
//            INTERNAL_CALL_Pause(this);
//        }
//
//        public void Play()
//        {
//            INTERNAL_CALL_Play(this);
//        }
//
//        public void Stop()
//        {
//            INTERNAL_CALL_Stop(this);
//        }
//
//        public AudioClip audioClip {  get; }
//
//        public float duration {  get; }
//
//        public bool isPlaying {  get; }
//
//        public bool isReadyToPlay {  get; }
//
//        public bool loop {  get;  set; }
//    }
//}
//
