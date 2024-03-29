﻿namespace UnityEngine
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential)]
    public struct LayerMask
    {
        private int m_Mask;
        public int value
        {
            get
            {
                return this.m_Mask;
            }
            set
            {
                this.m_Mask = value;
            }
        }
        
        public static extern string LayerToName(int layer);
        
        public static extern int NameToLayer(string layerName);
        public static int GetMask(params string[] layerNames)
        {
            int num = 0;
            foreach (string str in layerNames)
            {
                int num3 = NameToLayer(str);
                if (num3 != 0)
                {
                    num |= ((int) 1) << num3;
                }
            }
            return num;
        }

        public static implicit operator int(LayerMask mask)
        {
            return mask.m_Mask;
        }

        public static implicit operator LayerMask(int intVal)
        {
            LayerMask mask;
            mask.m_Mask = intVal;
            return mask;
        }
    }
}

