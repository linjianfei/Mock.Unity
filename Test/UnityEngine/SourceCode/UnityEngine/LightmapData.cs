﻿namespace UnityEngine
{
    using System;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential)]
    public sealed class LightmapData
    {
        internal Texture2D m_Light;
        internal Texture2D m_Dir;
        public Texture2D lightmapFar
        {
            get
            {
                return this.m_Light;
            }
            set
            {
                this.m_Light = value;
            }
        }
        public Texture2D lightmapNear
        {
            get
            {
                return this.m_Dir;
            }
            set
            {
                this.m_Dir = value;
            }
        }
        public Texture2D lightmap
        {
            get
            {
                return null;
            }
            set
            {
            }
        }
    }
}

