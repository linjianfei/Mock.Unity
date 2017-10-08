namespace UnityEngine
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    public sealed class CanvasRenderer : Component
    {
        public static  event OnRequestRebuild onRequestRebuild;

        public static void AddUIVertexStream(List<UIVertex> verts, List<Vector3> positions, List<Color32> colors, List<Vector2> uv0S, List<Vector2> uv1S, List<Vector3> normals, List<Vector4> tangents)
        {
            SplitUIVertexStreamsInternal(verts, positions, colors, uv0S, uv1S, normals, tangents);
        }

        
        public extern void Clear();
        public static void CreateUIVertexStream(List<UIVertex> verts, List<Vector3> positions, List<Color32> colors, List<Vector2> uv0S, List<Vector2> uv1S, List<Vector3> normals, List<Vector4> tangents, List<int> indicies)
        {
            CreateUIVertexStreamInternal(verts, positions, colors, uv0S, uv1S, normals, tangents, indicies);
        }

        
        private static extern void CreateUIVertexStreamInternal(object verts, object positions, object colors, object uv0S, object uv1S, object normals, object tangents, object indicies);
        
        public extern void DisableRectClipping();
        public void EnableRectClipping(Rect rect)
        {
            INTERNAL_CALL_EnableRectClipping(this, ref rect);
        }

        
        public extern float GetAlpha();
        
        public extern Color GetColor();
        public Material GetMaterial()
        {
            return this.GetMaterial(0);
        }

        
        public extern Material GetMaterial(int index);
        
        public extern Material GetPopMaterial(int index);
        
        private static extern void INTERNAL_CALL_EnableRectClipping(CanvasRenderer self, ref Rect rect);
        
        private static extern void INTERNAL_CALL_SetColor(CanvasRenderer self, ref Color color);
        private static void RequestRefresh()
        {
            if (onRequestRebuild != null)
            {
                onRequestRebuild();
            }
        }

        
        public extern void SetAlpha(float alpha);
        public void SetColor(Color color)
        {
            INTERNAL_CALL_SetColor(this, ref color);
        }

        
        public extern void SetMaterial(Material material, int index);
        public void SetMaterial(Material material, Texture texture)
        {
            this.materialCount = Math.Max(1, this.materialCount);
            this.SetMaterial(material, 0);
            this.SetTexture(texture);
        }

        
        public extern void SetMesh(Mesh mesh);
        
        public extern void SetPopMaterial(Material material, int index);
        
        public extern void SetTexture(Texture texture);
        [Obsolete("UI System now uses meshes. Generate a mesh and use 'SetMesh' instead")]
        public void SetVertices(List<UIVertex> vertices)
        {
            this.SetVertices(vertices.ToArray(), vertices.Count);
        }

        [Obsolete("UI System now uses meshes. Generate a mesh and use 'SetMesh' instead")]
        public void SetVertices(UIVertex[] vertices, int size)
        {
            Mesh mesh = new Mesh();
            List<Vector3> inVertices = new List<Vector3>();
            List<Color32> inColors = new List<Color32>();
            List<Vector2> uvs = new List<Vector2>();
            List<Vector2> list4 = new List<Vector2>();
            List<Vector3> inNormals = new List<Vector3>();
            List<Vector4> inTangents = new List<Vector4>();
            List<int> list7 = new List<int>();
            for (int i = 0; i < size; i += 4)
            {
                for (int j = 0; j < 4; j++)
                {
                    inVertices.Add(vertices[i + j].position);
                    inColors.Add(vertices[i + j].color);
                    uvs.Add(vertices[i + j].uv0);
                    list4.Add(vertices[i + j].uv1);
                    inNormals.Add(vertices[i + j].normal);
                    inTangents.Add(vertices[i + j].tangent);
                }
                list7.Add(i);
                list7.Add(i + 1);
                list7.Add(i + 2);
                list7.Add(i + 2);
                list7.Add(i + 3);
                list7.Add(i);
            }
            mesh.SetVertices(inVertices);
            mesh.SetColors(inColors);
            mesh.SetNormals(inNormals);
            mesh.SetTangents(inTangents);
            mesh.SetUVs(0, uvs);
            mesh.SetUVs(1, list4);
            mesh.SetIndices(list7.ToArray(), MeshTopology.Triangles, 0);
            this.SetMesh(mesh);
            Object.DestroyImmediate(mesh);
        }

        
        private static extern void SplitIndiciesStreamsInternal(object verts, object indicies);
        public static void SplitUIVertexStreams(List<UIVertex> verts, List<Vector3> positions, List<Color32> colors, List<Vector2> uv0S, List<Vector2> uv1S, List<Vector3> normals, List<Vector4> tangents, List<int> indicies)
        {
            SplitUIVertexStreamsInternal(verts, positions, colors, uv0S, uv1S, normals, tangents);
            SplitIndiciesStreamsInternal(verts, indicies);
        }

        
        private static extern void SplitUIVertexStreamsInternal(object verts, object positions, object colors, object uv0S, object uv1S, object normals, object tangents);

        public int absoluteDepth {  get; }

        public bool cull {  get;  set; }

        public bool hasMoved {  get; }

        public bool hasPopInstruction {  get;  set; }

        public bool hasRectClipping {  get; }

        [Obsolete("isMask is no longer supported. See EnableClipping for vertex clipping configuration")]
        public bool isMask {  get;  set; }

        public int materialCount {  get;  set; }

        public int popMaterialCount {  get;  set; }

        public int relativeDepth {  get; }

        public delegate void OnRequestRebuild();
    }
}

