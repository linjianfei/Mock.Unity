﻿namespace UnityEngine
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using UnityEngine.Internal;

    public class Material : Object
    {
        [Obsolete("Creating materials from shader source string will be removed in the future. Use Shader assets instead.")]
        public Material(string contents)
        {
            Internal_CreateWithString(this, contents);
        }

        public Material(Material source)
        {
            Internal_CreateWithMaterial(this, source);
        }

        public Material(Shader shader)
        {
            Internal_CreateWithShader(this, shader);
        }

        
        public extern void CopyPropertiesFromMaterial(Material mat);
        [Obsolete("Creating materials from shader source string will be removed in the future. Use Shader assets instead.")]
        public static Material Create(string scriptContents)
        {
            return new Material(scriptContents);
        }

        
        public extern void DisableKeyword(string keyword);
        
        public extern void EnableKeyword(string keyword);
        
        public extern Color GetColor(int nameID);
        public Color GetColor(string propertyName)
        {
            return this.GetColor(Shader.PropertyToID(propertyName));
        }

        
        public extern float GetFloat(int nameID);
        public float GetFloat(string propertyName)
        {
            return this.GetFloat(Shader.PropertyToID(propertyName));
        }

        public int GetInt(int nameID)
        {
            return (int) this.GetFloat(nameID);
        }

        public int GetInt(string propertyName)
        {
            return (int) this.GetFloat(propertyName);
        }

        
        public extern Matrix4x4 GetMatrix(int nameID);
        public Matrix4x4 GetMatrix(string propertyName)
        {
            return this.GetMatrix(Shader.PropertyToID(propertyName));
        }

        [ExcludeFromDocs]
        public string GetTag(string tag, bool searchFallbacks)
        {
            string defaultValue = string.Empty;
            return this.GetTag(tag, searchFallbacks, defaultValue);
        }

        
        public extern string GetTag(string tag, bool searchFallbacks, [DefaultValue("\"\"")] string defaultValue);
        
        public extern Texture GetTexture(int nameID);
        public Texture GetTexture(string propertyName)
        {
            return this.GetTexture(Shader.PropertyToID(propertyName));
        }

        public Vector2 GetTextureOffset(string propertyName)
        {
            Vector2 vector;
            Internal_GetTextureOffset(this, propertyName, out vector);
            return vector;
        }

        public Vector2 GetTextureScale(string propertyName)
        {
            Vector2 vector;
            Internal_GetTextureScale(this, propertyName, out vector);
            return vector;
        }

        public Vector4 GetVector(int nameID)
        {
            Color color = this.GetColor(nameID);
            return new Vector4(color.r, color.g, color.b, color.a);
        }

        public Vector4 GetVector(string propertyName)
        {
            Color color = this.GetColor(propertyName);
            return new Vector4(color.r, color.g, color.b, color.a);
        }

        
        public extern bool HasProperty(int nameID);
        public bool HasProperty(string propertyName)
        {
            return this.HasProperty(Shader.PropertyToID(propertyName));
        }

        
        private static extern void INTERNAL_CALL_SetColor(Material self, int nameID, ref Color color);
        
        private static extern void INTERNAL_CALL_SetMatrix(Material self, int nameID, ref Matrix4x4 matrix);
        
        private static extern void INTERNAL_CALL_SetTextureOffset(Material self, string propertyName, ref Vector2 offset);
        
        private static extern void INTERNAL_CALL_SetTextureScale(Material self, string propertyName, ref Vector2 scale);
        
        private static extern void Internal_CreateWithMaterial([Writable] Material mono, Material source);
        
        private static extern void Internal_CreateWithShader([Writable] Material mono, Shader shader);
        
        private static extern void Internal_CreateWithString([Writable] Material mono, string contents);
        
        private static extern void Internal_GetTextureOffset(Material mat, string name, out Vector2 output);
        
        private static extern void Internal_GetTextureScale(Material mat, string name, out Vector2 output);
        
        public extern bool IsKeywordEnabled(string keyword);
        
        public extern void Lerp(Material start, Material end, float t);
        
        public extern void SetBuffer(string propertyName, ComputeBuffer buffer);
        public void SetColor(int nameID, Color color)
        {
            INTERNAL_CALL_SetColor(this, nameID, ref color);
        }

        public void SetColor(string propertyName, Color color)
        {
            this.SetColor(Shader.PropertyToID(propertyName), color);
        }

        
        public extern void SetFloat(int nameID, float value);
        public void SetFloat(string propertyName, float value)
        {
            this.SetFloat(Shader.PropertyToID(propertyName), value);
        }

        public void SetInt(int nameID, int value)
        {
            this.SetFloat(nameID, (float) value);
        }

        public void SetInt(string propertyName, int value)
        {
            this.SetFloat(propertyName, (float) value);
        }

        public void SetMatrix(int nameID, Matrix4x4 matrix)
        {
            INTERNAL_CALL_SetMatrix(this, nameID, ref matrix);
        }

        public void SetMatrix(string propertyName, Matrix4x4 matrix)
        {
            this.SetMatrix(Shader.PropertyToID(propertyName), matrix);
        }

        
        public extern void SetOverrideTag(string tag, string val);
        
        public extern bool SetPass(int pass);
        
        public extern void SetTexture(int nameID, Texture texture);
        public void SetTexture(string propertyName, Texture texture)
        {
            this.SetTexture(Shader.PropertyToID(propertyName), texture);
        }

        public void SetTextureOffset(string propertyName, Vector2 offset)
        {
            INTERNAL_CALL_SetTextureOffset(this, propertyName, ref offset);
        }

        public void SetTextureScale(string propertyName, Vector2 scale)
        {
            INTERNAL_CALL_SetTextureScale(this, propertyName, ref scale);
        }

        public void SetVector(int nameID, Vector4 vector)
        {
            this.SetColor(nameID, new Color(vector.x, vector.y, vector.z, vector.w));
        }

        public void SetVector(string propertyName, Vector4 vector)
        {
            this.SetColor(propertyName, new Color(vector.x, vector.y, vector.z, vector.w));
        }

        public Color color
        {
            get
            {
                return this.GetColor("_Color");
            }
            set
            {
                this.SetColor("_Color", value);
            }
        }

        public MaterialGlobalIlluminationFlags globalIlluminationFlags {  get;  set; }

        public Texture mainTexture
        {
            get
            {
                return this.GetTexture("_MainTex");
            }
            set
            {
                this.SetTexture("_MainTex", value);
            }
        }

        public Vector2 mainTextureOffset
        {
            get
            {
                return this.GetTextureOffset("_MainTex");
            }
            set
            {
                this.SetTextureOffset("_MainTex", value);
            }
        }

        public Vector2 mainTextureScale
        {
            get
            {
                return this.GetTextureScale("_MainTex");
            }
            set
            {
                this.SetTextureScale("_MainTex", value);
            }
        }

        public int passCount {  get; }

        public int renderQueue {  get;  set; }

        public Shader shader {  get;  set; }

        public string[] shaderKeywords {  get;  set; }
    }
}

