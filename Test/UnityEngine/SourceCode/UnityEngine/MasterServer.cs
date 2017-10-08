namespace UnityEngine
{
    using System;
    using System.Runtime.CompilerServices;
    using UnityEngine.Internal;

    public sealed class MasterServer
    {
        
        public static extern void ClearHostList();
        
        public static extern HostData[] PollHostList();
        [ExcludeFromDocs]
        public static void RegisterHost(string gameTypeName, string gameName)
        {
            string comment = string.Empty;
            RegisterHost(gameTypeName, gameName, comment);
        }

        
        public static extern void RegisterHost(string gameTypeName, string gameName, [DefaultValue("\"\"")] string comment);
        
        public static extern void RequestHostList(string gameTypeName);
        
        public static extern void UnregisterHost();

        public static bool dedicatedServer {  get;  set; }

        public static string ipAddress {  get;  set; }

        public static int port {  get;  set; }

        public static int updateRate {  get;  set; }
    }
}

