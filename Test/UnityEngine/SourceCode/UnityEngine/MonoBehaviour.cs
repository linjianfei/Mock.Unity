namespace UnityEngine
{
    using System;
    using System.Collections;
    using System.Runtime.CompilerServices;
    using UnityEngine.Internal;

    public class MonoBehaviour : Behaviour
    {
        
        public void CancelInvoke()
        {
        }

        
   
        public bool IsInvoking()
        {
            return true;
        }

        
        public static void print(object message)
        {
            Debug.Log(message);
        }

        public Coroutine StartCoroutine(IEnumerator routine)
        {
            return null;
        }

        public Coroutine StartCoroutine(string methodName)
        {
            return null;
        }

        
        
        public void StopCoroutine(IEnumerator routine)
        {
        }

        
        public void StopCoroutine(Coroutine routine)
        {
        }

        

        public bool useGUILayout {  get;  set; }
    }
}

