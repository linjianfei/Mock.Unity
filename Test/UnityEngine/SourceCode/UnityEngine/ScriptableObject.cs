namespace UnityEngine
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential)]
    public class ScriptableObject : Object
    {
        public ScriptableObject()
        {
            Internal_CreateScriptableObject(this);
        }

        
        private static extern void Internal_CreateScriptableObject([Writable] ScriptableObject self);
        [Obsolete("Use EditorUtility.SetDirty instead")]
        public void SetDirty()
        {
            INTERNAL_CALL_SetDirty(this);
        }

        
        private static extern void INTERNAL_CALL_SetDirty(ScriptableObject self);
        
        public static extern ScriptableObject CreateInstance(string className);
        public static ScriptableObject CreateInstance(Type type)
        {
            return CreateInstanceFromType(type);
        }

        
        private static extern ScriptableObject CreateInstanceFromType(Type type);
        public static T CreateInstance<T>() where T: ScriptableObject
        {
            return (T) CreateInstance(typeof(T));
        }
    }
}

