using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security;
using UnityEngine.Internal;

namespace UnityEngine
{
    public class GameObject:Object
    {
        public Transform transform { get; }

        public GameObject gameObject { get { return this; } }

        public string tag { get; set; }

        public int layer { get; set; }


        public void SetActive(bool active)
        {
            this.activeSelf = active;
        }

        public GameObject():this("new game object")
        {

        }

        public GameObject(string name)
        {
            this.transform = this.AddComponent<Transform>();
            this.name = name;
        }

        public Component AddComponent(Type componentType)
        {
            if(!typeof(Component).IsAssignableFrom(componentType)) throw new Exception("not component type");
            var obj = _getNewInstance(componentType);
            var component =  obj as Component;
            component.SetGameObject(this);
            ComponentContainer.Instance.Add(component);

            return component;
        }

        private Component _getNewInstance(Type type)
        {
            System.Reflection.ConstructorInfo[] constructorInfoArray = type.GetConstructors(System.Reflection.BindingFlags.Instance
                | System.Reflection.BindingFlags.NonPublic
                | System.Reflection.BindingFlags.Public);
            System.Reflection.ConstructorInfo noParameterConstructorInfo = null;
            foreach (System.Reflection.ConstructorInfo constructorInfo in constructorInfoArray)
            {
                System.Reflection.ParameterInfo[] parameterInfoArray = constructorInfo.GetParameters();
                if (0 == parameterInfoArray.Length)
                {
                    noParameterConstructorInfo = constructorInfo;
                    break;
                }
            }
            if (null == noParameterConstructorInfo)
            {
                throw new NotSupportedException("No constructor without 0 parameter");
            }
            var result = noParameterConstructorInfo.Invoke(null);
            return result as Component;
        }

        public T AddComponent<T>() where T : Component
        {
            var component = AddComponent(typeof(T));
            return (T) component;
        }


        public Component GetComponent(Type type)
        {
            return GetComponents(type).FirstOrDefault();
        }

        public T GetComponent<T>()
        {
            return GetComponents<T>().FirstOrDefault();
        }

        public Component GetComponentInChildren(Type type)
        {
            return GetComponentsInChildren(type).FirstOrDefault();

        }

        public T GetComponentInChildren<T>()
        {
            return GetComponentsInChildren<T>().FirstOrDefault();
        }

        public Component GetComponentInParent(Type type)
        {
            
            throw new NotImplementedException();
        }

        public T GetComponentInParent<T>()
        {
            
            throw new NotImplementedException();
        }

        public Component[] GetComponents(Type type)
        {
            return ComponentContainer.Instance.GetAll(type, this).ToArray();
        }

        public Component[] GetComponents(List<Component> listToDo)
        {
            return null;
        }

        public T[] GetComponents<T>()
        {

            return ComponentContainer.Instance.GetAll<T>(this).ToArray();
        }

        public Component[] GetComponentsInChildren(Type type,bool includeInactive)
        {
            var childrenRecrive = this.transform.ChildrenRecursive;
            return ComponentContainer.Instance
                .GetAll(type, childrenRecrive.Select(x => x.gameObject))
                .ToArray();
        }

        public Component[] GetComponentsInChildren(Type type)
        {
            var childrenRecrive = this.transform.ChildrenRecursive;
            return ComponentContainer.Instance
                .GetAll(type, childrenRecrive.Select(x => x.gameObject))
                .ToArray();
        }

        public T[] GetComponentsInChildren<T>()
        {
            var childrenRecrive = this.transform.ChildrenRecursive;
            return ComponentContainer.Instance
                .GetAll<T>(childrenRecrive.Select(x => x.gameObject))
                .ToArray();
        }
        public T[] GetComponentsInChildren<T>(bool includeInactive,List<T> list )
        {
            var childrenRecrive = this.transform.ChildrenRecursive;
            return ComponentContainer.Instance
                .GetAll<T>(childrenRecrive.Select(x => x.gameObject))
                .ToArray();
        }
        public T[] GetComponentsInChildren<T>(bool includInactive)
        {
            var childrenRecrive = this.transform.ChildrenRecursive;
            return ComponentContainer.Instance
                .GetAll<T>(childrenRecrive.Select(x => x.gameObject))
                .ToArray();
        }
        public Component[] GetComponentsInParent(Type type)
        {
            throw new NotImplementedException();
        }
        public Component[] GetComponentsInParent(Type type,bool todo)
        {
            throw new NotImplementedException();
        }
        public T[] GetComponentsInParent<T>()
        {
            
            throw new NotImplementedException();
        }
        public T[] GetComponentsInParent<T>(bool todo,List<T> todosa )
        {

            throw new NotImplementedException();
        }

        public T[] GetComponentsInParent<T>(bool todo)
        {

            throw new NotImplementedException();
        }
        public bool activeInHierarchy {get { return true; } }

        public bool activeSelf { get; set; }

        public void SendMessage(string methodName)
        {
            SendMessageOptions requireReceiver = SendMessageOptions.RequireReceiver;
            object obj2 = null;
            this.SendMessage(methodName, obj2, requireReceiver);
        }

        public void SendMessage(string methodName, object value)
        {
            SendMessageOptions requireReceiver = SendMessageOptions.RequireReceiver;
            this.SendMessage(methodName, value, requireReceiver);
        }

        public void SendMessage(string methodName, SendMessageOptions options)
        {
            this.SendMessage(methodName, null, options);
        }
        public void SendMessage(string methodName,object value, SendMessageOptions options)
        {
            Debug.Log("message");
        }
    }
}