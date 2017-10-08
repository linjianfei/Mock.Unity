//namespace UnityEngine
//{
//    using System;
//    using System.Runtime.CompilerServices;
//    using System.Runtime.InteropServices;
//
//    public sealed class Microphone
//    {
//        
//        public static extern void End(string deviceName);
//        
//        public static extern void GetDeviceCaps(string deviceName, out int minFreq, out int maxFreq);
//        
//        public static extern int GetPosition(string deviceName);
//        
//        public static extern bool IsRecording(string deviceName);
//        
//        public static extern AudioClip Start(string deviceName, bool loop, int lengthSec, int frequency);
//
//        public static string[] devices {  get; }
//    }
//}
//
