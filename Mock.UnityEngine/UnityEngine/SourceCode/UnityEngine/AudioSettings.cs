namespace UnityEngine
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    public sealed class AudioSettings
    {
        public static  event AudioConfigurationChangeHandler OnAudioConfigurationChanged;

        
        public static extern AudioConfiguration GetConfiguration();
        
        public static extern void GetDSPBufferSize(out int bufferLength, out int numBuffers);
        
        private static extern bool INTERNAL_CALL_Reset(ref AudioConfiguration config);
        internal static void InvokeOnAudioConfigurationChanged(bool deviceWasChanged)
        {
            if (OnAudioConfigurationChanged != null)
            {
                OnAudioConfigurationChanged(deviceWasChanged);
            }
        }

        public static bool Reset(AudioConfiguration config)
        {
            return INTERNAL_CALL_Reset(ref config);
        }

        
        public static extern void SetDSPBufferSize(int bufferLength, int numBuffers);

        public static AudioSpeakerMode driverCapabilities {  get; }

        public static AudioSpeakerMode driverCaps
        {
            get
            {
                return driverCapabilities;
            }
        }

        public static double dspTime {  get; }

        internal static bool editingInPlaymode {  get;  set; }

        public static int outputSampleRate {  get;  set; }

        public static AudioSpeakerMode speakerMode {  get;  set; }

        public delegate void AudioConfigurationChangeHandler(bool deviceWasChanged);
    }
}

