namespace UnityEngine
{
    using System;
    using System.Runtime.CompilerServices;

    public sealed class CanvasGroup : Component, ICanvasRaycastFilter
    {
        public bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera)
        {
            return this.blocksRaycasts;
        }

        public float alpha {  get;  set; }

        public bool blocksRaycasts {  get;  set; }

        public bool ignoreParentGroups {  get;  set; }

        public bool interactable {  get;  set; }
    }
}

