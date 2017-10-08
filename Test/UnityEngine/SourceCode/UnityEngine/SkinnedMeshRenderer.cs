namespace UnityEngine
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    public class SkinnedMeshRenderer 
    {
        
        public extern void BakeMesh(Mesh mesh);
        
        public extern float GetBlendShapeWeight(int index);
        
        private extern void INTERNAL_get_localBounds(out Bounds value);
        
        private extern void INTERNAL_set_localBounds(ref Bounds value);
        
        public extern void SetBlendShapeWeight(int index, float value);

        internal Transform actualRootBone {  get; }

        public Transform[] bones {  get;  set; }

        public Bounds localBounds
        {
            get
            {
                Bounds bounds;
                this.INTERNAL_get_localBounds(out bounds);
                return bounds;
            }
            set
            {
                this.INTERNAL_set_localBounds(ref value);
            }
        }

        public SkinQuality quality {  get;  set; }

        public Transform rootBone {  get;  set; }

        public Mesh sharedMesh {  get;  set; }

        public bool updateWhenOffscreen {  get;  set; }
    }
}

