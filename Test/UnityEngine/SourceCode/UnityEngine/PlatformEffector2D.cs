﻿namespace UnityEngine
{
    using System;
    using System.Runtime.CompilerServices;

    public sealed class PlatformEffector2D : Effector2D
    {
        [Obsolete("PlatformEffector2D.oneWay has been deprecated. Use PlatformEffector2D.useOneWay instead (UnityUpgradable) -> useOneWay", true)]
        public bool oneWay
        {
            get
            {
                return this.useOneWay;
            }
            set
            {
                this.useOneWay = value;
            }
        }

        [Obsolete("PlatformEffector2D.sideAngleVariance has been deprecated. Use PlatformEffector2D.sideArc instead (UnityUpgradable) -> sideArc", true)]
        public float sideAngleVariance
        {
            get
            {
                return this.sideArc;
            }
            set
            {
                this.sideArc = value;
            }
        }

        public float sideArc {  get;  set; }

        [Obsolete("PlatformEffector2D.sideBounce has been deprecated. Use PlatformEffector2D.useSideBounce instead (UnityUpgradable) -> useSideBounce", true)]
        public bool sideBounce
        {
            get
            {
                return this.useSideBounce;
            }
            set
            {
                this.useSideBounce = value;
            }
        }

        [Obsolete("PlatformEffector2D.sideFriction has been deprecated. Use PlatformEffector2D.useSideFriction instead (UnityUpgradable) -> useSideFriction", true)]
        public bool sideFriction
        {
            get
            {
                return this.useSideFriction;
            }
            set
            {
                this.useSideFriction = value;
            }
        }

        public float surfaceArc {  get;  set; }

        public bool useOneWay {  get;  set; }

        public bool useOneWayGrouping {  get;  set; }

        public bool useSideBounce {  get;  set; }

        public bool useSideFriction {  get;  set; }
    }
}

