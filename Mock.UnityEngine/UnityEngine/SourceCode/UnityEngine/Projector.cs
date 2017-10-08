namespace UnityEngine
{
    using System;
    using System.Runtime.CompilerServices;

    public sealed class Projector : Behaviour
    {
        public float aspectRatio {  get;  set; }

        public float farClipPlane {  get;  set; }

        public float fieldOfView {  get;  set; }

        public int ignoreLayers {  get;  set; }

        public bool isOrthoGraphic
        {
            get
            {
                return false;
            }
            set
            {
            }
        }

        public Material material {  get;  set; }

        public float nearClipPlane {  get;  set; }

        public bool orthographic {  get;  set; }

        public float orthographicSize {  get;  set; }

        public float orthoGraphicSize
        {
            get
            {
                return -1f;
            }
            set
            {
            }
        }
    }
}

