namespace UnityEngine
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    public sealed class LODGroup : Component
    {
        
        public extern void ForceLOD(int index);
        
        public extern LOD[] GetLODs();
        
        private extern void INTERNAL_get_localReferencePoint(out Vector3 value);
        
        private extern void INTERNAL_set_localReferencePoint(ref Vector3 value);
        
        public extern void RecalculateBounds();
        
        public extern void SetLODs(LOD[] lods);
        [Obsolete("Use SetLODs instead.")]
        public void SetLODS(LOD[] lods)
        {
            this.SetLODs(lods);
        }

        public bool animateCrossFading {  get;  set; }

        public static float crossFadeAnimationDuration {  get;  set; }

        public bool enabled {  get;  set; }

        public LODFadeMode fadeMode {  get;  set; }

        public Vector3 localReferencePoint
        {
            get
            {
                Vector3 vector;
                this.INTERNAL_get_localReferencePoint(out vector);
                return vector;
            }
            set
            {
                this.INTERNAL_set_localReferencePoint(ref value);
            }
        }

        public int lodCount {  get; }

        public float size {  get;  set; }
    }
}

