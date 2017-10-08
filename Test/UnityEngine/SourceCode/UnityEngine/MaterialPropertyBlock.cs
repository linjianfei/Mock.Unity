namespace UnityEngine
{
    using System;
    using System.Runtime.CompilerServices;

    public sealed class MaterialPropertyBlock
    {
        internal IntPtr m_Ptr;

        public MaterialPropertyBlock()
        {
            this.InitBlock();
        }

        public void AddColor(int nameID, Color value)
        {
            INTERNAL_CALL_AddColor(this, nameID, ref value);
        }

        public void AddColor(string name, Color value)
        {
            this.AddColor(Shader.PropertyToID(name), value);
        }

        
        public extern void AddFloat(int nameID, float value);
        public void AddFloat(string name, float value)
        {
            this.AddFloat(Shader.PropertyToID(name), value);
        }

        public void AddMatrix(int nameID, Matrix4x4 value)
        {
            INTERNAL_CALL_AddMatrix(this, nameID, ref value);
        }

        public void AddMatrix(string name, Matrix4x4 value)
        {
            this.AddMatrix(Shader.PropertyToID(name), value);
        }

        
        public extern void AddTexture(int nameID, Texture value);
        public void AddTexture(string name, Texture value)
        {
            this.AddTexture(Shader.PropertyToID(name), value);
        }

        public void AddVector(int nameID, Vector4 value)
        {
            INTERNAL_CALL_AddVector(this, nameID, ref value);
        }

        public void AddVector(string name, Vector4 value)
        {
            this.AddVector(Shader.PropertyToID(name), value);
        }

        
        public extern void Clear();
        
        internal extern void DestroyBlock();
        ~MaterialPropertyBlock()
        {
            this.DestroyBlock();
        }

        
        public extern float GetFloat(int nameID);
        public float GetFloat(string name)
        {
            return this.GetFloat(Shader.PropertyToID(name));
        }

        
        public extern Matrix4x4 GetMatrix(int nameID);
        public Matrix4x4 GetMatrix(string name)
        {
            return this.GetMatrix(Shader.PropertyToID(name));
        }

        
        public extern Texture GetTexture(int nameID);
        public Texture GetTexture(string name)
        {
            return this.GetTexture(Shader.PropertyToID(name));
        }

        
        public extern Vector4 GetVector(int nameID);
        public Vector4 GetVector(string name)
        {
            return this.GetVector(Shader.PropertyToID(name));
        }

        
        internal extern void InitBlock();
        
        private static extern void INTERNAL_CALL_AddColor(MaterialPropertyBlock self, int nameID, ref Color value);
        
        private static extern void INTERNAL_CALL_AddMatrix(MaterialPropertyBlock self, int nameID, ref Matrix4x4 value);
        
        private static extern void INTERNAL_CALL_AddVector(MaterialPropertyBlock self, int nameID, ref Vector4 value);
        
        private static extern void INTERNAL_CALL_SetColor(MaterialPropertyBlock self, int nameID, ref Color value);
        
        private static extern void INTERNAL_CALL_SetMatrix(MaterialPropertyBlock self, int nameID, ref Matrix4x4 value);
        
        private static extern void INTERNAL_CALL_SetVector(MaterialPropertyBlock self, int nameID, ref Vector4 value);
        public void SetColor(int nameID, Color value)
        {
            INTERNAL_CALL_SetColor(this, nameID, ref value);
        }

        public void SetColor(string name, Color value)
        {
            this.SetColor(Shader.PropertyToID(name), value);
        }

        
        public extern void SetFloat(int nameID, float value);
        public void SetFloat(string name, float value)
        {
            this.SetFloat(Shader.PropertyToID(name), value);
        }

        public void SetMatrix(int nameID, Matrix4x4 value)
        {
            INTERNAL_CALL_SetMatrix(this, nameID, ref value);
        }

        public void SetMatrix(string name, Matrix4x4 value)
        {
            this.SetMatrix(Shader.PropertyToID(name), value);
        }

        
        public extern void SetTexture(int nameID, Texture value);
        public void SetTexture(string name, Texture value)
        {
            this.SetTexture(Shader.PropertyToID(name), value);
        }

        public void SetVector(int nameID, Vector4 value)
        {
            INTERNAL_CALL_SetVector(this, nameID, ref value);
        }

        public void SetVector(string name, Vector4 value)
        {
            this.SetVector(Shader.PropertyToID(name), value);
        }

        public bool isEmpty {  get; }
    }
}

