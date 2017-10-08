//namespace UnityEngine
//{
//    using System;
//    using System.ComponentModel;
//    using System.Runtime.CompilerServices;
//    using System.Runtime.InteropServices;
//    using UnityEngine.Audio;
//    using UnityEngine.Internal;
//
//    public sealed class AudioSource : Behaviour
//    {
//        
//        public extern AnimationCurve GetCustomCurve(AudioSourceCurveType type);
//        [Obsolete("GetOutputData return a float[] is deprecated, use GetOutputData passing a pre allocated array instead.")]
//        public float[] GetOutputData(int numSamples, int channel)
//        {
//            float[] samples = new float[numSamples];
//            this.GetOutputDataHelper(samples, channel);
//            return samples;
//        }
//
//        public void GetOutputData(float[] samples, int channel)
//        {
//            this.GetOutputDataHelper(samples, channel);
//        }
//
//        
//        private extern void GetOutputDataHelper(float[] samples, int channel);
//        
//        public extern bool GetSpatializerFloat(int index, out float value);
//        [Obsolete("GetSpectrumData returning a float[] is deprecated, use GetSpectrumData passing a pre allocated array instead.")]
//        public float[] GetSpectrumData(int numSamples, int channel, FFTWindow window)
//        {
//            float[] samples = new float[numSamples];
//            this.GetSpectrumDataHelper(samples, channel, window);
//            return samples;
//        }
//
//        public void GetSpectrumData(float[] samples, int channel, FFTWindow window)
//        {
//            this.GetSpectrumDataHelper(samples, channel, window);
//        }
//
//        
//        private extern void GetSpectrumDataHelper(float[] samples, int channel, FFTWindow window);
//        
//        private static extern void INTERNAL_CALL_Pause(AudioSource self);
//        
//        private static extern void INTERNAL_CALL_UnPause(AudioSource self);
//        public void Pause()
//        {
//            INTERNAL_CALL_Pause(this);
//        }
//
//        [ExcludeFromDocs]
//        public void Play()
//        {
//            ulong delay = 0L;
//            this.Play(delay);
//        }
//
//        
//        public extern void Play([DefaultValue("0")] ulong delay);
//        [ExcludeFromDocs]
//        public static void PlayClipAtPoint(AudioClip clip, Vector3 position)
//        {
//            float volume = 1f;
//            PlayClipAtPoint(clip, position, volume);
//        }
//
//        public static void PlayClipAtPoint(AudioClip clip, Vector3 position, [DefaultValue("1.0F")] float volume)
//        {
//            GameObject obj2 = new GameObject("One shot audio") {
//                transform = { position = position }
//            };
//            AudioSource source = (AudioSource) obj2.AddComponent(typeof(AudioSource));
//            source.clip = clip;
//            source.spatialBlend = 1f;
//            source.volume = volume;
//            source.Play();
//            Object.Destroy(obj2, clip.length * ((Time.timeScale >= 0.01f) ? Time.timeScale : 0.01f));
//        }
//
//        
//        public extern void PlayDelayed(float delay);
//        [ExcludeFromDocs]
//        public void PlayOneShot(AudioClip clip)
//        {
//            float volumeScale = 1f;
//            this.PlayOneShot(clip, volumeScale);
//        }
//
//        
//        public extern void PlayOneShot(AudioClip clip, [DefaultValue("1.0F")] float volumeScale);
//        
//        public extern void PlayScheduled(double time);
//        
//        public extern void SetCustomCurve(AudioSourceCurveType type, AnimationCurve curve);
//        
//        public extern void SetScheduledEndTime(double time);
//        
//        public extern void SetScheduledStartTime(double time);
//        
//        public extern bool SetSpatializerFloat(int index, float value);
//        
//        public extern void Stop();
//        public void UnPause()
//        {
//            INTERNAL_CALL_UnPause(this);
//        }
//
//        public bool bypassEffects {  get;  set; }
//
//        public bool bypassListenerEffects {  get;  set; }
//
//        public bool bypassReverbZones {  get;  set; }
//
//        public AudioClip clip {  get;  set; }
//
//        public float dopplerLevel {  get;  set; }
//
//        public bool ignoreListenerPause {  get;  set; }
//
//        public bool ignoreListenerVolume {  get;  set; }
//
//        public bool isPlaying {  get; }
//
//        public bool loop {  get;  set; }
//
//        public float maxDistance {  get;  set; }
//
//        [Obsolete("maxVolume is not supported anymore. Use min-, maxDistance and rolloffMode instead.", true)]
//        public float maxVolume {  get;  set; }
//
//        public float minDistance {  get;  set; }
//
//        [Obsolete("minVolume is not supported anymore. Use min-, maxDistance and rolloffMode instead.", true)]
//        public float minVolume {  get;  set; }
//
//        public bool mute {  get;  set; }
//
//        public AudioMixerGroup outputAudioMixerGroup {  get;  set; }
//
//        [EditorBrowsable(EditorBrowsableState.Never), Obsolete("AudioSource.pan has been deprecated. Use AudioSource.panStereo instead (UnityUpgradable) -> panStereo", true)]
//        public float pan
//        {
//            get
//            {
//                return this.panStereo;
//            }
//            set
//            {
//            }
//        }
//
//        [Obsolete("AudioSource.panLevel has been deprecated. Use AudioSource.spatialBlend instead (UnityUpgradable) -> spatialBlend", true), EditorBrowsable(EditorBrowsableState.Never)]
//        public float panLevel
//        {
//            get
//            {
//                return this.spatialBlend;
//            }
//            set
//            {
//            }
//        }
//
//        public float panStereo {  get;  set; }
//
//        public float pitch {  get;  set; }
//
//        public bool playOnAwake {  get;  set; }
//
//        public int priority {  get;  set; }
//
//        public float reverbZoneMix {  get;  set; }
//
//        [Obsolete("rolloffFactor is not supported anymore. Use min-, maxDistance and rolloffMode instead.", true)]
//        public float rolloffFactor {  get;  set; }
//
//        public AudioRolloffMode rolloffMode {  get;  set; }
//
//        public float spatialBlend {  get;  set; }
//
//        public bool spatialize {  get;  set; }
//
//        public float spread {  get;  set; }
//
//        public float time {  get;  set; }
//
//        public int timeSamples {  get;  set; }
//
//        public AudioVelocityUpdateMode velocityUpdateMode {  get;  set; }
//
//        public float volume {  get;  set; }
//    }
//}
//
