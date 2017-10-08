namespace UnityEngine.Experimental.Director
{
    using System;
    using System.Runtime.CompilerServices;
    using UnityEngine;

    public class DirectorPlayer : Behaviour
    {
        
        public extern double GetTime();
        
        public extern DirectorUpdateMode GetTimeUpdateMode();
        public void Play(Playable playable)
        {
            this.PlayInternal(playable, null);
        }

        public void Play(Playable playable, object customData)
        {
            this.PlayInternal(playable, customData);
        }

        
        private extern void PlayInternal(Playable playable, object customData);
        
        public extern void SetTime(double time);
        
        public extern void SetTimeUpdateMode(DirectorUpdateMode mode);
        
        public extern void Stop();
    }
}

