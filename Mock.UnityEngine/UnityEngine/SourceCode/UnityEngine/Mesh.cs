namespace UnityEngine
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using UnityEngine.Internal;

    public sealed class Mesh : Object
    {
        public Mesh()
        {
            Internal_Create(this);
        }

        [ExcludeFromDocs]
        public void Clear()
        {
            bool keepVertexLayout = true;
            this.Clear(keepVertexLayout);
        }

        
        public extern void Clear([DefaultValue("true")] bool keepVertexLayout);
        [ExcludeFromDocs]
        public void CombineMeshes(CombineInstance[] combine)
        {
            bool useMatrices = true;
            bool mergeSubMeshes = true;
            this.CombineMeshes(combine, mergeSubMeshes, useMatrices);
        }

        [ExcludeFromDocs]
        public void CombineMeshes(CombineInstance[] combine, bool mergeSubMeshes)
        {
            bool useMatrices = true;
            this.CombineMeshes(combine, mergeSubMeshes, useMatrices);
        }

        
        public extern void CombineMeshes(CombineInstance[] combine, bool mergeSubMeshes,  bool useMatrices);
        
        public extern int GetBlendShapeIndex(string blendShapeName);
        
        public extern string GetBlendShapeName(int index);
        
        public extern int[] GetIndices(int submesh);
        
        public extern MeshTopology GetTopology(int submesh);
        
        public extern int[] GetTriangles(int submesh);
        
        private static extern void Internal_Create([Writable] Mesh mono);
        
        private extern void INTERNAL_get_bounds(out Bounds value);
        
        private extern void INTERNAL_set_bounds(ref Bounds value);
        
        public extern void MarkDynamic();
        
        public extern void Optimize();
        
        public extern void RecalculateBounds();
        
        public extern void RecalculateNormals();
        public void SetColors(List<Color> inColors)
        {
            this.SetColorsInternal(inColors);
        }

        public void SetColors(List<Color32> inColors)
        {
            this.SetColors32Internal(inColors);
        }

        
        private extern void SetColors32Internal(object colors);
        
        private extern void SetColorsInternal(object colors);
        
        public extern void SetIndices(int[] indices, MeshTopology topology, int submesh);
        public void SetNormals(List<Vector3> inNormals)
        {
            this.SetNormalsInternal(inNormals);
        }

        
        private extern void SetNormalsInternal(object normals);
        public void SetTangents(List<Vector4> inTangents)
        {
            this.SetTangentsInternal(inTangents);
        }

        
        private extern void SetTangentsInternal(object tangents);
        public void SetTriangles(List<int> inTriangles, int submesh)
        {
            this.SetTrianglesInternal(inTriangles, submesh);
        }

        
        public extern void SetTriangles(int[] triangles, int submesh);
        
        private extern void SetTrianglesInternal(object triangles, int submesh);
        
        private extern void SetUVInternal(object uvs, int channel, int dim);
        public void SetUVs(int channel, List<Vector2> uvs)
        {
            this.SetUVInternal(uvs, channel, 2);
        }

        public void SetUVs(int channel, List<Vector3> uvs)
        {
            this.SetUVInternal(uvs, channel, 3);
        }

        public void SetUVs(int channel, List<Vector4> uvs)
        {
            this.SetUVInternal(uvs, channel, 4);
        }

        public void SetVertices(List<Vector3> inVertices)
        {
            this.SetVerticesInternal(inVertices);
        }

        
        private extern void SetVerticesInternal(object vertices);
        
        public extern void UploadMeshData(bool markNoLogerReadable);

        public Matrix4x4[] bindposes {  get;  set; }

        public int blendShapeCount {  get; }

        public BoneWeight[] boneWeights {  get;  set; }

        public Bounds bounds
        {
            get
            {
                Bounds bounds;
                this.INTERNAL_get_bounds(out bounds);
                return bounds;
            }
            set
            {
                this.INTERNAL_set_bounds(ref value);
            }
        }

        internal bool canAccess {  get; }

        public Color[] colors {  get;  set; }

        public Color32[] colors32 {  get;  set; }

        public bool isReadable {  get; }

        public Vector3[] normals {  get;  set; }

        public int subMeshCount {  get;  set; }

        public Vector4[] tangents {  get;  set; }

        public int[] triangles {  get;  set; }

        public Vector2[] uv {  get;  set; }

     

        public Vector2[] uv2 {  get;  set; }

        public Vector2[] uv3 {  get;  set; }

        public Vector2[] uv4 {  get;  set; }

        public int vertexCount {  get; }

        public Vector3[] vertices {  get;  set; }
    }
}

