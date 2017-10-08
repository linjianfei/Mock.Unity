namespace UnityEngine
{
    using System;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential)]
    public class Collision2D
    {
        internal Collider2D m_Collider;
        internal ContactPoint2D[] m_Contacts;
        internal Vector2 m_RelativeVelocity;
        internal bool m_Enabled;
        public bool enabled
        {
            get
            {
                return this.m_Enabled;
            }
        }
       
        public Collider2D collider
        {
            get
            {
                return this.m_Collider;
            }
        }
        public Transform transform
        {
            get { return null; }
        }
        public GameObject gameObject
        {
            get { return null; }
        }
        public ContactPoint2D[] contacts
        {
            get
            {
                return this.m_Contacts;
            }
        }
        public Vector2 relativeVelocity
        {
            get
            {
                return this.m_RelativeVelocity;
            }
        }
    }
}

