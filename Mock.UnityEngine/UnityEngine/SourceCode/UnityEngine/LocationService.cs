namespace UnityEngine
{
    using System;
    using System.Runtime.CompilerServices;
    using UnityEngine.Internal;

    public sealed class LocationService
    {
        [ExcludeFromDocs]
        public void Start()
        {
            float updateDistanceInMeters = 10f;
            float desiredAccuracyInMeters = 10f;
            this.Start(desiredAccuracyInMeters, updateDistanceInMeters);
        }

        [ExcludeFromDocs]
        public void Start(float desiredAccuracyInMeters)
        {
            float updateDistanceInMeters = 10f;
            this.Start(desiredAccuracyInMeters, updateDistanceInMeters);
        }

        
        public extern void Start([DefaultValue("10f")] float desiredAccuracyInMeters, [DefaultValue("10f")] float updateDistanceInMeters);
        
        public extern void Stop();

        public bool isEnabledByUser {  get; }

        public LocationInfo lastData {  get; }

        public LocationServiceStatus status {  get; }
    }
}

