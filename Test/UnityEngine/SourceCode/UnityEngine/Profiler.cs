namespace UnityEngine
{
    using System;
    using System.Diagnostics;
    using System.Runtime.CompilerServices;

    public sealed class Profiler
    {
        
        public static extern void AddFramesFromFile(string file);
        [Conditional("ENABLE_PROFILER")]
        public static void BeginSample(string name)
        {
            BeginSampleOnly(name);
        }

        
        public static extern void BeginSample(string name, Object targetObject);
        
        private static extern void BeginSampleOnly(string name);
        
        public static extern void EndSample();
        
        public static extern uint GetMonoHeapSize();
        
        public static extern uint GetMonoUsedSize();
        
        public static extern int GetRuntimeMemorySize(Object o);
        
        public static extern uint GetTotalAllocatedMemory();
        
        public static extern uint GetTotalReservedMemory();
        
        public static extern uint GetTotalUnusedReservedMemory();

        public static bool enableBinaryLog {  get;  set; }

        public static bool enabled {  get;  set; }

        public static string logFile {  get;  set; }

        public static int maxNumberOfSamplesPerFrame {  get;  set; }

        public static bool supported {  get; }

        public static uint usedHeapSize {  get; }
    }
}

