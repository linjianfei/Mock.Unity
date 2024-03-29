﻿//namespace UnityEngine
//{
//    using System;
//    using System.Runtime.CompilerServices;
//    using System.Runtime.InteropServices;
//
//    public sealed class NetworkView : Behaviour
//    {
//        public static NetworkView Find(NetworkViewID viewID)
//        {
//            return INTERNAL_CALL_Find(ref viewID);
//        }
//
//        
//        private static extern NetworkView INTERNAL_CALL_Find(ref NetworkViewID viewID);
//        
//        private static extern void INTERNAL_CALL_Internal_SetViewID(NetworkView self, ref NetworkViewID viewID);
//        
//        private extern void Internal_GetViewID(out NetworkViewID viewID);
//        
//        private static extern void Internal_RPC(NetworkView view, string name, RPCMode mode, object[] args);
//        
//        private static extern void Internal_RPC_Target(NetworkView view, string name, NetworkPlayer target, object[] args);
//        private void Internal_SetViewID(NetworkViewID viewID)
//        {
//            INTERNAL_CALL_Internal_SetViewID(this, ref viewID);
//        }
//
//        [Obsolete("NetworkView RPC functions are deprecated. Refer to the new Multiplayer Networking system.")]
//        public void RPC(string name, NetworkPlayer target, params object[] args)
//        {
//            Internal_RPC_Target(this, name, target, args);
//        }
//
//        [Obsolete("NetworkView RPC functions are deprecated. Refer to the new Multiplayer Networking system.")]
//        public void RPC(string name, RPCMode mode, params object[] args)
//        {
//            Internal_RPC(this, name, mode, args);
//        }
//
//        
//        public extern bool SetScope(NetworkPlayer player, bool relevancy);
//
//        public int group {  get;  set; }
//
//        public bool isMine
//        {
//            get
//            {
//                return this.viewID.isMine;
//            }
//        }
//
//        public Component observed {  get;  set; }
//
//        public NetworkPlayer owner
//        {
//            get
//            {
//                return this.viewID.owner;
//            }
//        }
//
//        public NetworkStateSynchronization stateSynchronization {  get;  set; }
//
//        public NetworkViewID viewID
//        {
//            get
//            {
//                NetworkViewID wid;
//                this.Internal_GetViewID(out wid);
//                return wid;
//            }
//            set
//            {
//                this.Internal_SetViewID(value);
//            }
//        }
//    }
//}
//
