namespace UnityEngine
{
    using System;
    using System.Runtime.CompilerServices;

    internal sealed class RuntimeUndo
    {
        
        public static extern void RecordObject(Object objectToUndo, string name);
        
        public static extern void RecordObjects(Object[] objectsToUndo, string name);
        
        public static extern void SetTransformParent(Transform transform, Transform newParent, string name);
    }
}

