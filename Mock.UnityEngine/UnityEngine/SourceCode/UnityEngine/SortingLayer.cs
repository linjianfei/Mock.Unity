﻿namespace UnityEngine
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential)]
    public struct SortingLayer
    {
        private int m_Id;
        public int id
        {
            get
            {
                return this.m_Id;
            }
        }
        public string name
        {
            get
            {
                return IDToName(this.m_Id);
            }
        }
        public int value
        {
            get
            {
                return GetLayerValueFromID(this.m_Id);
            }
        }
        public static SortingLayer[] layers
        {
            get
            {
                int[] sortingLayerIDsInternal = GetSortingLayerIDsInternal();
                SortingLayer[] layerArray = new SortingLayer[sortingLayerIDsInternal.Length];
                for (int i = 0; i < sortingLayerIDsInternal.Length; i++)
                {
                    layerArray[i].m_Id = sortingLayerIDsInternal[i];
                }
                return layerArray;
            }
        }
        
        private static extern int[] GetSortingLayerIDsInternal();
        
        public static extern int GetLayerValueFromID(int id);
        
        public static extern int GetLayerValueFromName(string name);
        
        public static extern int NameToID(string name);
        
        public static extern string IDToName(int id);
        
        public static extern bool IsValid(int id);
    }
}

