﻿namespace UnityEngine.Rendering
{
    using System;
    using System.Runtime.CompilerServices;
    using UnityEngine;
    using UnityEngine.Internal;

    public sealed class CommandBuffer : IDisposable
    {
        internal IntPtr m_Ptr = IntPtr.Zero;

        public CommandBuffer()
        {
            InitBuffer(this);
        }

        public void Blit(RenderTargetIdentifier source, RenderTargetIdentifier dest)
        {
            this.Blit_Identifier(ref source, ref dest, null, -1);
        }

        public void Blit(Texture source, RenderTargetIdentifier dest)
        {
            this.Blit_Texture(source, ref dest, null, -1);
        }

        public void Blit(RenderTargetIdentifier source, RenderTargetIdentifier dest, Material mat)
        {
            this.Blit_Identifier(ref source, ref dest, mat, -1);
        }

        public void Blit(Texture source, RenderTargetIdentifier dest, Material mat)
        {
            this.Blit_Texture(source, ref dest, mat, -1);
        }

        public void Blit(RenderTargetIdentifier source, RenderTargetIdentifier dest, Material mat, int pass)
        {
            this.Blit_Identifier(ref source, ref dest, mat, pass);
        }

        public void Blit(Texture source, RenderTargetIdentifier dest, Material mat, int pass)
        {
            this.Blit_Texture(source, ref dest, mat, pass);
        }

        [ExcludeFromDocs]
        private void Blit_Identifier(ref RenderTargetIdentifier source, ref RenderTargetIdentifier dest)
        {
            int pass = -1;
            Material mat = null;
            this.Blit_Identifier(ref source, ref dest, mat, pass);
        }

        [ExcludeFromDocs]
        private void Blit_Identifier(ref RenderTargetIdentifier source, ref RenderTargetIdentifier dest, Material mat)
        {
            int pass = -1;
            this.Blit_Identifier(ref source, ref dest, mat, pass);
        }

        
        private extern void Blit_Identifier(ref RenderTargetIdentifier source, ref RenderTargetIdentifier dest, [DefaultValue("null")] Material mat, [DefaultValue("-1")] int pass);
        
        private extern void Blit_Texture(Texture source, ref RenderTargetIdentifier dest, Material mat, int pass);
        
        public extern void Clear();
        [ExcludeFromDocs]
        public void ClearRenderTarget(bool clearDepth, bool clearColor, Color backgroundColor)
        {
            float depth = 1f;
            INTERNAL_CALL_ClearRenderTarget(this, clearDepth, clearColor, ref backgroundColor, depth);
        }

        public void ClearRenderTarget(bool clearDepth, bool clearColor, Color backgroundColor, [DefaultValue("1.0f")] float depth)
        {
            INTERNAL_CALL_ClearRenderTarget(this, clearDepth, clearColor, ref backgroundColor, depth);
        }

        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool disposing)
        {
            this.ReleaseBuffer();
            this.m_Ptr = IntPtr.Zero;
        }

        [ExcludeFromDocs]
        public void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material)
        {
            MaterialPropertyBlock properties = null;
            int shaderPass = -1;
            int submeshIndex = 0;
            INTERNAL_CALL_DrawMesh(this, mesh, ref matrix, material, submeshIndex, shaderPass, properties);
        }

        [ExcludeFromDocs]
        public void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int submeshIndex)
        {
            MaterialPropertyBlock properties = null;
            int shaderPass = -1;
            INTERNAL_CALL_DrawMesh(this, mesh, ref matrix, material, submeshIndex, shaderPass, properties);
        }

        [ExcludeFromDocs]
        public void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int submeshIndex, int shaderPass)
        {
            MaterialPropertyBlock properties = null;
            INTERNAL_CALL_DrawMesh(this, mesh, ref matrix, material, submeshIndex, shaderPass, properties);
        }

        public void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, [DefaultValue("0")] int submeshIndex, [DefaultValue("-1")] int shaderPass, [DefaultValue("null")] MaterialPropertyBlock properties)
        {
            INTERNAL_CALL_DrawMesh(this, mesh, ref matrix, material, submeshIndex, shaderPass, properties);
        }

        [ExcludeFromDocs]
        public void DrawProcedural(Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, int vertexCount)
        {
            MaterialPropertyBlock properties = null;
            int instanceCount = 1;
            INTERNAL_CALL_DrawProcedural(this, ref matrix, material, shaderPass, topology, vertexCount, instanceCount, properties);
        }

        [ExcludeFromDocs]
        public void DrawProcedural(Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, int vertexCount, int instanceCount)
        {
            MaterialPropertyBlock properties = null;
            INTERNAL_CALL_DrawProcedural(this, ref matrix, material, shaderPass, topology, vertexCount, instanceCount, properties);
        }

        public void DrawProcedural(Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, int vertexCount, [DefaultValue("1")] int instanceCount, [DefaultValue("null")] MaterialPropertyBlock properties)
        {
            INTERNAL_CALL_DrawProcedural(this, ref matrix, material, shaderPass, topology, vertexCount, instanceCount, properties);
        }

        [ExcludeFromDocs]
        public void DrawProceduralIndirect(Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, ComputeBuffer bufferWithArgs)
        {
            MaterialPropertyBlock properties = null;
            int argsOffset = 0;
            INTERNAL_CALL_DrawProceduralIndirect(this, ref matrix, material, shaderPass, topology, bufferWithArgs, argsOffset, properties);
        }

        [ExcludeFromDocs]
        public void DrawProceduralIndirect(Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, ComputeBuffer bufferWithArgs, int argsOffset)
        {
            MaterialPropertyBlock properties = null;
            INTERNAL_CALL_DrawProceduralIndirect(this, ref matrix, material, shaderPass, topology, bufferWithArgs, argsOffset, properties);
        }

        public void DrawProceduralIndirect(Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, ComputeBuffer bufferWithArgs, [DefaultValue("0")] int argsOffset, [DefaultValue("null")] MaterialPropertyBlock properties)
        {
            INTERNAL_CALL_DrawProceduralIndirect(this, ref matrix, material, shaderPass, topology, bufferWithArgs, argsOffset, properties);
        }


    

        [ExcludeFromDocs]
        public void GetTemporaryRT(int nameID, int width, int height)
        {
            int antiAliasing = 1;
            RenderTextureReadWrite readWrite = RenderTextureReadWrite.Default;
            RenderTextureFormat format = RenderTextureFormat.Default;
            FilterMode point = FilterMode.Point;
            int depthBuffer = 0;
            this.GetTemporaryRT(nameID, width, height, depthBuffer, point, format, readWrite, antiAliasing);
        }

        [ExcludeFromDocs]
        public void GetTemporaryRT(int nameID, int width, int height, int depthBuffer)
        {
            int antiAliasing = 1;
            RenderTextureReadWrite readWrite = RenderTextureReadWrite.Default;
            RenderTextureFormat format = RenderTextureFormat.Default;
            FilterMode point = FilterMode.Point;
            this.GetTemporaryRT(nameID, width, height, depthBuffer, point, format, readWrite, antiAliasing);
        }

        [ExcludeFromDocs]
        public void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, FilterMode filter)
        {
            int antiAliasing = 1;
            RenderTextureReadWrite readWrite = RenderTextureReadWrite.Default;
            RenderTextureFormat format = RenderTextureFormat.Default;
            this.GetTemporaryRT(nameID, width, height, depthBuffer, filter, format, readWrite, antiAliasing);
        }

        [ExcludeFromDocs]
        public void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, FilterMode filter, RenderTextureFormat format)
        {
            int antiAliasing = 1;
            RenderTextureReadWrite readWrite = RenderTextureReadWrite.Default;
            this.GetTemporaryRT(nameID, width, height, depthBuffer, filter, format, readWrite, antiAliasing);
        }

        [ExcludeFromDocs]
        public void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, FilterMode filter, RenderTextureFormat format, RenderTextureReadWrite readWrite)
        {
            int antiAliasing = 1;
            this.GetTemporaryRT(nameID, width, height, depthBuffer, filter, format, readWrite, antiAliasing);
        }

        
        public extern void GetTemporaryRT(int nameID, int width, int height, [DefaultValue("0")] int depthBuffer, [DefaultValue("FilterMode.Point")] FilterMode filter, [DefaultValue("RenderTextureFormat.Default")] RenderTextureFormat format, [DefaultValue("RenderTextureReadWrite.Default")] RenderTextureReadWrite readWrite, [DefaultValue("1")] int antiAliasing);
        
        private static extern void InitBuffer(CommandBuffer buf);
        
        private static extern void INTERNAL_CALL_ClearRenderTarget(CommandBuffer self, bool clearDepth, bool clearColor, ref Color backgroundColor, float depth);
        
        private static extern void INTERNAL_CALL_DrawMesh(CommandBuffer self, Mesh mesh, ref Matrix4x4 matrix, Material material, int submeshIndex, int shaderPass, MaterialPropertyBlock properties);
        
        private static extern void INTERNAL_CALL_DrawProcedural(CommandBuffer self, ref Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, int vertexCount, int instanceCount, MaterialPropertyBlock properties);
        
        private static extern void INTERNAL_CALL_DrawProceduralIndirect(CommandBuffer self, ref Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, ComputeBuffer bufferWithArgs, int argsOffset, MaterialPropertyBlock properties);
        
        private static extern void INTERNAL_CALL_SetGlobalColor(CommandBuffer self, int nameID, ref Color value);
        
        private static extern void INTERNAL_CALL_SetGlobalMatrix(CommandBuffer self, int nameID, ref Matrix4x4 value);
        
        private static extern void INTERNAL_CALL_SetGlobalVector(CommandBuffer self, int nameID, ref Vector4 value);
        public void IssuePluginEvent(IntPtr callback, int eventID)
        {
            if (callback == IntPtr.Zero)
            {
                throw new ArgumentException("Null callback specified.");
            }
            this.IssuePluginEventInternal(callback, eventID);
        }

        
        private extern void IssuePluginEventInternal(IntPtr callback, int eventID);
        public void Release()
        {
            this.Dispose();
        }

        
        private extern void ReleaseBuffer();
        
        public extern void ReleaseTemporaryRT(int nameID);
        public void SetGlobalColor(int nameID, Color value)
        {
            INTERNAL_CALL_SetGlobalColor(this, nameID, ref value);
        }

        public void SetGlobalColor(string name, Color value)
        {
            this.SetGlobalColor(Shader.PropertyToID(name), value);
        }

        
        public extern void SetGlobalFloat(int nameID, float value);
        public void SetGlobalFloat(string name, float value)
        {
            this.SetGlobalFloat(Shader.PropertyToID(name), value);
        }

        public void SetGlobalMatrix(int nameID, Matrix4x4 value)
        {
            INTERNAL_CALL_SetGlobalMatrix(this, nameID, ref value);
        }

        public void SetGlobalMatrix(string name, Matrix4x4 value)
        {
            this.SetGlobalMatrix(Shader.PropertyToID(name), value);
        }

        public void SetGlobalTexture(int nameID, RenderTargetIdentifier value)
        {
            this.SetGlobalTexture_Impl(nameID, ref value);
        }

        public void SetGlobalTexture(string name, RenderTargetIdentifier value)
        {
            this.SetGlobalTexture(Shader.PropertyToID(name), value);
        }

        
        private extern void SetGlobalTexture_Impl(int nameID, ref RenderTargetIdentifier rt);
        public void SetGlobalVector(int nameID, Vector4 value)
        {
            INTERNAL_CALL_SetGlobalVector(this, nameID, ref value);
        }

        public void SetGlobalVector(string name, Vector4 value)
        {
            this.SetGlobalVector(Shader.PropertyToID(name), value);
        }

        public void SetRenderTarget(RenderTargetIdentifier rt)
        {
            this.SetRenderTarget_Single(ref rt, 0, CubemapFace.Unknown);
        }

        public void SetRenderTarget(RenderTargetIdentifier rt, int mipLevel)
        {
            this.SetRenderTarget_Single(ref rt, mipLevel, CubemapFace.Unknown);
        }

        public void SetRenderTarget(RenderTargetIdentifier color, RenderTargetIdentifier depth)
        {
            this.SetRenderTarget_ColDepth(ref color, ref depth, 0, CubemapFace.Unknown);
        }

        public void SetRenderTarget(RenderTargetIdentifier[] colors, RenderTargetIdentifier depth)
        {
            this.SetRenderTarget_Multiple(colors, ref depth);
        }

        public void SetRenderTarget(RenderTargetIdentifier rt, int mipLevel, CubemapFace cubemapFace)
        {
            this.SetRenderTarget_Single(ref rt, mipLevel, cubemapFace);
        }

        public void SetRenderTarget(RenderTargetIdentifier color, RenderTargetIdentifier depth, int mipLevel)
        {
            this.SetRenderTarget_ColDepth(ref color, ref depth, mipLevel, CubemapFace.Unknown);
        }

        public void SetRenderTarget(RenderTargetIdentifier color, RenderTargetIdentifier depth, int mipLevel, CubemapFace cubemapFace)
        {
            this.SetRenderTarget_ColDepth(ref color, ref depth, mipLevel, cubemapFace);
        }

        
        private extern void SetRenderTarget_ColDepth(ref RenderTargetIdentifier color, ref RenderTargetIdentifier depth, int mipLevel, CubemapFace cubemapFace);
        
        private extern void SetRenderTarget_Multiple(RenderTargetIdentifier[] color, ref RenderTargetIdentifier depth);
        
        private extern void SetRenderTarget_Single(ref RenderTargetIdentifier rt, int mipLevel, CubemapFace cubemapFace);

        public string name {  get;  set; }

        public int sizeInBytes {  get; }
    }
}

