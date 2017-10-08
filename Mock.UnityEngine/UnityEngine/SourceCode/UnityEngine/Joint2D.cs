namespace UnityEngine
{
    using System;
    using System.Runtime.CompilerServices;

    public class Joint2D : Behaviour
    {
        [Obsolete("Joint2D.collideConnected has been deprecated. Use Joint2D.enableCollision instead (UnityUpgradable) -> enableCollision", true)]
        public bool collideConnected
        {
            get
            {
                return this.enableCollision;
            }
            set
            {
                this.enableCollision = value;
            }
        }


        public bool enableCollision {  get;  set; }
    }
}

