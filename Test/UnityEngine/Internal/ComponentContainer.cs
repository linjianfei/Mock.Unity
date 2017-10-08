using System;
using System.Collections.Generic;
using System.Linq;

namespace UnityEngine.Internal
{
    class ComponentContainer:Singleton<ComponentContainer>
    {
        public  List<Component> AllComponents = new List<Component>();

        public void Add(Component transform)
        {
            AllComponents.Add(transform);
        }

        public void Remove(Component transform)
        {
            AllComponents.Remove(transform);
        }

        public IEnumerable<T> GetAll<T>()
        {
            return AllComponents.OfType<T>();
        }

        public IEnumerable<Component> GetAll(Type type)
        {
            return AllComponents.Where(type.IsInstanceOfType);
        }

        public IEnumerable<T> GetAll<T>(GameObject gameObject)
        {
            return AllComponents.Where(x=>x.gameObject==gameObject).OfType<T>();
        }

        public IEnumerable<Component> GetAll(Type type,GameObject gameObject)
        {
            return AllComponents.Where(x=>x.gameObject==gameObject).Where(type.IsInstanceOfType);
        }


        public IEnumerable<T> GetAll<T>(IEnumerable<GameObject> gameObjects)
        {
            return AllComponents.Where(x => gameObjects.Contains(x.gameObject)).OfType<T>();
        }

        public IEnumerable<Component> GetAll(Type type, IEnumerable<GameObject> gameObjects)
        {
            return AllComponents.Where(x => gameObjects.Contains(x.gameObject)).Where(type.IsInstanceOfType);
        }


    }
}