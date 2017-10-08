namespace UnityEngine
{
    using System;
    using System.Runtime.CompilerServices;

    public sealed class BillboardAsset : Object
    {
        
        internal extern void MakeMaterialProperties(MaterialPropertyBlock properties, Camera camera);
        
        internal extern void MakePreviewMesh(Mesh mesh);
        
        internal extern void MakeRenderMesh(Mesh mesh, float widthScale, float heightScale, float rotation);

        public float bottom {  get;  set; }

        public float height {  get;  set; }

        public int imageCount {  get; }

        public int indexCount {  get; }

        public Material material {  get;  set; }

        public int vertexCount {  get; }

        public float width {  get;  set; }
    }
}

