using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using UnityEngine.Internal;

namespace UnityEngine
{
    public  class Transform : Component
    {
        public  bool IsChildOf(Transform parent)
        {
            return this.parent == parent;
        }

        public Transform()
        {
        }

        internal string Path
        {
            get
            {
                if (parent == null) return this.name;
                return parent.Path + "/" + this.name;
            }
        }

        /// <summary>
        /// 把每个节点的hashcode拼成路径
        /// </summary>
        internal string HashPath
        {
            get
            {
                if (parent == null) return this.GetHashCode().ToString();
                return parent.HashPath + "/" + this.GetHashCode().ToString();
            }
        }

        /// <summary>
        /// 子节点，不包括自己
        /// </summary>
        internal IEnumerable<Transform> Children
        {
            get
            {
                var list = ComponentContainer.Instance.GetAll<Transform>();
                return list.Where(x =>x.parent!=null&& x.parent == this).OrderBy(x => x.SiblingIndex);
            }
        }

        public int childCount
        {
            get { return Children.Count(); }
        }

        public Transform Find(string name)
        {
            if (string.IsNullOrEmpty(name)) return this;
            var fullPath = this.Path + "/" + name;
            return Children.SingleOrDefault(x => x.Path == fullPath);
        }

        public Transform FindChild(string name)
        {
            return Find(name);
        }

        public void SetParent(Transform parent)
        {
            if(parent==this) throw new Exception("parent can't be self");
            this.parent = parent;
            this.SetAsLastSibling();
        }

        public void SetParent(Transform parent, bool worldPositionStays)
        {
            this.SetParent(parent);
        }

        public Transform parent { get; set; }

        internal int SiblingIndex;

        public int GetSiblingIndex()
        {
            return SiblingIndex;
        }

        public void SetAsFirstSibling()
        {
            this.SiblingIndex = -1;
            ReindexSibling();
        }

        public void SetAsLastSibling()
        {
            this.SiblingIndex = int.MaxValue;
            ReindexSibling();
        }

        public void SetSiblingIndex(int index)
        {
            this.SiblingIndex = index;
            ReindexSibling();
        }

        public Transform GetChild(int index)
        {
            return Children.ToList()[index];
        }

        internal void ReindexSibling()
        {
            var i = 0;
            foreach (var child in Children)
            {
                child.SiblingIndex = i;
                i++;
            }
        }

        /// <summary>
        /// 所有的子节点。
        /// 包括自己
        /// </summary>
        internal IEnumerable<Transform> ChildrenRecursive
        {
            get
            {
                return ComponentContainer.Instance
                    .GetAll<Transform>()
                    .Where(x => x.HashPath.StartsWith(this.HashPath));
            }
        }

        /// <summary>
        /// 枚举每一个祖先
        /// </summary>
        /// <returns></returns>
        internal IEnumerable<Transform> GetAncient()
        {
            Transform p = this.parent;
            while (p != null)
            {
                yield return p;
                p = p.parent;
            }
        }

        public T GetComponent<T>()
        {
            return gameObject.GetComponent<T>();
        }

        public Vector3 TransformDirection(Vector3 direction)
        {
            return direction;
        }

        public Vector3 TransformDirection(float x, float y, float z)
        {
            return this.TransformDirection(new Vector3(x, y, z));
        }

        public Vector3 TransformPoint(Vector3 position)
        {
            return position;
        }

        public Vector3 TransformPoint(float x, float y, float z)
        {
            return this.TransformPoint(new Vector3(x, y, z));
        }

        public Vector3 TransformVector(Vector3 vector)
        {
            return vector;
        }

        public Vector3 TransformVector(float x, float y, float z)
        {
            return this.TransformVector(new Vector3(x, y, z));
        }

        [ExcludeFromDocs]
        public void Translate(Vector3 translation)
        {
            Space self = Space.Self;
            this.Translate(translation, self);
        }

        public void Translate(Vector3 translation, [DefaultValue("Space.Self")] Space relativeTo)
        {
            if (relativeTo == Space.World)
            {
                this.position += translation;
            }
            else
            {
                this.position += this.TransformDirection(translation);
            }
        }

        public void Translate(Vector3 translation, Transform relativeTo)
        {
            if (relativeTo != null)
            {
                this.position += relativeTo.TransformDirection(translation);
            }
            else
            {
                this.position += translation;
            }
        }

        [ExcludeFromDocs]
        public void Translate(float x, float y, float z)
        {
            Space self = Space.Self;
            this.Translate(x, y, z, self);
        }

        public void Translate(float x, float y, float z, [DefaultValue("Space.Self")] Space relativeTo)
        {
            this.Translate(new Vector3(x, y, z), relativeTo);
        }

        public void Translate(float x, float y, float z, Transform relativeTo)
        {
            this.Translate(new Vector3(x, y, z), relativeTo);
        }


        public Vector3 eulerAngles
        {
            get
            {
                return this.rotation.eulerAngles;
            }
            set
            {
                this.rotation = Quaternion.Euler(value);
            }
        }

        public Vector3 forward
        {
            get
            {
                return (Vector3)(this.rotation * Vector3.forward);
            }
            set
            {
                this.rotation = Quaternion.LookRotation(value);
            }
        }

        public bool hasChanged {  get;  set; }

        public Vector3 localEulerAngles { get; set; }

        public Vector3 localPosition
        {
            get; set; }

        public Quaternion localRotation { get; set; }

        public Vector3 localScale { get; set; }

        public Matrix4x4 localToWorldMatrix
        {
            get { return Matrix4x4.zero;}
        }

        public Vector3 lossyScale
        {
            get { return Vector3.zero; }
        }


        public Vector3 position { get; set; }

        public Vector3 right
        {
            get
            {
                return (Vector3)(this.rotation * Vector3.right);
            }
            set
            {
                this.rotation = Quaternion.FromToRotation(Vector3.right, value);
            }
        }

        public Transform root { get; set; }

        public Quaternion rotation { get; set; }

        public Vector3 up
        {
            get
            {
                return (Vector3)(this.rotation * Vector3.up);
            }
            set
            {
                this.rotation = Quaternion.FromToRotation(Vector3.up, value);
            }
        }

        public Matrix4x4 worldToLocalMatrix
        {
            get
            {
               return Matrix4x4.zero;
            }
        }

        public Vector3 InverseTransformPoint(Vector3 position)
        {
            return position;
        }

        public Vector3 InverseTransformPoint(float x, float y, float z)
        {
            return this.InverseTransformPoint(new Vector3(x, y, z));
        }

    }
}