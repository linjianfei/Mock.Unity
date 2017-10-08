namespace UnityEngine
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using UnityEngine.Rendering;

    public sealed class ShaderVariantCollection : Object
    {
        public ShaderVariantCollection()
        {
            Internal_Create(this);
        }

        public bool Add(ShaderVariant variant)
        {
            return this.AddInternal(variant.shader, variant.passType, variant.keywords);
        }

        
        private extern bool AddInternal(Shader shader, PassType passType, string[] keywords);
        
        public extern void Clear();
        public bool Contains(ShaderVariant variant)
        {
            return this.ContainsInternal(variant.shader, variant.passType, variant.keywords);
        }

        
        private extern bool ContainsInternal(Shader shader, PassType passType, string[] keywords);
        
        private static extern void Internal_Create([Writable] ShaderVariantCollection mono);
        public bool Remove(ShaderVariant variant)
        {
            return this.RemoveInternal(variant.shader, variant.passType, variant.keywords);
        }

        
        private extern bool RemoveInternal(Shader shader, PassType passType, string[] keywords);
        
        public extern void WarmUp();

        public bool isWarmedUp {  get; }

        public int shaderCount {  get; }

        public int variantCount {  get; }

        [StructLayout(LayoutKind.Sequential)]
        public struct ShaderVariant
        {
            public Shader shader;
            public PassType passType;
            public string[] keywords;
            public ShaderVariant(Shader shader, PassType passType, params string[] keywords)
            {
                this.shader = shader;
                this.passType = passType;
                this.keywords = keywords;
                Internal_CheckVariant(shader, passType, keywords);
            }

            
            private static extern void Internal_CheckVariant(Shader shader, PassType passType, string[] keywords);
        }
    }
}

