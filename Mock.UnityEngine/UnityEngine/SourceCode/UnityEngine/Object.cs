namespace UnityEngine
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using UnityEngine.Internal;
    using UnityEngineInternal;

    [StructLayout(LayoutKind.Sequential)]
    public class Object
    {
        private int m_InstanceID;
        private IntPtr m_CachedPtr;
        private string m_UnityRuntimeErrorString;

        private static Object Internal_CloneSingle(Object data)
        {
            return data;
        }
        private static Object Internal_InstantiateSingle(Object data, Vector3 pos, Quaternion rot)
        {
            return INTERNAL_CALL_Internal_InstantiateSingle(data, ref pos, ref rot);
        }


        private static  Object INTERNAL_CALL_Internal_InstantiateSingle(Object data, ref Vector3 pos,
            ref Quaternion rot)
        {
            return null;
        }

        public static void Destroy(Object obj, [DefaultValue("0.0F")] float t)
        {
            
        }

        [ExcludeFromDocs]
        public static void Destroy(Object obj)
        {
            float t = 0f;
            Destroy(obj, t);
        }


        public static void DestroyImmediate(Object obj, [DefaultValue("false")] bool allowDestroyingAssets)
        {
            
        }
        [ExcludeFromDocs]
        public static void DestroyImmediate(Object obj)
        {
            bool allowDestroyingAssets = false;
            DestroyImmediate(obj, allowDestroyingAssets);
        }


        public static  Object[] FindObjectsOfType(Type type)
        {
            return null;
        }
        public string name {  get;  set; }

        public static  void DontDestroyOnLoad(Object target)
        {
            
        }
        public HideFlags hideFlags {  get;  set; }

        public static  void DestroyObject(Object obj, [DefaultValue("0.0F")] float t)
        {
            
        }
        [ExcludeFromDocs]
        public static void DestroyObject(Object obj)
        {
            float t = 0f;
            DestroyObject(obj, t);
        }


        public static Object[] FindSceneObjectsOfType(Type type)
        {
            return null;
        }

        public static Object[] FindObjectsOfTypeIncludingAssets(Type type)
        {
            return null;
        }
        public static Object[] FindObjectsOfTypeAll(Type type)
        {
            return Resources.FindObjectsOfTypeAll(type);
        }


        internal static bool DoesObjectWithInstanceIDExist(int instanceID)
        {
            return true;
        }
      

        public int GetInstanceID()
        {
            return this.m_InstanceID;
        }

  

        [TypeInferenceRule(TypeInferenceRules.TypeOfFirstArgument)]
        public static Object Instantiate(Object original, Vector3 position, Quaternion rotation)
        {
            CheckNullArgument(original, "The thing you want to instantiate is null.");
            return Internal_InstantiateSingle(original, position, rotation);
        }

        [TypeInferenceRule(TypeInferenceRules.TypeOfFirstArgument)]
        public static Object Instantiate(Object original)
        {
            CheckNullArgument(original, "The thing you want to instantiate is null.");
            return Internal_CloneSingle(original);
        }

        public static T Instantiate<T>(T original) where T: Object
        {
            CheckNullArgument(original, "The thing you want to instantiate is null.");
            return (T) Internal_CloneSingle(original);
        }

        private static void CheckNullArgument(object arg, string message)
        {
            if (arg == null)
            {
                throw new ArgumentException(message);
            }
        }

        public static T[] FindObjectsOfType<T>() where T: Object
        {
            return Resources.ConvertObjects<T>(FindObjectsOfType(typeof(T)));
        }

        [TypeInferenceRule(TypeInferenceRules.TypeReferencedByFirstArgument)]
        public static Object FindObjectOfType(Type type)
        {
            Object[] objArray = FindObjectsOfType(type);
            if (objArray.Length > 0)
            {
                return objArray[0];
            }
            return null;
        }

        public static T FindObjectOfType<T>() where T: Object
        {
            return (T) FindObjectOfType(typeof(T));
        }

        public static implicit operator bool(Object exists)
        {
            return exists != null;
        }

        public static bool operator ==(Object x, Object y)
        {
            return System.Object.Equals(x, y);

        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            if (GetType() != obj.GetType())
                return false;
            return this.GetHashCode() == obj.GetHashCode();
        }


        public static bool operator !=(Object x, Object y)
        {
            return !System.Object.Equals(x, y);
        }
    }
}


