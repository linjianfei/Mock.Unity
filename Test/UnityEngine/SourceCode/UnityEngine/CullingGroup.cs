namespace UnityEngine
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Security;

    [StructLayout(LayoutKind.Sequential)]
    public sealed class CullingGroup : IDisposable
    {
        internal IntPtr m_Ptr;
        private StateChanged m_OnStateChanged;
        public CullingGroup()
        {
            this.Init();
        }

        ~CullingGroup()
        {
            if (this.m_Ptr != IntPtr.Zero)
            {
                this.FinalizerFailure();
            }
        }

        
        public extern void Dispose();
        public StateChanged onStateChanged
        {
            get
            {
                return this.m_OnStateChanged;
            }
            set
            {
                this.m_OnStateChanged = value;
            }
        }
        public bool enabled {  get;  set; }
        public Camera targetCamera {  get;  set; }
        
        public extern void SetBoundingSpheres(BoundingSphere[] array);
        
        public extern void SetBoundingSphereCount(int count);
        
        public extern void EraseSwapBack(int index);
        public static void EraseSwapBack<T>(int index, T[] myArray, ref int size)
        {
            size--;
            myArray[index] = myArray[size];
        }

        public int QueryIndices(bool visible, int[] result, int firstIndex)
        {
            return this.QueryIndices(visible, -1, CullingQueryOptions.IgnoreDistance, result, firstIndex);
        }

        public int QueryIndices(int distanceIndex, int[] result, int firstIndex)
        {
            return this.QueryIndices(false, distanceIndex, CullingQueryOptions.IgnoreVisibility, result, firstIndex);
        }

        public int QueryIndices(bool visible, int distanceIndex, int[] result, int firstIndex)
        {
            return this.QueryIndices(visible, distanceIndex, CullingQueryOptions.Normal, result, firstIndex);
        }

        
        private extern int QueryIndices(bool visible, int distanceIndex, CullingQueryOptions options, int[] result, int firstIndex);
        
        public extern bool IsVisible(int index);
        
        public extern int GetDistance(int index);
        
        public extern void SetBoundingDistances(float[] distances);
        public void SetDistanceReferencePoint(Vector3 point)
        {
            INTERNAL_CALL_SetDistanceReferencePoint(this, ref point);
        }

        
        private static extern void INTERNAL_CALL_SetDistanceReferencePoint(CullingGroup self, ref Vector3 point);
        
        public extern void SetDistanceReferencePoint(Transform transform);
        [SecuritySafeCritical]
        private static  void SendEvents(CullingGroup cullingGroup, IntPtr eventsPtr, int count)
        {
           
        }

        
        private extern void Init();
        
        private extern void FinalizerFailure();
        public delegate void StateChanged(CullingGroupEvent sphere);
    }
}

